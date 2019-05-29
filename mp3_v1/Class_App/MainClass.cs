using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mp3_v1
{

    public static class MainClass
    {
        public static Form1 Link;
        /// <summary>
        /// Путь к программе
        /// </summary>
        public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;
        /// <summary>
        /// Список полных имён файлов
        /// </summary>
        public static List<string> Files = new List<string>();
        /// <summary>
        /// Текущая позиция трека в плейлисте
        /// </summary>
        public static int CurrentTrackNumber;

        /// <summary>
        /// Получени имени трека
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static string GetFileName(string file)
        {
            string[] tmp = file.Split('\\');
            return tmp[tmp.Length - 1];
        }
        /// <summary>
        /// Фильты для для открытия 1 трека
        /// </summary>
        public static void SetInputFormats()
        {
            Link.openFileDialog1.Filter = "Все форматы|*.mp3; *.m4a; *.mp4; *.tta; *.alac; *.ogg; *.opus; *.ac3; *.ape; *.mpc; *.wv; *.wma; *.flac;";
        }

    }
}
