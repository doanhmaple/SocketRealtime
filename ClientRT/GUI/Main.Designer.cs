namespace ClientRT.GUI
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
            this.onlNoti = new DevExpress.XtraEditors.LabelControl();
            this.sendBtn = new System.Windows.Forms.Button();
            this.userLabel = new DevExpress.XtraEditors.LabelControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientRTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messTxt = new System.Windows.Forms.TextBox();
            this.viewUser = new System.Windows.Forms.ListView();
            this.lbSendto = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // onlNoti
            // 
            this.onlNoti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onlNoti.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlNoti.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.onlNoti.Appearance.Options.UseFont = true;
            this.onlNoti.Appearance.Options.UseForeColor = true;
            this.onlNoti.Location = new System.Drawing.Point(21, 35);
            this.onlNoti.Name = "onlNoti";
            this.onlNoti.Size = new System.Drawing.Size(0, 21);
            this.onlNoti.TabIndex = 22;
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendBtn.BackColor = System.Drawing.Color.Transparent;
            this.sendBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(616, 422);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(88, 30);
            this.sendBtn.TabIndex = 21;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // userLabel
            // 
            this.userLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.userLabel.Appearance.Options.UseFont = true;
            this.userLabel.Appearance.Options.UseForeColor = true;
            this.userLabel.Location = new System.Drawing.Point(20, 35);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(30, 21);
            this.userLabel.TabIndex = 20;
            this.userLabel.Text = "-----";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientRTToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // clientRTToolStripMenuItem
            // 
            this.clientRTToolStripMenuItem.Name = "clientRTToolStripMenuItem";
            this.clientRTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientRTToolStripMenuItem.Text = "ClientRT";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // messTxt
            // 
            this.messTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messTxt.Location = new System.Drawing.Point(210, 424);
            this.messTxt.Name = "messTxt";
            this.messTxt.Size = new System.Drawing.Size(400, 27);
            this.messTxt.TabIndex = 24;
            // 
            // viewUser
            // 
            this.viewUser.HideSelection = false;
            this.viewUser.Location = new System.Drawing.Point(12, 63);
            this.viewUser.Name = "viewUser";
            this.viewUser.Size = new System.Drawing.Size(180, 393);
            this.viewUser.TabIndex = 25;
            this.viewUser.UseCompatibleStateImageBehavior = false;
            this.viewUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listUser_MouseClick);
            // 
            // lbSendto
            // 
            this.lbSendto.AutoSize = true;
            this.lbSendto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSendto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.lbSendto.Location = new System.Drawing.Point(210, 35);
            this.lbSendto.Name = "lbSendto";
            this.lbSendto.Size = new System.Drawing.Size(0, 21);
            this.lbSendto.TabIndex = 27;
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(207, 63);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(497, 354);
            this.listView.TabIndex = 28;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // Main
            // 
            this.AcceptButton = this.sendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 468);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lbSendto);
            this.Controls.Add(this.viewUser);
            this.Controls.Add(this.messTxt);
            this.Controls.Add(this.onlNoti);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl onlNoti;
        private System.Windows.Forms.Button sendBtn;
        private DevExpress.XtraEditors.LabelControl userLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientRTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox messTxt;
        private System.Windows.Forms.ListView viewUser;
        private System.Windows.Forms.Label lbSendto;
        private System.Windows.Forms.ListView listView;
    }
}