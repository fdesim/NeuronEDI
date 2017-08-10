namespace TPA_Editor
{
    partial class PartnerCreateForm
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
            this.labelTPName = new System.Windows.Forms.Label();
            this.labelInterchangeIDQual = new System.Windows.Forms.Label();
            this.labelInterchangeID = new System.Windows.Forms.Label();
            this.labelFunctionalGroupID = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxInterchangeIDQual = new System.Windows.Forms.ComboBox();
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.checkBoxTPActive = new System.Windows.Forms.CheckBox();
            this.checkBoxGroupActive = new System.Windows.Forms.CheckBox();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.buttonNewTP = new System.Windows.Forms.Button();
            this.groupBoxTradingPartner = new System.Windows.Forms.GroupBox();
            this.textBoxExternalReferenceID = new System.Windows.Forms.TextBox();
            this.labelExternalReferenceID = new System.Windows.Forms.Label();
            this.textBoxInterchangeID = new System.Windows.Forms.TextBox();
            this.textBoxTPName = new System.Windows.Forms.TextBox();
            this.groupBoxGroup = new System.Windows.Forms.GroupBox();
            this.textBoxFunctionalGroupID = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxTradingPartner.SuspendLayout();
            this.groupBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTPName
            // 
            this.labelTPName.AutoSize = true;
            this.labelTPName.Location = new System.Drawing.Point(15, 41);
            this.labelTPName.Name = "labelTPName";
            this.labelTPName.Size = new System.Drawing.Size(141, 16);
            this.labelTPName.TabIndex = 38;
            this.labelTPName.Text = "Trading Partner Name";
            // 
            // labelInterchangeIDQual
            // 
            this.labelInterchangeIDQual.AutoSize = true;
            this.labelInterchangeIDQual.Location = new System.Drawing.Point(15, 72);
            this.labelInterchangeIDQual.Name = "labelInterchangeIDQual";
            this.labelInterchangeIDQual.Size = new System.Drawing.Size(146, 16);
            this.labelInterchangeIDQual.TabIndex = 40;
            this.labelInterchangeIDQual.Text = "Interchange ID Qualifier";
            // 
            // labelInterchangeID
            // 
            this.labelInterchangeID.AutoSize = true;
            this.labelInterchangeID.Location = new System.Drawing.Point(15, 103);
            this.labelInterchangeID.Name = "labelInterchangeID";
            this.labelInterchangeID.Size = new System.Drawing.Size(94, 16);
            this.labelInterchangeID.TabIndex = 42;
            this.labelInterchangeID.Text = "Interchange ID";
            // 
            // labelFunctionalGroupID
            // 
            this.labelFunctionalGroupID.AutoSize = true;
            this.labelFunctionalGroupID.Location = new System.Drawing.Point(15, 67);
            this.labelFunctionalGroupID.Name = "labelFunctionalGroupID";
            this.labelFunctionalGroupID.Size = new System.Drawing.Size(125, 16);
            this.labelFunctionalGroupID.TabIndex = 44;
            this.labelFunctionalGroupID.Text = "Functional Group ID";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(152, 371);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 45;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxInterchangeIDQual
            // 
            this.comboBoxInterchangeIDQual.FormattingEnabled = true;
            this.comboBoxInterchangeIDQual.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "AM",
            "NR",
            "SA",
            "SN",
            "ZZ"});
            this.comboBoxInterchangeIDQual.Location = new System.Drawing.Point(170, 69);
            this.comboBoxInterchangeIDQual.MaxLength = 2;
            this.comboBoxInterchangeIDQual.Name = "comboBoxInterchangeIDQual";
            this.comboBoxInterchangeIDQual.Size = new System.Drawing.Size(57, 24);
            this.comboBoxInterchangeIDQual.TabIndex = 2;
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNewGroup.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.buttonNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewGroup.ForeColor = System.Drawing.Color.Black;
            this.buttonNewGroup.Location = new System.Drawing.Point(422, 27);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGroup.TabIndex = 52;
            this.buttonNewGroup.Text = "New";
            this.buttonNewGroup.UseVisualStyleBackColor = false;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonAddNewGroupID_Click);
            // 
            // checkBoxTPActive
            // 
            this.checkBoxTPActive.AutoSize = true;
            this.checkBoxTPActive.Location = new System.Drawing.Point(455, 79);
            this.checkBoxTPActive.Name = "checkBoxTPActive";
            this.checkBoxTPActive.Size = new System.Drawing.Size(64, 20);
            this.checkBoxTPActive.TabIndex = 57;
            this.checkBoxTPActive.Text = "Active";
            this.checkBoxTPActive.UseVisualStyleBackColor = true;
            // 
            // checkBoxGroupActive
            // 
            this.checkBoxGroupActive.AutoSize = true;
            this.checkBoxGroupActive.Location = new System.Drawing.Point(437, 74);
            this.checkBoxGroupActive.Name = "checkBoxGroupActive";
            this.checkBoxGroupActive.Size = new System.Drawing.Size(64, 20);
            this.checkBoxGroupActive.TabIndex = 58;
            this.checkBoxGroupActive.Text = "Active";
            this.checkBoxGroupActive.UseVisualStyleBackColor = true;
            // 
            // labelGroupName
            // 
            this.labelGroupName.Location = new System.Drawing.Point(15, 33);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(100, 23);
            this.labelGroupName.TabIndex = 62;
            this.labelGroupName.Text = "Group Name";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(140, 30);
            this.textBoxGroupName.MaxLength = 100;
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(242, 22);
            this.textBoxGroupName.TabIndex = 61;
            // 
            // buttonNewTP
            // 
            this.buttonNewTP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNewTP.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.buttonNewTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewTP.ForeColor = System.Drawing.Color.Black;
            this.buttonNewTP.Location = new System.Drawing.Point(440, 38);
            this.buttonNewTP.Name = "buttonNewTP";
            this.buttonNewTP.Size = new System.Drawing.Size(75, 23);
            this.buttonNewTP.TabIndex = 62;
            this.buttonNewTP.Text = "New";
            this.buttonNewTP.UseVisualStyleBackColor = false;
            this.buttonNewTP.Click += new System.EventHandler(this.buttonNewTP_Click);
            // 
            // groupBoxTradingPartner
            // 
            this.groupBoxTradingPartner.Controls.Add(this.textBoxExternalReferenceID);
            this.groupBoxTradingPartner.Controls.Add(this.labelExternalReferenceID);
            this.groupBoxTradingPartner.Controls.Add(this.textBoxInterchangeID);
            this.groupBoxTradingPartner.Controls.Add(this.textBoxTPName);
            this.groupBoxTradingPartner.Controls.Add(this.buttonNewTP);
            this.groupBoxTradingPartner.Controls.Add(this.labelTPName);
            this.groupBoxTradingPartner.Controls.Add(this.labelInterchangeIDQual);
            this.groupBoxTradingPartner.Controls.Add(this.labelInterchangeID);
            this.groupBoxTradingPartner.Controls.Add(this.checkBoxTPActive);
            this.groupBoxTradingPartner.Controls.Add(this.comboBoxInterchangeIDQual);
            this.groupBoxTradingPartner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTradingPartner.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxTradingPartner.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTradingPartner.Name = "groupBoxTradingPartner";
            this.groupBoxTradingPartner.Size = new System.Drawing.Size(539, 176);
            this.groupBoxTradingPartner.TabIndex = 63;
            this.groupBoxTradingPartner.TabStop = false;
            this.groupBoxTradingPartner.Text = "Trading Partner";
            // 
            // textBoxExternalReferenceID
            // 
            this.textBoxExternalReferenceID.Location = new System.Drawing.Point(170, 136);
            this.textBoxExternalReferenceID.MaxLength = 50;
            this.textBoxExternalReferenceID.Name = "textBoxExternalReferenceID";
            this.textBoxExternalReferenceID.Size = new System.Drawing.Size(187, 22);
            this.textBoxExternalReferenceID.TabIndex = 66;
            // 
            // labelExternalReferenceID
            // 
            this.labelExternalReferenceID.AutoSize = true;
            this.labelExternalReferenceID.Location = new System.Drawing.Point(15, 142);
            this.labelExternalReferenceID.Name = "labelExternalReferenceID";
            this.labelExternalReferenceID.Size = new System.Drawing.Size(138, 16);
            this.labelExternalReferenceID.TabIndex = 65;
            this.labelExternalReferenceID.Text = "External Reference ID";
            // 
            // textBoxInterchangeID
            // 
            this.textBoxInterchangeID.Location = new System.Drawing.Point(170, 103);
            this.textBoxInterchangeID.MaxLength = 15;
            this.textBoxInterchangeID.Name = "textBoxInterchangeID";
            this.textBoxInterchangeID.Size = new System.Drawing.Size(119, 22);
            this.textBoxInterchangeID.TabIndex = 64;
            // 
            // textBoxTPName
            // 
            this.textBoxTPName.Location = new System.Drawing.Point(170, 34);
            this.textBoxTPName.MaxLength = 100;
            this.textBoxTPName.Name = "textBoxTPName";
            this.textBoxTPName.Size = new System.Drawing.Size(242, 22);
            this.textBoxTPName.TabIndex = 63;
            // 
            // groupBoxGroup
            // 
            this.groupBoxGroup.Controls.Add(this.textBoxFunctionalGroupID);
            this.groupBoxGroup.Controls.Add(this.labelFunctionalGroupID);
            this.groupBoxGroup.Controls.Add(this.textBoxGroupName);
            this.groupBoxGroup.Controls.Add(this.labelGroupName);
            this.groupBoxGroup.Controls.Add(this.buttonNewGroup);
            this.groupBoxGroup.Controls.Add(this.checkBoxGroupActive);
            this.groupBoxGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxGroup.Location = new System.Drawing.Point(12, 207);
            this.groupBoxGroup.Name = "groupBoxGroup";
            this.groupBoxGroup.Size = new System.Drawing.Size(539, 120);
            this.groupBoxGroup.TabIndex = 64;
            this.groupBoxGroup.TabStop = false;
            this.groupBoxGroup.Text = "Group";
            // 
            // textBoxFunctionalGroupID
            // 
            this.textBoxFunctionalGroupID.Location = new System.Drawing.Point(140, 64);
            this.textBoxFunctionalGroupID.MaxLength = 15;
            this.textBoxFunctionalGroupID.Name = "textBoxFunctionalGroupID";
            this.textBoxFunctionalGroupID.Size = new System.Drawing.Size(119, 22);
            this.textBoxFunctionalGroupID.TabIndex = 63;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(319, 371);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 65;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // PartnerCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(588, 406);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxGroup);
            this.Controls.Add(this.groupBoxTradingPartner);
            this.Controls.Add(this.buttonSave);
            this.Name = "PartnerCreateForm";
            this.Text = "Neuron ESB - Create New EDI Trading Partner";
            this.Load += new System.EventHandler(this.Trading_Partner_Editor_Load);
            this.groupBoxTradingPartner.ResumeLayout(false);
            this.groupBoxTradingPartner.PerformLayout();
            this.groupBoxGroup.ResumeLayout(false);
            this.groupBoxGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTPName;
        private System.Windows.Forms.Label labelInterchangeIDQual;
        private System.Windows.Forms.Label labelInterchangeID;
        private System.Windows.Forms.Label labelFunctionalGroupID;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxInterchangeIDQual;
        private System.Windows.Forms.Button buttonNewGroup;
        private System.Windows.Forms.CheckBox checkBoxTPActive;
        private System.Windows.Forms.CheckBox checkBoxGroupActive;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Button buttonNewTP;
        private System.Windows.Forms.GroupBox groupBoxTradingPartner;
        private System.Windows.Forms.GroupBox groupBoxGroup;
        private System.Windows.Forms.TextBox textBoxInterchangeID;
        private System.Windows.Forms.TextBox textBoxTPName;
        private System.Windows.Forms.TextBox textBoxFunctionalGroupID;
        private System.Windows.Forms.TextBox textBoxExternalReferenceID;
        private System.Windows.Forms.Label labelExternalReferenceID;
        private System.Windows.Forms.Button buttonClose;
    }
}