namespace mp3_v1
{
    partial class Equalizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equalizer));
            this.Panel_BG = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ColorSlider_Balance = new MB.Controls.ColorSlider();
            this.checkBox_ON = new System.Windows.Forms.CheckBox();
            this.colorSlider7 = new MB.Controls.ColorSlider();
            this.colorSlider6 = new MB.Controls.ColorSlider();
            this.colorSlider5 = new MB.Controls.ColorSlider();
            this.colorSlider4 = new MB.Controls.ColorSlider();
            this.colorSlider3 = new MB.Controls.ColorSlider();
            this.colorSlider2 = new MB.Controls.ColorSlider();
            this.colorSlider1 = new MB.Controls.ColorSlider();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Panel_BG.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_BG
            // 
            this.Panel_BG.BackColor = System.Drawing.Color.DimGray;
            this.Panel_BG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_BG.BackgroundImage")));
            this.Panel_BG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_BG.Controls.Add(this.label2);
            this.Panel_BG.Controls.Add(this.label1);
            this.Panel_BG.Controls.Add(this.ColorSlider_Balance);
            this.Panel_BG.Controls.Add(this.checkBox_ON);
            this.Panel_BG.Controls.Add(this.colorSlider7);
            this.Panel_BG.Controls.Add(this.colorSlider6);
            this.Panel_BG.Controls.Add(this.colorSlider5);
            this.Panel_BG.Controls.Add(this.colorSlider4);
            this.Panel_BG.Controls.Add(this.colorSlider3);
            this.Panel_BG.Controls.Add(this.colorSlider2);
            this.Panel_BG.Controls.Add(this.colorSlider1);
            this.Panel_BG.Controls.Add(this.btn_Exit);
            this.Panel_BG.Location = new System.Drawing.Point(0, 0);
            this.Panel_BG.Name = "Panel_BG";
            this.Panel_BG.Size = new System.Drawing.Size(554, 221);
            this.Panel_BG.TabIndex = 1;
            this.Panel_BG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_BG_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(372, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "П";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(49, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Л";
            // 
            // ColorSlider_Balance
            // 
            this.ColorSlider_Balance.BackColor = System.Drawing.Color.Transparent;
            this.ColorSlider_Balance.BarInnerColor = System.Drawing.Color.Silver;
            this.ColorSlider_Balance.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.ColorSlider_Balance.ElapsedInnerColor = System.Drawing.Color.Silver;
            this.ColorSlider_Balance.ElapsedOuterColor = System.Drawing.Color.SkyBlue;
            this.ColorSlider_Balance.LargeChange = ((uint)(5u));
            this.ColorSlider_Balance.Location = new System.Drawing.Point(59, 171);
            this.ColorSlider_Balance.Maximum = 10;
            this.ColorSlider_Balance.Minimum = -10;
            this.ColorSlider_Balance.Name = "ColorSlider_Balance";
            this.ColorSlider_Balance.Size = new System.Drawing.Size(320, 17);
            this.ColorSlider_Balance.SmallChange = ((uint)(1u));
            this.ColorSlider_Balance.TabIndex = 3;
            this.ColorSlider_Balance.Text = "colorSlider8";
            this.ColorSlider_Balance.ThumbInnerColor = System.Drawing.Color.Black;
            this.ColorSlider_Balance.ThumbOuterColor = System.Drawing.Color.Tomato;
            this.ColorSlider_Balance.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.ColorSlider_Balance.Value = 0;
            this.ColorSlider_Balance.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ColorSlider_Balance_Scroll);
            // 
            // checkBox_ON
            // 
            this.checkBox_ON.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_ON.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkBox_ON.BackgroundImage")));
            this.checkBox_ON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox_ON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ON.Location = new System.Drawing.Point(407, 36);
            this.checkBox_ON.Name = "checkBox_ON";
            this.checkBox_ON.Size = new System.Drawing.Size(37, 23);
            this.checkBox_ON.TabIndex = 2;
            this.checkBox_ON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_ON.UseVisualStyleBackColor = false;
            this.checkBox_ON.CheckedChanged += new System.EventHandler(this.checkBox_ON_CheckedChanged);
            // 
            // colorSlider7
            // 
            this.colorSlider7.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider7.BarInnerColor = System.Drawing.Color.DeepSkyBlue;
            this.colorSlider7.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider7.ElapsedInnerColor = System.Drawing.Color.Black;
            this.colorSlider7.LargeChange = ((uint)(5u));
            this.colorSlider7.Location = new System.Drawing.Point(375, 48);
            this.colorSlider7.Maximum = 10;
            this.colorSlider7.Name = "colorSlider7";
            this.colorSlider7.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorSlider7.Size = new System.Drawing.Size(16, 101);
            this.colorSlider7.SmallChange = ((uint)(1u));
            this.colorSlider7.TabIndex = 1;
            this.colorSlider7.Text = "colorSlider1";
            this.colorSlider7.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider7.Value = 10;
            this.colorSlider7.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider7_Scroll);
            // 
            // colorSlider6
            // 
            this.colorSlider6.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider6.BarInnerColor = System.Drawing.Color.DeepSkyBlue;
            this.colorSlider6.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider6.ElapsedInnerColor = System.Drawing.Color.Black;
            this.colorSlider6.LargeChange = ((uint)(5u));
            this.colorSlider6.Location = new System.Drawing.Point(320, 48);
            this.colorSlider6.Maximum = 10;
            this.colorSlider6.Name = "colorSlider6";
            this.colorSlider6.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorSlider6.Size = new System.Drawing.Size(16, 101);
            this.colorSlider6.SmallChange = ((uint)(1u));
            this.colorSlider6.TabIndex = 1;
            this.colorSlider6.Text = "colorSlider1";
            this.colorSlider6.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider6.Value = 10;
            this.colorSlider6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider6_Scroll);
            // 
            // colorSlider5
            // 
            this.colorSlider5.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider5.BarInnerColor = System.Drawing.Color.DeepSkyBlue;
            this.colorSlider5.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider5.ElapsedInnerColor = System.Drawing.Color.Black;
            this.colorSlider5.LargeChange = ((uint)(5u));
            this.colorSlider5.Location = new System.Drawing.Point(265, 48);
            this.colorSlider5.Maximum = 10;
            this.colorSlider5.Name = "colorSlider5";
            this.colorSlider5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorSlider5.Size = new System.Drawing.Size(16, 101);
            this.colorSlider5.SmallChange = ((uint)(1u));
            this.colorSlider5.TabIndex = 1;
            this.colorSlider5.Text = "colorSlider1";
            this.colorSlider5.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider5.Value = 10;
            this.colorSlider5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider5_Scroll);
            // 
            // colorSlider4
            // 
            this.colorSlider4.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider4.BarInnerColor = System.Drawing.Color.DeepSkyBlue;
            this.colorSlider4.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider4.ElapsedInnerColor = System.Drawing.Color.Black;
            this.colorSlider4.LargeChange = ((uint)(5u));
            this.colorSlider4.Location = new System.Drawing.Point(210, 48);
            this.colorSlider4.Maximum = 10;
            this.colorSlider4.Name = "colorSlider4";
            this.colorSlider4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorSlider4.Size = new System.Drawing.Size(16, 101);
            this.colorSlider4.SmallChange = ((uint)(1u));
            this.colorSlider4.TabIndex = 1;
            this.colorSlider4.Text = "colorSlider1";
            this.colorSlider4.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider4.Value = 10;
            this.colorSlider4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider4_Scroll);
            // 
            // colorSlider3
            // 
            this.colorSlider3.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider3.BarInnerColor = System.Drawing.Color.DeepSkyBlue;
            this.colorSlider3.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider3.ElapsedInnerColor = System.Drawing.Color.Black;
            this.colorSlider3.LargeChange = ((uint)(5u));
            this.colorSlider3.Location = new System.Drawing.Point(155, 48);
            this.colorSlider3.Maximum = 10;
            this.colorSlider3.Name = "colorSlider3";
            this.colorSlider3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorSlider3.Size = new System.Drawing.Size(16, 101);
            this.colorSlider3.SmallChange = ((uint)(1u));
            this.colorSlider3.TabIndex = 1;
            this.colorSlider3.Text = "colorSlider1";
            this.colorSlider3.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider3.Value = 10;
            this.colorSlider3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider3_Scroll);
            // 
            // colorSlider2
            // 
            this.colorSlider2.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider2.BarInnerColor = System.Drawing.Color.DeepSkyBlue;
            this.colorSlider2.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider2.ElapsedInnerColor = System.Drawing.Color.Black;
            this.colorSlider2.LargeChange = ((uint)(5u));
            this.colorSlider2.Location = new System.Drawing.Point(100, 48);
            this.colorSlider2.Maximum = 10;
            this.colorSlider2.Name = "colorSlider2";
            this.colorSlider2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorSlider2.Size = new System.Drawing.Size(16, 101);
            this.colorSlider2.SmallChange = ((uint)(1u));
            this.colorSlider2.TabIndex = 1;
            this.colorSlider2.Text = "colorSlider1";
            this.colorSlider2.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider2.Value = 10;
            this.colorSlider2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider2_Scroll);
            // 
            // colorSlider1
            // 
            this.colorSlider1.BackColor = System.Drawing.Color.Transparent;
            this.colorSlider1.BarInnerColor = System.Drawing.Color.DeepSkyBlue;
            this.colorSlider1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider1.ElapsedInnerColor = System.Drawing.Color.Black;
            this.colorSlider1.LargeChange = ((uint)(5u));
            this.colorSlider1.Location = new System.Drawing.Point(45, 48);
            this.colorSlider1.Maximum = 10;
            this.colorSlider1.Name = "colorSlider1";
            this.colorSlider1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.colorSlider1.Size = new System.Drawing.Size(16, 101);
            this.colorSlider1.SmallChange = ((uint)(1u));
            this.colorSlider1.TabIndex = 1;
            this.colorSlider1.Text = "colorSlider1";
            this.colorSlider1.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.colorSlider1.Value = 10;
            this.colorSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.colorSlider1_Scroll);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Exit.BackgroundImage")));
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(15, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(22, 21);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Equalizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 204);
            this.Controls.Add(this.Panel_BG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Equalizer";
            this.Text = "Equalizer";
            this.Panel_BG.ResumeLayout(false);
            this.Panel_BG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_BG;
        private MB.Controls.ColorSlider colorSlider4;
        private MB.Controls.ColorSlider colorSlider3;
        private MB.Controls.ColorSlider colorSlider2;
        private MB.Controls.ColorSlider colorSlider1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.CheckBox checkBox_ON;
        private MB.Controls.ColorSlider colorSlider7;
        private MB.Controls.ColorSlider colorSlider6;
        private MB.Controls.ColorSlider colorSlider5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MB.Controls.ColorSlider ColorSlider_Balance;
    }
}