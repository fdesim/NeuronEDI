using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TPA_Editor
{
    public partial class PartnerUpdateForm : Form
    {
        // Declare variables
        public string partnerKey                    = string.Empty;
        public string partnerName                   = string.Empty;
        public string partnerInterchangeIDQual      = string.Empty;
        public string partnerInterchangeID          = string.Empty;
        public bool   partnerActivated              = false;
        public string partnerExternalReferenceID    = string.Empty;

        public string groupKey          = string.Empty;
        public string groupName         = string.Empty;
        public string functionalGroupID = string.Empty;
        public bool   groupActivated    = false;

        public PartnerUpdateForm()
        {
            InitializeComponent();
        }

        private void Trading_Partner_Update_Load(object sender, EventArgs e)
        {
            // Load data into the 'neuronEDIDataSet1.TradingPartner' table
            this.tradingPartnerTableAdapter.Fill(this.neuronEDIDataSet3.TradingPartner);
            dataGridViewTP.Sort(this.dataGridViewTP.Columns[1], ListSortDirection.Ascending);

            // Load data into the 'neuronEDIDataSet1.FunctionalGroup' table           
            this.functionalGroupTableAdapter.Fill(this.neuronEDIDataSet1.FunctionalGroup);

            // Filter the displayed Functional Group based on Partner
            partnerKey = dataGridViewTP.CurrentRow.Cells[0].Value.ToString();
            string filter = "FK_PartnerID = '" + partnerKey + "'";
            this.dataGridViewFunctionalGroup.DataSource = neuronEDIDataSet1.FunctionalGroup.Select(filter);
        }

        private void dataGridViewTP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updatePartner(dataGridViewTP.CurrentRow);
        }

        private void dataGridViewFunctionalGroup_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateGroup(dataGridViewFunctionalGroup.CurrentRow);
        }

        private void dataGridViewTP_SelectionChanged(object sender, EventArgs e)
        {
            // Update data grid view Group to reflect changes to the TP selection.
            if (dataGridViewTP.CurrentCell != null)
            {
                partnerKey = dataGridViewTP.CurrentRow.Cells[0].Value.ToString();
                string filter = "FK_PartnerID = '" + partnerKey + "'";

                //this.functionalGroupTableAdapter.Fill(this.neuronEDIDataSet2.FunctionalGroup);
                this.dataGridViewFunctionalGroup.DataSource = neuronEDIDataSet1.FunctionalGroup.Select(filter);
            }
        }

        private void buttonUpdateTP_Click(object sender, EventArgs e)
        {
            updatePartner(dataGridViewTP.CurrentRow);
        }

        private void buttonUpdateGroup_Click(object sender, EventArgs e)
        {
            updateGroup(dataGridViewFunctionalGroup.CurrentRow);
        }

        private void buttonAddNewGroup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxGroupName.Text) && !string.IsNullOrWhiteSpace(textBoxFunctionalGroupID.Text))
            {
                // Build the xml
                XDocument doc = new XDocument();

                doc.Add(new XElement("FunctionalGroups",
                    new XElement("FunctionalGroup",
                    new XElement("GroupName", textBoxGroupName.Text),
                    new XElement("FunctionalGroupID", textBoxFunctionalGroupID.Text),
                    new XElement("Activated", checkBoxActivated.Checked)
                    )));
                // Insert Group
                try
                {
                    string constr = ConfigurationManager.ConnectionStrings["NeuronEDI"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_FunctionalGroup_Create"))
                        {
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@group", doc.ToString());
                            cmd.Parameters.AddWithValue("@partnerid", partnerKey);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // Refresh dataGridViewGroup
                this.dataGridViewFunctionalGroup.DataSource = null;
                partnerKey = dataGridViewTP.CurrentRow.Cells[0].Value.ToString();
                string filter = "FK_PartnerID = '" + partnerKey + "'";
                this.functionalGroupTableAdapter.Fill(this.neuronEDIDataSet1.FunctionalGroup);
                this.dataGridViewFunctionalGroup.DataSource = neuronEDIDataSet1.FunctionalGroup.Select(filter);
            }

            else
            {
                MessageBox.Show("Must enter a Group Name and Functional Group ID");
            }
        }

        private void updatePartner(DataGridViewRow row)
        {
            partnerKey                  = row.Cells[0].Value.ToString();
            partnerName                 = row.Cells[1].Value.ToString();
            partnerInterchangeIDQual    = row.Cells[2].Value.ToString();
            partnerInterchangeID        = row.Cells[3].Value.ToString();
            partnerActivated            = Convert.ToBoolean(row.Cells[4].Value.ToString());
            partnerExternalReferenceID  = row.Cells[5].Value.ToString();

            // Insert updates into Trading Partner table
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["NeuronEDI"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE dbo.TradingPartner SET PartnerName               = @partnername, " +
                                                                                         "InterchangeIDQualifier    = @interchangeidqual, " +
                                                                                         "InterchangeID             = @interchangeid, " +
                                                                                         "Activated                 = @activated, " +
                                                                                         "ExternalReferenceID       = @externalreferenceid " +
                                                                                     "WHERE PK_PartnerID            = @partnerKey"))
                    {
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@partnerkey",          partnerKey);
                        cmd.Parameters.AddWithValue("@partnername",         partnerName);
                        cmd.Parameters.AddWithValue("@interchangeidqual",   partnerInterchangeIDQual);
                        cmd.Parameters.AddWithValue("@interchangeid",       partnerInterchangeID);
                        cmd.Parameters.AddWithValue("@activated",           partnerActivated);
                        cmd.Parameters.AddWithValue("@externalreferenceid", partnerExternalReferenceID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateGroup(DataGridViewRow row)
        {
            groupKey            = row.Cells[0].Value.ToString();
            groupName           = row.Cells[1].Value.ToString();
            functionalGroupID   = row.Cells[2].Value.ToString();
            groupActivated      = Convert.ToBoolean(row.Cells[3].Value.ToString());

            // Insert into Functional Group table
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["NeuronEDI"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE dbo.FunctionalGroup SET GroupName            = @groupname, " +
                                                                                          "FunctionalGroupID    = @functionalgroupid, " +
                                                                                          "Activated            = @activated " +
                                                                                      "WHERE PK_GroupID         = @groupKey"))
                    {
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@groupkey",            groupKey);
                        cmd.Parameters.AddWithValue("@groupname",           groupName);
                        cmd.Parameters.AddWithValue("@functionalgroupid",   functionalGroupID);
                        cmd.Parameters.AddWithValue("@activated",           groupActivated);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
