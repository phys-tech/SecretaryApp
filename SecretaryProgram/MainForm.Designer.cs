namespace SecretaryApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.pageViewMain = new Telerik.WinControls.UI.RadPageView();
            this.pageMail = new Telerik.WinControls.UI.RadPageViewPage();
            this.rtbMailContent = new Telerik.WinControls.RichTextBox.RadRichTextBox();
            this.pMailContents = new Telerik.WinControls.UI.RadPanel();
            this.tbDate = new Telerik.WinControls.UI.RadTextBox();
            this.tbTheme = new Telerik.WinControls.UI.RadTextBox();
            this.tbSender = new Telerik.WinControls.UI.RadTextBox();
            this.lDate = new Telerik.WinControls.UI.RadLabel();
            this.lTheme = new Telerik.WinControls.UI.RadLabel();
            this.lSender = new Telerik.WinControls.UI.RadLabel();
            this.tvMailbox = new Telerik.WinControls.UI.RadTreeView();
            this.pageGallery = new Telerik.WinControls.UI.RadPageViewPage();
            this.rotatorPhotos = new Telerik.WinControls.UI.RadRotator();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panelPhotos = new Telerik.WinControls.UI.RadPanel();
            this.bPrevButton = new Telerik.WinControls.UI.RadButton();
            this.bNextButton = new Telerik.WinControls.UI.RadButton();
            this.pageContacts = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridViewContacts = new Telerik.WinControls.UI.RadGridView();
            this.panelOfficialTitle = new Telerik.WinControls.UI.RadPanel();
            this.pageDocs = new Telerik.WinControls.UI.RadPageViewPage();
            this.rtbDocs = new Telerik.WinControls.RichTextBox.RadRichTextBox();
            this.panelLogo = new Telerik.WinControls.UI.RadPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.highContrastBlackTheme1 = new Telerik.WinControls.Themes.HighContrastBlackTheme();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).BeginInit();
            this.pageViewMain.SuspendLayout();
            this.pageMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbMailContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMailContents)).BeginInit();
            this.pMailContents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvMailbox)).BeginInit();
            this.pageGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotatorPhotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPhotos)).BeginInit();
            this.panelPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bPrevButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNextButton)).BeginInit();
            this.pageContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelOfficialTitle)).BeginInit();
            this.pageDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtbDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
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
            this.pageViewMain.SelectedPage = this.pageDocs;
            this.pageViewMain.Size = new System.Drawing.Size(1022, 588);
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
            this.pageMail.Controls.Add(this.pMailContents);
            this.pageMail.Controls.Add(this.tvMailbox);
            this.pageMail.Location = new System.Drawing.Point(10, 37);
            this.pageMail.Name = "pageMail";
            this.pageMail.Size = new System.Drawing.Size(1001, 540);
            this.pageMail.Text = "Почта";
            // 
            // rtbMailContent
            // 
            this.rtbMailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMailContent.HyperlinkToolTipFormatString = null;
            this.rtbMailContent.IsReadOnly = true;
            this.rtbMailContent.Location = new System.Drawing.Point(335, 100);
            this.rtbMailContent.Name = "rtbMailContent";
            this.rtbMailContent.Size = new System.Drawing.Size(666, 440);
            this.rtbMailContent.TabIndex = 1;
            // 
            // pMailContents
            // 
            this.pMailContents.Controls.Add(this.tbDate);
            this.pMailContents.Controls.Add(this.tbTheme);
            this.pMailContents.Controls.Add(this.tbSender);
            this.pMailContents.Controls.Add(this.lDate);
            this.pMailContents.Controls.Add(this.lTheme);
            this.pMailContents.Controls.Add(this.lSender);
            this.pMailContents.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMailContents.Location = new System.Drawing.Point(335, 0);
            this.pMailContents.Name = "pMailContents";
            this.pMailContents.Size = new System.Drawing.Size(666, 100);
            this.pMailContents.TabIndex = 2;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(83, 69);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(632, 20);
            this.tbDate.TabIndex = 5;
            this.tbDate.TabStop = false;
            // 
            // tbTheme
            // 
            this.tbTheme.Location = new System.Drawing.Point(83, 42);
            this.tbTheme.Name = "tbTheme";
            this.tbTheme.ReadOnly = true;
            this.tbTheme.Size = new System.Drawing.Size(632, 20);
            this.tbTheme.TabIndex = 4;
            this.tbTheme.TabStop = false;
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(83, 15);
            this.tbSender.Name = "tbSender";
            this.tbSender.ReadOnly = true;
            this.tbSender.Size = new System.Drawing.Size(632, 20);
            this.tbSender.TabIndex = 3;
            this.tbSender.TabStop = false;
            // 
            // lDate
            // 
            this.lDate.Location = new System.Drawing.Point(7, 65);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(33, 18);
            this.lDate.TabIndex = 2;
            this.lDate.Text = "Дата:";
            // 
            // lTheme
            // 
            this.lTheme.Location = new System.Drawing.Point(7, 40);
            this.lTheme.Name = "lTheme";
            this.lTheme.Size = new System.Drawing.Size(34, 18);
            this.lTheme.TabIndex = 1;
            this.lTheme.Text = "Тема:";
            // 
            // lSender
            // 
            this.lSender.Location = new System.Drawing.Point(7, 15);
            this.lSender.Name = "lSender";
            this.lSender.Size = new System.Drawing.Size(48, 18);
            this.lSender.TabIndex = 0;
            this.lSender.Text = "От кого:";
            // 
            // tvMailbox
            // 
            this.tvMailbox.AllowArbitraryItemHeight = true;
            this.tvMailbox.AllowDrop = true;
            this.tvMailbox.AllowShowFocusCues = true;
            this.tvMailbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.tvMailbox.CheckBoxes = true;
            this.tvMailbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.tvMailbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvMailbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tvMailbox.ForeColor = System.Drawing.Color.Black;
            this.tvMailbox.Location = new System.Drawing.Point(0, 0);
            this.tvMailbox.Name = "tvMailbox";
            radTreeNode1.CheckType = Telerik.WinControls.UI.CheckType.CheckBox;
            radTreeNode1.Expanded = true;
            radTreeNode1.Name = "Inbox";
            radTreeNode1.Text = "Входящие";
            radTreeNode2.CheckType = Telerik.WinControls.UI.CheckType.CheckBox;
            radTreeNode2.Expanded = true;
            radTreeNode2.Name = "Sent";
            radTreeNode2.Text = "Исходящие";
            radTreeNode3.CheckType = Telerik.WinControls.UI.CheckType.CheckBox;
            radTreeNode3.Name = "Drafts";
            radTreeNode3.Text = "Черновики";
            radTreeNode4.CheckType = Telerik.WinControls.UI.CheckType.CheckBox;
            radTreeNode4.Expanded = true;
            radTreeNode4.Name = "Spam";
            radTreeNode4.Text = "Спам";
            radTreeNode5.CheckType = Telerik.WinControls.UI.CheckType.CheckBox;
            radTreeNode5.Name = "Deleted";
            radTreeNode5.Text = "Корзина";
            this.tvMailbox.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1,
            radTreeNode2,
            radTreeNode3,
            radTreeNode4,
            radTreeNode5});
            this.tvMailbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tvMailbox.ShowLines = true;
            this.tvMailbox.Size = new System.Drawing.Size(335, 540);
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
            this.pageGallery.Controls.Add(this.panelPhotos);
            this.pageGallery.Location = new System.Drawing.Point(10, 37);
            this.pageGallery.Name = "pageGallery";
            this.pageGallery.Size = new System.Drawing.Size(1001, 540);
            this.pageGallery.Text = "Фото";
            // 
            // rotatorPhotos
            // 
            this.rotatorPhotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rotatorPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotatorPhotos.EnableTheming = false;
            this.rotatorPhotos.ImageList = this.imageList;
            this.rotatorPhotos.ImageScalingSize = new System.Drawing.Size(100, 100);
            this.rotatorPhotos.Location = new System.Drawing.Point(0, 42);
            this.rotatorPhotos.Name = "rotatorPhotos";
            this.rotatorPhotos.Size = new System.Drawing.Size(1001, 498);
            this.rotatorPhotos.TabIndex = 2;
            ((Telerik.WinControls.UI.RadRotatorElement)(this.rotatorPhotos.GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Cat4.jpg");
            this.imageList.Images.SetKeyName(1, "Cat5.jpg");
            this.imageList.Images.SetKeyName(2, "Cat6.jpg");
            // 
            // panelPhotos
            // 
            this.panelPhotos.Controls.Add(this.bPrevButton);
            this.panelPhotos.Controls.Add(this.bNextButton);
            this.panelPhotos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPhotos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelPhotos.Location = new System.Drawing.Point(0, 0);
            this.panelPhotos.Name = "panelPhotos";
            this.panelPhotos.Size = new System.Drawing.Size(1001, 42);
            this.panelPhotos.TabIndex = 3;
            this.panelPhotos.Text = "Фотографии офисов ЗАО \"ПромНефть Россия\"";
            this.panelPhotos.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bPrevButton
            // 
            this.bPrevButton.EnableTheming = false;
            this.bPrevButton.Location = new System.Drawing.Point(12, 7);
            this.bPrevButton.Name = "bPrevButton";
            this.bPrevButton.Size = new System.Drawing.Size(77, 24);
            this.bPrevButton.TabIndex = 8;
            this.bPrevButton.Text = "Назад";
            this.bPrevButton.ThemeName = "HighContrastBlack";
            this.bPrevButton.Click += new System.EventHandler(this.bPrevPhoto_Click);
            // 
            // bNextButton
            // 
            this.bNextButton.EnableTheming = false;
            this.bNextButton.Location = new System.Drawing.Point(95, 7);
            this.bNextButton.Name = "bNextButton";
            this.bNextButton.Size = new System.Drawing.Size(77, 24);
            this.bNextButton.TabIndex = 7;
            this.bNextButton.Text = "Вперед";
            this.bNextButton.ThemeName = "HighContrastBlack";
            this.bNextButton.Click += new System.EventHandler(this.bNextPhoto_Click);
            // 
            // pageContacts
            // 
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.pageContacts.Controls.Add(this.gridViewContacts);
            this.pageContacts.Controls.Add(this.panelOfficialTitle);
            this.pageContacts.Location = new System.Drawing.Point(10, 37);
            this.pageContacts.Name = "pageContacts";
            this.pageContacts.Size = new System.Drawing.Size(1001, 540);
            this.pageContacts.Text = "Список сотрудников";
            // 
            // gridViewContacts
            // 
            this.gridViewContacts.AllowDrop = true;
            this.gridViewContacts.BackColor = System.Drawing.Color.White;
            this.gridViewContacts.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridViewContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewContacts.EnableTheming = false;
            this.gridViewContacts.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridViewContacts.ForeColor = System.Drawing.Color.Black;
            this.gridViewContacts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridViewContacts.Location = new System.Drawing.Point(0, 42);
            // 
            // 
            // 
            this.gridViewContacts.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridViewContacts.MasterTemplate.AllowAddNewRow = false;
            this.gridViewContacts.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gridViewContacts.MasterTemplate.AllowDeleteRow = false;
            this.gridViewContacts.MasterTemplate.AllowEditRow = false;
            this.gridViewContacts.MasterTemplate.AllowRowReorder = true;
            this.gridViewContacts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.gridViewContacts.MasterTemplate.EnableFiltering = true;
            this.gridViewContacts.MasterTemplate.EnableGrouping = false;
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
            this.gridViewContacts.Size = new System.Drawing.Size(1001, 498);
            this.gridViewContacts.TabIndex = 0;
            this.gridViewContacts.ThemeName = "HighContrastBlack";
            // 
            // panelOfficialTitle
            // 
            this.panelOfficialTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOfficialTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelOfficialTitle.Location = new System.Drawing.Point(0, 0);
            this.panelOfficialTitle.Name = "panelOfficialTitle";
            this.panelOfficialTitle.Size = new System.Drawing.Size(1001, 42);
            this.panelOfficialTitle.TabIndex = 1;
            this.panelOfficialTitle.Text = "Центральная сетевая дирекция ЗАО \"ПромНефть Россия\"";
            this.panelOfficialTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageDocs
            // 
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.pageDocs.Controls.Add(this.rtbDocs);
            this.pageDocs.Location = new System.Drawing.Point(10, 37);
            this.pageDocs.Name = "pageDocs";
            this.pageDocs.Size = new System.Drawing.Size(1001, 540);
            this.pageDocs.Text = "Документы";
            // 
            // rtbDocs
            // 
            this.rtbDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDocs.HyperlinkToolTipFormatString = null;
            this.rtbDocs.IsReadOnly = true;
            this.rtbDocs.Location = new System.Drawing.Point(0, 0);
            this.rtbDocs.Name = "rtbDocs";
            this.rtbDocs.Size = new System.Drawing.Size(1001, 540);
            this.rtbDocs.TabIndex = 0;
            this.rtbDocs.Text = "radRichTextBox1";
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.EnableTheming = false;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1022, 104);
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
            this.pbLogo.Size = new System.Drawing.Size(573, 82);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 692);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).EndInit();
            this.pageViewMain.ResumeLayout(false);
            this.pageMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rtbMailContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMailContents)).EndInit();
            this.pMailContents.ResumeLayout(false);
            this.pMailContents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvMailbox)).EndInit();
            this.pageGallery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rotatorPhotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelPhotos)).EndInit();
            this.panelPhotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bPrevButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNextButton)).EndInit();
            this.pageContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelOfficialTitle)).EndInit();
            this.pageDocs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rtbDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLogo)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
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
        private Telerik.WinControls.Themes.HighContrastBlackTheme highContrastBlackTheme1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadPageViewPage pageDocs;
        private Telerik.WinControls.UI.RadPageViewPage pageMail;
        private Telerik.WinControls.UI.RadTreeView tvMailbox;
        private Telerik.WinControls.RichTextBox.RadRichTextBox rtbMailContent;
        private Telerik.WinControls.RichTextBox.RadRichTextBox rtbDocs;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Telerik.WinControls.UI.RadPanel pMailContents;
        private Telerik.WinControls.UI.RadTextBox tbDate;
        private Telerik.WinControls.UI.RadTextBox tbTheme;
        private Telerik.WinControls.UI.RadTextBox tbSender;
        private Telerik.WinControls.UI.RadLabel lDate;
        private Telerik.WinControls.UI.RadLabel lTheme;
        private Telerik.WinControls.UI.RadLabel lSender;
        private Telerik.WinControls.UI.RadPanel panelOfficialTitle;
        private Telerik.WinControls.UI.RadPanel panelPhotos;
        private Telerik.WinControls.UI.RadButton bPrevButton;
        private Telerik.WinControls.UI.RadButton bNextButton;
    }
}
