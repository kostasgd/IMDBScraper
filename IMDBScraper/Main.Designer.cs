namespace IMDBScraper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mtc = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvNews = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbNews = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvTopseries = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToWishlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvTopmovies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnScrap = new System.Windows.Forms.Button();
            this.txtScraped = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picboxScraped = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lvWishlist = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mfbnbo = new MaterialSkin.Controls.MaterialFlatButton();
            this.mfbtops = new MaterialSkin.Controls.MaterialFlatButton();
            this.mfbScrap = new MaterialSkin.Controls.MaterialFlatButton();
            this.mfbWishlist = new MaterialSkin.Controls.MaterialFlatButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.mtc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxScraped)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "News";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(-1, 220);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Box Office";
            // 
            // mtc
            // 
            this.mtc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtc.Controls.Add(this.tabPage1);
            this.mtc.Controls.Add(this.tabPage2);
            this.mtc.Controls.Add(this.tabPage3);
            this.mtc.Controls.Add(this.tabPage4);
            this.mtc.Depth = 0;
            this.mtc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtc.Location = new System.Drawing.Point(1, 111);
            this.mtc.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtc.Name = "mtc";
            this.mtc.SelectedIndex = 0;
            this.mtc.Size = new System.Drawing.Size(1275, 464);
            this.mtc.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lvNews);
            this.tabPage1.Controls.Add(this.lbNews);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1267, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // lvNews
            // 
            this.lvNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvNews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lvNews.HideSelection = false;
            this.lvNews.Location = new System.Drawing.Point(0, 243);
            this.lvNews.Name = "lvNews";
            this.lvNews.Size = new System.Drawing.Size(1264, 191);
            this.lvNews.TabIndex = 6;
            this.lvNews.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Title";
            this.columnHeader14.Width = 260;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Weekend";
            this.columnHeader15.Width = 190;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Gross";
            this.columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Weeks";
            this.columnHeader17.Width = 80;
            // 
            // lbNews
            // 
            this.lbNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbNews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNews.FormattingEnabled = true;
            this.lbNews.ItemHeight = 17;
            this.lbNews.Location = new System.Drawing.Point(3, 26);
            this.lbNews.Name = "lbNews";
            this.lbNews.Size = new System.Drawing.Size(1261, 172);
            this.lbNews.TabIndex = 5;
            this.lbNews.DoubleClick += new System.EventHandler(this.lbNews_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lvTopseries);
            this.tabPage2.Controls.Add(this.lvTopmovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1267, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // lvTopseries
            // 
            this.lvTopseries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvTopseries.BackColor = System.Drawing.Color.Yellow;
            this.lvTopseries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvTopseries.ContextMenuStrip = this.contextMenuStrip1;
            this.lvTopseries.HideSelection = false;
            this.lvTopseries.Location = new System.Drawing.Point(662, 3);
            this.lvTopseries.Name = "lvTopseries";
            this.lvTopseries.Size = new System.Drawing.Size(609, 428);
            this.lvTopseries.TabIndex = 1;
            this.lvTopseries.UseCompatibleStateImageBehavior = false;
            this.lvTopseries.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTopseries_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Title";
            this.columnHeader5.Width = 250;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Rating";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Year";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Width = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToWishlistToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 26);
            this.contextMenuStrip1.Text = "Add to wishlist";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addToWishlistToolStripMenuItem
            // 
            this.addToWishlistToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.addToWishlistToolStripMenuItem.Name = "addToWishlistToolStripMenuItem";
            this.addToWishlistToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addToWishlistToolStripMenuItem.Text = "Add Series to Wishlist";
            this.addToWishlistToolStripMenuItem.Click += new System.EventHandler(this.addToWishlistToolStripMenuItem_Click);
            // 
            // lvTopmovies
            // 
            this.lvTopmovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvTopmovies.BackColor = System.Drawing.Color.Yellow;
            this.lvTopmovies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTopmovies.ContextMenuStrip = this.contextMenuStrip2;
            this.lvTopmovies.GridLines = true;
            this.lvTopmovies.HideSelection = false;
            this.lvTopmovies.Location = new System.Drawing.Point(3, 3);
            this.lvTopmovies.Name = "lvTopmovies";
            this.lvTopmovies.Size = new System.Drawing.Size(653, 428);
            this.lvTopmovies.TabIndex = 0;
            this.lvTopmovies.UseCompatibleStateImageBehavior = false;
            this.lvTopmovies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTopmovies_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Movie";
            this.columnHeader1.Width = 280;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rating";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Year";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 0;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(191, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem1.Text = "Add Movie to Wishlist";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbDesc);
            this.tabPage3.Controls.Add(this.btnScrap);
            this.tabPage3.Controls.Add(this.txtScraped);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.lblGenre);
            this.tabPage3.Controls.Add(this.lbldesc);
            this.tabPage3.Controls.Add(this.lblRate);
            this.tabPage3.Controls.Add(this.lblTitle);
            this.tabPage3.Controls.Add(this.picboxScraped);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1267, 434);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnScrap
            // 
            this.btnScrap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnScrap.Location = new System.Drawing.Point(572, 14);
            this.btnScrap.Name = "btnScrap";
            this.btnScrap.Size = new System.Drawing.Size(98, 33);
            this.btnScrap.TabIndex = 8;
            this.btnScrap.Text = "Scrap";
            this.btnScrap.UseVisualStyleBackColor = true;
            this.btnScrap.Click += new System.EventHandler(this.btnScrap_Click);
            // 
            // txtScraped
            // 
            this.txtScraped.Location = new System.Drawing.Point(25, 21);
            this.txtScraped.Name = "txtScraped";
            this.txtScraped.Size = new System.Drawing.Size(531, 23);
            this.txtScraped.TabIndex = 7;
            this.txtScraped.Text = "https://www.imdb.com/title/tt8332922/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=f9f31d04-fc2" +
    "2-4d12-86b4-f46e25aa2f6f&pf_rd_r=JS341E8CGERB8WQY5228&pf_rd_s=center-1&pf_rd_t=1" +
    "5506&pf_rd_i=boxoffice&ref_=cht_bo_1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(362, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(362, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "label2";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblGenre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblGenre.Location = new System.Drawing.Point(373, 152);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(0, 21);
            this.lblGenre.TabIndex = 4;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbldesc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbldesc.Location = new System.Drawing.Point(483, 106);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(0, 21);
            this.lbldesc.TabIndex = 3;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRate.Location = new System.Drawing.Point(373, 106);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(0, 21);
            this.lblRate.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Location = new System.Drawing.Point(373, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 22);
            this.lblTitle.TabIndex = 1;
            // 
            // picboxScraped
            // 
            this.picboxScraped.Location = new System.Drawing.Point(25, 68);
            this.picboxScraped.Name = "picboxScraped";
            this.picboxScraped.Size = new System.Drawing.Size(331, 333);
            this.picboxScraped.TabIndex = 0;
            this.picboxScraped.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvWishlist);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1267, 434);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lvWishlist
            // 
            this.lvWishlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvWishlist.BackColor = System.Drawing.Color.Yellow;
            this.lvWishlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lvWishlist.HideSelection = false;
            this.lvWishlist.Location = new System.Drawing.Point(-4, 0);
            this.lvWishlist.Name = "lvWishlist";
            this.lvWishlist.Size = new System.Drawing.Size(1268, 438);
            this.lvWishlist.TabIndex = 0;
            this.lvWishlist.UseCompatibleStateImageBehavior = false;
            this.lvWishlist.DoubleClick += new System.EventHandler(this.lvWishlist_DoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Id";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Title";
            this.columnHeader10.Width = 270;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Rating";
            this.columnHeader11.Width = 120;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Year";
            this.columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Link";
            this.columnHeader13.Width = 280;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BackColor = System.Drawing.Color.Yellow;
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(1179, 75);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(97, 10);
            this.materialTabSelector2.TabIndex = 7;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector3.BackColor = System.Drawing.Color.Yellow;
            this.materialTabSelector3.BaseTabControl = null;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Location = new System.Drawing.Point(1158, 93);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(118, 10);
            this.materialTabSelector3.TabIndex = 8;
            this.materialTabSelector3.Text = "materialTabSelector3";
            this.materialTabSelector3.Click += new System.EventHandler(this.materialTabSelector3_Click);
            // 
            // mfbnbo
            // 
            this.mfbnbo.AutoSize = true;
            this.mfbnbo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbnbo.Depth = 0;
            this.mfbnbo.Location = new System.Drawing.Point(38, 69);
            this.mfbnbo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mfbnbo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbnbo.Name = "mfbnbo";
            this.mfbnbo.Primary = false;
            this.mfbnbo.Size = new System.Drawing.Size(141, 36);
            this.mfbnbo.TabIndex = 9;
            this.mfbnbo.Text = "News & Box Office";
            this.mfbnbo.UseVisualStyleBackColor = true;
            this.mfbnbo.Click += new System.EventHandler(this.mfbnbo_Click);
            // 
            // mfbtops
            // 
            this.mfbtops.AutoSize = true;
            this.mfbtops.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbtops.Depth = 0;
            this.mfbtops.Location = new System.Drawing.Point(212, 69);
            this.mfbtops.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mfbtops.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbtops.Name = "mfbtops";
            this.mfbtops.Primary = false;
            this.mfbtops.Size = new System.Drawing.Size(76, 36);
            this.mfbtops.TabIndex = 10;
            this.mfbtops.Text = "The Tops";
            this.mfbtops.UseVisualStyleBackColor = true;
            this.mfbtops.Click += new System.EventHandler(this.mfbtops_Click);
            // 
            // mfbScrap
            // 
            this.mfbScrap.AutoSize = true;
            this.mfbScrap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbScrap.Depth = 0;
            this.mfbScrap.Location = new System.Drawing.Point(322, 69);
            this.mfbScrap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mfbScrap.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbScrap.Name = "mfbScrap";
            this.mfbScrap.Primary = false;
            this.mfbScrap.Size = new System.Drawing.Size(114, 36);
            this.mfbScrap.TabIndex = 11;
            this.mfbScrap.Text = "Scrap a movie";
            this.mfbScrap.UseVisualStyleBackColor = true;
            this.mfbScrap.Click += new System.EventHandler(this.mfbScrap_Click);
            // 
            // mfbWishlist
            // 
            this.mfbWishlist.AutoSize = true;
            this.mfbWishlist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbWishlist.Depth = 0;
            this.mfbWishlist.Location = new System.Drawing.Point(471, 69);
            this.mfbWishlist.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mfbWishlist.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbWishlist.Name = "mfbWishlist";
            this.mfbWishlist.Primary = false;
            this.mfbWishlist.Size = new System.Drawing.Size(74, 36);
            this.mfbWishlist.TabIndex = 12;
            this.mfbWishlist.Text = "Wishlist";
            this.mfbWishlist.UseVisualStyleBackColor = true;
            this.mfbWishlist.Click += new System.EventHandler(this.mfbWishlist_Click);
            // 
            // rtbDesc
            // 
            this.rtbDesc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rtbDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbDesc.Location = new System.Drawing.Point(487, 106);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.ReadOnly = true;
            this.rtbDesc.Size = new System.Drawing.Size(746, 173);
            this.rtbDesc.TabIndex = 9;
            this.rtbDesc.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 576);
            this.Controls.Add(this.mfbWishlist);
            this.Controls.Add(this.mfbScrap);
            this.Controls.Add(this.mfbtops);
            this.Controls.Add(this.mfbnbo);
            this.Controls.Add(this.materialTabSelector3);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.mtc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imdb Scraper";
            this.Load += new System.EventHandler(this.Main_Load);
            this.DoubleClick += new System.EventHandler(this.Main_DoubleClick);
            this.mtc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxScraped)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTabControl mtc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialFlatButton mfbnbo;
        private MaterialSkin.Controls.MaterialFlatButton mfbtops;
        private System.Windows.Forms.ListView lvTopmovies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvTopseries;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MaterialSkin.Controls.MaterialFlatButton mfbScrap;
        private MaterialSkin.Controls.MaterialFlatButton mfbWishlist;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToWishlistToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvWishlist;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ListView lvNews;
        private System.Windows.Forms.ListBox lbNews;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnScrap;
        private System.Windows.Forms.TextBox txtScraped;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picboxScraped;
        private System.Windows.Forms.RichTextBox rtbDesc;
    }
}