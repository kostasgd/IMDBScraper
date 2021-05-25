using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            
            getTopSeries();
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

        private void lbNews_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index == 2) e.ItemHeight = 54;
        }

        private void lbNews_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.DrawBackground();
            //e.Graphics.DrawString(lbNews.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
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
    }
}
