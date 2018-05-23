namespace Client
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.loginCode = new MetroFramework.Controls.MetroTextBox();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.login_btn = new MetroFramework.Controls.MetroButton();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.txtIp = new MetroFramework.Controls.MetroTextBox();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(115, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Login Code";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(117, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Password";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // loginCode
            // 
            // 
            // 
            // 
            this.loginCode.CustomButton.Image = null;
            this.loginCode.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.loginCode.CustomButton.Name = "";
            this.loginCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.loginCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginCode.CustomButton.TabIndex = 1;
            this.loginCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginCode.CustomButton.UseSelectable = true;
            this.loginCode.CustomButton.Visible = false;
            this.loginCode.Lines = new string[0];
            this.loginCode.Location = new System.Drawing.Point(93, 72);
            this.loginCode.MaxLength = 32767;
            this.loginCode.Name = "loginCode";
            this.loginCode.PasswordChar = '\0';
            this.loginCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginCode.SelectedText = "";
            this.loginCode.SelectionLength = 0;
            this.loginCode.SelectionStart = 0;
            this.loginCode.ShortcutsEnabled = true;
            this.loginCode.Size = new System.Drawing.Size(114, 23);
            this.loginCode.TabIndex = 1;
            this.loginCode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginCode.UseSelectable = true;
            this.loginCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[0];
            this.password.Location = new System.Drawing.Point(91, 128);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(114, 23);
            this.password.TabIndex = 2;
            this.password.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.password.UseSelectable = true;
            this.password.UseSystemPasswordChar = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // login_btn
            // 
            this.login_btn.Enabled = false;
            this.login_btn.Location = new System.Drawing.Point(91, 200);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(114, 23);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "Login";
            this.login_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.login_btn.UseSelectable = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(211, 301);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtIp
            // 
            // 
            // 
            // 
            this.txtIp.CustomButton.Image = null;
            this.txtIp.CustomButton.Location = new System.Drawing.Point(65, 1);
            this.txtIp.CustomButton.Name = "";
            this.txtIp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIp.CustomButton.TabIndex = 1;
            this.txtIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIp.CustomButton.UseSelectable = true;
            this.txtIp.CustomButton.Visible = false;
            this.txtIp.Lines = new string[] {
        "192.168.1.147"};
            this.txtIp.Location = new System.Drawing.Point(13, 301);
            this.txtIp.MaxLength = 32767;
            this.txtIp.Name = "txtIp";
            this.txtIp.PasswordChar = '\0';
            this.txtIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIp.SelectedText = "";
            this.txtIp.SelectionLength = 0;
            this.txtIp.SelectionStart = 0;
            this.txtIp.ShortcutsEnabled = true;
            this.txtIp.Size = new System.Drawing.Size(87, 23);
            this.txtIp.TabIndex = 4;
            this.txtIp.Text = "192.168.1.147";
            this.txtIp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtIp.UseSelectable = true;
            this.txtIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPort
            // 
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.Lines = new string[] {
        "8910"};
            this.txtPort.Location = new System.Drawing.Point(112, 301);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(75, 23);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "8910";
            this.txtPort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(112, 279);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 19);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Port";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 279);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(35, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Host";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 332);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.loginCode);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Login";
            this.Resizable = false;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox loginCode;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroButton login_btn;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroTextBox txtIp;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}