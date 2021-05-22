using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.imdb.com/") ;
            var title = doc.DocumentNode.SelectNodes("//h3[contains(@class,'title')]");
            foreach (var item in title)
            {
               // Console.WriteLine(item.InnerText.ToString());
            }


            //κομβος που παιρνει τις  μερες
            //var nbt = doc.DocumentNode.SelectNodes("//div[contains(@class,'born-today-name')]");
            //var nba = doc.DocumentNode.SelectNodes("//div[contains(@class,'born-today-age')]");

            //foreach (var item in nbt)
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            //foreach (var item in nba)
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            //getNews();
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
            List<IWebElement> pdate = driver.FindElements(By.XPath("//span[contains(@class,'ipc-rating-star ipc-rating-star--baseAlt ipc-rating-star--imdb')]")).ToList();
            foreach(var k in pdate)
            {
                Console.WriteLine(k.Text);
            }
            String columns = "{0, -55}{1, -35}{2, -35}";
            lbstream.Items.Add(String.Format(columns, "Title", "Rating", "Link"));
            lbstream.Items.Add(String.Format(columns, "LOTR", "9", "www.google.com"));
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

            for (int i=0;i< headline.Count; i++)
            {
                string s = headline[i].Text + "\n " +pdate[i].Text +" - " +source[i].Text;
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
            System.Diagnostics.Process.Start("http://google.com");
        }
    }
}
