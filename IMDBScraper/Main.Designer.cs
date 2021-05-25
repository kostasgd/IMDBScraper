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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbNews = new System.Windows.Forms.ListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbstream = new System.Windows.Forms.ListBox();
            this.mtc = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mfbnbo = new MaterialSkin.Controls.MaterialFlatButton();
            this.mfbtops = new MaterialSkin.Controls.MaterialFlatButton();
            this.lvTopmovies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTopseries = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNews
            // 
            this.lbNews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNews.BackColor = System.Drawing.Color.Yellow;
            this.lbNews.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbNews.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNews.FormattingEnabled = true;
            this.lbNews.ItemHeight = 44;
            this.lbNews.Location = new System.Drawing.Point(0, 28);
            this.lbNews.Name = "lbNews";
            this.lbNews.Size = new System.Drawing.Size(1284, 72);
            this.lbNews.TabIndex = 1;
            this.lbNews.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbNews_DrawItem);
            this.lbNews.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbNews_MeasureItem);
            this.lbNews.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbNews_MouseDoubleClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "News";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(11, 115);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Box Office";
            // 
            // lbstream
            // 
            this.lbstream.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbstream.BackColor = System.Drawing.Color.Yellow;
            this.lbstream.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstream.FormattingEnabled = true;
            this.lbstream.ItemHeight = 17;
            this.lbstream.Location = new System.Drawing.Point(0, 146);
            this.lbstream.Name = "lbstream";
            this.lbstream.Size = new System.Drawing.Size(1284, 89);
            this.lbstream.TabIndex = 4;
            this.lbstream.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbstream_MouseDoubleClick);
            // 
            // mtc
            // 
            this.mtc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtc.Controls.Add(this.tabPage1);
            this.mtc.Controls.Add(this.tabPage2);
            this.mtc.Depth = 0;
            this.mtc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtc.Location = new System.Drawing.Point(1, 111);
            this.mtc.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtc.Name = "mtc";
            this.mtc.SelectedIndex = 0;
            this.mtc.Size = new System.Drawing.Size(974, 277);
            this.mtc.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lbNews);
            this.tabPage1.Controls.Add(this.lbstream);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lvTopseries);
            this.tabPage2.Controls.Add(this.lvTopmovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(966, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BackColor = System.Drawing.Color.Yellow;
            this.materialTabSelector2.BaseTabControl = null;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(878, 75);
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
            this.materialTabSelector3.Location = new System.Drawing.Point(857, 93);
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
            this.lvTopmovies.GridLines = true;
            this.lvTopmovies.HideSelection = false;
            this.lvTopmovies.Location = new System.Drawing.Point(3, 3);
            this.lvTopmovies.Name = "lvTopmovies";
            this.lvTopmovies.Size = new System.Drawing.Size(486, 241);
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
            this.lvTopseries.HideSelection = false;
            this.lvTopseries.Location = new System.Drawing.Point(492, 3);
            this.lvTopseries.Name = "lvTopseries";
            this.lvTopseries.Size = new System.Drawing.Size(474, 241);
            this.lvTopseries.TabIndex = 1;
            this.lvTopseries.UseCompatibleStateImageBehavior = false;
            this.lvTopseries.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvTopseries_MouseDoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 0;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 389);
            this.Controls.Add(this.mfbtops);
            this.Controls.Add(this.mfbnbo);
            this.Controls.Add(this.materialTabSelector3);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.mtc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imdb Scraper";
            this.DoubleClick += new System.EventHandler(this.Main_DoubleClick);
            this.mtc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbNews;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListBox lbstream;
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
    }
}