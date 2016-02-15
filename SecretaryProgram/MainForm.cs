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

namespace SecretaryProgram
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        MailBox Mail = new MailBox();

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            //ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark";
            ThemeResolutionService.ApplicationThemeName = "Office2010Black";
            //ThemeResolutionService.ApplicationThemeName = "HighContrastBlack";

            SetUpLocalization();
            FillContactsData();
            FillMailData();
            CreateSlideViewerRotator_Load(sender, e);

            AddTextToDocs();
        }

        private void CreateSlideViewerRotator_Load(object sender, EventArgs e)
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
            image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipNone);
            // calculate aspect ratio so image is not distorted
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
            imageItem.Alignment = ContentAlignment.MiddleCenter;
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
            //data.Columns["Дата рождения"].Cells

            CultureInfo standardizedCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            standardizedCulture.DateTimeFormat.DateSeparator = ".";
            standardizedCulture.DateTimeFormat.LongDatePattern = "dd MMMM yyyy";
            standardizedCulture.DateTimeFormat.FullDateTimePattern = "dd.MM.yyyy";
            standardizedCulture.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
            standardizedCulture.DateTimeFormat.LongTimePattern = "";
            Thread.CurrentThread.CurrentCulture = standardizedCulture;
            Thread.CurrentThread.CurrentUICulture = standardizedCulture;
            //data.Locale = standardizedCulture;

            gridViewContacts.DataSource = data;
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
            String docText = "Инструкции. \r\nЗдесь будут располагаться интрукции, описывающие, как составляется табельный номер,  ";
            docText += "\r\nгде искать нужную информацию и вообще любые вещи, которые нам понадобятся.";
            rtbDocs.Document.Insert(docText , style);
            //rtbDocs.Document.InsertLineBreak();
            //rtbDocs.Document.Insert(docText, style);
        }

    }

    }
