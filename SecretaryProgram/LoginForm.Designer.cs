namespace SecretaryApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.ilButtons = new System.Windows.Forms.ImageList(this.components);
            this.pLoginWindowWhole = new System.Windows.Forms.Panel();
            this.lPassChecker = new Telerik.WinControls.UI.RadLabel();
            this.bOK = new Telerik.WinControls.UI.RadButton();
            this.lLoginChecker = new Telerik.WinControls.UI.RadLabel();
            this.lPassword = new Telerik.WinControls.UI.RadLabel();
            this.lLogin = new Telerik.WinControls.UI.RadLabel();
            this.tbPassword = new Telerik.WinControls.UI.RadTextBox();
            this.tbLogin = new Telerik.WinControls.UI.RadTextBox();
            this.pLoginWindowWhole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lPassChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLoginChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ilButtons
            // 
            this.ilButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilButtons.ImageStream")));
            this.ilButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilButtons.Images.SetKeyName(0, "ok.png");
            this.ilButtons.Images.SetKeyName(1, "delete.png");
            // 
            // pLoginWindowWhole
            // 
            this.pLoginWindowWhole.Controls.Add(this.lPassChecker);
            this.pLoginWindowWhole.Controls.Add(this.bOK);
            this.pLoginWindowWhole.Controls.Add(this.lLoginChecker);
            this.pLoginWindowWhole.Controls.Add(this.lPassword);
            this.pLoginWindowWhole.Controls.Add(this.lLogin);
            this.pLoginWindowWhole.Controls.Add(this.tbPassword);
            this.pLoginWindowWhole.Controls.Add(this.tbLogin);
            this.pLoginWindowWhole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoginWindowWhole.Location = new System.Drawing.Point(0, 0);
            this.pLoginWindowWhole.Name = "pLoginWindowWhole";
            this.pLoginWindowWhole.Size = new System.Drawing.Size(792, 570);
            this.pLoginWindowWhole.TabIndex = 10;
            // 
            // lPassChecker
            // 
            this.lPassChecker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPassChecker.Image = ((System.Drawing.Image)(resources.GetObject("lPassChecker.Image")));
            this.lPassChecker.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lPassChecker.ImageIndex = 1;
            this.lPassChecker.ImageList = this.ilButtons;
            this.lPassChecker.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.lPassChecker.Location = new System.Drawing.Point(517, 192);
            this.lPassChecker.Name = "lPassChecker";
            this.lPassChecker.Size = new System.Drawing.Size(34, 34);
            this.lPassChecker.TabIndex = 11;
            // 
            // bOK
            // 
            this.bOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bOK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bOK.Location = new System.Drawing.Point(300, 288);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(200, 60);
            this.bOK.TabIndex = 12;
            this.bOK.Text = "Войти";
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // lLoginChecker
            // 
            this.lLoginChecker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLoginChecker.Image = ((System.Drawing.Image)(resources.GetObject("lLoginChecker.Image")));
            this.lLoginChecker.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lLoginChecker.ImageIndex = 1;
            this.lLoginChecker.ImageList = this.ilButtons;
            this.lLoginChecker.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.lLoginChecker.Location = new System.Drawing.Point(517, 147);
            this.lLoginChecker.Name = "lLoginChecker";
            this.lLoginChecker.Size = new System.Drawing.Size(34, 34);
            this.lLoginChecker.TabIndex = 10;
            // 
            // lPassword
            // 
            this.lPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lPassword.Location = new System.Drawing.Point(217, 194);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(68, 25);
            this.lPassword.TabIndex = 9;
            this.lPassword.Text = "Пароль:";
            // 
            // lLogin
            // 
            this.lLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lLogin.Location = new System.Drawing.Point(217, 156);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(58, 25);
            this.lLogin.TabIndex = 8;
            this.lLogin.Text = "Логин:";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPassword.Location = new System.Drawing.Point(300, 192);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(200, 27);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.TabStop = false;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbLogin.Location = new System.Drawing.Point(300, 154);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(200, 27);
            this.tbLogin.TabIndex = 6;
            this.tbLogin.TabStop = false;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.ControlBox = false;
            this.Controls.Add(this.pLoginWindowWhole);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ввод логина";
            this.ThemeName = "ControlDefault";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pLoginWindowWhole.ResumeLayout(false);
            this.pLoginWindowWhole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lPassChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLoginChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private System.Windows.Forms.ImageList ilButtons;
        private System.Windows.Forms.Panel pLoginWindowWhole;
        private Telerik.WinControls.UI.RadLabel lPassword;
        private Telerik.WinControls.UI.RadLabel lLogin;
        private Telerik.WinControls.UI.RadTextBox tbPassword;
        private Telerik.WinControls.UI.RadTextBox tbLogin;
        private Telerik.WinControls.UI.RadButton bOK;
        private Telerik.WinControls.UI.RadLabel lPassChecker;
        private Telerik.WinControls.UI.RadLabel lLoginChecker;
    }
}
