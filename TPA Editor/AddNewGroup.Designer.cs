namespace TPA_Editor
{
    partial class AddNewGroup
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
            this.labelGroupName = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelFunctionalGroupID = new System.Windows.Forms.Label();
            this.textBoxFunctionalGroupID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Location = new System.Drawing.Point(23, 29);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(67, 13);
            this.labelGroupName.TabIndex = 0;
            this.labelGroupName.Text = "Group Name";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(131, 29);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(226, 20);
            this.textBoxGroupName.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(131, 165);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelFunctionalGroupID
            // 
            this.labelFunctionalGroupID.AutoSize = true;
            this.labelFunctionalGroupID.Location = new System.Drawing.Point(23, 68);
            this.labelFunctionalGroupID.Name = "labelFunctionalGroupID";
            this.labelFunctionalGroupID.Size = new System.Drawing.Size(102, 13);
            this.labelFunctionalGroupID.TabIndex = 3;
            this.labelFunctionalGroupID.Text = "Functional Group ID";
            // 
            // textBoxFunctionalGroupID
            // 
            this.textBoxFunctionalGroupID.Location = new System.Drawing.Point(131, 65);
            this.textBoxFunctionalGroupID.Name = "textBoxFunctionalGroupID";
            this.textBoxFunctionalGroupID.Size = new System.Drawing.Size(168, 20);
            this.textBoxFunctionalGroupID.TabIndex = 4;
            // 
            // AddNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 261);
            this.Controls.Add(this.textBoxFunctionalGroupID);
            this.Controls.Add(this.labelFunctionalGroupID);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxGroupName);
            this.Controls.Add(this.labelGroupName);
            this.Name = "AddNewGroup";
            this.Text = "AddNewGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelFunctionalGroupID;
        private System.Windows.Forms.TextBox textBoxFunctionalGroupID;
    }
}