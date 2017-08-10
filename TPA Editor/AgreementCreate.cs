using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace TPA_Editor
{
    public partial class AgreementCreate : Form
    {
        public Guid SenderID;
        public Guid ReceiverID;

        DataTable senderTable = new DataTable();
        DataTable receiverTable = new DataTable();

        public string[] separators = { "58", "42", "126", "33", "34", "35", "36", "37", "38", "39", "40", "41", "43", "44", "45", "46", "47", "59", "60", "61", "62", "63", "64", "91", "92", "93", "94", "95", "96", "123", "124", "125", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "127" };
        public string[] suffix      = { "0", "13", "10", "13 10"};

        public AgreementCreate()
        {
            InitializeComponent();
        }

        private void AgreementCreate_Load(object sender, EventArgs e)
        {
            // Load Sender and Receiver tables
            var connection = ConfigurationManager.ConnectionStrings["NeuronEDI"].ConnectionString;

            using (SqlConnection sqlConn = new SqlConnection(connection))
            {
                using (SqlDataAdapter da_partner = new SqlDataAdapter(@"SELECT           PK_PartnerID, 
                                                                                          PartnerName, 
                                                                               InterchangeIDQualifier, 
                                                                                        InterchangeID,
                                                                                            Activated
                                                                        FROM TradingPartner", sqlConn))
                {
                    da_partner.Fill(senderTable);
                    da_partner.Fill(receiverTable);
                }
            }

            if (senderTable.Rows.Count > 0 && receiverTable.Rows.Count > 0)
            {
                // Partners
                senderTable.Columns.Add(  "Combined", typeof(string), "PartnerName + ' - ' + InterchangeID");
                receiverTable.Columns.Add("Combined", typeof(string), "PartnerName + ' - ' + InterchangeID");

                comboBoxISA06SenderInterchangeID.DataSource = senderTable;
                comboBoxISA06SenderInterchangeID.DisplayMember = "Combined";

                comboBoxISA08ReceiverInterchangeID.DataSource = receiverTable;
                comboBoxISA08ReceiverInterchangeID.DisplayMember = "Combined";
            }

            // Set the initial default values for these
            comboBoxISA01AuthorizationInformationQualifier.SelectedIndex    = 0;
            comboBoxISA03SecurityInformationQualifier.SelectedIndex         = 0;
            comboBoxSegmentSeparator.SelectedIndex                          = 1;
            comboBoxElementSeparator.SelectedIndex                          = 2;
            comboBoxISA16SubElementSeparator.SelectedIndex                  = 0;
            comboBoxSegmentSeparatorSuffix.SelectedIndex                    = 0;
        }

        private void comboBoxISA06InterchangeSenderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["NeuronEDI"].ConnectionString;
            DataTable senderGroupTable = new DataTable();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(connection))
                {
                    using (SqlDataAdapter da_senderGroup = new SqlDataAdapter(@"SELECT a.FunctionalGroupID
                                                                                FROM dbo.FunctionalGroup a,
                                                                                     dbo.TradingPartner b
                                                                                WHERE a.FK_PartnerID = b.PK_PartnerID AND b.InterchangeID = '" + comboBoxISA06SenderInterchangeID.Text.Split('-')[1].Trim() + "'", sqlConn))
                    {
                        da_senderGroup.Fill(senderGroupTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (senderGroupTable.Rows.Count > 0)
            {
                comboBoxGS02ApplicationSenderID.DataSource = senderGroupTable;
                comboBoxGS02ApplicationSenderID.DisplayMember = "FunctionalGroupID";
            }
        }

        private void comboBoxISA08InterchangeReceiverID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["NeuronEDI"].ConnectionString;
            DataTable receiverGroupTable = new DataTable();

            try
            {
                using (SqlConnection sqlConn = new SqlConnection(connection))
                {
                    using (SqlDataAdapter da_receiverGroup = new SqlDataAdapter(@"SELECT a.FunctionalGroupID
                                                                                FROM dbo.FunctionalGroup a,
                                                                                     dbo.TradingPartner b
                                                                                WHERE a.FK_PartnerID = b.PK_PartnerID AND b.InterchangeID = '" + comboBoxISA08ReceiverInterchangeID.Text.Split('-')[1].Trim() + "'", sqlConn))
                    {
                        da_receiverGroup.Fill(receiverGroupTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            if (receiverGroupTable.Rows.Count > 0)
            {
                comboBoxGS03ApplicationReceiverID.DataSource = receiverGroupTable;
                comboBoxGS03ApplicationReceiverID.DisplayMember = "FunctionalGroupID";
            }
        }

        private void buttonSaveAgreement_Click(object sender, EventArgs e)
        {
            // Validate data
            if (string.IsNullOrWhiteSpace(textBoxAgreementName.Text))
            {
                MessageBox.Show("Please enter an Agreement Name");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxISA01AuthorizationInformationQualifier.Text))
            {
                MessageBox.Show("Please enter a value for ISA01-Authorization Information Qualifier");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxISA02AuthorizationInformation.Text) && comboBoxISA01AuthorizationInformationQualifier.Text.Substring(0, 2) != "00")
            {
                MessageBox.Show("Please enter a value for ISA02-Authorization Information");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxISA03SecurityInformationQualifier.Text))
            {
                MessageBox.Show("Please enter a value for ISA03-Security Information Qualifier");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxISA04SecurityInformation.Text) && comboBoxISA03SecurityInformationQualifier.Text.Substring(0, 2) != "00")
            {
                MessageBox.Show("Please enter a value for ISA04-Security Information");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxISA05SenderInterchangeIDQualifier.Text))
            {
                MessageBox.Show("Please enter a value for ISA05-Sender InterchangeID Qualifier");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxISA06SenderInterchangeID.Text.Split('-')[1].Trim()))
            {
                MessageBox.Show("Please enter a value for ISA06-Sender InterchangeID");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxISA07ReceiverInterchangeIDQualifier.Text))
            {
                MessageBox.Show("Please enter a value for ISA07-Receiver InterchangeID Qualifier");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxISA08ReceiverInterchangeID.Text.Split('-')[1].Trim()))
            {
                MessageBox.Show("Please enter a value for ISA08-Receiver InterchangeID");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxISA11InterchangeStandardsID.Text))
            {
                MessageBox.Show("Please enter a value for ISA11-Interchange StandardsID");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxISA12InterchangeVersionID.Text))
            {
                MessageBox.Show("Please enter a value for ISA12-Interchange VersionID");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxISA14AckRequested.Text))
            {
                MessageBox.Show("Please enter a value for ISA14-Acknowledgement Requested");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxISA15TestIndicator.Text))
            {
                MessageBox.Show("Please enter a value for ISA15-Test Indicator");
                return;
            }
            if (string.IsNullOrWhiteSpace(separators[comboBoxISA16SubElementSeparator.SelectedIndex]) && comboBoxDirection.Text == "Outbound" || string.IsNullOrWhiteSpace(comboBoxDirection.Text))
            {
                MessageBox.Show("Please enter a value for ISA16-Sub Element Separator if this Agreement is for an outbound transmission");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxGS01FunctionalIDCode.Text))
            {
                MessageBox.Show("Please enter a value for GS01-Functional ID Code");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxGS02ApplicationSenderID.Text))
            {
                MessageBox.Show("Please enter a value for GS02-Application SenderID");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxGS03ApplicationReceiverID.Text))
            {
                MessageBox.Show("Please enter a value for GS03-Application ReceiverID");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxGS07ResponsibleAgencyCode.Text))
            {
                MessageBox.Show("Please enter a value for GS07-Responsible Agency Code");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxGS08VersionReleaseIndustryIDCode.Text))
            {
                MessageBox.Show("Please enter a value for GS08-Version/Release/Industry ID Code");
                return;
            }
            if (string.IsNullOrWhiteSpace(separators[comboBoxSegmentSeparator.SelectedIndex]) && comboBoxDirection.Text == "Outbound" || string.IsNullOrWhiteSpace(comboBoxDirection.Text))
            {
                MessageBox.Show("Please enter a value for SegmentSeparator if this Agreement is for an outbound transmission");
                return;
            }
            if (string.IsNullOrWhiteSpace(separators[comboBoxElementSeparator.SelectedIndex]) && comboBoxDirection.Text == "Outbound" || string.IsNullOrWhiteSpace(comboBoxDirection.Text))
            {
                MessageBox.Show("Please enter a value for ElementSeparator if this Agreement is for an outbound transmission");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxTransactionType.Text))
            {
                MessageBox.Show("Please enter a value for TransactionType");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxDirection.Text))
            {
                MessageBox.Show("Please enter a value for Direction");
                return;
            }
            if (string.IsNullOrWhiteSpace(suffix[comboBoxSegmentSeparatorSuffix.SelectedIndex]) && comboBoxDirection.Text == "Outbound" || string.IsNullOrWhiteSpace(comboBoxDirection.Text))
            {
                MessageBox.Show("Please enter a value for SegmentSeparatorSuffix if this Agreement is for an outbound transmission");
                return;
            }

            // Create the xml document to pass to the stored proc
            XDocument doc = new XDocument();

            doc.Add(new XElement("Agreement",
                new XElement("Action", "Create"),
                new XElement("AgreementName",                       textBoxAgreementName.Text),
                new XElement("AuthorizationInformationQualifier",   comboBoxISA01AuthorizationInformationQualifier.Text.Substring(0, 2)),
                new XElement("AuthorizationInformation",            textBoxISA02AuthorizationInformation.Text),
                new XElement("SecurityInformationQualifier",        comboBoxISA03SecurityInformationQualifier.Text.Substring(0, 2)),
                new XElement("SecurityInformation",                 textBoxISA04SecurityInformation.Text),
                new XElement("Partner",
                    new XAttribute("Type", "Sender"),
                    new XElement("InterchangeIDQualifier",          comboBoxISA05SenderInterchangeIDQualifier.Text.Substring(0, 2)),
                    new XElement("InterchangeID",                   comboBoxISA06SenderInterchangeID.Text.Split('-')[1].Trim())),
                new XElement("Partner",
                    new XAttribute("Type", "Receiver"),
                    new XElement("InterchangeIDQualifier",          comboBoxISA07ReceiverInterchangeIDQualifier.Text.Substring(0, 2)),
                    new XElement("InterchangeID",                   comboBoxISA08ReceiverInterchangeID.Text.Split('-')[1].Trim())),
                new XElement("InterchangeStandardsID",              comboBoxISA11InterchangeStandardsID.Text.Substring(0, 1)),
                new XElement("InterchangeVersionID",                comboBoxISA12InterchangeVersionID.Text),
                new XElement("InterchangeControlNumber",            textBoxISA13InterchangeControlNumber.Text),
                new XElement("AckRequested",                        comboBoxISA14AckRequested.Text.Substring(0, 1)),
                new XElement("TestIndicator",                       comboBoxISA15TestIndicator.Text.Substring(0, 1)),
                new XElement("SubElementSeparator",                 separators[comboBoxISA16SubElementSeparator.SelectedIndex]),
                new XElement("FunctionalIDCode",                    comboBoxGS01FunctionalIDCode.Text.Substring(4, 2)),
                new XElement("ApplicationSenderID",                 comboBoxGS02ApplicationSenderID.Text),
                new XElement("ApplicationReceiverID",               comboBoxGS03ApplicationReceiverID.Text),
                new XElement("GroupControlNumber",                  textBoxGS06GroupControlNumber.Text),
                new XElement("ResponsibleAgencyCode",               comboBoxGS07ResponsibleAgencyCode.Text.Substring(0, 1)),
                new XElement("VersionReleaseIndustryIDCode",        textBoxGS08VersionReleaseIndustryIDCode.Text),
                new XElement("SegmentSeparator",                    separators[comboBoxSegmentSeparator.SelectedIndex]),
                new XElement("ElementSeparator",                    separators[comboBoxElementSeparator.SelectedIndex]),
                new XElement("TransactionType",                     comboBoxTransactionType.Text.Substring(0, 3)),
                new XElement("Direction",                           comboBoxDirection.Text),
                new XElement("Activated",                           checkBoxAgreementActivated.Checked),
                new XElement("SegmentSeparatorSuffix",              suffix[comboBoxSegmentSeparatorSuffix.SelectedIndex])
                    ));

            DialogResult reviewResult = MessageBox.Show("Agreement Name : "                         + doc.Root.Element("AgreementName").Value +
                                                      "\nAuthorization Information Qualifier : "    + doc.Root.Element("AuthorizationInformationQualifier").Value +
                                                      "\nAuthorization Information : "              + doc.Root.Element("AuthorizationInformation").Value +
                                                      "\nSecurity Information Qualifier : "         + doc.Root.Element("SecurityInformationQualifier").Value +
                                                      "\nSecurity Information : "                   + doc.Root.Element("SecurityInformation").Value +
                                                      "\nSender InterchangeID Qualifier : "         + (from x in doc.Root.Elements("Partner") where (x.Attribute("Type").Value == "Sender")   select x.Element("InterchangeIDQualifier").Value).FirstOrDefault() +
                                                      "\nSender InterchangeID : "                   + (from x in doc.Root.Elements("Partner") where (x.Attribute("Type").Value == "Sender")   select x.Element("InterchangeID").Value).FirstOrDefault() +
                                                      "\nReceiver InterchangeID Qualifier : "       + (from x in doc.Root.Elements("Partner") where (x.Attribute("Type").Value == "Receiver") select x.Element("InterchangeIDQualifier").Value).FirstOrDefault() +
                                                      "\nReceiver InterchangeID : "                 + (from x in doc.Root.Elements("Partner") where (x.Attribute("Type").Value == "Receiver") select x.Element("InterchangeID").Value).FirstOrDefault() +
                                                      "\nInterchange StandardsID : "                + doc.Root.Element("InterchangeStandardsID").Value +
                                                      "\nInterchange VersionID : "                  + doc.Root.Element("InterchangeVersionID").Value +
                                                      "\nInterchange Control Number : "             + doc.Root.Element("InterchangeControlNumber").Value +
                                                      "\nAck Requested : "                          + doc.Root.Element("AckRequested").Value +
                                                      "\nTest Indicator : "                         + doc.Root.Element("TestIndicator").Value +
                                                      "\nSub Element Separator : "                  + doc.Root.Element("SubElementSeparator").Value +
                                                      "\nFunctional IDCode : "                      + doc.Root.Element("FunctionalIDCode").Value +
                                                      "\nApplication SenderID : "                   + doc.Root.Element("ApplicationSenderID").Value +
                                                      "\nApplication ReceiverID : "                 + doc.Root.Element("ApplicationReceiverID").Value +
                                                      "\nGroup Control Number : "                   + doc.Root.Element("GroupControlNumber").Value +
                                                      "\nResponsible Agency Code : "                + doc.Root.Element("ResponsibleAgencyCode").Value +
                                                      "\nVersion/Release/Industry IDCode : "        + doc.Root.Element("VersionReleaseIndustryIDCode").Value +
                                                      "\nSegment Separator : "                      + doc.Root.Element("SegmentSeparator").Value +
                                                      "\nElement Separator : "                      + doc.Root.Element("ElementSeparator").Value +
                                                      "\nTransaction Type : "                       + doc.Root.Element("TransactionType").Value +
                                                      "\nDirection : "                              + doc.Root.Element("Direction").Value +
                                                      "\nActivated : "                              + doc.Root.Element("Activated").Value +
                                                      "\nSegment Separator Suffix : "               + doc.Root.Element("SegmentSeparatorSuffix").Value +
                                                      "\n\nSave this Agreement?",
                                                   "Review Agreement",
                                                    MessageBoxButtons.YesNoCancel,
                                                    MessageBoxIcon.Question);

            if (reviewResult == DialogResult.Yes)
            {
                // Insert agreement info
                try
                {
                    string constr = ConfigurationManager.ConnectionStrings["NeuronEDI"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Agreement_Create"))
                        {
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@agreement", doc.ToString());
                            SqlParameter result = new SqlParameter("@result", SqlDbType.NVarChar);
                            result.Size = 50;
                            result.Direction = ParameterDirection.Output;
                            cmd.Parameters.Add(result);
                            con.Open();
                            cmd.ExecuteScalar();
                            con.Close();
                            if (result.Value.ToString() == "Success")
                            {
                                MessageBox.Show("Agreement successfully added!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error attempting to save Agreement \n" + ex.Message + "\n" + ex.StackTrace);
                }
            }
            else
            {
                return;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (string item in comboBoxGS01FunctionalIDCode.Items)
            {
                if(item.Substring(0, 3) == comboBoxTransactionType.Text.Substring(0, 3))
                {
                    comboBoxGS01FunctionalIDCode.SelectedItem = item;
                }
            }
        }
    }
}
