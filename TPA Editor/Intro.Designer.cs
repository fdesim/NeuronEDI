namespace TPA_Editor
{
    partial class IntroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.linkLabelCreatePartner = new System.Windows.Forms.LinkLabel();
            this.linkLabelUpdatePartner = new System.Windows.Forms.LinkLabel();
            this.linkLabelCreateAgreement = new System.Windows.Forms.LinkLabel();
            this.linkLabelUpdateAgreement = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(57, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(623, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Neuron ESB Trading Partner Management";
            // 
            // linkLabelCreatePartner
            // 
            this.linkLabelCreatePartner.AutoSize = true;
            this.linkLabelCreatePartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreatePartner.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabelCreatePartner.Location = new System.Drawing.Point(60, 137);
            this.linkLabelCreatePartner.Name = "linkLabelCreatePartner";
            this.linkLabelCreatePartner.Size = new System.Drawing.Size(205, 20);
            this.linkLabelCreatePartner.TabIndex = 1;
            this.linkLabelCreatePartner.TabStop = true;
            this.linkLabelCreatePartner.Text = "Create New Trading Partner";
            this.linkLabelCreatePartner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddPartner_LinkClicked);
            // 
            // linkLabelUpdatePartner
            // 
            this.linkLabelUpdatePartner.AutoSize = true;
            this.linkLabelUpdatePartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelUpdatePartner.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabelUpdatePartner.Location = new System.Drawing.Point(60, 173);
            this.linkLabelUpdatePartner.Name = "linkLabelUpdatePartner";
            this.linkLabelUpdatePartner.Size = new System.Drawing.Size(234, 20);
            this.linkLabelUpdatePartner.TabIndex = 2;
            this.linkLabelUpdatePartner.TabStop = true;
            this.linkLabelUpdatePartner.Text = "Update Existing Trading Partner";
            this.linkLabelUpdatePartner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUpdatePartner_LinkClicked);
            // 
            // linkLabelCreateAgreement
            // 
            this.linkLabelCreateAgreement.AutoSize = true;
            this.linkLabelCreateAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateAgreement.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabelCreateAgreement.Location = new System.Drawing.Point(60, 243);
            this.linkLabelCreateAgreement.Name = "linkLabelCreateAgreement";
            this.linkLabelCreateAgreement.Size = new System.Drawing.Size(175, 20);
            this.linkLabelCreateAgreement.TabIndex = 3;
            this.linkLabelCreateAgreement.TabStop = true;
            this.linkLabelCreateAgreement.Text = "Create New Agreement";
            this.linkLabelCreateAgreement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddAgreement_LinkClicked);
            // 
            // linkLabelUpdateAgreement
            // 
            this.linkLabelUpdateAgreement.AutoSize = true;
            this.linkLabelUpdateAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelUpdateAgreement.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabelUpdateAgreement.Location = new System.Drawing.Point(60, 279);
            this.linkLabelUpdateAgreement.Name = "linkLabelUpdateAgreement";
            this.linkLabelUpdateAgreement.Size = new System.Drawing.Size(204, 20);
            this.linkLabelUpdateAgreement.TabIndex = 4;
            this.linkLabelUpdateAgreement.TabStop = true;
            this.linkLabelUpdateAgreement.Text = "Update Existing Agreement";
            this.linkLabelUpdateAgreement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUpdateAgreement_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(646, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(743, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabelUpdateAgreement);
            this.Controls.Add(this.linkLabelCreateAgreement);
            this.Controls.Add(this.linkLabelUpdatePartner);
            this.Controls.Add(this.linkLabelCreatePartner);
            this.Controls.Add(this.labelTitle);
            this.Name = "IntroForm";
            this.Text = "Neuron ESB - EDI Trading Partner Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.LinkLabel linkLabelCreatePartner;
        private System.Windows.Forms.LinkLabel linkLabelUpdatePartner;
        private System.Windows.Forms.LinkLabel linkLabelCreateAgreement;
        private System.Windows.Forms.LinkLabel linkLabelUpdateAgreement;
        private System.Windows.Forms.Button button1;
    }
}