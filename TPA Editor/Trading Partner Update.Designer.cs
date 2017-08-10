namespace TPA_Editor
{
    partial class PartnerUpdateForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTP = new System.Windows.Forms.DataGridView();
            this.pKPartnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interchangeIDQualifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interchangeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.externalReferenceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradingPartnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neuronEDIDataSet3 = new TPA_Editor.NeuronEDIDataSet3();
            this.tradingPartnerTableAdapter = new TPA_Editor.NeuronEDIDataSet3TableAdapters.TradingPartnerTableAdapter();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxTP = new System.Windows.Forms.GroupBox();
            this.buttonUpdateTP = new System.Windows.Forms.Button();
            this.groupBoxFunctionalGroup = new System.Windows.Forms.GroupBox();
            this.buttonUpdateGroup = new System.Windows.Forms.Button();
            this.dataGridViewFunctionalGroup = new System.Windows.Forms.DataGridView();
            this.pKGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionalGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activatedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fKPartnerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionalGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.neuronEDIDataSet1 = new TPA_Editor.NeuronEDIDataSet1();
            this.functionalGroupTableAdapter = new TPA_Editor.NeuronEDIDataSet1TableAdapters.FunctionalGroupTableAdapter();
            this.buttonAddNewGroup = new System.Windows.Forms.Button();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.groupBoxAddNewGroup = new System.Windows.Forms.GroupBox();
            this.checkBoxActivated = new System.Windows.Forms.CheckBox();
            this.labelFunctionalGroupID = new System.Windows.Forms.Label();
            this.textBoxFunctionalGroupID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingPartnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuronEDIDataSet3)).BeginInit();
            this.groupBoxTP.SuspendLayout();
            this.groupBoxFunctionalGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctionalGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionalGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuronEDIDataSet1)).BeginInit();
            this.groupBoxAddNewGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTP
            // 
            this.dataGridViewTP.AllowUserToAddRows = false;
            this.dataGridViewTP.AllowUserToDeleteRows = false;
            this.dataGridViewTP.AllowUserToOrderColumns = true;
            this.dataGridViewTP.AutoGenerateColumns = false;
            this.dataGridViewTP.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKPartnerIDDataGridViewTextBoxColumn,
            this.partnerNameDataGridViewTextBoxColumn,
            this.interchangeIDQualifierDataGridViewTextBoxColumn,
            this.interchangeIDDataGridViewTextBoxColumn,
            this.activatedDataGridViewCheckBoxColumn,
            this.externalReferenceIDDataGridViewTextBoxColumn});
            this.dataGridViewTP.DataSource = this.tradingPartnerBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTP.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTP.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewTP.Location = new System.Drawing.Point(23, 37);
            this.dataGridViewTP.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTP.Name = "dataGridViewTP";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTP.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTP.Size = new System.Drawing.Size(812, 382);
            this.dataGridViewTP.TabIndex = 0;
            // 
            // pKPartnerIDDataGridViewTextBoxColumn
            // 
            this.pKPartnerIDDataGridViewTextBoxColumn.DataPropertyName = "PK_PartnerID";
            this.pKPartnerIDDataGridViewTextBoxColumn.HeaderText = "PK_PartnerID";
            this.pKPartnerIDDataGridViewTextBoxColumn.MaxInputLength = 36;
            this.pKPartnerIDDataGridViewTextBoxColumn.Name = "pKPartnerIDDataGridViewTextBoxColumn";
            this.pKPartnerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // partnerNameDataGridViewTextBoxColumn
            // 
            this.partnerNameDataGridViewTextBoxColumn.DataPropertyName = "PartnerName";
            this.partnerNameDataGridViewTextBoxColumn.HeaderText = "PartnerName";
            this.partnerNameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.partnerNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.partnerNameDataGridViewTextBoxColumn.Name = "partnerNameDataGridViewTextBoxColumn";
            this.partnerNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // interchangeIDQualifierDataGridViewTextBoxColumn
            // 
            this.interchangeIDQualifierDataGridViewTextBoxColumn.DataPropertyName = "InterchangeIDQualifier";
            this.interchangeIDQualifierDataGridViewTextBoxColumn.HeaderText = "InterchangeIDQualifier";
            this.interchangeIDQualifierDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.interchangeIDQualifierDataGridViewTextBoxColumn.Name = "interchangeIDQualifierDataGridViewTextBoxColumn";
            this.interchangeIDQualifierDataGridViewTextBoxColumn.Width = 150;
            // 
            // interchangeIDDataGridViewTextBoxColumn
            // 
            this.interchangeIDDataGridViewTextBoxColumn.DataPropertyName = "InterchangeID";
            this.interchangeIDDataGridViewTextBoxColumn.HeaderText = "InterchangeID";
            this.interchangeIDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.interchangeIDDataGridViewTextBoxColumn.Name = "interchangeIDDataGridViewTextBoxColumn";
            this.interchangeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // activatedDataGridViewCheckBoxColumn
            // 
            this.activatedDataGridViewCheckBoxColumn.DataPropertyName = "Activated";
            this.activatedDataGridViewCheckBoxColumn.HeaderText = "Activated";
            this.activatedDataGridViewCheckBoxColumn.Name = "activatedDataGridViewCheckBoxColumn";
            // 
            // externalReferenceIDDataGridViewTextBoxColumn
            // 
            this.externalReferenceIDDataGridViewTextBoxColumn.DataPropertyName = "ExternalReferenceID";
            this.externalReferenceIDDataGridViewTextBoxColumn.HeaderText = "ExternalReferenceID";
            this.externalReferenceIDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.externalReferenceIDDataGridViewTextBoxColumn.Name = "externalReferenceIDDataGridViewTextBoxColumn";
            this.externalReferenceIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // tradingPartnerBindingSource
            // 
            this.tradingPartnerBindingSource.DataMember = "TradingPartner";
            this.tradingPartnerBindingSource.DataSource = this.neuronEDIDataSet3;
            // 
            // neuronEDIDataSet3
            // 
            this.neuronEDIDataSet3.DataSetName = "NeuronEDIDataSet3";
            this.neuronEDIDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tradingPartnerTableAdapter
            // 
            this.tradingPartnerTableAdapter.ClearBeforeFill = true;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(1183, 676);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 28);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxTP
            // 
            this.groupBoxTP.Controls.Add(this.buttonUpdateTP);
            this.groupBoxTP.Controls.Add(this.dataGridViewTP);
            this.groupBoxTP.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxTP.Location = new System.Drawing.Point(16, 15);
            this.groupBoxTP.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTP.Name = "groupBoxTP";
            this.groupBoxTP.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTP.Size = new System.Drawing.Size(992, 447);
            this.groupBoxTP.TabIndex = 2;
            this.groupBoxTP.TabStop = false;
            this.groupBoxTP.Text = "Trading Partner";
            // 
            // buttonUpdateTP
            // 
            this.buttonUpdateTP.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonUpdateTP.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.buttonUpdateTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateTP.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdateTP.Location = new System.Drawing.Point(864, 391);
            this.buttonUpdateTP.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateTP.Name = "buttonUpdateTP";
            this.buttonUpdateTP.Size = new System.Drawing.Size(100, 28);
            this.buttonUpdateTP.TabIndex = 1;
            this.buttonUpdateTP.Text = "Update";
            this.buttonUpdateTP.UseVisualStyleBackColor = false;
            this.buttonUpdateTP.Click += new System.EventHandler(this.buttonUpdateTP_Click);
            // 
            // groupBoxFunctionalGroup
            // 
            this.groupBoxFunctionalGroup.Controls.Add(this.buttonUpdateGroup);
            this.groupBoxFunctionalGroup.Controls.Add(this.dataGridViewFunctionalGroup);
            this.groupBoxFunctionalGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxFunctionalGroup.Location = new System.Drawing.Point(16, 474);
            this.groupBoxFunctionalGroup.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFunctionalGroup.Name = "groupBoxFunctionalGroup";
            this.groupBoxFunctionalGroup.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFunctionalGroup.Size = new System.Drawing.Size(664, 172);
            this.groupBoxFunctionalGroup.TabIndex = 3;
            this.groupBoxFunctionalGroup.TabStop = false;
            this.groupBoxFunctionalGroup.Text = "Functional Group";
            // 
            // buttonUpdateGroup
            // 
            this.buttonUpdateGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonUpdateGroup.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.buttonUpdateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateGroup.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdateGroup.Location = new System.Drawing.Point(551, 123);
            this.buttonUpdateGroup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateGroup.Name = "buttonUpdateGroup";
            this.buttonUpdateGroup.Size = new System.Drawing.Size(100, 28);
            this.buttonUpdateGroup.TabIndex = 2;
            this.buttonUpdateGroup.Text = "Update";
            this.buttonUpdateGroup.UseVisualStyleBackColor = false;
            // 
            // dataGridViewFunctionalGroup
            // 
            this.dataGridViewFunctionalGroup.AllowUserToAddRows = false;
            this.dataGridViewFunctionalGroup.AllowUserToDeleteRows = false;
            this.dataGridViewFunctionalGroup.AllowUserToOrderColumns = true;
            this.dataGridViewFunctionalGroup.AutoGenerateColumns = false;
            this.dataGridViewFunctionalGroup.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewFunctionalGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunctionalGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pKGroupIDDataGridViewTextBoxColumn,
            this.groupNameDataGridViewTextBoxColumn,
            this.functionalGroupIDDataGridViewTextBoxColumn,
            this.activatedDataGridViewCheckBoxColumn1,
            this.fKPartnerIDDataGridViewTextBoxColumn});
            this.dataGridViewFunctionalGroup.DataSource = this.functionalGroupBindingSource;
            this.dataGridViewFunctionalGroup.Location = new System.Drawing.Point(23, 41);
            this.dataGridViewFunctionalGroup.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFunctionalGroup.Name = "dataGridViewFunctionalGroup";
            this.dataGridViewFunctionalGroup.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewFunctionalGroup.Size = new System.Drawing.Size(511, 110);
            this.dataGridViewFunctionalGroup.TabIndex = 0;
            // 
            // pKGroupIDDataGridViewTextBoxColumn
            // 
            this.pKGroupIDDataGridViewTextBoxColumn.DataPropertyName = "PK_GroupID";
            this.pKGroupIDDataGridViewTextBoxColumn.HeaderText = "PK_GroupID";
            this.pKGroupIDDataGridViewTextBoxColumn.Name = "pKGroupIDDataGridViewTextBoxColumn";
            this.pKGroupIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            this.groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.HeaderText = "GroupName";
            this.groupNameDataGridViewTextBoxColumn.MaxInputLength = 100;
            this.groupNameDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            this.groupNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // functionalGroupIDDataGridViewTextBoxColumn
            // 
            this.functionalGroupIDDataGridViewTextBoxColumn.DataPropertyName = "FunctionalGroupID";
            this.functionalGroupIDDataGridViewTextBoxColumn.HeaderText = "FunctionalGroupID";
            this.functionalGroupIDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.functionalGroupIDDataGridViewTextBoxColumn.Name = "functionalGroupIDDataGridViewTextBoxColumn";
            this.functionalGroupIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // activatedDataGridViewCheckBoxColumn1
            // 
            this.activatedDataGridViewCheckBoxColumn1.DataPropertyName = "Activated";
            this.activatedDataGridViewCheckBoxColumn1.HeaderText = "Activated";
            this.activatedDataGridViewCheckBoxColumn1.Name = "activatedDataGridViewCheckBoxColumn1";
            // 
            // fKPartnerIDDataGridViewTextBoxColumn
            // 
            this.fKPartnerIDDataGridViewTextBoxColumn.DataPropertyName = "FK_PartnerID";
            this.fKPartnerIDDataGridViewTextBoxColumn.HeaderText = "FK_PartnerID";
            this.fKPartnerIDDataGridViewTextBoxColumn.Name = "fKPartnerIDDataGridViewTextBoxColumn";
            this.fKPartnerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // functionalGroupBindingSource
            // 
            this.functionalGroupBindingSource.DataMember = "FunctionalGroup";
            this.functionalGroupBindingSource.DataSource = this.neuronEDIDataSet1;
            // 
            // neuronEDIDataSet1
            // 
            this.neuronEDIDataSet1.DataSetName = "NeuronEDIDataSet1";
            this.neuronEDIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // functionalGroupTableAdapter
            // 
            this.functionalGroupTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddNewGroup
            // 
            this.buttonAddNewGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonAddNewGroup.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.buttonAddNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewGroup.ForeColor = System.Drawing.Color.Black;
            this.buttonAddNewGroup.Location = new System.Drawing.Point(482, 123);
            this.buttonAddNewGroup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddNewGroup.Name = "buttonAddNewGroup";
            this.buttonAddNewGroup.Size = new System.Drawing.Size(100, 28);
            this.buttonAddNewGroup.TabIndex = 1;
            this.buttonAddNewGroup.Text = "Add";
            this.buttonAddNewGroup.UseVisualStyleBackColor = false;
            this.buttonAddNewGroup.Click += new System.EventHandler(this.buttonAddNewGroup_Click);
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(161, 41);
            this.textBoxGroupName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(421, 22);
            this.textBoxGroupName.TabIndex = 3;
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Location = new System.Drawing.Point(15, 48);
            this.labelGroupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(85, 16);
            this.labelGroupName.TabIndex = 4;
            this.labelGroupName.Text = "Group Name";
            // 
            // groupBoxAddNewGroup
            // 
            this.groupBoxAddNewGroup.Controls.Add(this.checkBoxActivated);
            this.groupBoxAddNewGroup.Controls.Add(this.labelFunctionalGroupID);
            this.groupBoxAddNewGroup.Controls.Add(this.textBoxFunctionalGroupID);
            this.groupBoxAddNewGroup.Controls.Add(this.labelGroupName);
            this.groupBoxAddNewGroup.Controls.Add(this.buttonAddNewGroup);
            this.groupBoxAddNewGroup.Controls.Add(this.textBoxGroupName);
            this.groupBoxAddNewGroup.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBoxAddNewGroup.Location = new System.Drawing.Point(701, 474);
            this.groupBoxAddNewGroup.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAddNewGroup.Name = "groupBoxAddNewGroup";
            this.groupBoxAddNewGroup.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAddNewGroup.Size = new System.Drawing.Size(615, 172);
            this.groupBoxAddNewGroup.TabIndex = 4;
            this.groupBoxAddNewGroup.TabStop = false;
            this.groupBoxAddNewGroup.Text = "Add New Group";
            // 
            // checkBoxActivated
            // 
            this.checkBoxActivated.AutoSize = true;
            this.checkBoxActivated.Location = new System.Drawing.Point(164, 120);
            this.checkBoxActivated.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxActivated.Name = "checkBoxActivated";
            this.checkBoxActivated.Size = new System.Drawing.Size(75, 20);
            this.checkBoxActivated.TabIndex = 7;
            this.checkBoxActivated.Text = "Activate";
            this.checkBoxActivated.UseVisualStyleBackColor = true;
            // 
            // labelFunctionalGroupID
            // 
            this.labelFunctionalGroupID.AutoSize = true;
            this.labelFunctionalGroupID.Location = new System.Drawing.Point(15, 85);
            this.labelFunctionalGroupID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFunctionalGroupID.Name = "labelFunctionalGroupID";
            this.labelFunctionalGroupID.Size = new System.Drawing.Size(125, 16);
            this.labelFunctionalGroupID.TabIndex = 6;
            this.labelFunctionalGroupID.Text = "Functional Group ID";
            // 
            // textBoxFunctionalGroupID
            // 
            this.textBoxFunctionalGroupID.Location = new System.Drawing.Point(163, 78);
            this.textBoxFunctionalGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFunctionalGroupID.Name = "textBoxFunctionalGroupID";
            this.textBoxFunctionalGroupID.Size = new System.Drawing.Size(203, 22);
            this.textBoxFunctionalGroupID.TabIndex = 5;
            // 
            // PartnerUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(1329, 728);
            this.Controls.Add(this.groupBoxAddNewGroup);
            this.Controls.Add(this.groupBoxFunctionalGroup);
            this.Controls.Add(this.groupBoxTP);
            this.Controls.Add(this.buttonClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PartnerUpdateForm";
            this.Text = "Neuron ESB - Update EDI Trading Partner";
            this.Load += new System.EventHandler(this.Trading_Partner_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradingPartnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuronEDIDataSet3)).EndInit();
            this.groupBoxTP.ResumeLayout(false);
            this.groupBoxFunctionalGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunctionalGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionalGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neuronEDIDataSet1)).EndInit();
            this.groupBoxAddNewGroup.ResumeLayout(false);
            this.groupBoxAddNewGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTP;
        private NeuronEDIDataSet3 neuronEDIDataSet3;
        private System.Windows.Forms.BindingSource tradingPartnerBindingSource;
        private NeuronEDIDataSet3TableAdapters.TradingPartnerTableAdapter tradingPartnerTableAdapter;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxTP;
        private System.Windows.Forms.GroupBox groupBoxFunctionalGroup;
        private System.Windows.Forms.DataGridView dataGridViewFunctionalGroup;
        private NeuronEDIDataSet1 neuronEDIDataSet1;
        private System.Windows.Forms.BindingSource functionalGroupBindingSource;
        private NeuronEDIDataSet1TableAdapters.FunctionalGroupTableAdapter functionalGroupTableAdapter;
        private System.Windows.Forms.Button buttonUpdateGroup;
        private System.Windows.Forms.Button buttonAddNewGroup;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.GroupBox groupBoxAddNewGroup;
        private System.Windows.Forms.CheckBox checkBoxActivated;
        private System.Windows.Forms.Label labelFunctionalGroupID;
        private System.Windows.Forms.TextBox textBoxFunctionalGroupID;
        private System.Windows.Forms.Button buttonUpdateTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKPartnerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interchangeIDQualifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interchangeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activatedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn externalReferenceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pKGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionalGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activatedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKPartnerIDDataGridViewTextBoxColumn;

    }
}