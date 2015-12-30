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
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.pageViewMain = new Telerik.WinControls.UI.RadPageView();
            this.pageMail = new Telerik.WinControls.UI.RadPageViewPage();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.carouselPhotos = new Telerik.WinControls.UI.RadCarousel();
            this.radImageButtonElement1 = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radImageItem1 = new Telerik.WinControls.UI.RadImageItem();
            this.radImageItem2 = new Telerik.WinControls.UI.RadImageItem();
            this.pageGallery = new Telerik.WinControls.UI.RadPageViewPage();
            this.rotatorPhotos = new Telerik.WinControls.UI.RadRotator();
            this.bPrevButton = new Telerik.WinControls.UI.RadButton();
            this.bNextButton = new Telerik.WinControls.UI.RadButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pageContacts = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridViewContacts = new Telerik.WinControls.UI.RadGridView();
            this.panelLogo = new Telerik.WinControls.UI.RadPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.customShape1 = new Telerik.WinControls.OldShapeEditor.CustomShape();
            this.highContrastBlackTheme1 = new Telerik.WinControls.Themes.HighContrastBlackTheme();
            this.office2010BlackTheme1 = new Telerik.WinControls.Themes.Office2010BlackTheme();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).BeginInit();
            this.pageViewMain.SuspendLayout();
            this.pageMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carouselPhotos)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pageViewMain
            // 
            this.pageViewMain.Controls.Add(this.pageMail);
            this.pageViewMain.Controls.Add(this.pageGallery);
            this.pageViewMain.Controls.Add(this.pageContacts);
            this.pageViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageViewMain.Location = new System.Drawing.Point(0, 104);
            this.pageViewMain.Name = "pageViewMain";
            this.pageViewMain.SelectedPage = this.pageContacts;
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
            this.pageMail.Controls.Add(this.radLabel1);
            this.pageMail.Controls.Add(this.carouselPhotos);
            this.pageMail.Location = new System.Drawing.Point(10, 37);
            this.pageMail.Name = "pageMail";
            this.pageMail.Size = new System.Drawing.Size(993, 536);
            this.pageMail.Text = "Почта";
            // 
            // radLabel1
            // 
            this.radLabel1.EnableTheming = false;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radLabel1.Location = new System.Drawing.Point(346, 233);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(328, 25);
            this.radLabel1.TabIndex = 3;
            this.radLabel1.Text = "Здесь будет почта компании ПромНефть! ";
            // 
            // carouselPhotos
            // 
            this.carouselPhotos.ButtonPositions = Telerik.WinControls.UI.NavigationButtonsPosition.Top;
            carouselEllipsePath1.Center = new Telerik.WinControls.UI.Point3D(50.837138508371382D, 45.892351274787536D, 0D);
            carouselEllipsePath1.FinalAngle = -45D;
            carouselEllipsePath1.InitialAngle = 90D;
            carouselEllipsePath1.U = new Telerik.WinControls.UI.Point3D(-20D, -17D, -50D);
            carouselEllipsePath1.V = new Telerik.WinControls.UI.Point3D(30D, -25D, -60D);
            carouselEllipsePath1.ZScale = 500D;
            this.carouselPhotos.CarouselPath = carouselEllipsePath1;
            this.carouselPhotos.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radImageButtonElement1,
            this.radImageItem1,
            this.radImageItem2});
            this.carouselPhotos.Location = new System.Drawing.Point(34, 16);
            this.carouselPhotos.Name = "carouselPhotos";
            this.carouselPhotos.Size = new System.Drawing.Size(524, 174);
            this.carouselPhotos.TabIndex = 2;
            this.carouselPhotos.Text = "Whre is the text";
            this.carouselPhotos.Visible = false;
            // 
            // radImageButtonElement1
            // 
            this.radImageButtonElement1.AccessibleDescription = "radImageButtonElement1";
            this.radImageButtonElement1.AccessibleName = "radImageButtonElement1";
            this.radImageButtonElement1.AutoSize = true;
            this.radImageButtonElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.radImageButtonElement1.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            this.radImageButtonElement1.Image = ((System.Drawing.Image)(resources.GetObject("radImageButtonElement1.Image")));
            this.radImageButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radImageButtonElement1.ImageIndexClicked = 0;
            this.radImageButtonElement1.ImageIndexHovered = 0;
            this.radImageButtonElement1.MaxSize = new System.Drawing.Size(200, 200);
            this.radImageButtonElement1.Name = "radImageButtonElement1";
            this.radImageButtonElement1.SerializeChildren = false;
            this.radImageButtonElement1.ShouldPaint = true;
            this.radImageButtonElement1.StretchHorizontally = true;
            this.radImageButtonElement1.StretchVertically = true;
            this.radImageButtonElement1.Text = "radImageButtonElement1";
            this.radImageButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radImageItem1
            // 
            this.radImageItem1.AccessibleDescription = "radImageItem1";
            this.radImageItem1.AccessibleName = "radImageItem1";
            this.radImageItem1.AutoSize = true;
            this.radImageItem1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.radImageItem1.ClipDrawing = true;
            this.radImageItem1.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent;
            this.radImageItem1.Image = ((System.Drawing.Image)(resources.GetObject("radImageItem1.Image")));
            this.radImageItem1.MaxSize = new System.Drawing.Size(200, 200);
            this.radImageItem1.Name = "radImageItem1";
            this.radImageItem1.Text = "radImageItem1";
            this.radImageItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radImageItem2
            // 
            this.radImageItem2.AccessibleDescription = "radImageItem2";
            this.radImageItem2.AccessibleName = "radImageItem2";
            this.radImageItem2.ClipDrawing = true;
            this.radImageItem2.Image = ((System.Drawing.Image)(resources.GetObject("radImageItem2.Image")));
            this.radImageItem2.MaxSize = new System.Drawing.Size(200, 200);
            this.radImageItem2.Name = "radImageItem2";
            this.radImageItem2.ShouldPaint = true;
            this.radImageItem2.StretchHorizontally = false;
            this.radImageItem2.StretchVertically = false;
            this.radImageItem2.Text = "radImageItem2";
            this.radImageItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
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
            this.gridViewContacts.EnableTheming = false;
            this.gridViewContacts.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridViewContacts.ForeColor = System.Drawing.Color.Black;
            this.gridViewContacts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridViewContacts.Location = new System.Drawing.Point(0, 0);
            // 
            // gridViewContacts
            // 
            this.gridViewContacts.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gridViewContacts.MasterTemplate.AllowAddNewRow = false;
            this.gridViewContacts.MasterTemplate.AllowDeleteRow = false;
            this.gridViewContacts.MasterTemplate.AllowEditRow = false;
            this.gridViewContacts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
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
            // customShape1
            // 
            this.customShape1.Dimension = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(SecretaryProgram.Contact);
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
            this.pageMail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carouselPhotos)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView pageViewMain;
        private Telerik.WinControls.UI.RadPageViewPage pageMail;
        private Telerik.WinControls.UI.RadPageViewPage pageGallery;
        private Telerik.WinControls.UI.RadPageViewPage pageContacts;
        private Telerik.WinControls.UI.RadPanel panelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private Telerik.WinControls.UI.RadGridView gridViewContacts;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private Telerik.WinControls.OldShapeEditor.CustomShape customShape1;
        private System.Windows.Forms.ImageList imageList;
        private Telerik.WinControls.UI.RadCarousel carouselPhotos;
        private Telerik.WinControls.UI.RadImageButtonElement radImageButtonElement1;
        private Telerik.WinControls.UI.RadImageItem radImageItem1;
        private Telerik.WinControls.UI.RadImageItem radImageItem2;
        private Telerik.WinControls.UI.RadRotator rotatorPhotos;
        private Telerik.WinControls.UI.RadButton bPrevButton;
        private Telerik.WinControls.UI.RadButton bNextButton;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.HighContrastBlackTheme highContrastBlackTheme1;
        private Telerik.WinControls.Themes.Office2010BlackTheme office2010BlackTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}
