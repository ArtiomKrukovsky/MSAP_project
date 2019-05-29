namespace mp3_v1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer_RunString = new System.Windows.Forms.Timer(this.components);
            this.Name_of_song = new System.Windows.Forms.Panel();
            this.Labl_nameofsong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Random = new System.Windows.Forms.CheckBox();
            this.Repeat = new System.Windows.Forms.CheckBox();
            this.Next_Treakbtn = new System.Windows.Forms.Button();
            this.Previous_Treakbtn = new System.Windows.Forms.Button();
            this.ValueProsent = new System.Windows.Forms.Label();
            this.LabVolume = new System.Windows.Forms.Label();
            this.Btn_Play = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.Btn_Pause = new System.Windows.Forms.Button();
            this.ScrollVolume = new MB.Controls.ColorSlider();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Time_end = new System.Windows.Forms.Label();
            this.Scroll_Time = new MB.Controls.ColorSlider();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.Time_begin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StripMenu = new System.Windows.Forms.Button();
            this.btn_zacrep = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.Name_of_song.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(85, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 20);
            this.button2.TabIndex = 10;
            this.button2.Text = "DelAll";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Поиск ";
            // 
            // timer_RunString
            // 
            this.timer_RunString.Interval = 600;
            this.timer_RunString.Tick += new System.EventHandler(this.timer_RunString_Tick);
            // 
            // Name_of_song
            // 
            this.Name_of_song.BackColor = System.Drawing.Color.Transparent;
            this.Name_of_song.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Name_of_song.BackgroundImage")));
            this.Name_of_song.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Name_of_song.Controls.Add(this.Labl_nameofsong);
            this.Name_of_song.Controls.Add(this.label1);
            this.Name_of_song.Location = new System.Drawing.Point(2, 20);
            this.Name_of_song.Name = "Name_of_song";
            this.Name_of_song.Size = new System.Drawing.Size(375, 24);
            this.Name_of_song.TabIndex = 4;
            // 
            // Labl_nameofsong
            // 
            this.Labl_nameofsong.AutoSize = true;
            this.Labl_nameofsong.BackColor = System.Drawing.SystemColors.MenuText;
            this.Labl_nameofsong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Labl_nameofsong.ForeColor = System.Drawing.Color.Red;
            this.Labl_nameofsong.Location = new System.Drawing.Point(71, 4);
            this.Labl_nameofsong.Name = "Labl_nameofsong";
            this.Labl_nameofsong.Size = new System.Drawing.Size(112, 19);
            this.Labl_nameofsong.TabIndex = 2;
            this.Labl_nameofsong.Text = "NameofSong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(316, 431);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 22);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(186, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(160, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(46, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Add.Image")));
            this.Btn_Add.Location = new System.Drawing.Point(20, 431);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(23, 23);
            this.Btn_Add.TabIndex = 3;
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Random);
            this.panel1.Controls.Add(this.Repeat);
            this.panel1.Controls.Add(this.Next_Treakbtn);
            this.panel1.Controls.Add(this.Previous_Treakbtn);
            this.panel1.Controls.Add(this.ValueProsent);
            this.panel1.Controls.Add(this.LabVolume);
            this.panel1.Controls.Add(this.Btn_Play);
            this.panel1.Controls.Add(this.Btn_Stop);
            this.panel1.Controls.Add(this.Btn_Pause);
            this.panel1.Controls.Add(this.ScrollVolume);
            this.panel1.Location = new System.Drawing.Point(3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 116);
            this.panel1.TabIndex = 12;
            // 
            // Random
            // 
            this.Random.Appearance = System.Windows.Forms.Appearance.Button;
            this.Random.BackColor = System.Drawing.Color.LightGray;
            this.Random.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Random.BackgroundImage")));
            this.Random.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Random.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Random.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Random.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Random.Location = new System.Drawing.Point(295, 41);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(23, 20);
            this.Random.TabIndex = 14;
            this.Random.UseVisualStyleBackColor = false;
            // 
            // Repeat
            // 
            this.Repeat.Appearance = System.Windows.Forms.Appearance.Button;
            this.Repeat.BackColor = System.Drawing.Color.Silver;
            this.Repeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Repeat.BackgroundImage")));
            this.Repeat.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Repeat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Repeat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Repeat.Location = new System.Drawing.Point(270, 41);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(23, 20);
            this.Repeat.TabIndex = 14;
            this.Repeat.UseVisualStyleBackColor = false;
            // 
            // Next_Treakbtn
            // 
            this.Next_Treakbtn.Location = new System.Drawing.Point(160, 82);
            this.Next_Treakbtn.Name = "Next_Treakbtn";
            this.Next_Treakbtn.Size = new System.Drawing.Size(33, 19);
            this.Next_Treakbtn.TabIndex = 13;
            this.Next_Treakbtn.Text = ">>>";
            this.Next_Treakbtn.UseVisualStyleBackColor = true;
            this.Next_Treakbtn.Click += new System.EventHandler(this.Next_Treakbtn_Click);
            // 
            // Previous_Treakbtn
            // 
            this.Previous_Treakbtn.Location = new System.Drawing.Point(121, 82);
            this.Previous_Treakbtn.Name = "Previous_Treakbtn";
            this.Previous_Treakbtn.Size = new System.Drawing.Size(33, 19);
            this.Previous_Treakbtn.TabIndex = 13;
            this.Previous_Treakbtn.Text = "<<<";
            this.Previous_Treakbtn.UseVisualStyleBackColor = true;
            this.Previous_Treakbtn.Click += new System.EventHandler(this.Previous_Treakbtn_Click);
            // 
            // ValueProsent
            // 
            this.ValueProsent.AutoSize = true;
            this.ValueProsent.BackColor = System.Drawing.Color.Transparent;
            this.ValueProsent.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueProsent.ForeColor = System.Drawing.Color.Brown;
            this.ValueProsent.Location = new System.Drawing.Point(292, 70);
            this.ValueProsent.Name = "ValueProsent";
            this.ValueProsent.Size = new System.Drawing.Size(32, 18);
            this.ValueProsent.TabIndex = 12;
            this.ValueProsent.Text = "20%";
            // 
            // LabVolume
            // 
            this.LabVolume.AutoSize = true;
            this.LabVolume.BackColor = System.Drawing.Color.Transparent;
            this.LabVolume.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabVolume.ForeColor = System.Drawing.Color.Maroon;
            this.LabVolume.Location = new System.Drawing.Point(230, 70);
            this.LabVolume.Name = "LabVolume";
            this.LabVolume.Size = new System.Drawing.Size(62, 20);
            this.LabVolume.TabIndex = 11;
            this.LabVolume.Text = "Volume";
            // 
            // Btn_Play
            // 
            this.Btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Play.BackgroundImage")));
            this.Btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Play.FlatAppearance.BorderSize = 0;
            this.Btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Play.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_Play.Location = new System.Drawing.Point(46, 70);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(38, 38);
            this.Btn_Play.TabIndex = 1;
            this.Btn_Play.UseVisualStyleBackColor = false;
            this.Btn_Play.Click += new System.EventHandler(this.Btn_Play_Click);
            this.Btn_Play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Play_MouseDown);
            this.Btn_Play.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Play_MouseUp);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Stop.BackgroundImage")));
            this.Btn_Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Stop.Location = new System.Drawing.Point(90, 81);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(22, 20);
            this.Btn_Stop.TabIndex = 2;
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Pause
            // 
            this.Btn_Pause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Pause.BackgroundImage")));
            this.Btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Pause.Location = new System.Drawing.Point(21, 81);
            this.Btn_Pause.Name = "Btn_Pause";
            this.Btn_Pause.Size = new System.Drawing.Size(22, 20);
            this.Btn_Pause.TabIndex = 8;
            this.Btn_Pause.UseVisualStyleBackColor = true;
            this.Btn_Pause.Click += new System.EventHandler(this.Btn_Pause_Click);
            // 
            // ScrollVolume
            // 
            this.ScrollVolume.BackColor = System.Drawing.Color.Transparent;
            this.ScrollVolume.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.ScrollVolume.ElapsedInnerColor = System.Drawing.Color.Blue;
            this.ScrollVolume.ElapsedOuterColor = System.Drawing.Color.Navy;
            this.ScrollVolume.LargeChange = ((uint)(5u));
            this.ScrollVolume.Location = new System.Drawing.Point(234, 88);
            this.ScrollVolume.Name = "ScrollVolume";
            this.ScrollVolume.Size = new System.Drawing.Size(89, 13);
            this.ScrollVolume.SmallChange = ((uint)(1u));
            this.ScrollVolume.TabIndex = 6;
            this.ScrollVolume.Text = "colorSlider2";
            this.ScrollVolume.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.ScrollVolume.Value = 20;
            this.ScrollVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider2_Scroll);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Time_end);
            this.panel3.Controls.Add(this.Scroll_Time);
            this.panel3.Controls.Add(this.PlayList);
            this.panel3.Controls.Add(this.Time_begin);
            this.panel3.Location = new System.Drawing.Point(-11, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 297);
            this.panel3.TabIndex = 18;
            // 
            // Time_end
            // 
            this.Time_end.AutoSize = true;
            this.Time_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_end.ForeColor = System.Drawing.Color.Red;
            this.Time_end.Location = new System.Drawing.Point(305, 24);
            this.Time_end.Name = "Time_end";
            this.Time_end.Size = new System.Drawing.Size(55, 15);
            this.Time_end.TabIndex = 7;
            this.Time_end.Text = "00:00:00";
            // 
            // Scroll_Time
            // 
            this.Scroll_Time.BackColor = System.Drawing.Color.Transparent;
            this.Scroll_Time.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.Scroll_Time.ElapsedInnerColor = System.Drawing.Color.Red;
            this.Scroll_Time.LargeChange = ((uint)(5u));
            this.Scroll_Time.Location = new System.Drawing.Point(31, 3);
            this.Scroll_Time.Name = "Scroll_Time";
            this.Scroll_Time.Size = new System.Drawing.Size(321, 23);
            this.Scroll_Time.SmallChange = ((uint)(1u));
            this.Scroll_Time.TabIndex = 5;
            this.Scroll_Time.Text = "colorSlider1";
            this.Scroll_Time.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.Scroll_Time.Value = 0;
            this.Scroll_Time.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Scroll_Time_Scroll);
            // 
            // PlayList
            // 
            this.PlayList.AllowDrop = true;
            this.PlayList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PlayList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayList.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PlayList.FormattingEnabled = true;
            this.PlayList.ItemHeight = 19;
            this.PlayList.Location = new System.Drawing.Point(32, 51);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(315, 232);
            this.PlayList.TabIndex = 0;
            this.PlayList.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlayList_DragDrop);
            this.PlayList.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlayList_DragEnter);
            this.PlayList.DoubleClick += new System.EventHandler(this.PlayList_DoubleClick);
            // 
            // Time_begin
            // 
            this.Time_begin.AutoSize = true;
            this.Time_begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_begin.ForeColor = System.Drawing.Color.Red;
            this.Time_begin.Location = new System.Drawing.Point(21, 24);
            this.Time_begin.Name = "Time_begin";
            this.Time_begin.Size = new System.Drawing.Size(55, 15);
            this.Time_begin.TabIndex = 7;
            this.Time_begin.Text = "00:00:00";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.StripMenu);
            this.panel2.Controls.Add(this.btn_zacrep);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.btn_Close);
            this.panel2.Location = new System.Drawing.Point(-17, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 23);
            this.panel2.TabIndex = 17;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // StripMenu
            // 
            this.StripMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StripMenu.BackgroundImage")));
            this.StripMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StripMenu.Location = new System.Drawing.Point(33, 2);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(19, 18);
            this.StripMenu.TabIndex = 1;
            this.StripMenu.UseVisualStyleBackColor = true;
            this.StripMenu.Click += new System.EventHandler(this.StripMenu_Click);
            // 
            // btn_zacrep
            // 
            this.btn_zacrep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_zacrep.BackgroundImage")));
            this.btn_zacrep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_zacrep.Location = new System.Drawing.Point(330, 2);
            this.btn_zacrep.Name = "btn_zacrep";
            this.btn_zacrep.Size = new System.Drawing.Size(19, 18);
            this.btn_zacrep.TabIndex = 0;
            this.btn_zacrep.UseVisualStyleBackColor = true;
            this.btn_zacrep.Click += new System.EventHandler(this.btn_zacrep_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(313, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(19, 18);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.BackgroundImage")));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Location = new System.Drawing.Point(347, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(19, 18);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(356, 459);
            this.Controls.Add(this.Name_of_song);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicAudioPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Name_of_song.ResumeLayout(false);
            this.Name_of_song.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Play;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Panel Name_of_song;
        private MB.Controls.ColorSlider Scroll_Time;
        private MB.Controls.ColorSlider ScrollVolume;
        private System.Windows.Forms.Label Time_begin;
        private System.Windows.Forms.Label Time_end;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_Pause;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labl_nameofsong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LabVolume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label ValueProsent;
        private System.Windows.Forms.Button Next_Treakbtn;
        private System.Windows.Forms.Button Previous_Treakbtn;
        private System.Windows.Forms.CheckBox Repeat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_zacrep;
        private System.Windows.Forms.Timer timer_RunString;
        private System.Windows.Forms.CheckBox Random;
        private System.Windows.Forms.Button StripMenu;
    }
}

