using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Telerik.WinControls;

namespace SecretaryApp
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm
    {
        public class LoginPass
        {
            private string Login;
            private string Pass1;
            private string Pass2;
            private string Hint;
            public string MainFormCaption;

            public LoginPass(string login, string pass1, string pass2, string caption, string hint)
            {
                Login = login;
                Pass1 = pass1;
                Pass2 = pass2;
                MainFormCaption = caption;
                Hint = hint;
            }

            public bool CheckLogin(string TypedLogin)
            {
                string caseLessLogin = TypedLogin.ToLowerInvariant();
                return (Login == caseLessLogin);
            }

            public bool CheckPassword(string TypedPassword)
            {
                if (TypedPassword == Pass1 || TypedPassword == Pass2)
                    return true;
                else 
                    return false;
            }
            public string GetHint()
            {
                return Hint;
            }
        }

        private LoginPass Secretary;
        private LoginPass Director;
        private LoginPass SpeedyPatch;
        public LoginPass CurrentMode;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void FillLoginPassData()
        {
            Secretary = new LoginPass("nina.kupriyanova", "1992", "540372", "Промнефть Секретарь", "Год основания компании");
            Director = new LoginPass("prokhor.benzinovsky", "Ley.925", "849163", "Промнефть Директор", "Любимый алкогольный напиток");
            SpeedyPatch = new LoginPass("1", "1", "2", "ТЕстовый сцуко прогон", "Пароль - 1 или 2");
        }

        private void SetCurrentMode()
        {
            if (File.Exists("Coolman.txt"))
                CurrentMode = Director;
            else if (File.Exists("SuperPatcher.txt"))
                CurrentMode = SpeedyPatch;
            else
                CurrentMode = Secretary;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark";
            ThemeResolutionService.ApplicationThemeName = "Office2010Black";
            //ThemeResolutionService.ApplicationThemeName = "HighContrastBlack";

            FillLoginPassData();
            SetCurrentMode();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            if (CurrentMode.CheckLogin(tbLogin.Text))
                lLoginChecker.ImageIndex = 0;
            else
                lLoginChecker.ImageIndex = 1;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (CurrentMode.CheckPassword(tbPassword.Text))
                lPassChecker.ImageIndex = 0;
            else
                lPassChecker.ImageIndex = 1;
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            string inLogin = tbLogin.Text;
            string inPassword = tbPassword.Text;
            if ( CurrentMode.CheckLogin(inLogin) && CurrentMode.CheckPassword(inPassword) )
            {
                MainForm main = new MainForm(this);
                this.Hide();
                main.Show();
            }
        }

        private void lForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TooltipPassword.Show(CurrentMode.GetHint(), lForgotPassword, 30, 20, 1000);
            TooltipPassword.Show(CurrentMode.GetHint(), lForgotPassword, 30, 20, 1000);
        }

    }
}
