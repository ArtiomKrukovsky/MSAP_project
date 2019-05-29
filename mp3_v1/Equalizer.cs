using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;

namespace mp3_v1
{
    public partial class Equalizer : Form
    {
        private Point _locationmain; private int _widthMainForm;
        public Equalizer()
        {
            InitializeComponent();
        }
        public async void ShowThis(int x, int y, int width)
        {
            var t_s = this;
            await Task.Factory.StartNew(new Action(() =>
            {
                t_s.Invoke(new Action(() =>
                {
                    _locationmain = new Point(x, y);
                    _widthMainForm = width;
                    int widthForm2 = this.Size.Width;
                    int startPoint = _locationmain.X + _widthMainForm + 10;
                    int winWidth = Screen.PrimaryScreen.Bounds.Width;
                    int distance_right = _locationmain.X+10;
                    if (distance_right > widthForm2)
                    {
                        this.Location = new Point(_locationmain.X - widthForm2 - 10, _locationmain.Y);
                    }
                    else
                    {
                        this.Location = new Point(startPoint, _locationmain.Y);
                    }
                }));
            }));
        }


        private async void Panel_BG_MouseDown(object sender, MouseEventArgs e)
        {
            var p = Panel_BG as Panel;
            await Task.Factory.StartNew(new Action(() =>
            {
                p.Invoke(new Action(() =>
                {
                    Panel_BG.Capture = false;
                    Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                    WndProc(ref m);
                }));
            }));
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            do
            {
                Thread.Sleep(59);
                this.Opacity -= 0.2;
            } while (this.Opacity > 0);
            Hide();
        }

        BASS_DX8_PARAMEQ p = new BASS_DX8_PARAMEQ(140f, 1f, 0f);
        int[] fx = new int[7];

        private void checkBox_ON_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ON.Checked == true)
            {
                for (int i = 0; i < fx.Length; i++)
                {
                    fx[i] = Bass.BASS_ChannelSetFX(MyBass.Stream, BASSFXType.BASS_FX_DX8_PARAMEQ, 1);
                }

                p.fGain = 15 - colorSlider1.Value;
                p.fBandwidth = 3;
                p.fCenter = 170;
                Bass.BASS_FXSetParameters(fx[0], @p);

                p.fGain = 15 - colorSlider2.Value;
                p.fBandwidth = 3;
                p.fCenter = 310;
                Bass.BASS_FXSetParameters(fx[1], @p);

                p.fGain = 15 - colorSlider3.Value;
                p.fBandwidth = 3;
                p.fCenter = 1000;
                Bass.BASS_FXSetParameters(fx[2], @p);

                p.fGain = 15 - colorSlider4.Value;
                p.fBandwidth = 3;
                p.fCenter = 3000;
                Bass.BASS_FXSetParameters(fx[3], @p);

                p.fGain = 15 - colorSlider5.Value;
                p.fBandwidth = 3;
                p.fCenter = 6000;
                Bass.BASS_FXSetParameters(fx[4], @p);

                p.fGain = 15 - colorSlider6.Value;
                p.fBandwidth = 3;
                p.fCenter = 12000;
                Bass.BASS_FXSetParameters(fx[5], @p);

                p.fGain = 15 - colorSlider7.Value;
                p.fBandwidth = 3;
                p.fCenter = 14000;
                Bass.BASS_FXSetParameters(fx[6], @p);
            }
            else
            {
                for (int i = 0; i < fx.Length; i++)
                {
                    Bass.BASS_ChannelRemoveFX(MyBass.Stream, fx[i]);
                }
            }
        }

        private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
        {
            if (Bass.BASS_FXGetParameters(fx[0], @p))
            {
                p.fGain = 15 - colorSlider1.Value;
                Bass.BASS_FXSetParameters(fx[0], @p);
            }
        }

        private void colorSlider2_Scroll(object sender, ScrollEventArgs e)
        {
            if (Bass.BASS_FXGetParameters(fx[1], @p))
            {
                p.fGain = 15 - colorSlider2.Value;
                Bass.BASS_FXSetParameters(fx[1], @p);
            }
        }

        private void colorSlider3_Scroll(object sender, ScrollEventArgs e)
        {
            if (Bass.BASS_FXGetParameters(fx[2], @p))
            {
                p.fGain = 15 - colorSlider3.Value;
                Bass.BASS_FXSetParameters(fx[2], @p);
            }
        }

        private void colorSlider4_Scroll(object sender, ScrollEventArgs e)
        {
            if (Bass.BASS_FXGetParameters(fx[3], @p))
            {
                p.fGain = 15 - colorSlider4.Value;
                Bass.BASS_FXSetParameters(fx[3], @p);
            }
        }

        private void colorSlider5_Scroll(object sender, ScrollEventArgs e)
        {
            if (Bass.BASS_FXGetParameters(fx[4], @p))
            {
                p.fGain = 15 - colorSlider5.Value;
                Bass.BASS_FXSetParameters(fx[4], @p);
            }
        }

        private void colorSlider6_Scroll(object sender, ScrollEventArgs e)
        {
            if (Bass.BASS_FXGetParameters(fx[5], @p))
            {
                p.fGain = 15 - colorSlider6.Value;
                Bass.BASS_FXSetParameters(fx[5], @p);
            }
        }

        private void colorSlider7_Scroll(object sender, ScrollEventArgs e)
        {
            if (Bass.BASS_FXGetParameters(fx[6], @p))
            {
                p.fGain = 15 - colorSlider7.Value;
                Bass.BASS_FXSetParameters(fx[6], @p);
            }
        }

        private async void ColorSlider_Balance_Scroll(object sender, ScrollEventArgs e)
        {
            await Task.Factory.StartNew(new Action(() =>
            {
                MyBass.Pan(ColorSlider_Balance.Value);
            }));
        }
    }
}
