using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPA_Editor
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void linkLabelAddPartner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create a new instance of the Trading_Partner_Editor class
            PartnerCreateForm tpeForm = new PartnerCreateForm();

            // Show the settings form
            tpeForm.Show();
        }

        private void linkLabelUpdatePartner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create a new instance of the Trading_Partner_Editor class
            PartnerUpdateForm tpeForm = new PartnerUpdateForm();

            // Show the settings form
            tpeForm.Show();
        }

        private void linkLabelAddAgreement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create a new instance of the Trading_Partner_Editor class
            AgreementCreate tpeForm = new AgreementCreate();

            // Show the settings form
            tpeForm.Show();
        }

        private void linkLabelUpdateAgreement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create a new instance of the Trading_Partner_Editor class
            AgreementUpdate tpeForm = new AgreementUpdate();

            // Show the settings form
            tpeForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
