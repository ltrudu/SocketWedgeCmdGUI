namespace SocketWedgeCmdGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWindowName = new System.Windows.Forms.TextBox();
            this.cbAddReturn = new System.Windows.Forms.CheckBox();
            this.txtCmdTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWedge = new System.Windows.Forms.CheckBox();
            this.lvServers = new System.Windows.Forms.ListView();
            this.Ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Focus Window";
            // 
            // txtWindowName
            // 
            this.txtWindowName.Location = new System.Drawing.Point(94, 48);
            this.txtWindowName.Name = "txtWindowName";
            this.txtWindowName.Size = new System.Drawing.Size(291, 20);
            this.txtWindowName.TabIndex = 2;
            // 
            // cbAddReturn
            // 
            this.cbAddReturn.AutoSize = true;
            this.cbAddReturn.Location = new System.Drawing.Point(16, 81);
            this.cbAddReturn.Name = "cbAddReturn";
            this.cbAddReturn.Size = new System.Drawing.Size(80, 17);
            this.cbAddReturn.TabIndex = 4;
            this.cbAddReturn.Text = "Add Return";
            this.cbAddReturn.UseVisualStyleBackColor = true;
            // 
            // txtCmdTitle
            // 
            this.txtCmdTitle.Location = new System.Drawing.Point(94, 20);
            this.txtCmdTitle.Name = "txtCmdTitle";
            this.txtCmdTitle.Size = new System.Drawing.Size(291, 20);
            this.txtCmdTitle.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cmd Title";
            // 
            // cbWedge
            // 
            this.cbWedge.AutoSize = true;
            this.cbWedge.Location = new System.Drawing.Point(103, 81);
            this.cbWedge.Name = "cbWedge";
            this.cbWedge.Size = new System.Drawing.Size(61, 17);
            this.cbWedge.TabIndex = 7;
            this.cbWedge.Text = "Wedge";
            this.cbWedge.UseVisualStyleBackColor = true;
            // 
            // lvServers
            // 
            this.lvServers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ip,
            this.Port});
            this.lvServers.HideSelection = false;
            this.lvServers.Location = new System.Drawing.Point(16, 105);
            this.lvServers.Name = "lvServers";
            this.lvServers.Size = new System.Drawing.Size(374, 192);
            this.lvServers.TabIndex = 8;
            this.lvServers.UseCompatibleStateImageBehavior = false;
            // 
            // Ip
            // 
            this.Ip.Text = "Ip";
            this.Ip.Width = 150;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.Width = 150;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(137, 303);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(109, 23);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Delete Server";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(16, 303);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(115, 23);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Add Server";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 334);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lvServers);
            this.Controls.Add(this.cbWedge);
            this.Controls.Add(this.txtCmdTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAddReturn);
            this.Controls.Add(this.txtWindowName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Socket Wedge CMD Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWindowName;
        private System.Windows.Forms.CheckBox cbAddReturn;
        private System.Windows.Forms.TextBox txtCmdTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbWedge;
        private System.Windows.Forms.ListView lvServers;
        private System.Windows.Forms.ColumnHeader Ip;
        private System.Windows.Forms.ColumnHeader Port;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
    }
}

