using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;

namespace mp3_v1
{
    public static class MyBass
    {
        /// <summary>
        /// Частота дикритизации
        /// </summary>
        public static int DiscritisationBass = 44100;

        /// <summary>
        /// Состояние инициализации библиотеки
        /// </summary>
        public static bool InitDefaultDevice;

        /// <summary>
        /// Поток(канал)
        /// </summary>
        public static int Stream;

        /// <summary>
        /// Громкость
        /// </summary>
        public static int Volume = 20;

        /// <summary>
        /// Канал остановлен вручную
        /// </summary>
        private static bool isStoped = true;

        /// <summary>
        /// Плейлист закончен
        /// </summary>
        public static bool EndPlayList;

        private static readonly List<int> BassPlaginsHandles = new List<int>();
        /// <summary>
        /// Инициализация библиотеки
        /// </summary>
        /// <param name="DiscritisationBass"></param>
        /// <returns></returns>
        public static bool InitBass (int DiscritisationBass)
        {
            if (InitDefaultDevice==false)
            {
                InitDefaultDevice = Bass.BASS_Init(-1,DiscritisationBass, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                if (InitDefaultDevice)
                {
                    BassPlaginsHandles.Add(Bass.BASS_PluginLoad(MainClass.AppPath + @"plugins\bass_aac.dll"));
                    BassPlaginsHandles.Add(Bass.BASS_PluginLoad(MainClass.AppPath + @"plugins\bass_ac3.dll"));
                    BassPlaginsHandles.Add(Bass.BASS_PluginLoad(MainClass.AppPath + @"plugins\bass_ape.dll"));
                    BassPlaginsHandles.Add(Bass.BASS_PluginLoad(MainClass.AppPath + @"plugins\bass_mpc.dll"));
                    BassPlaginsHandles.Add(Bass.BASS_PluginLoad(MainClass.AppPath + @"plugins\bass_tta.dll"));
                    BassPlaginsHandles.Add(Bass.BASS_PluginLoad(MainClass.AppPath + @"plugins\bassalac.dll"));
                    BassPlaginsHandles.Add(Bass.BASS_PluginLoad(MainClass.AppPath + @"plugins\bassflac.dll"));
                    BassPlaginsHandles.Add(Bass.BASS_PluginLoad(MainClass.AppPath + @"plugins\bassopus.dll"));
                    BassPlaginsHandles.Add(Bass.BASS_PluginLoad(MainClass.AppPath + @"plugins\basswma.dll"));
                    BassPlaginsHandles.Add(Bass.BASS_PluginLoad(MainClass.AppPath + @"plugins\basswv.dll"));

                    int ErrorCount = 0;
                    for (int i = 0; i < BassPlaginsHandles.Count; i++)
                    {
                        if (BassPlaginsHandles[i]==0)
                        {
                            ErrorCount++;
                        }
                        if (ErrorCount!=0)
                        {
                            MessageBox.Show("Не все плагины были загружены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        ErrorCount = 0;
                    }
                }
            }
            return InitDefaultDevice;
        }
        /// <summary>
        /// Воспроизведение потока
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="vol"></param>
        public static void Play(string filename, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {


                Stop();
                if (InitBass(DiscritisationBass))
                {
                    Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (Stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
            else Bass.BASS_ChannelPlay(Stream, false);
            isStoped = false;
        }
        /// <summary>
        /// Воспроизведение на 2-ое нажатие
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="vol"></param>
        public static void Play_On_DblClick(string filename, int vol)
        {
            Stop();
            if (InitBass(DiscritisationBass))
            {
                Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                if (Stream != 0)
                {
                    Volume = vol;
                    Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100F);
                    Bass.BASS_ChannelPlay(Stream, false);
                }
            }
            isStoped = false;
        }
        /// <summary>
        ///Стоп канала
        /// </summary>
        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            isStoped = true;
        }

        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                Bass.BASS_ChannelPause(Stream);
            }
        }
        /// <summary>
        /// Получение длительности канала в секундах
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static int GetLengthofStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }
        /// <summary>
        /// Получение текущей позиции в секундах
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static int GetPosOfStream(int stream)
        {
            long position = Bass.BASS_ChannelGetPosition(stream);
            int PositionInSec = (int)Bass.BASS_ChannelBytes2Seconds(stream, position);
            return PositionInSec;
        }
        /// <summary>
        /// Установление позиции скролла
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="pos"></param>
        public static void SetScrollPosition(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }
        /// <summary>
        /// Установка громкости
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="volume"></param>
       public static void SetVolumeStream(int stream,int volume)
        {
            Volume = volume;
            Bass.BASS_ChannelSetAttribute(stream,BASSAttribute.BASS_ATTRIB_VOL, Volume/100F);
        }
        /// <summary>
        /// Метод перехода к следующему треку
        /// </summary>
        /// <returns></returns>
        public static bool ToNextTreak()
        {
            if ((Bass.BASS_ChannelIsActive(Stream)==BASSActive.BASS_ACTIVE_STOPPED)&&(isStoped==false))
            {
                if (MainClass.Files.Count > MainClass.CurrentTrackNumber + 1)
                {
                    Play(MainClass.Files[++MainClass.CurrentTrackNumber], Volume);
                    EndPlayList = false;
                    return true;
                }
                else EndPlayList = true;
            }
            return false;
        }
        /// <summary>
        ///Метод без перехода к следующему треку(repeat)
        /// </summary>
        /// <returns></returns>
        public static bool ToThisTreak()
        {
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (isStoped == false))
            {
                if (MainClass.Files.Count > MainClass.CurrentTrackNumber)
                {
                    Play(MainClass.Files[MainClass.CurrentTrackNumber], Volume);
                    EndPlayList = false;
                    return true;
                }
                else EndPlayList = true;
            }
            return false;
        }

        public static bool RandomTreak()
        {
            int count = MainClass.Files.Count;
            int rand = -1;
            Random rd = new Random();
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (isStoped == false))
            {
                if (MainClass.Files.Count > 0)
                {
                    do
                    {
                        rand = rd.Next(0, count);
                    } while (rand == MainClass.CurrentTrackNumber);
                    Play(MainClass.Files[rand], Volume);
                    MainClass.CurrentTrackNumber = rand;
                    EndPlayList = false;
                    return true;
                }
                else EndPlayList = true;
            }
            return false;
        }

        public static void Pan(int pos)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_STOPPED)
            {
                Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_PAN, pos / 10f);
            }
            else Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_PAN, 0f);
        }

    }
}
