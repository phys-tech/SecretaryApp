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
            public string DutyPosition;
            public string GalleryCaption;

            public LoginPass(string login, string pass1, string pass2, string caption, string hint, string gallery)
            {
                Login = login;
                Pass1 = pass1;
                Pass2 = pass2;
                DutyPosition = caption;
                Hint = hint;
                GalleryCaption = gallery;
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
        public bool HiddenCloseActivated;
        MainForm mainForm;

        public LoginForm()
        {
            InitializeComponent();
            HiddenCloseActivated = false;            
        }

        private void FillLoginPassData()
        {
            Secretary = new LoginPass("nina.kupriyanova", "1992", "540372", "Секретарь", "Год основания компании", "Фотографии офисов ЗАО \"ПромНефть Россия\"");
            Director = new LoginPass("prokhor.benzinovsky", "Ley.925", "849163", "Директор", "Любимый алкогольный напиток", "Бизнес-аналитика, отчеты");
            SpeedyPatch = new LoginPass("1", "1", "2", "Тeстовик ", "Пароль - 1 или 2", "Много разных фоток");
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
            backgroundWorker.RunWorkerAsync();
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
                this.Hide();
                mainForm.Show();
            }
        }

        private void lForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TooltipPassword.Show(CurrentMode.GetHint(), lForgotPassword, 30, 20, 1000);
            TooltipPassword.Show(CurrentMode.GetHint(), lForgotPassword, 30, 20, 1000);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!HiddenCloseActivated)
                e.Cancel = true;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Shift && e.KeyCode == Keys.M)
            {
                HiddenCloseActivated = true;
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
                bOK_Click(sender, e);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            mainForm = new MainForm(this);
        }

    }
}
