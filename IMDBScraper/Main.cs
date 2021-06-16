using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IMDBScraper
{
    public partial class Main : MaterialSkin.Controls.MaterialForm
    {
        public Main()
        {
            InitializeComponent();
            var skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Yellow400, MaterialSkin.Primary.BlueGrey900,
                MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.BLACK);
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.imdb.com/chart/top/?ref_=nv_mv_250") ;
            var myear = doc.DocumentNode.SelectNodes("//span[@class='secondaryInfo']");
            var mrating = doc.DocumentNode.SelectNodes("//tr/td[contains(@class,'ratingColumn imdbRating')]");
            var mtitle = doc.DocumentNode.SelectNodes("//td[contains(@class,'titleColumn')]/a");
            var link = doc.DocumentNode.SelectNodes("//td[@class='titleColumn']/a/@href");
            //getNews();
            // getTopMovies();
            //getTopSeries();
            //fillwishlist();
            //getBoxOffice();
            getscraped();
        }

        public void getTopMovies()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.imdb.com/chart/top/?ref_=nv_mv_250");
            var myear = doc.DocumentNode.SelectNodes("//span[@class='secondaryInfo']");
            var mrating = doc.DocumentNode.SelectNodes("//tr/td[contains(@class,'ratingColumn imdbRating')]");
            var mtitle = doc.DocumentNode.SelectNodes("//td[contains(@class,'titleColumn')]/a");
            foreach (var item in mtitle)
            {
                Console.WriteLine(item.InnerText.ToString().TrimStart().TrimEnd());
            }
            List<string> links = new List<string>();
            foreach (var item in mtitle)
            {
                var val = item.Attributes["href"].Value; //10743
                links.Add("https://www.imdb.com/" + val.ToString().TrimStart().TrimEnd());
            }
            lvTopmovies.View = View.Details;
            for (int i = 0; i < mtitle.Count; i++)
            {
                var lvi = lvTopmovies.Items.Add(mtitle[i].InnerText.ToString());
                lvi.SubItems.Add(mrating[i].InnerText.ToString());
                lvi.SubItems.Add(myear[i].InnerText.ToString());
                lvi.SubItems.Add(links[i].ToString());
            }
        }
        public void getTopSeries()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.imdb.com/chart/toptv/?ref_=nv_tvv_250");
            var myear = doc.DocumentNode.SelectNodes("//span[@class='secondaryInfo']");
            var mrating = doc.DocumentNode.SelectNodes("//tr/td[contains(@class,'ratingColumn imdbRating')]");
            var mtitle = doc.DocumentNode.SelectNodes("//td[contains(@class,'titleColumn')]/a");
            foreach (var item in mtitle)
            {
                //Console.WriteLine(item.InnerText.ToString().TrimStart().TrimEnd());
            }
            List<string> links = new List<string>();
            foreach (var item in mtitle)
            {
                var val = item.Attributes["href"].Value; //10743
                links.Add("https://www.imdb.com/" + val.ToString().TrimStart().TrimEnd());
            }
            lvTopseries.View = View.Details;
            for (int i = 0; i < mtitle.Count; i++)
            {
                var lvi = lvTopseries.Items.Add(mtitle[i].InnerText.ToString());
                lvi.SubItems.Add(mrating[i].InnerText.ToString());
                lvi.SubItems.Add(myear[i].InnerText.ToString());
                lvi.SubItems.Add(links[i].ToString());
            }
        }
        public void getNews()
        {
            var chromeOptions = new ChromeOptions();//δημιουργια αντικειμενου για να περασουμε τις επιλογες που θελουμε για το chrome driver
            chromeOptions.AddArguments("headless");//επιλογη ωστε το chrome driver να δουλευει χωρις κεφαλη
            var experimentalFlags = new List<string>();
            string mediasrc = "";//μεταβλητη που θα την γεμισουμε μετα
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;//κρυψιμο του prompt του selenium
            ChromeDriver driver = new ChromeDriver(driverService, chromeOptions);//δημιουργια chrome driver αντικειμενου και περασμα παραμετρων
            driver.Navigate().GoToUrl("https://www.imdb.com/");
            chromeOptions.AddLocalStatePreference("browser.enabled_labs_experiments",
                experimentalFlags);
            var cookies = driver.Manage().Cookies.AllCookies;
            List<IWebElement> headline = driver.FindElements(By.ClassName("headline")).ToList();//κομβος που παιρνει τις  μερες
            List<IWebElement> pdate = driver.FindElements(By.ClassName("publicationDate")).ToList();
            List<IWebElement> source = driver.FindElements(By.ClassName("source")).ToList();
            List<IWebElement> nitem = driver.FindElements(By.XPath("//a[contains(@class,'NewsItem__Container')]")).ToList();
            string[] links = new string[headline.Count];
            for(int j=0;j<nitem.Count;j++)
            {
                string url = nitem[j].GetAttribute("href");
                var link = nitem[j].ToString().Split("\t\n ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www.") || s.StartsWith("https://"));
                links[j] = url.Trim();
            }

            for (int i = 0; i < headline.Count; i++)
            {
                string s = headline[i].Text + " \n |" + pdate[i].Text  +" | " + source[i].Text + " | " + links[i];
                lbNews.Items.Add(s);
                s = "";
            }
            driver.Quit();
        }
        private void getBoxOffice()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.imdb.com/chart/boxoffice/?ref_=nv_ch_cht");
            var mtitle = doc.DocumentNode.SelectNodes("//td[contains(@class,'titleColumn')]/a");
            var mrating = doc.DocumentNode.SelectNodes("//td[contains(@class,'ratingColumn')]");
            var mgross = doc.DocumentNode.SelectNodes("//span[contains(@class,'secondaryInfo')]");
            var weeks = doc.DocumentNode.SelectNodes("//td[contains(@class,'weeksColumn')]");
            List<string> links = new List<string>();
            foreach (var item in mtitle)
            {
                var val = item.Attributes["href"].Value; //10743
                links.Add("https://www.imdb.com/" + val.ToString().TrimStart().TrimEnd());
            }
            lvNews.Items.Clear();
           
            lvNews.View = View.Details; //make column headings visible
            for(int i=0;i<mtitle.Count;i++) //item has strings for each column of one row
            {
                ListViewItem lvi = new ListViewItem(mtitle[i].InnerText);
                lvi.SubItems.Add(mrating[i].InnerText);
                lvi.SubItems.Add(mgross[i].InnerText);
                lvi.SubItems.Add(weeks[i].InnerText);
                // add the listviewitem to a new row of the ListView control
                lvNews.Items.Add(lvi); //show Text1 in column1, Text2 in col2
            }
        }
        private void lbstream_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var list = (ListBox)sender;

            // This is your selected item
            object item = list.SelectedItem;
            var link = item.ToString().Split("\t\n ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Where(s => s.StartsWith("http://") || s.StartsWith("www.") || s.StartsWith("https://"));
            System.Diagnostics.Process.Start(link.ToString());
            MessageBox.Show(link.ToString());
        }

        private void Main_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void lbNews_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void lbNews_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index == 2) e.ItemHeight = 54;
        }

        private void lbNews_DrawItem(object sender, DrawItemEventArgs e)
        {
        }

        private void materialTabSelector3_Click(object sender, EventArgs e)
        {

        }

        private void mfbtops_Click(object sender, EventArgs e)
        {
            mtc.SelectedIndex = 1;
        }

        private void mfbnbo_Click(object sender, EventArgs e)
        {
            mtc.SelectedIndex = 0;
        }

        private void lvTopmovies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvTopmovies.SelectedItems.Count == 0)
                return;
            string link = "";
            ListViewItem item = lvTopmovies.SelectedItems[0];
            link = item.SubItems[3].Text;
            System.Diagnostics.Process.Start(link);
        }

        private void lvTopseries_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvTopseries.SelectedItems.Count == 0)
                return;
            string link = "";
            ListViewItem item = lvTopseries.SelectedItems[0];
            link = item.SubItems[3].Text;
            System.Diagnostics.Process.Start(link);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }
        public void fillwishlist()
        {
            lvWishlist.Items.Clear();
            lvWishlist.View = View.Details;
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kostas\source\repos\IMDBScraper\IMDBScraper\ScrapDBIMDB.mdf;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Wishlist", con))
                {
                    //Fill the DataTable with records from Table.
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    //Loop through the DataTable.
                    foreach (DataRow row in dt.Rows)
                    {
                        //Add Item to ListView.
                        ListViewItem item = new ListViewItem(row["Id"].ToString());
                        item.SubItems.Add(row["Title"].ToString());
                        item.SubItems.Add(row["Rating"].ToString());
                        item.SubItems.Add(row["Year"].ToString());
                        item.SubItems.Add(row["Link"].ToString());
                        lvWishlist.Items.Add(item);
                    }     
                }
            }
            lvWishlist.Refresh();
        }
        private void addToWishlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTopseries.SelectedItems.Count == 0)
                return;
            string link = "";
            string title = "";
            string rating = "";
            string year = "";
            ListViewItem item = lvTopseries.SelectedItems[0];
            title = item.SubItems[0].Text;
            rating =  item.SubItems[1].Text;
            year= item.SubItems[2].Text;
            link = item.SubItems[3].Text;
            lvWishlist.View = View.Details;
            
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kostas\source\repos\IMDBScraper\IMDBScraper\ScrapDBIMDB.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String squery = "SELECT COUNT(*) FROM dbo.Wishlist WHERE [Title] = @Title ";
                var result = 0;
                using (SqlCommand command = new SqlCommand(squery, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    result = (Int32)command.ExecuteScalar();
                }
                if (result == 0)
                {
                    String query = "INSERT INTO dbo.Wishlist (Title,Rating,Year,Link) VALUES (@Title,@Rating, @Year, @Link)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Rating", rating);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@Link", link);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Η εγγραφή υπάρχει ήδη στο Wishlist", "Προσοχή!");
                }
                connection.Close();
            }
           
            fillwishlist();     
        }

        private void mfbWishlist_Click(object sender, EventArgs e)
        {
            mtc.SelectedIndex = 3;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void lbNews_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;
            object item = list.SelectedItem;
            //Match match = Regex.Match(item.ToString(), @"http://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?");
            List<string> list2 = new List<string>();
            Regex urlRx = new Regex(@"((https?|ftp|file)\://|www.)[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*", RegexOptions.IgnoreCase);

            MatchCollection matches = urlRx.Matches(item.ToString());
            string urltogo = "";
            foreach (Match match in matches)
            {
                Console.WriteLine("m value -" + match.Value);
                urltogo = match.Value;
            }
            System.Diagnostics.Process.Start(urltogo);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lvWishlist_DoubleClick(object sender, EventArgs e)
        {
            if (lvWishlist.SelectedItems.Count == 0)
                return;
            string link = "";
            ListViewItem item = lvWishlist.SelectedItems[0];
            link = item.SubItems[4].Text;
            System.Diagnostics.Process.Start(link);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvTopmovies.SelectedItems.Count == 0)
                return;
            string link = "";
            string title = "";
            string rating = "";
            string year = "";
            ListViewItem item = lvTopmovies.SelectedItems[0];
            title = item.SubItems[0].Text;
            rating = item.SubItems[1].Text;
            year = item.SubItems[2].Text;
            link = item.SubItems[3].Text;
            lvWishlist.View = View.Details;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kostas\source\repos\IMDBScraper\IMDBScraper\ScrapDBIMDB.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String squery = "SELECT COUNT(*) FROM dbo.Wishlist WHERE [Title] = @Title ";
                var result = 0;
                using (SqlCommand command = new SqlCommand(squery, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    result = (Int32)command.ExecuteScalar();
                }
                if (result == 0)
                {
                    String query = "INSERT INTO dbo.Wishlist (Title,Rating,Year,Link) VALUES (@Title,@Rating, @Year, @Link)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Rating", rating);
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@Link", link);
                        command.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Η εγγραφή υπάρχει ήδη στο Wishlist", "Προσοχή!");
                }
                connection.Close();
            }
            fillwishlist();
        }

        private void mfbScrap_Click(object sender, EventArgs e)
        {
            mtc.SelectedIndex = 2;
        }

        private void btnScrap_Click(object sender, EventArgs e)
        {
            if (txtScraped.Text.StartsWith("https://www.imdb.com/title/") && txtScraped.Text.Length>0)
            {
                getscraped();
            }
            else
            {
                MessageBox.Show("Εισάγατε λάθος link","Προσοχή!");
            }
        }
        void getscraped()
        {
            try
            {
                string s = txtScraped.Text;
                HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.LoadFromBrowser(s);
                var mheader = doc.DocumentNode.SelectSingleNode("//h1[contains(@data-testid,'hero-title-block__title')]");
                var mdesc = doc.DocumentNode.SelectSingleNode("//span[contains(@data-testid,'plot-xs')]");
                var mrating = doc.DocumentNode.SelectNodes("//div[contains(@data-testid,'genres')]/a");
                var mrate = doc.DocumentNode.SelectSingleNode("//div[contains(@data-testid,'hero-title-block__aggregate-rating__score')]/span");
                var mphotolink = doc.DocumentNode.SelectSingleNode("//a[contains(@class,'ipc-lockup-overlay')]");
                Thread.Sleep(2000);
                var link = doc.DocumentNode
                      .Descendants("a")
                      .First(x => x.Attributes["class"] != null
                               && x.Attributes["class"].Value == "ipc-lockup-overlay ipc-focusable");
                string hrefValue = link.Attributes["href"].Value;
                Console.WriteLine("Title " + mheader.InnerText + "Rate " + mrate.InnerText);
                List<string> links = new List<string>();
                Console.WriteLine("Desc : " + mdesc.InnerText);
                foreach (var item in mrating)
                {
                    Console.WriteLine("Genre " + item.InnerText);
                    lblGenre.Text += item.InnerText + "\n";
                }
                string linkforpicbox = "https://www.imdb.com" + hrefValue;
                lblTitle.Text = mheader.InnerText;
                lblRate.Text = mrate.InnerText + "/10";
                rtbDesc.Text = mdesc.InnerText;
                var chromeOptions = new ChromeOptions();//δημιουργια αντικειμενου για να περασουμε τις επιλογες που θελουμε για το chrome driver
                //chromeOptions.AddArguments("headless");//επιλογη ωστε το chrome driver να δουλευει χωρις κεφαλη
                chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.cookies", 2);
                var experimentalFlags = new List<string>();
                string mediasrc = "";//μεταβλητη που θα την γεμισουμε μετα
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;//κρυψιμο του prompt του selenium
                ChromeDriver driver = new ChromeDriver(driverService, chromeOptions);//δημιουργια chrome driver αντικειμενου και περασμα παραμετρων

                chromeOptions.AddLocalStatePreference("browser.enabled_labs_experiments",
                    experimentalFlags);

                driver.Navigate().GoToUrl("https://www.google.gr/imghp?hl=el&ogbl");
                Thread.Sleep(2000);
                var cookies = driver.Manage().Cookies.AllCookies;

                var txt = driver.FindElement(By.Name("q"));
                txt.SendKeys(mheader.InnerText);
                driver.FindElement(By.ClassName("Tg7LZd")).Click();
                IWebElement l = driver.FindElement(By.XPath("//a[@rel='noopener']"));
                //getAttribute() to get src of image
                Thread.Sleep(2000);
                Console.WriteLine("Src attribute is: " + l.GetAttribute("href"));
                string aa = l.GetAttribute("src");
                picboxScraped.Load("https://img.cineplexx.gr/media/gr/inc/movies_licences/AQuietPlace2_Plakat.jpg");
            }
            catch (System.UriFormatException ex) { }
        }
    }
}
