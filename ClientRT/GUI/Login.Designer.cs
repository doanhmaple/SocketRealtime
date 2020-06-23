namespace ClientRT.GUI
{
    partial class Login
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.nameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.passTxt = new DevExpress.XtraEditors.TextEdit();
            this.usNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.titleLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.textIPAddress = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.passTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usNameTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(158, 256);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(105, 35);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(33, 256);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(105, 35);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordLabelControl
            // 
            this.passwordLabelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabelControl.Appearance.Options.UseFont = true;
            this.passwordLabelControl.Location = new System.Drawing.Point(33, 158);
            this.passwordLabelControl.Name = "passwordLabelControl";
            this.passwordLabelControl.Size = new System.Drawing.Size(67, 21);
            this.passwordLabelControl.TabIndex = 17;
            this.passwordLabelControl.Text = "Password";
            // 
            // nameLabelControl
            // 
            this.nameLabelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabelControl.Appearance.Options.UseFont = true;
            this.nameLabelControl.Location = new System.Drawing.Point(33, 88);
            this.nameLabelControl.Name = "nameLabelControl";
            this.nameLabelControl.Size = new System.Drawing.Size(71, 21);
            this.nameLabelControl.TabIndex = 18;
            this.nameLabelControl.Text = "Username";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(33, 185);
            this.passTxt.Name = "passTxt";
            this.passTxt.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.Properties.Appearance.Options.UseFont = true;
            this.passTxt.Properties.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(230, 28);
            this.passTxt.TabIndex = 3;
            this.passTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passTxt_KeyPress);
            // 
            // usNameTxt
            // 
            this.usNameTxt.Location = new System.Drawing.Point(33, 115);
            this.usNameTxt.Name = "usNameTxt";
            this.usNameTxt.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usNameTxt.Properties.Appearance.Options.UseFont = true;
            this.usNameTxt.Size = new System.Drawing.Size(230, 28);
            this.usNameTxt.TabIndex = 2;
            // 
            // titleLabelControl
            // 
            this.titleLabelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.titleLabelControl.Appearance.Options.UseFont = true;
            this.titleLabelControl.Appearance.Options.UseForeColor = true;
            this.titleLabelControl.Location = new System.Drawing.Point(69, 36);
            this.titleLabelControl.Name = "titleLabelControl";
            this.titleLabelControl.Size = new System.Drawing.Size(158, 32);
            this.titleLabelControl.TabIndex = 14;
            this.titleLabelControl.Text = "Realtime Chat";
            // 
            // textIPAddress
            // 
            this.textIPAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIPAddress.Location = new System.Drawing.Point(33, 332);
            this.textIPAddress.Name = "textIPAddress";
            this.textIPAddress.Size = new System.Drawing.Size(230, 29);
            this.textIPAddress.TabIndex = 0;
            this.textIPAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIPAddress_KeyPress);
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.Transparent;
            this.connectBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(96, 367);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(105, 35);
            this.connectBtn.TabIndex = 1;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(33, 305);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 21);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Connect to Server";
            // 
            // Login
            // 
            this.AcceptButton = this.loginBtn;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 420);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.textIPAddress);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordLabelControl);
            this.Controls.Add(this.nameLabelControl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.usNameTxt);
            this.Controls.Add(this.titleLabelControl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usNameTxt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button loginBtn;
        private DevExpress.XtraEditors.LabelControl passwordLabelControl;
        private DevExpress.XtraEditors.LabelControl nameLabelControl;
        private DevExpress.XtraEditors.TextEdit passTxt;
        private DevExpress.XtraEditors.TextEdit usNameTxt;
        private DevExpress.XtraEditors.LabelControl titleLabelControl;
        private System.Windows.Forms.TextBox textIPAddress;
        private System.Windows.Forms.Button connectBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}