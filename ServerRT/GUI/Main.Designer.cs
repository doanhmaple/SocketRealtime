namespace ServerRT.GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.sendBtn = new System.Windows.Forms.Button();
            this.usOnl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverRTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientView = new System.Windows.Forms.ListView();
            this.lbSend = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.messTxt = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Transparent;
            this.sendBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendBtn.Location = new System.Drawing.Point(547, 351);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(79, 27);
            this.sendBtn.TabIndex = 22;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // usOnl
            // 
            this.usOnl.AutoSize = true;
            this.usOnl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.usOnl.ForeColor = System.Drawing.Color.Green;
            this.usOnl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.usOnl.Location = new System.Drawing.Point(60, 30);
            this.usOnl.Name = "usOnl";
            this.usOnl.Size = new System.Drawing.Size(132, 21);
            this.usOnl.TabIndex = 19;
            this.usOnl.Text = "Clients online: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverRTToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // serverRTToolStripMenuItem
            // 
            this.serverRTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserItem});
            this.serverRTToolStripMenuItem.Name = "serverRTToolStripMenuItem";
            this.serverRTToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.serverRTToolStripMenuItem.Text = "Server RT";
            // 
            // addUserItem
            // 
            this.addUserItem.Name = "addUserItem";
            this.addUserItem.Size = new System.Drawing.Size(122, 22);
            this.addUserItem.Text = "Add User";
            this.addUserItem.Click += new System.EventHandler(this.addUserItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // clientView
            // 
            this.clientView.HideSelection = false;
            this.clientView.Location = new System.Drawing.Point(12, 54);
            this.clientView.Name = "clientView";
            this.clientView.Size = new System.Drawing.Size(224, 326);
            this.clientView.TabIndex = 24;
            this.clientView.UseCompatibleStateImageBehavior = false;
            this.clientView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientView_MouseClick);
            // 
            // lbSend
            // 
            this.lbSend.AutoSize = true;
            this.lbSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSend.ForeColor = System.Drawing.Color.Green;
            this.lbSend.Location = new System.Drawing.Point(245, 30);
            this.lbSend.Name = "lbSend";
            this.lbSend.Size = new System.Drawing.Size(0, 21);
            this.lbSend.TabIndex = 26;
            // 
            // messTxt
            // 
            this.messTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messTxt.Location = new System.Drawing.Point(242, 351);
            this.messTxt.Name = "messTxt";
            this.messTxt.Size = new System.Drawing.Size(300, 27);
            this.messTxt.TabIndex = 27;
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(242, 55);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(385, 292);
            this.listView.TabIndex = 29;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // Main
            // 
            this.AcceptButton = this.sendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 392);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.messTxt);
            this.Controls.Add(this.lbSend);
            this.Controls.Add(this.clientView);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.usOnl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label usOnl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverRTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ListView clientView;
        private System.Windows.Forms.Label lbSend;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox messTxt;
        private System.Windows.Forms.ListView listView;
    }
}