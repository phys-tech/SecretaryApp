﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;
using Telerik.WinControls.RichTextBox;


namespace SecretaryProgram
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        DataTable dtMailData = new DataTable();
        MailFolder InboxMail = new MailFolder();

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            //ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark";
            ThemeResolutionService.ApplicationThemeName = "Office2010Black";
            //ThemeResolutionService.ApplicationThemeName = "HighContrastBlack";

            /*object[] row = { "1", "Иван", "Залупин", "Урюпинск", "Ведущий аналитик", "+79234234" };
            gridViewContacts.Rows.Add(row);
            object[] row1 = { "2", "Петер", "Шмейхель", "Хайфа", "Ведущий аналитик", "+8653249345" };
            gridViewContacts.Rows.Add(row1);
            object[] row2 = { "3", "Джек", "Шеппард", "Лос-Анджелес", "Ведущий аналитик", "+1986755635" };
            gridViewContacts.Rows.Add(row2);
            object[] row3 = { "4", "Анна", "Шаповалова", "Москва", "Ведущий аналитик", "+7942342422" };
            gridViewContacts.Rows.Add(row3);
            object[] row4 = { "5", "Мустафа", "Ибрагим иба Ашаб Кхан", "Дели", "Ведущий аналитик", "+7942342422" };
            gridViewContacts.Rows.Add(row4);
            object[] row5 = { "6", "John", "Smith", "Winchester", "Ведущий аналитик", "+443459342422" };
            gridViewContacts.Rows.Add(row5);
            object[] row6 = { "7", "Nicolas", "Sarcozy", "Paris", "Ведущий аналитик", "+2345366452" };
            gridViewContacts.Rows.Add(row6);
            object[] row7 = { "8", "Adolf", "Schiklgruber", "Nurnberg", "Ведущий аналитик", "+545111232234" };
            gridViewContacts.Rows.Add(row7);
            gridViewContacts.Update();
            gridViewContacts.Refresh();*/
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
                            "WorkerksList.xlsx" +
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
            String name = "Входящие";
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            "MailList.xlsx" +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";
            
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + name + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);

            sda.Fill(dtMailData);
            foreach (DataRow row in dtMailData.Rows)
            {
                //MessageBox.Show(row[1].ToString(), "MyData");
                InboxMail.LetterList.Add(new Letter(row[0].ToString(), (DateTime) row[1], row[2].ToString(), row[3].ToString()));
            }
        }
        
        private void SetUpLocalization()
        {
            RadPageViewLocalizationProvider.CurrentProvider = new RussianPageViewLocalization();
            RadGridLocalizationProvider.CurrentProvider = new RussianGridViewLocalization();
        }

        private void tvMailbox_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {
            if (e.TreeView.HasChildren)
                return;

            Telerik.WinControls.RichTextBox.Model.Styles.StyleDefinition style = new Telerik.WinControls.RichTextBox.Model.Styles.StyleDefinition();

            //MessageBox.Show(e.Node.Text.ToString(), "Selected TEXT");     // text of the selected node
            //string par = e.Node.Parent.Text.ToString(); // text of the parent
            string level = e.Node.Level.ToString();     // level of the node, like root = 0 (inbox-outbox), real letters - 1 and so on
            if (e.Node.Level == 1)
            {
                int index = e.Node.Index;       // index of the letter, like fifth in the parent node
                ClearMailContentsBox();
                tbSender.Text = InboxMail.LetterList[index].Sender;
                tbTheme.Text = InboxMail.LetterList[index].Theme;
                tbDate.Text = InboxMail.LetterList[index].Date.ToShortDateString();
                rtbMailContent.Document.Insert(InboxMail.LetterList[index].Text, style);
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
