using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace SecretaryApp
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm
    {
        struct LoginPass
        {
            public string Login;
            public string Pass1;
            public string Pass2;
        }

        LoginPass Secretary;
        LoginPass Director;
        LoginPass CurrentMode;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void FillLoginPassData()
        {
            Secretary.Login = "Nina.Kupriyanova";
            Secretary.Pass1 = "1992";
            Secretary.Pass2 = "540372";
            Director.Login = "Prohor.Benzinovsky";
            Director.Pass1 = "LEY925";
            Director.Pass2 = "849163";
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            string inLogin = tbLogin.Text;
            string inPassword = tbPassword.Text;
            if (inLogin == CurrentMode.Login &&
                (inPassword == CurrentMode.Pass1 || inPassword == CurrentMode.Pass2))
            {
                MainForm main = new MainForm();
                this.Hide();
                main.Show();                
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark";
            ThemeResolutionService.ApplicationThemeName = "Office2010Black";
            //ThemeResolutionService.ApplicationThemeName = "HighContrastBlack";

            FillLoginPassData();
            CurrentMode = Secretary;
        }

        private void bLoginChecker_Click(object sender, EventArgs e)
        {
            bLoginChecker.ImageIndex++;
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            if (tbLogin.Text == CurrentMode.Login)
                lLoginChecker.ImageIndex = 0;
            else
                lLoginChecker.ImageIndex = 1;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text == CurrentMode.Pass1 || tbPassword.Text == CurrentMode.Pass2)
                lPassChecker.ImageIndex = 0;
            else
                lPassChecker.ImageIndex = 1;
        }
    }
}
