using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace TPA_Editor
{
    public partial class AgreementUpdate : Form
    {
        public DataTable agreementTable = new DataTable();
        public DataTable senderGroupTable = new DataTable();
        public DataTable receiverGroupTable = new DataTable();
        public DataRow dr;
        public string agreementID = string.Empty;

        public string[] separators = { "&#58;", "&#42;", "&#126;", "&#33;", "&#34;", "&#35;", "&#36;", "&#37;", "&#38;", "&#39;", "&#40;", "&#41;", "&#43;", "&#44;", "&#45;", "&#46;", "&#47;", "&#59;", "&#60;", "&#61;", "&#62;", "&#63;", "&#64;", "&#91;", "&#92;", "&#93;", "&#94;", "&#95;", "&#96;", "&#123;", "&#124;", "&#125;", "&#9;", "&#10;", "&#13;", "&#127;" };
        public string[] suffix      = { "&#0;", "&#13;", "&#10;", "&#13;&#10;" };

        public AgreementUpdate()
        {
            InitializeComponent();
        }

        private void AgreementUpdate_Load(object sender, EventArgs e)
        {
            var connection = ConfigurationManager.ConnectionStrings["NeuronEDI"].ConnectionString;

                // Load agreements table
                using (SqlConnection sqlConn = new SqlConnection(connection))
                {
                    using (SqlDataAdapter da_agreement = new SqlDataAdapter(@"SELECT a.PK_AgreementID,
                                                                                     a.AgreementName,
                                                                                     a.TransactionType,
                                                                                     a.Direction,
                                                                                     a.Activated,
                                                                                     a.ISA01AuthorizationInformationQualifier,
                                                                                     a.ISA02AuthorizationInformation,
                                                                                     a.ISA03SecurityInformationQualifier,
                                                                                     a.ISA04SecurityInformation,
                                                                                     a.ISA05SenderInterchangeIDQualifier,
                                                                                     a.ISA06SenderInterchangeID,
                                                                                     a.ISA07ReceiverInterchangeIDQualifier,
                                                                                     a.ISA08ReceiverInterchangeID,
                                                                                     a.ISA11InterchangeStandardsID,
                                                                                     a.ISA12InterchangeVersionID,
                                                                                     a.ISA14AckRequested,
                                                                                     a.ISA15TestIndicator,
                                                                                     a.SegmentSeparator,
                                                                                     a.ElementSeparator,
                                                                                     a.ISA16SubElementSeparator,
                                                                                     a.GS01FunctionalIDCode,
                                                                                     a.GS02ApplicationSenderID,
                                                                                     a.GS03ApplicationReceiverID,
                                                                                     a.GS07ResponsibleAgencyCode,
                                                                                     a.GS08VersionReleaseIndustryIDCode,
                                                                                     a.SegmentSeparatorSuffix,
                                                                                     b.ISA13InterchangeControlNumber,
                                                                                     b.GS06GroupControlNumber
                                                                              FROM dbo.Agreement a, dbo.ControlNumber b
                                                                              WHERE a.PK_AgreementID = b.PK_AgreementID " +
                                                                             "ORDER BY a.AgreementName", sqlConn))
                    {
                        da_agreement.Fill(agreementTable);
                    }
                }

                // Populate agreement names
                comboBoxAgreementName.DataSource = agreementTable;
                comboBoxAgreementName.DisplayMember = "AgreementName";
                comboBoxAgreementName.SelectedIndex = 0;
            }

        private void buttonUpdateAgreement_Click(object sender, EventArgs e)
        {
            string gs01 = string.Empty;
            if(comboBoxGS01FunctionalIDCode.Text.Length > 2) 
            {
                gs01 = comboBoxGS01FunctionalIDCode.Text.Substring(4, 2);
            } 
            else 
            {
                gs01 = comboBoxGS01FunctionalIDCode.Text.Substring(0, 2);
            }

            XDocument doc = new XDocument();

            doc.Add(new XElement("Agreement",
                new XElement("Action", "Update"),
                new XElement("AgreementName",                       comboBoxAgreementName.Text),
                new XElement("AgreementID",                         dr["PK_AgreementID"].ToString()),
                new XElement("AuthorizationInformationQualifier",   comboBoxISA01AuthorizationInformationQualifier.Text.Substring(0, 2)),
                new XElement("AuthorizationInformation",            textBoxISA02AuthorizationInformation.Text),
                new XElement("SecurityInformationQualifier",        comboBoxISA03SecurityInformationQualifier.Text.Substring(0, 2)),
                new XElement("SecurityInformation",                 textBoxISA04SecurityInformation.Text),
                new XElement("Partner",
                    new XAttribute("Type", "Sender"),
                    new XElement("InterchangeIDQualifier",          comboBoxISA05SenderInterchangeIDQualifier.Text.Substring(0, 2)),
                    new XElement("InterchangeID",                   comboBoxISA06SenderInterchangeID.Text)),
                new XElement("Partner",
                    new XAttribute("Type", "Receiver"),
                    new XElement("InterchangeIDQualifier",          comboBoxISA07ReceiverInterchangeIDQualifier.Text.Substring(0, 2)),
                    new XElement("InterchangeID",                   comboBoxISA08ReceiverInterchangeID.Text)),
                new XElement("InterchangeStandardsID",              comboBoxISA11InterchangeStandardsID.Text.Substring(0, 1)),
                new XElement("InterchangeVersionID",                comboBoxISA12InterchangeVersionID.Text),
                new XElement("InterchangeControlNumber",            textBoxISA13InterchangeControlNumber.Text),
                new XElement("AckRequested",                        comboBoxISA14AckRequested.Text.Substring(0, 1)),
                new XElement("TestIndicator",                       comboBoxISA15TestIndicator.Text.Substring(0, 1)),
                new XElement("SubElementSeparator",                 separators[comboBoxISA16SubElementSeparator.SelectedIndex]),
                new XElement("FunctionalIDCode",                    gs01),
                new XElement("ApplicationSenderID",                 comboBoxGS02ApplicationSenderID.Text),
                new XElement("ApplicationReceiverID",               comboBoxGS03ApplicationReceiverID.Text),
                new XElement("GroupControlNumber",                  textBoxGS06GroupControlNumber.Text),
                new XElement("ResponsibleAgencyCode",               comboBoxGS07ResponsibleAgencyCode.Text.Substring(0, 1)),
                new XElement("VersionReleaseIndustryIDCode",        comboBoxGS08VersionReleaseIndustryIDCode.Text),
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
                                                      "\nSender InterchangeID Qualifier : "         + (from x in doc.Root.Elements("Partner") where (x.Attribute("Type").Value == "Sender") select x.Element("InterchangeIDQualifier").Value).FirstOrDefault() +
                                                      "\nSender InterchangeID : "                   + (from x in doc.Root.Elements("Partner") where (x.Attribute("Type").Value == "Sender") select x.Element("InterchangeID").Value).FirstOrDefault() +
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
                                                      "\n\nUpdate this Agreement?",
                                                   "Review Agreement",
                                                    MessageBoxButtons.YesNoCancel,
                                                    MessageBoxIcon.Question);
            if (reviewResult == DialogResult.Yes)
            {
                // Update agreement info
                try
                {
                    string constr = ConfigurationManager.ConnectionStrings["NeuronEDI"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Agreement_Update"))
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
                                MessageBox.Show("Agreement successfully updated!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error attempting to update Agreement \n" + ex.Message + "\n" + ex.StackTrace);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAgreementName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxAgreementName.Focused == true)
            {
                dr = agreementTable.AsEnumerable().Where(row => row.Field<String>("AgreementName") == comboBoxAgreementName.Text).FirstOrDefault();

                agreementID = Convert.ToString(dr["PK_AgreementID"]);

                comboBoxISA01AuthorizationInformationQualifier.Text = dr["ISA01AuthorizationInformationQualifier"].ToString();
                textBoxISA02AuthorizationInformation.Text           = dr["ISA02AuthorizationInformation"].ToString();
                comboBoxISA03SecurityInformationQualifier.Text      = dr["ISA03SecurityInformationQualifier"].ToString();
                textBoxISA04SecurityInformation.Text                = dr["ISA04SecurityInformation"].ToString();
                comboBoxISA05SenderInterchangeIDQualifier.Text      = dr["ISA05SenderInterchangeIDQualifier"].ToString();
                comboBoxISA06SenderInterchangeID.Text               = dr["ISA06SenderInterchangeID"].ToString();
                comboBoxISA07ReceiverInterchangeIDQualifier.Text    = dr["ISA07ReceiverInterchangeIDQualifier"].ToString();
                comboBoxISA08ReceiverInterchangeID.Text             = dr["ISA08ReceiverInterchangeID"].ToString();
                comboBoxISA11InterchangeStandardsID.Text            = dr["ISA11InterchangeStandardsID"].ToString();
                comboBoxISA12InterchangeVersionID.Text              = dr["ISA12InterchangeVersionID"].ToString();
                textBoxISA13InterchangeControlNumber.Text           = dr["ISA13InterchangeControlNumber"].ToString();
                comboBoxISA14AckRequested.Text                      = dr["ISA14AckRequested"].ToString();
                comboBoxISA15TestIndicator.Text                     = dr["ISA15TestIndicator"].ToString();
                comboBoxISA16SubElementSeparator.SelectedIndex      = Array.IndexOf(separators, (dr["ISA16SubElementSeparator"]));
                comboBoxGS01FunctionalIDCode.Text                   = dr["GS01FunctionalIDCode"].ToString();
                comboBoxGS02ApplicationSenderID.Text                = dr["GS02ApplicationSenderID"].ToString();
                comboBoxGS03ApplicationReceiverID.Text              = dr["GS03ApplicationReceiverID"].ToString();
                textBoxGS06GroupControlNumber.Text                  = dr["GS06GroupControlNumber"].ToString();
                comboBoxGS07ResponsibleAgencyCode.Text              = dr["GS07ResponsibleAgencyCode"].ToString();
                comboBoxGS08VersionReleaseIndustryIDCode.Text       = dr["GS08VersionReleaseIndustryIDCode"].ToString();
                comboBoxTransactionType.Text                        = dr["TransactionType"].ToString();
                comboBoxDirection.Text                              = dr["Direction"].ToString();
                comboBoxSegmentSeparator.SelectedIndex              = Array.IndexOf(separators, (dr["SegmentSeparator"].ToString()));
                comboBoxElementSeparator.SelectedIndex              = Array.IndexOf(separators, (dr["ElementSeparator"].ToString()));
                comboBoxSegmentSeparatorSuffix.SelectedIndex        = Array.IndexOf(suffix, (dr["SegmentSeparatorSuffix"].ToString()));
                checkBoxAgreementActivated.Checked                  = Convert.ToBoolean(dr["Activated"]);
            }
        }
    }
}
