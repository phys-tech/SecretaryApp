using System;
using System.IO;
using System.Text;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.RichTextBox;
using System.Globalization;
using System.Threading;

namespace SecretaryApp
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        MailBox Mail = new MailBox();
        LoginForm parentForm;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(LoginForm _parentForm)
        {
            parentForm = _parentForm;            
            InitializeComponent();
            this.Text = "Промнефть " + parentForm.CurrentMode.DutyPosition;
            lUserPhoto.Text = parentForm.CurrentMode.DutyPosition;
            lUserPhoto.ImageKey = parentForm.CurrentMode.DutyPosition + ".jpg";
            panelPhotos.Text = parentForm.CurrentMode.GalleryCaption;

            SetUpLocalization();
            FillContactsData();
            FillMailData();
            CreateSlideViewerRotator();
            AddTextToDocs();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            pageViewMain.SelectedPage = pageMail;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Shift && e.KeyCode == Keys.M)
            {                
                parentForm.HiddenCloseActivated = true;
                this.Close();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!parentForm.HiddenCloseActivated)
                e.Cancel = true;
            else
                parentForm.Close();
            //Application.Exit();   // <- this shit also works
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:             //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;

                case WM_NCLBUTTONDBLCLK:       //preventing the form being resized by the mouse double click on the title bar.
                    m.Result = IntPtr.Zero;
                    return;
            }

            base.WndProc(ref m);
        }

        private void CreateSlideViewerRotator()
        {
            string myPicturesPath = ".";
            foreach (string fileName in Directory.GetFiles(myPicturesPath, "*.jpg"))
            {
                rotatorPhotos.Items.Add(GetThumbNail(fileName));
            }
            rotatorPhotos.Goto(0);
            //rotatorPhotos.Start(true);
            //rotatorPhotos.ShouldStopOnMouseOver = false;
        }

        private RadImageItem GetThumbNail(string path)
        {
            RadImageItem imageItem = new RadImageItem();
            Image image = Image.FromFile(path);
            // workaround to prevent using internal image thumbnail
            //image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            //image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            // calculate aspect ratio so image is not distorted
            /*
            double ratio = 0;
            if (image.Width < image.Height)
            {
                ratio = (double)rotatorPhotos.Width / (double)image.Width;
            }
            else
            {
                ratio = (double)rotatorPhotos.Height / (double)image.Height;
            }
            int newWidth = (int)((double)image.Width * ratio);
            int newHeight = (int)((double)image.Height * ratio);
            imageItem.Image = image.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
             */
            imageItem.Image = image;
            //imageItem.Alignment = ContentAlignment.MiddleCenter;  // doesn't work
            ((Telerik.WinControls.Primitives.ImagePrimitive)(imageItem.GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            return imageItem;
        }

        private void bNextPhoto_Click(object sender, EventArgs e)
        {
            rotatorPhotos.Next();
        }

        private void bPrevPhoto_Click(object sender, EventArgs e)
        {
            rotatorPhotos.Previous();
        }

        private void FillContactsData()
        {
            String name = "Sheet2";
            String ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            "WorkersList.xlsx" +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

            OleDbConnection Connection = new OleDbConnection(ConnectionString);
            OleDbCommand DbCommand = new OleDbCommand("Select * From [" + name + "$]", Connection);
            Connection.Open();

            OleDbDataAdapter OleDataAdapter = new OleDbDataAdapter(DbCommand);
            DataTable data = new DataTable();
            OleDataAdapter.Fill(data);

            CultureInfo standardizedCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            standardizedCulture.DateTimeFormat.DateSeparator = ".";
            standardizedCulture.DateTimeFormat.LongDatePattern = "dd MMMM yyyy";
            standardizedCulture.DateTimeFormat.FullDateTimePattern = "dd.MM.yyyy";
            standardizedCulture.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
            standardizedCulture.DateTimeFormat.LongTimePattern = "";
            Thread.CurrentThread.CurrentCulture = standardizedCulture;
            Thread.CurrentThread.CurrentUICulture = standardizedCulture;

            gridViewContacts.DataSource = data;
            try
            {
                gridViewContacts.Columns["П/п"].Width = 30;
                gridViewContacts.Columns["Фамилия"].Width = 80;
                gridViewContacts.Columns["Имя"].Width = 80;
                gridViewContacts.Columns["Отчество"].Width = 80;
                gridViewContacts.Columns["Должность"].Width = 230;
                gridViewContacts.Columns["Дата рождения"].Width = 40;
                gridViewContacts.Columns["Уровень доступа"].Width = 40;
                gridViewContacts.Columns["Название отдела"].Width = 100;
                gridViewContacts.Columns["Дата рождения"].TextAlignment = ContentAlignment.MiddleCenter;
                gridViewContacts.Columns["Уровень доступа"].TextAlignment = ContentAlignment.MiddleCenter;
            }
            catch(Exception e)
            {
            }
        }

        private void FillMailData()
        {
            List<string> FolderNames = new List<string> { "Входящие", "Исходящие", "Черновики", "Спам", "Корзина" };
            foreach (string folder in FolderNames)
            {
                Mail.AddFolderToMailBox(folder);
                foreach (Letter letter in Mail.Folders[folder].LetterList.ToArray())
                    tvMailbox.Nodes[folder].Nodes.Add(letter.NameAndDate());                
            }
        }
        
        private void SetUpLocalization()
        {
            RadPageViewLocalizationProvider.CurrentProvider = new RussianPageViewLocalization();
            RadGridLocalizationProvider.CurrentProvider = new RussianGridViewLocalization();
        }

        private void tvMailbox_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Text.ToString(), "Selected TEXT");     // text of the selected node
            //string level = e.Node.Level.ToString();     // level of the node, like root = 0 (inbox-outbox), real letters - 1 and so on
            if (e.TreeView.HasChildren)
                return;

            Telerik.WinControls.RichTextBox.Model.Styles.StyleDefinition style = new Telerik.WinControls.RichTextBox.Model.Styles.StyleDefinition();            

            if (e.Node.Level == 1)
            {
                string folder = e.Node.Parent.Text.ToString(); // text of the parent
                int index = e.Node.Index;       // index of the letter, like fifth in the parent node
                ClearMailContentsBox();
                tbSender.Text = Mail.Folders[folder].LetterList[index].Sender;
                tbTheme.Text = Mail.Folders[folder].LetterList[index].Theme;
                tbDate.Text = Mail.Folders[folder].LetterList[index].Date.ToLongDateString();
                rtbMailContent.Document.Insert(Mail.Folders[folder].LetterList[index].Text, style);
                lSender.Text = (new List<string>(){"Исходящие", "Черновики"}.Contains(folder) ) ? ("Кому:") : ("От кого:");
            }
        }

        private void ClearMailContentsBox()
        {
            DocumentPosition start = rtbMailContent.Document.CaretPosition;
            start.MoveToFirstPositionInDocument();
            DocumentPosition end = new DocumentPosition(start);
            end.MoveToLastPositionInDocument();
            rtbMailContent.Document.DeleteRange(start, end);
        }

        private void AddTextToDocs()
        {
            Telerik.WinControls.RichTextBox.Model.Styles.StyleDefinition style = new Telerik.WinControls.RichTextBox.Model.Styles.StyleDefinition();

            rtbDocs.ToggleItalic();
            rtbDocs.ToggleBold();
            
            string title = "Инструкция по составлению личного кода сотрудника «ПромНефть» в головном офисе компании \r\n\r\n";
            rtbDocs.Document.Insert(title, style);
            
            string docText = "Личный код сотрудника отображает три параметра, которые влияют на возможность доступа к определенной информации, а также зданиям и помещениям корпорации. Кроме того,  он отображает расположение постоянного рабочего места сотрудника, где он находится максимальное время, исключая сотрудников с разъездным характером работы, или работникам, выполняющим свои трудовые обязанности удаленно. ";
            docText += "Маска личного кода: \r\n";
            docText += "X – YY – ZZ \r\n";
            docText += "где: \r\n";
            docText += "X – уровень доступа сотрудника к информации \r\n";
            docText += "YY – год рождения сотрудника \r\n";
            docText += "ZZ – этаж, где находится постоянное рабочее место сотрудника \r\n";

            rtbDocs.Document.Insert(docText , style);
        }

        /*
Инструкция по составлению личного кода сотрудника «ПромНефть» в головном офисе компании 
 
Личный код сотрудника отображает три параметра, которые влияют на возможность доступа к определенной информации, а также зданиям и помещениям корпорации. Кроме того,  он отображает расположение постоянного рабочего места сотрудника, где он находится максимальное время, исключая сотрудников с разъездным характером работы, или работникам, выполняющим свои трудовые обязанности удаленно. 
Маска личного кода: 
X – YY – ZZ 
где: 
 
X – уровень доступа сотрудника к информации 
YY – год рождения сотрудника 
ZZ – этаж, где находится постоянное рабочее место сотрудника
         */

    }

    }
