using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace mp3_v1
{
    public partial class Form1 : Form
    {
        Equalizer equalizer;

        /// <summary>
        /// Операции при создании Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Labl_nameofsong.BackColor = Color.Transparent;
            Time_end.BackColor = Color.Transparent;
            Time_begin.BackColor = Color.Transparent;
            Labl_nameofsong.Text = "";
            MainClass.Link = this;
            this.Show();
            MyBass.InitBass(MyBass.DiscritisationBass);
            MainClass.SetInputFormats();
            RoundBorderForm(this);
            Btn_Circler();
            equalizer = new Equalizer();
        }
        private void Btn_Circler()
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
            new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, Btn_Play.Width, Btn_Play.Height);

            Region myRegion = new Region(myPath);
            Btn_Play.Region = myRegion;
        }
        /// <summary>
        /// Вывов openDialog для добавления 1 тека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        /// <summary>
        /// Добавление трека в List_Files(содержащий полный путь к треку)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] tmp = openFileDialog1.FileNames;
            for (int i = 0; i < tmp.Length; i++)
            {
                MainClass.Files.Add(tmp[i]);
                TagModel TM = new TagModel(tmp[i]);
                PlayList.Items.Add(TM.Artist + " - " + TM.Title);
            }

        }
        string name = "";// запасное имя при ошибке
        /// <summary>
        /// Кнопка Play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Play_Click(object sender, EventArgs e)
        {

            if ((PlayList.Items.Count != 0) && (PlayList.SelectedIndex != -1))
            {
                string current = MainClass.Files[PlayList.SelectedIndex];
                MainClass.CurrentTrackNumber = PlayList.SelectedIndex;
                MyBass.Play(current, MyBass.Volume);
                Time_begin.Text = TimeSpan.FromSeconds(MyBass.GetPosOfStream(MyBass.Stream)).ToString();
                Time_end.Text = TimeSpan.FromSeconds(MyBass.GetLengthofStream(MyBass.Stream)).ToString();
                Scroll_Time.Maximum = MyBass.GetLengthofStream(MyBass.Stream);
                Scroll_Time.Value = MyBass.GetPosOfStream(MyBass.Stream);
                string Panel_Name = MainClass.Files[PlayList.SelectedIndex];
                TagModel TM = new TagModel(Panel_Name);
                Labl_nameofsong.Text = (TM.Artist + " - " + TM.Title);
                name = (TM.Artist + " - " + TM.Title);
                timer1.Enabled = true;
                timer_RunString.Enabled = true;
                scrore_numbersong = 1;

            }
        }

        /// <summary>
        /// Кнопка стоп
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MyBass.Stop();
            timer1.Enabled = false;
            Scroll_Time.Value = 0;
            Time_begin.Text = "00:00:00";
        }
        /// <summary>
        /// Тайпер с переходом на следующий трек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Repeat.Checked == false && Random.Checked == false)
            {
                Time_begin.Text = TimeSpan.FromSeconds(MyBass.GetPosOfStream(MyBass.Stream)).ToString();
                Scroll_Time.Value = MyBass.GetPosOfStream(MyBass.Stream);
                if (PlayList.Items.Count != 0)
                {
                    if (MyBass.ToNextTreak())
                    {
                        PlayList.SelectedIndex = MainClass.CurrentTrackNumber;
                        Time_begin.Text = TimeSpan.FromSeconds(MyBass.GetPosOfStream(MyBass.Stream)).ToString();
                        Time_end.Text = TimeSpan.FromSeconds(MyBass.GetLengthofStream(MyBass.Stream)).ToString();
                        Scroll_Time.Maximum = MyBass.GetLengthofStream(MyBass.Stream);
                        Scroll_Time.Value = MyBass.GetPosOfStream(MyBass.Stream);
                        string Panel_Name = MainClass.Files[PlayList.SelectedIndex];
                        TagModel TM = new TagModel(Panel_Name);
                        Labl_nameofsong.Text = (TM.Artist + " - " + TM.Title);
                        name = (TM.Artist + " - " + TM.Title);
                        scrore_numbersong = 0;
                    }
                    if (MyBass.EndPlayList)
                    {
                        button2_Click(this, new EventArgs());
                        PlayList.SelectedIndex = MainClass.CurrentTrackNumber = 0;
                        MyBass.EndPlayList = false;
                    }
                }
            }
            else if (Repeat.Checked == true)
            {
                if (PlayList.Items.Count != 0)
                {
                    Time_begin.Text = TimeSpan.FromSeconds(MyBass.GetPosOfStream(MyBass.Stream)).ToString();
                    Scroll_Time.Value = MyBass.GetPosOfStream(MyBass.Stream);
                    if (MyBass.ToThisTreak())
                    {
                        PlayList.SelectedIndex = MainClass.CurrentTrackNumber;
                        Time_begin.Text = TimeSpan.FromSeconds(MyBass.GetPosOfStream(MyBass.Stream)).ToString();
                        Time_end.Text = TimeSpan.FromSeconds(MyBass.GetLengthofStream(MyBass.Stream)).ToString();
                        Scroll_Time.Maximum = MyBass.GetLengthofStream(MyBass.Stream);
                        Scroll_Time.Value = MyBass.GetPosOfStream(MyBass.Stream);
                    }
                }
                else
                {
                    button2_Click(this, new EventArgs());
                }
            }
            else if (Random.Checked == true && PlayList.Items.Count > 1)
            {
                Time_begin.Text = TimeSpan.FromSeconds(MyBass.GetPosOfStream(MyBass.Stream)).ToString();
                Scroll_Time.Value = MyBass.GetPosOfStream(MyBass.Stream);
                if (MyBass.RandomTreak())
                {
                    PlayList.SelectedIndex = MainClass.CurrentTrackNumber;
                    Time_begin.Text = TimeSpan.FromSeconds(MyBass.GetPosOfStream(MyBass.Stream)).ToString();
                    Time_end.Text = TimeSpan.FromSeconds(MyBass.GetLengthofStream(MyBass.Stream)).ToString();
                    Scroll_Time.Maximum = MyBass.GetLengthofStream(MyBass.Stream);
                    Scroll_Time.Value = MyBass.GetPosOfStream(MyBass.Stream);
                    string Panel_Name = MainClass.Files[PlayList.SelectedIndex];
                    TagModel TM = new TagModel(Panel_Name);
                    Labl_nameofsong.Text = (TM.Artist + " - " + TM.Title);
                    name = (TM.Artist + " - " + TM.Title);
                    scrore_numbersong = 0;
                }
                if (MyBass.EndPlayList)
                {
                    button2_Click(this, new EventArgs());
                    PlayList.SelectedIndex = MainClass.CurrentTrackNumber = 0;
                    MyBass.EndPlayList = false;
                }
            }
            else
            {
                if (PlayList.Items.Count != 0)
                {
                    Time_begin.Text = TimeSpan.FromSeconds(MyBass.GetPosOfStream(MyBass.Stream)).ToString();
                    Scroll_Time.Value = MyBass.GetPosOfStream(MyBass.Stream);
                    if (MyBass.ToNextTreak())
                    {
                        PlayList.SelectedIndex = MainClass.CurrentTrackNumber;
                        Time_begin.Text = TimeSpan.FromSeconds(MyBass.GetPosOfStream(MyBass.Stream)).ToString();
                        Time_end.Text = TimeSpan.FromSeconds(MyBass.GetLengthofStream(MyBass.Stream)).ToString();
                        Scroll_Time.Maximum = MyBass.GetLengthofStream(MyBass.Stream);
                        Scroll_Time.Value = MyBass.GetPosOfStream(MyBass.Stream);
                        string Panel_Name = MainClass.Files[PlayList.SelectedIndex];
                        TagModel TM = new TagModel(Panel_Name);
                        Labl_nameofsong.Text = (TM.Artist + " - " + TM.Title);
                        name = (TM.Artist + " - " + TM.Title);
                        scrore_numbersong = 0;
                    }
                    if (MyBass.EndPlayList)
                    {
                        button2_Click(this, new EventArgs());
                        PlayList.SelectedIndex = MainClass.CurrentTrackNumber = 0;
                        MyBass.EndPlayList = false;
                    }
                }
                else
                {
                    button2_Click(this, new EventArgs());
                }   
            }
        }

        /// <summary>
        /// Регулировка по ползунку врмени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Scroll_Time_Scroll(object sender, ScrollEventArgs e)
        {
            MyBass.SetScrollPosition(MyBass.Stream, Scroll_Time.Value);
        }
        /// <summary>
        /// Регулировка громкости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorSlider2_Scroll(object sender, ScrollEventArgs e)
        {
            MyBass.SetVolumeStream(MyBass.Stream, ScrollVolume.Value);
            ValueProsent.Text = Convert.ToString(ScrollVolume.Value) + "%";
        }
        /// <summary>
        /// Пауза
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Pause_Click(object sender, EventArgs e)
        {
            MyBass.Pause();
        }

        /// <summary>
        /// Кнопка удаления 1 трека из плейлиста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int initem;
            if ((PlayList.Items.Count != 0) && (PlayList.SelectedIndex != -1))
            {
                initem = PlayList.SelectedIndex;
                PlayList.Items.RemoveAt(initem);
                MainClass.Files.RemoveAt(initem);
                if (initem > PlayList.Items.Count - 1)
                    initem = PlayList.Items.Count - 1;
                PlayList.SelectedIndex = initem;
            }
        }
        /// <summary>
        /// Кнопка удаления всего плейлиста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                   "Вы действительно хотите очистить плейлист?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                PlayList.Items.Clear();
                MainClass.Files.Clear();
            }
        }
        /// <summary>
        /// Кнопка для сохранения плейлиста в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlayList.Items.Count == 0)
                {
                    DialogResult result = MessageBox.Show(
                    "Плейлист пустой, вы действительно хотите его сохранить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        SaveFileDialog savedialog = new SaveFileDialog();
                        savedialog.InitialDirectory = @"";
                        savedialog.RestoreDirectory = true;
                        savedialog.FileName = @"MyPlayList.txt";
                        savedialog.DefaultExt = @"txt";
                        savedialog.Filter = "Все форматы| (*.txt)";
                        if (savedialog.ShowDialog() == DialogResult.OK)
                        {
                            Stream filestream = savedialog.OpenFile();
                            StreamWriter writer = new StreamWriter(filestream);
                            for (int i = 0; i < MainClass.Files.Count; i++)
                            {
                                writer.WriteLine(MainClass.Files[i]);
                            }
                            writer.Close();
                        }
                    }
                    Show();
                }
                else
                {
                    SaveFileDialog savedialog = new SaveFileDialog();
                    savedialog.InitialDirectory = @"";
                    savedialog.RestoreDirectory = true;
                    savedialog.FileName = @"MyPlayList.txt";
                    savedialog.DefaultExt = @"txt";
                    savedialog.Filter = "Все форматы| (*.txt)";
                    if (savedialog.ShowDialog() == DialogResult.OK)
                    {
                        Stream filestream = savedialog.OpenFile();
                        StreamWriter writer = new StreamWriter(filestream);
                        for (int i = 0; i < MainClass.Files.Count; i++)
                        {
                            writer.WriteLine(MainClass.Files[i]);
                        }
                        writer.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка при сохранении файла, возможно вы пытаетесь пересохраить файл, который уже используется.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Кнопка загрузки плейлиста из файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"Плейлисты";
            ofd.RestoreDirectory = true;
            ofd.FileName = @"";
            ofd.Filter = "Все форматы|*.txt;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PlayList.Items.Clear();
                MainClass.Files.Clear();
                Stream filestream = ofd.OpenFile();
                StreamReader reader = new StreamReader(filestream);
                while (reader.EndOfStream == false)
                {
                    MainClass.Files.Add(reader.ReadLine());
                }
                for (int i = 0; i < MainClass.Files.Count; i++)
                {
                    string Name_AddFile = MainClass.Files[i];
                    TagModel TM = new TagModel(Name_AddFile);
                    PlayList.Items.Add(TM.Artist + " - " + TM.Title);
                }
                if (MainClass.Files.Count == 0)
                {
                    PlayList.Items.Clear();
                    MessageBox.Show("Вы загрузили недопустимый файл!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else PlayList.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// Кнопка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            PlayList.SelectedItems.Clear();
            for (int i = 0; i < PlayList.Items.Count; i++)
            {
                if (textBox1.Text != "")
                {
                    if (PlayList.Items[i].ToString().Contains(textBox1.Text))
                        PlayList.SelectedIndex = i;
                }
                else PlayList.SelectedItems.Clear();
            }
        }

        /// <summary>
        /// DragAndDrop на лист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// Добавление элементов с помощью Drag&Drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayList_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string file in files)
            {
                int CountOfEnd = MainClass.Files.Count;
                MainClass.Files.Add(file);
                string Name_AddFile = MainClass.Files[CountOfEnd];
                TagModel TM = new TagModel(Name_AddFile);
                PlayList.Items.Add(TM.Artist + " - " + TM.Title);
            }
            if (MainClass.Files.Count == 0)
            {
                PlayList.Items.Clear();
                MessageBox.Show("Вы загрузили недопустимый файл!!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else PlayList.SelectedIndex = PlayList.Items.Count - 1;
        }

        /// <summary>
        /// Кнопка перехода на следующий трек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Treakbtn_Click(object sender, EventArgs e)
        {
            if (PlayList.SelectedIndex != -1)
            {
                int n = PlayList.Items.Count;
                if (PlayList.SelectedIndex + 1 != n)
                {
                    PlayList.SelectedIndex = PlayList.SelectedIndex + 1;
                    Btn_Stop.PerformClick();
                    Btn_Play.PerformClick();
                }
            }
        }
        /// <summary>
        /// Кнопка перехода на предыдущий трек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Previous_Treakbtn_Click(object sender, EventArgs e)
        {
            if (PlayList.SelectedIndex != -1)
            {
                if (PlayList.SelectedIndex != 0)
                {
                    PlayList.SelectedIndex = PlayList.SelectedIndex - 1;
                    Btn_Stop.PerformClick();
                    Btn_Play.PerformClick();
                }
            }
        }
        /// <summary>
        /// Метод закругления краёв формы
        /// </summary>
        /// <param name="frm"></param>
        public static void RoundBorderForm(Form frm)
        {

            Rectangle Bounds = new Rectangle(0, 0, frm.Width, frm.Height);
            int CornerRadius = 25;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            frm.Region = new Region(path);
            frm.Show();
        }

        /// <summary>
        /// Кнопка выхода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Close_Click(object sender, EventArgs e)
        {
            do
            {
                Thread.Sleep(59);
                this.Opacity -= 0.2;
            } while (this.Opacity > 0);
            Application.Exit();
        }

        /// <summary>
        ///Метод закругления краёв панели1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        /// <summary>
        /// Метод перемещения формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        /// <summary>
        /// Кнопка свернуть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Закрепить окно поверх других окон
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_zacrep_Click(object sender, EventArgs e)
        {
            if (!TopMost)
                TopMost = true;
            else TopMost = false;
        }
        /// <summary>
        /// Метод при нажатии на кнопку Play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Play_MouseDown(object sender, MouseEventArgs e)
        {
            Btn_Play.Width = 36;
            Btn_Play.Height = 36;
            Btn_Circler();
        }

        /// <summary>
        /// Метод при отжатия кнопки Play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Play_MouseUp(object sender, MouseEventArgs e)
        {
            Btn_Play.Width = 38;
            Btn_Play.Height = 38;
            Btn_Circler();
        }
        private int scrore_numbersong = 0;//счётчиковая переменная отвечающая за кол-во символов в названии
        /// <summary>
        /// RuningString
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_RunString_Tick(object sender, EventArgs e)
        {
            try
            {

                string text_nameofsong = name;
                Labl_nameofsong.Text = text_nameofsong.Substring(0, scrore_numbersong);
                scrore_numbersong++;
                if (scrore_numbersong == text_nameofsong.Length + 1)
                {
                    Labl_nameofsong.Text = name;
                    scrore_numbersong = 0;
                }
            }
            catch (Exception)
            {
            };

        }
        /// <summary>
        /// Перемещение за Panel2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
        /// <summary>
        /// Play при нажатии 2 раза на плейлист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayList_DoubleClick(object sender, EventArgs e)
        {
            if ((PlayList.Items.Count != 0) && (PlayList.SelectedIndex != -1))
            {
                string current = MainClass.Files[PlayList.SelectedIndex];
                MainClass.CurrentTrackNumber = PlayList.SelectedIndex;
                MyBass.Play_On_DblClick(current, MyBass.Volume);
                Time_begin.Text = TimeSpan.FromSeconds(MyBass.GetPosOfStream(MyBass.Stream)).ToString();
                Time_end.Text = TimeSpan.FromSeconds(MyBass.GetLengthofStream(MyBass.Stream)).ToString();
                Scroll_Time.Maximum = MyBass.GetLengthofStream(MyBass.Stream);
                Scroll_Time.Value = MyBass.GetPosOfStream(MyBass.Stream);
                string Panel_Name = MainClass.Files[PlayList.SelectedIndex];
                TagModel TM = new TagModel(Panel_Name);
                Labl_nameofsong.Text = (TM.Artist + " - " + TM.Title);
                name = (TM.Artist + " - " + TM.Title);
                timer1.Enabled = true;
                timer_RunString.Enabled = true;
                scrore_numbersong = 1;

            }
        }
        ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();//Создание меню
        /// <summary>
        /// Кнопка открывавшая контекстное меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StripMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.BackColor = Color.Gray;
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.Add("О программе");
            contextMenuStrip1.Items.Add("Справка");
            contextMenuStrip1.Items.Add("-");
            contextMenuStrip1.Items.Add("Эквалайзер");
            contextMenuStrip1.Items.Add("Поиск в Интернете");
            contextMenuStrip1.Items.Add("-");
            contextMenuStrip1.Items.Add("Выход");
            contextMenuStrip1.Items[3].Image = Properties.Resources.EQ;
            contextMenuStrip1.Items[4].Image = Properties.Resources.WS;
            contextMenuStrip1.Items[6].Image = Properties.Resources.exit_icon;
            contextMenuStrip1.Show(StripMenu, new Point(0, StripMenu.Height));

        }
        SearchInternet si = null;
        /// <summary>
        /// Действия происходимы при нажатие на кнопку в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Выход")
            {
                do
                {
                    Thread.Sleep(59);
                    this.Opacity -= 0.2;
                } while (this.Opacity > 0);
                Application.Exit();
            }
            else if (e.ClickedItem.Text == "Поиск в Интернете")
            {
                FormCollection fc = Application.OpenForms;
                int i = 0;
                foreach (Form frm in fc)
                {
                    if (frm.Name == "SearchInternet")
                        i++;
                }
                if (i == 0)
                {
                    si = new SearchInternet(this.Location.X, this.Location.Y, this.Size.Width);
                    si.Show();
                }
                else
                {
                    si.WindowState = FormWindowState.Minimized;
                    si.WindowState = FormWindowState.Normal;
                }
            }
            else if (e.ClickedItem.Text == "Эквалайзер")
            {
                equalizer.Opacity = 1;
                equalizer.Show();
                equalizer.ShowThis(this.Location.X, this.Location.Y, this.Size.Width);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contextMenuStrip1_ItemClicked);
        }
    }
}
