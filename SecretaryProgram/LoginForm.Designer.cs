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
            this.tbLogin = new Telerik.WinControls.UI.RadTextBox();
            this.tbPassword = new Telerik.WinControls.UI.RadTextBox();
            this.lLogin = new Telerik.WinControls.UI.RadLabel();
            this.lPassword = new Telerik.WinControls.UI.RadLabel();
            this.bOK = new Telerik.WinControls.UI.RadButton();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.bLoginChecker = new Telerik.WinControls.UI.RadButton();
            this.ilButtons = new System.Windows.Forms.ImageList(this.components);
            this.lLoginChecker = new Telerik.WinControls.UI.RadLabel();
            this.lPassChecker = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLoginChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLoginChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPassChecker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbLogin.Location = new System.Drawing.Point(301, 176);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(165, 27);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.TabStop = false;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPassword.Location = new System.Drawing.Point(301, 212);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(165, 27);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TabStop = false;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // lLogin
            // 
            this.lLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lLogin.Location = new System.Drawing.Point(210, 178);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(58, 25);
            this.lLogin.TabIndex = 4;
            this.lLogin.Text = "Логин:";
            // 
            // lPassword
            // 
            this.lPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lPassword.Location = new System.Drawing.Point(210, 214);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(68, 25);
            this.lPassword.TabIndex = 5;
            this.lPassword.Text = "Пароль:";
            // 
            // bOK
            // 
            this.bOK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bOK.Location = new System.Drawing.Point(268, 310);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(142, 45);
            this.bOK.TabIndex = 6;
            this.bOK.Text = "Войти";
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bLoginChecker
            // 
            this.bLoginChecker.DisplayStyle = Telerik.WinControls.DisplayStyle.Image;
            this.bLoginChecker.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bLoginChecker.ImageIndex = 0;
            this.bLoginChecker.ImageList = this.ilButtons;
            this.bLoginChecker.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.bLoginChecker.Location = new System.Drawing.Point(336, 96);
            this.bLoginChecker.Name = "bLoginChecker";
            this.bLoginChecker.Size = new System.Drawing.Size(33, 32);
            this.bLoginChecker.TabIndex = 7;
            this.bLoginChecker.Click += new System.EventHandler(this.bLoginChecker_Click);
            // 
            // ilButtons
            // 
            this.ilButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilButtons.ImageStream")));
            this.ilButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilButtons.Images.SetKeyName(0, "ok.png");
            this.ilButtons.Images.SetKeyName(1, "delete.png");
            // 
            // lLoginChecker
            // 
            this.lLoginChecker.Image = ((System.Drawing.Image)(resources.GetObject("lLoginChecker.Image")));
            this.lLoginChecker.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lLoginChecker.ImageIndex = 1;
            this.lLoginChecker.ImageList = this.ilButtons;
            this.lLoginChecker.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.lLoginChecker.Location = new System.Drawing.Point(472, 176);
            this.lLoginChecker.Name = "lLoginChecker";
            this.lLoginChecker.Size = new System.Drawing.Size(34, 34);
            this.lLoginChecker.TabIndex = 8;
            // 
            // lPassChecker
            // 
            this.lPassChecker.Image = ((System.Drawing.Image)(resources.GetObject("lPassChecker.Image")));
            this.lPassChecker.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lPassChecker.ImageIndex = 1;
            this.lPassChecker.ImageList = this.ilButtons;
            this.lPassChecker.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.lPassChecker.Location = new System.Drawing.Point(472, 212);
            this.lPassChecker.Name = "lPassChecker";
            this.lPassChecker.Size = new System.Drawing.Size(34, 34);
            this.lPassChecker.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 517);
            this.Controls.Add(this.lPassChecker);
            this.Controls.Add(this.lLoginChecker);
            this.Controls.Add(this.bLoginChecker);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
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
            ((System.ComponentModel.ISupportInitialize)(this.tbLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLoginChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLoginChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPassChecker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox tbLogin;
        private Telerik.WinControls.UI.RadTextBox tbPassword;
        private Telerik.WinControls.UI.RadLabel lLogin;
        private Telerik.WinControls.UI.RadLabel lPassword;
        private Telerik.WinControls.UI.RadButton bOK;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.UI.RadButton bLoginChecker;
        private System.Windows.Forms.ImageList ilButtons;
        private Telerik.WinControls.UI.RadLabel lLoginChecker;
        private Telerik.WinControls.UI.RadLabel lPassChecker;
    }
}
