namespace XSDSchemaBuilder
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Schema");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNamespaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unqualifiedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNamespaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.elementFormDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualifiedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unqualifiedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.ContextMenuStrip = this.contextMenuStrip2;
            treeNode1.Name = "Schema";
            treeNode1.Text = "Schema";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(260, 480);
            this.treeView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNamespaceToolStripMenuItem,
            this.elementFormToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 48);
            // 
            // addNamespaceToolStripMenuItem
            // 
            this.addNamespaceToolStripMenuItem.Name = "addNamespaceToolStripMenuItem";
            this.addNamespaceToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addNamespaceToolStripMenuItem.Text = "Add Namespace";
            // 
            // elementFormToolStripMenuItem
            // 
            this.elementFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qualifiedToolStripMenuItem,
            this.unqualifiedToolStripMenuItem});
            this.elementFormToolStripMenuItem.Name = "elementFormToolStripMenuItem";
            this.elementFormToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.elementFormToolStripMenuItem.Text = "Element Form Defualt";
            // 
            // qualifiedToolStripMenuItem
            // 
            this.qualifiedToolStripMenuItem.Name = "qualifiedToolStripMenuItem";
            this.qualifiedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.qualifiedToolStripMenuItem.Text = "Qualified";
            // 
            // unqualifiedToolStripMenuItem
            // 
            this.unqualifiedToolStripMenuItem.Name = "unqualifiedToolStripMenuItem";
            this.unqualifiedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unqualifiedToolStripMenuItem.Text = "Unqualified";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNamespaceToolStripMenuItem1,
            this.elementFormDefaultToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(190, 48);
            // 
            // addNamespaceToolStripMenuItem1
            // 
            this.addNamespaceToolStripMenuItem1.Name = "addNamespaceToolStripMenuItem1";
            this.addNamespaceToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.addNamespaceToolStripMenuItem1.Text = "Add Namespace";
            // 
            // elementFormDefaultToolStripMenuItem
            // 
            this.elementFormDefaultToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qualifiedToolStripMenuItem1,
            this.unqualifiedToolStripMenuItem1});
            this.elementFormDefaultToolStripMenuItem.Name = "elementFormDefaultToolStripMenuItem";
            this.elementFormDefaultToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.elementFormDefaultToolStripMenuItem.Text = "Element Form Default";
            // 
            // qualifiedToolStripMenuItem1
            // 
            this.qualifiedToolStripMenuItem1.Name = "qualifiedToolStripMenuItem1";
            this.qualifiedToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.qualifiedToolStripMenuItem1.Text = "Qualified";
            // 
            // unqualifiedToolStripMenuItem1
            // 
            this.unqualifiedToolStripMenuItem1.Name = "unqualifiedToolStripMenuItem1";
            this.unqualifiedToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.unqualifiedToolStripMenuItem1.Text = "Unqualified";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 504);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "XSD Schema Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNamespaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elementFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualifiedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unqualifiedToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addNamespaceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem elementFormDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualifiedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unqualifiedToolStripMenuItem1;
    }
}

