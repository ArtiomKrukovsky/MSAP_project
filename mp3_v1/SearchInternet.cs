using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.Net;

namespace mp3_v1
{
    public partial class SearchInternet : Form
    {
        private Point _locationmain; private int _widthMainForm;
        public SearchInternet(int x, int y, int width)
        {
            InitializeComponent();
            this.Load += SearchInternet_Load1;
            _locationmain = new Point(x, y);
            _widthMainForm = width;
            this.KeyPreview = true;
        }

        private async void SearchInternet_Load1(object sender, EventArgs e)
        {
            var t_s = this;
            await Task.Factory.StartNew(new Action(() =>
            {
                t_s.Invoke(new Action(() =>
                {
                    int widthForm2 = this.Size.Width;
                    int startPoint_left = _locationmain.X + _widthMainForm + 10;
                    int winWidth = Screen.PrimaryScreen.Bounds.Width;
                    int distance = winWidth - (startPoint_left);
                    if (distance > widthForm2)
                    {
                        this.Location = new Point(startPoint_left, _locationmain.Y);
                    }
                    else
                    {
                        this.Location = new Point(_locationmain.X - widthForm2 - 10, _locationmain.Y);
                    }
                }));
            }));
        }

        private async void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            var p = panel1 as Panel;
            await Task.Factory.StartNew(new Action(() =>
            {
                p.Invoke(new Action(() =>
                {
                    panel1.Capture = false;
                    Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                    WndProc(ref m);
                }));
            }));
        }
        ChromeDriver Browser;
        private async void SearchInternet_Load(object sender, EventArgs e)
        {
            var l = listView1 as ListView;
            await Task.Factory.StartNew(() =>
            {
                l.Invoke(new Action(() =>
                {
                    listView1.FullRowSelect = true;
                    listView1.View = View.Details;
                    listView1.Columns.Add("Sid", 0, HorizontalAlignment.Center);
                    listView1.Columns.Add("Исполнитель",170,HorizontalAlignment.Center);
                    listView1.Columns.Add("Название",187,HorizontalAlignment.Center);
                }));
            });
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://z1.fm/"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (CheckForInternetConnection())
                {
                        listView1.Enabled = false;
                        textBox1.Enabled = false;
                        button1.Enabled = false;
                        pictureBox1.Visible = true; button2.Enabled = false;
                        await Task.Factory.StartNew(() =>
                        {
                            try
                            {
                                if (Browser != null)
                                {
                                    Browser.Quit();
                                }
                                string text = textBox1.Text;
                                ChromeDriverService driverservice = ChromeDriverService.CreateDefaultService();
                                driverservice.HideCommandPromptWindow = true;
                                ChromeOptions options = new ChromeOptions();
                                options.AddArguments("--headless", "diseble-gpu");
                                Browser = new OpenQA.Selenium.Chrome.ChromeDriver(driverservice, options);

                                Dictionary<string, object> commandParameters = new Dictionary<string, object>
                                {
                                    ["behavior"] = "allow",
                                    ["downloadPath"] = @"C:\Downloads"
                                };

                                Browser.ExecuteChromeCommand("Page.setDownloadBehavior", commandParameters);

                                Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                                Browser.Navigate().GoToUrl("https://z1.fm/");
                                IWebElement SearchEl = Browser.FindElement(By.Id("topkeywords"));
                                SearchEl.SendKeys(@text + OpenQA.Selenium.Keys.Enter);
                            }
                            catch { MessageBox.Show("Произшла ошибка загрузки браузер, проверьте подключению к Интернету и наличие браузре Chrome!", "Произошла ошибка :(", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        });
                    
                    try
                    {
                        List<IWebElement> Artists = null; List<IWebElement> Name_Songs = null; List<IWebElement> Sid = null;
                        //ctrl+f - открыть cssselector в браузере

                        Task[] T_search_artist_name = new Task[3]
                        {
                    new Task(()=>
                    {
                        try{
                        Artists = Browser.FindElements(By.CssSelector(".whb_wrap .songs-list .songs-list-item .song-artist a")).ToList();
                        }catch{ }
                    }),
                    new Task(()=>
                    {
                        try{
                        Name_Songs = Browser.FindElements(By.CssSelector(".whb_wrap .songs-list .songs-list-item .song-name a")).ToList();
                        }catch{ }
                    }),
                    new Task(()=>
                    {
                        try{
                        Sid = Browser.FindElements(By.CssSelector(".whb_wrap .songs-list .songs-list-item .song-menu span.song-download.btn4.download")).ToList();
                        }catch{ }
                    })
                        };
                        foreach (Task t in T_search_artist_name) t.Start();
                        Task.WaitAll(T_search_artist_name);

                        listView1.Items.Clear();
                        var l = listView1 as ListView;
                        await Task.Factory.StartNew(() =>
                        {
                            try
                            {
                                for (int i = 0; i < Artists.Count; i++)
                                {
                                    ListViewItem item = new ListViewItem(new string[]
                                    {
                                    Convert.ToString(Sid[i].GetAttribute("data-sid")),
                                    Convert.ToString(Artists[i].Text),
                                    Convert.ToString(Name_Songs[i].Text)
                                    });
                                    l.Invoke(new Action(() =>
                                    {
                                        listView1.Items.Add(item);
                                    }));
                                }
                            }
                            catch { }
                        });
                        button1.Enabled = true; textBox1.Enabled = true; pictureBox1.Visible = false; listView1.Enabled = true; button2.Enabled = true;
                    }
                    catch { MessageBox.Show("Произшла ошибка загрузки браузер, проверьте подключению к Интернету и наличие браузре Chrome!", "Произошла ошибка :(", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                else MessageBox.Show("Отсутствует подключение к Интернету");
            }
            else MessageBox.Show("Введите песню или исполнителя, чтобы осуществить поиск");
        }

        private async void playStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0 && CheckForInternetConnection())
                {
                    await Task.Factory.StartNew(() =>
                    {
                        var l = listView1 as ListView;
                        l.Invoke(new Action(() =>
                        {
                            int index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                            int previndex = 0;
                            if (index != 0)
                            {
                                previndex = index - 1;
                            }
                            string prevsid = listView1.Items[previndex].SubItems[0].Text;
                            string sid = listView1.Items[index].SubItems[0].Text;
                        //воспроизвести
                        IJavaScriptExecutor js = (IJavaScriptExecutor)Browser;
                            IWebElement buttonprev_play = Browser.FindElement(By.CssSelector(".whb_wrap .songs-list .songs-list-item [data-sid=\"" + prevsid + "\"].song-play.btn4.play"));
                            IWebElement button_play = Browser.FindElement(By.CssSelector(".whb_wrap .songs-list .songs-list-item [data-sid=\"" + sid + "\"].song-play.btn4.play"));
                            if (index != 0)
                            {
                                js.ExecuteScript("arguments[0].scrollIntoView(true);", buttonprev_play);
                            }
                            else
                            {
                                js.ExecuteScript("window.scrollTo(0, -document.body.scrollHeight);");
                            }
                            button_play.Click();
                        }));
                    });
                }
            }
            catch { MessageBox.Show("Извините, на данный момент проигрывание недоступно :(", "Произшла ошибка загрузки, проверьте подключению к Интернету!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private async void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0 && CheckForInternetConnection())
                {
                    await Task.Factory.StartNew(() =>
                    {
                        var l = listView1 as ListView;
                        l.Invoke(new Action(() =>
                        {
                            int index = listView1.Items.IndexOf(listView1.SelectedItems[0]);
                            int previndex = 0;
                            if (index != 0)
                            {
                                previndex = index - 1;
                            }
                            string prevsid = listView1.Items[previndex].SubItems[0].Text;
                            string sid = listView1.Items[index].SubItems[0].Text;
                        //скачать
                        IJavaScriptExecutor js = (IJavaScriptExecutor)Browser;
                            IWebElement prevbutton_download = Browser.FindElement(By.CssSelector(".whb_wrap .songs-list .songs-list-item .song-menu [data-sid=\"" + prevsid + "\"].song-download.btn4.download"));
                            IWebElement button_download = Browser.FindElement(By.CssSelector(".whb_wrap .songs-list .songs-list-item .song-menu [data-sid=\"" + sid + "\"].song-download.btn4.download"));
                            if (index != 0)
                            {
                                js.ExecuteScript("arguments[0].scrollIntoView(true);", prevbutton_download);
                            }
                            else
                            {
                                js.ExecuteScript("window.scrollTo(0, -document.body.scrollHeight);");
                            }
                            button_download.Click();
                        }));
                    });
                }
            }
            catch { MessageBox.Show("Извините, на данный момент скачивание недоступно :(", "Произшла ошибка загрузки, проверьте подключению к Интернету!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void SearchInternet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Browser != null)
            {
                Browser.Quit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            do
            {
                Thread.Sleep(59);
                this.Opacity -= 0.2;
            } while (this.Opacity > 0);
            Close();
        }

        private void SearchInternet_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Space&& e.Shift)
            {
                button1.PerformClick();// имитируем нажатие button1
            }
        }
    }
}
