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
    public partial class PartnerCreateForm : Form
    {
        private bool addNewGroupToTP    = false;
        private Guid tpid               = Guid.Empty;

        public PartnerCreateForm()
        {
            InitializeComponent();
        }

        private void Trading_Partner_Editor_Load(object sender, EventArgs e)
        {
            buttonNewTP.Enabled     = false;
            buttonNewGroup.Enabled  = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // If adding another Group to the TP, call the Create Group sp
            if(addNewGroupToTP)
            {
                // Build the xml
                XDocument doc = new XDocument();

                doc.Add(new XElement("FunctionalGroups",
                    new XElement("FunctionalGroup",
                    new XElement("GroupName",           textBoxGroupName.Text),
                    new XElement("FunctionalGroupID",   textBoxFunctionalGroupID.Text),
                    new XElement("Activated",           checkBoxGroupActive.Checked)
                    )));

                if (!string.IsNullOrWhiteSpace(textBoxGroupName.Text) && !string.IsNullOrWhiteSpace(textBoxFunctionalGroupID.Text))
                {
                    // Insert partner info
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
                                cmd.Parameters.AddWithValue("@partnerid", tpid);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                        MessageBox.Show("Group " + textBoxGroupName.Text + " successfully added");
                        buttonNewTP.Enabled = true;
                        buttonNewGroup.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Must enter a Group Name and Functional Group ID");
                }
            }
            else
            {
                // Build the xml
                XDocument doc = new XDocument();

                doc.Add(new XElement("Partner",
                    new XElement("PartnerName",             textBoxTPName.Text),
                    new XElement("InterchangeIDQualifier",  comboBoxInterchangeIDQual.Text),
                    new XElement("InterchangeID",           textBoxInterchangeID.Text),
                    new XElement("Activated",               checkBoxTPActive.Checked),
                    new XElement("ExternalReferenceID",     textBoxExternalReferenceID.Text),
                    new XElement("FunctionalGroups",
                    new XElement("FunctionalGroup",
                    new XElement("GroupName",               textBoxGroupName.Text),
                    new XElement("FunctionalGroupID",       textBoxFunctionalGroupID.Text),
                    new XElement("Activated",               checkBoxGroupActive.Checked)
                    ))));

                // Insert partner info
                try
                {
                    string constr = ConfigurationManager.ConnectionStrings["NeuronEDI"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_TradingPartner_Create"))
                        {
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@partner", doc.ToString());
                            SqlParameter output = new SqlParameter("@tpid", SqlDbType.UniqueIdentifier);
                            output.Direction = ParameterDirection.Output;
                            cmd.Parameters.Add(output);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            tpid = (Guid)output.Value;
                            con.Close();
                        }
                    }
                    MessageBox.Show("Trading Partner " + textBoxTPName.Text + " successfully created");
                    buttonNewTP.Enabled = true;
                    buttonNewGroup.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }   
        }

        private void comboBoxInterchangeID_TextChanged(object sender, EventArgs e)
        {
            textBoxFunctionalGroupID.Text = textBoxInterchangeID.Text;
        }

        private void comboBoxTPName_TextChanged(object sender, EventArgs e)
        {
            textBoxGroupName.Text = textBoxTPName.Text;
        }

        private void buttonAddNewGroupID_Click(object sender, EventArgs e)
        {
            textBoxGroupName.Text           = "";
            textBoxFunctionalGroupID.Text   = "";
            checkBoxGroupActive.Checked     = false;
            addNewGroupToTP                 = true;
            
        }

        private void buttonNewTP_Click(object sender, EventArgs e)
        {
            // Clear the Form
            textBoxTPName.Text              = "";
            comboBoxInterchangeIDQual.Text  = "";
            textBoxInterchangeID.Text       = "";
            textBoxExternalReferenceID.Text = "";
            textBoxGroupName.Text           = "";
            textBoxFunctionalGroupID.Text   = "";

            buttonNewTP.Enabled = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
