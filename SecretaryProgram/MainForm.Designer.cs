namespace SecretaryProgram
{
    partial class MainForm
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
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode4 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode5 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode6 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode7 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode8 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode9 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode10 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode11 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode12 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode13 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode14 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode15 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode16 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode17 = new Telerik.WinControls.UI.RadTreeNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.pageViewMain = new Telerik.WinControls.UI.RadPageView();
            this.pageMail = new Telerik.WinControls.UI.RadPageViewPage();
            this.tvMailbox = new Telerik.WinControls.UI.RadTreeView();
            this.pageGallery = new Telerik.WinControls.UI.RadPageViewPage();
            this.rotatorPhotos = new Telerik.WinControls.UI.RadRotator();
            this.bPrevButton = new Telerik.WinControls.UI.RadButton();
            this.bNextButton = new Telerik.WinControls.UI.RadButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pageContacts = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridViewContacts = new Telerik.WinControls.UI.RadGridView();
            this.pageDocs = new Telerik.WinControls.UI.RadPageViewPage();
            this.panelLogo = new Telerik.WinControls.UI.RadPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.highContrastBlackTheme1 = new Telerik.WinControls.Themes.HighContrastBlackTheme();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.rtbMailContent = new Telerik.WinControls.RichTextBox.RadRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).BeginInit();
            this.pageViewMain.SuspendLayout();
            this.pageMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tvMailbox)).BeginInit();
            this.pageGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotatorPhotos)).BeginInit();
            this.rotatorPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bPrevButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNextButton)).BeginInit();
            this.pageContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbMailContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pageViewMain
            // 
            this.pageViewMain.Controls.Add(this.pageMail);
            this.pageViewMain.Controls.Add(this.pageGallery);
            this.pageViewMain.Controls.Add(this.pageContacts);
            this.pageViewMain.Controls.Add(this.pageDocs);
            this.pageViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageViewMain.Location = new System.Drawing.Point(0, 104);
            this.pageViewMain.Name = "pageViewMain";
            this.pageViewMain.SelectedPage = this.pageMail;
            this.pageViewMain.Size = new System.Drawing.Size(1014, 584);
            this.pageViewMain.TabIndex = 2;
            this.pageViewMain.Text = "PageView Main";
            this.pageViewMain.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageViewMain.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.Scroll;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageViewMain.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageViewMain.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageViewMain.GetChildAt(0))).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.Auto;
            // 
            // pageMail
            // 
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.pageMail.Controls.Add(this.rtbMailContent);
            this.pageMail.Controls.Add(this.tvMailbox);
            this.pageMail.Location = new System.Drawing.Point(10, 37);
            this.pageMail.Name = "pageMail";
            this.pageMail.Size = new System.Drawing.Size(993, 536);
            this.pageMail.Text = "Почта";
            // 
            // tvMailbox
            // 
            this.tvMailbox.AllowArbitraryItemHeight = true;
            this.tvMailbox.AllowDragDrop = true;
            this.tvMailbox.AllowDrop = true;
            this.tvMailbox.AllowShowFocusCues = true;
            this.tvMailbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.tvMailbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvMailbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvMailbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvMailbox.ForeColor = System.Drawing.Color.Black;
            this.tvMailbox.Location = new System.Drawing.Point(0, 0);
            this.tvMailbox.Name = "tvMailbox";
            radTreeNode1.Expanded = true;
            radTreeNode1.Name = "Inbox";
            radTreeNode2.Name = "Node6";
            radTreeNode2.Text = "Иван Петров, 6.06.2013";
            radTreeNode3.Name = "Node7";
            radTreeNode3.Text = "Серж Весёлкин, 07.07.2014";
            radTreeNode4.Name = "Node8";
            radTreeNode4.Text = "Брэд Питт, 01.02.2012";
            radTreeNode5.Name = "Node9";
            radTreeNode5.Text = "Тамара Захаровна, 28.12.2014";
            radTreeNode6.Name = "Node14";
            radTreeNode6.Text = "Alex Norden, 12.11.2001";
            radTreeNode1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode2,
            radTreeNode3,
            radTreeNode4,
            radTreeNode5,
            radTreeNode6});
            radTreeNode1.Text = "Входящие";
            radTreeNode7.Expanded = true;
            radTreeNode7.Name = "Sent";
            radTreeNode8.Name = "Node10";
            radTreeNode8.Text = "Иван Петров";
            radTreeNode9.Name = "Node11";
            radTreeNode9.Text = "Тамара Захаровна";
            radTreeNode10.Name = "Node12";
            radTreeNode10.Text = "Тамара Захаровна";
            radTreeNode11.Name = "Node13";
            radTreeNode11.Text = "Alex Norden";
            radTreeNode7.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode8,
            radTreeNode9,
            radTreeNode10,
            radTreeNode11});
            radTreeNode7.Text = "Отправленные";
            radTreeNode12.Name = "Drafts";
            radTreeNode12.Text = "Черновики";
            radTreeNode13.Expanded = true;
            radTreeNode13.Name = "Spam";
            radTreeNode14.Expanded = true;
            radTreeNode14.Name = "Node15";
            radTreeNode14.Text = "Заработайте 600 баксов в час!";
            radTreeNode15.Name = "Node16";
            radTreeNode15.Text = "Очки Ray Ban по 100 руб.";
            radTreeNode16.Name = "Node17";
            radTreeNode16.Text = "Увеличение пенисов анонимно";
            radTreeNode13.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode14,
            radTreeNode15,
            radTreeNode16});
            radTreeNode13.Text = "Спам";
            radTreeNode17.Name = "Deleted";
            radTreeNode17.Text = "Удаленные";
            this.tvMailbox.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1,
            radTreeNode7,
            radTreeNode12,
            radTreeNode13,
            radTreeNode17});
            this.tvMailbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tvMailbox.ShowLines = true;
            this.tvMailbox.Size = new System.Drawing.Size(497, 536);
            this.tvMailbox.SpacingBetweenNodes = -1;
            this.tvMailbox.TabIndex = 0;
            this.tvMailbox.Text = "TreeViewMail";
            this.tvMailbox.TriStateMode = true;
            this.tvMailbox.SelectedNodeChanged += new Telerik.WinControls.UI.RadTreeView.RadTreeViewEventHandler(this.tvMailbox_SelectedNodeChanged);
            // 
            // pageGallery
            // 
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.pageGallery.Controls.Add(this.rotatorPhotos);
            this.pageGallery.Location = new System.Drawing.Point(10, 37);
            this.pageGallery.Name = "pageGallery";
            this.pageGallery.Size = new System.Drawing.Size(993, 536);
            this.pageGallery.Text = "Фото";
            // 
            // rotatorPhotos
            // 
            this.rotatorPhotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rotatorPhotos.Controls.Add(this.bPrevButton);
            this.rotatorPhotos.Controls.Add(this.bNextButton);
            this.rotatorPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotatorPhotos.EnableTheming = false;
            this.rotatorPhotos.ImageList = this.imageList;
            this.rotatorPhotos.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.rotatorPhotos.Location = new System.Drawing.Point(0, 0);
            this.rotatorPhotos.Name = "rotatorPhotos";
            this.rotatorPhotos.Size = new System.Drawing.Size(993, 536);
            this.rotatorPhotos.TabIndex = 2;
            ((Telerik.WinControls.UI.RadRotatorElement)(this.rotatorPhotos.GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bPrevButton
            // 
            this.bPrevButton.EnableTheming = false;
            this.bPrevButton.Location = new System.Drawing.Point(7, 3);
            this.bPrevButton.Name = "bPrevButton";
            this.bPrevButton.Size = new System.Drawing.Size(77, 24);
            this.bPrevButton.TabIndex = 6;
            this.bPrevButton.Text = "Назад";
            this.bPrevButton.ThemeName = "HighContrastBlack";
            this.bPrevButton.Click += new System.EventHandler(this.bPrevPhoto_Click);
            // 
            // bNextButton
            // 
            this.bNextButton.EnableTheming = false;
            this.bNextButton.Location = new System.Drawing.Point(90, 3);
            this.bNextButton.Name = "bNextButton";
            this.bNextButton.Size = new System.Drawing.Size(77, 24);
            this.bNextButton.TabIndex = 5;
            this.bNextButton.Text = "Вперед";
            this.bNextButton.ThemeName = "HighContrastBlack";
            this.bNextButton.Click += new System.EventHandler(this.bNextPhoto_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Cat4.jpg");
            this.imageList.Images.SetKeyName(1, "Cat5.jpg");
            this.imageList.Images.SetKeyName(2, "Cat6.jpg");
            // 
            // pageContacts
            // 
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.pageContacts.Controls.Add(this.gridViewContacts);
            this.pageContacts.Location = new System.Drawing.Point(10, 37);
            this.pageContacts.Name = "pageContacts";
            this.pageContacts.Size = new System.Drawing.Size(993, 536);
            this.pageContacts.Text = "Контакты";
            // 
            // gridViewContacts
            // 
            this.gridViewContacts.AllowDrop = true;
            this.gridViewContacts.BackColor = System.Drawing.Color.White;
            this.gridViewContacts.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewContacts.EnableCustomGrouping = true;
            this.gridViewContacts.EnableCustomSorting = true;
            this.gridViewContacts.EnableTheming = false;
            this.gridViewContacts.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridViewContacts.ForeColor = System.Drawing.Color.Black;
            this.gridViewContacts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridViewContacts.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridViewContacts.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridViewContacts.MasterTemplate.AllowAddNewRow = false;
            this.gridViewContacts.MasterTemplate.AllowDeleteRow = false;
            this.gridViewContacts.MasterTemplate.AllowEditRow = false;
            this.gridViewContacts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridViewContacts.MasterTemplate.EnableCustomGrouping = true;
            this.gridViewContacts.MasterTemplate.EnableCustomSorting = true;
            this.gridViewContacts.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "column1";
            this.gridViewContacts.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gridViewContacts.Name = "gridViewContacts";
            this.gridViewContacts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.gridViewContacts.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.gridViewContacts.RootElement.AutoSize = true;
            this.gridViewContacts.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.gridViewContacts.RootElement.PositionOffset = new System.Drawing.SizeF(0F, 0F);
            this.gridViewContacts.Size = new System.Drawing.Size(993, 536);
            this.gridViewContacts.TabIndex = 0;
            this.gridViewContacts.ThemeName = "HighContrastBlack";
            // 
            // pageDocs
            // 
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.pageDocs.Location = new System.Drawing.Point(10, 37);
            this.pageDocs.Name = "pageDocs";
            this.pageDocs.Size = new System.Drawing.Size(993, 536);
            this.pageDocs.Text = "Документы";
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.EnableTheming = false;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1014, 104);
            this.panelLogo.TabIndex = 5;
            this.panelLogo.ThemeName = "ControlDefault";
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(224, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(565, 82);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // rtbMailContent
            // 
            this.rtbMailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMailContent.HyperlinkToolTipFormatString = null;
            this.rtbMailContent.Location = new System.Drawing.Point(497, 0);
            this.rtbMailContent.Name = "rtbMailContent";
            this.rtbMailContent.Size = new System.Drawing.Size(496, 536);
            this.rtbMailContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 688);
            this.ControlBox = false;
            this.Controls.Add(this.pageViewMain);
            this.Controls.Add(this.panelLogo);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.Text = "ПромНефть Секретарь";
            this.ThemeName = "HighContrastBlack";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).EndInit();
            this.pageViewMain.ResumeLayout(false);
            this.pageMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tvMailbox)).EndInit();
            this.pageGallery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rotatorPhotos)).EndInit();
            this.rotatorPhotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bPrevButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNextButton)).EndInit();
            this.pageContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbMailContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView pageViewMain;
        private Telerik.WinControls.UI.RadPageViewPage pageGallery;
        private Telerik.WinControls.UI.RadPageViewPage pageContacts;
        private Telerik.WinControls.UI.RadPanel panelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private Telerik.WinControls.UI.RadGridView gridViewContacts;
        private System.Windows.Forms.ImageList imageList;
        private Telerik.WinControls.UI.RadRotator rotatorPhotos;
        private Telerik.WinControls.UI.RadButton bPrevButton;
        private Telerik.WinControls.UI.RadButton bNextButton;
        private Telerik.WinControls.Themes.HighContrastBlackTheme highContrastBlackTheme1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadPageViewPage pageDocs;
        private Telerik.WinControls.UI.RadPageViewPage pageMail;
        private Telerik.WinControls.UI.RadTreeView tvMailbox;
        private Telerik.WinControls.RichTextBox.RadRichTextBox rtbMailContent;
    }
}
