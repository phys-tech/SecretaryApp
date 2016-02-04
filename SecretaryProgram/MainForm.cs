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

            FillContactsData();
            FillMailData();
            TutorialCreatingASlideViewerWithRadRotator_Load(sender, e);
            SetUpLocalization();
            AddTextToDocs();
        }

        private void TutorialCreatingASlideViewerWithRadRotator_Load(object sender, EventArgs e)
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
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            "WorkersList.xlsx" +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            gridViewContacts.DataSource = data;
            gridViewContacts.Update();
            gridViewContacts.Refresh();
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
