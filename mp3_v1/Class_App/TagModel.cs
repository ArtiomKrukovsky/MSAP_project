using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass.AddOn.Tags;

namespace mp3_v1
{
    public class TagModel
    {
        public int BitRate;
        public int Freq;
        public string Channels;
        public string Artist;
        public string Album;
        public string Title;
        public string Year;

        Dictionary<int, string> ChannelsDict = new Dictionary<int, string>()
        {
            {0,"Null" },
            {1,"Mono" },
            {2,"Stereo" }
        };
        /// <summary>
        /// Загрузка тегов
        /// </summary>
        /// <param name="file"></param>
        public TagModel(string file)
        {
            try
            {
                TAG_INFO tag_info = new TAG_INFO();
                tag_info = BassTags.BASS_TAG_GetFromFile(file);
                BitRate = tag_info.bitrate;
                Freq = tag_info.channelinfo.freq;
                Channels = ChannelsDict[tag_info.channelinfo.chans];
                Artist = tag_info.artist;
                Album = tag_info.album;
                if (tag_info.title == "")
                {
                    Title = MainClass.GetFileName(file);
                }
                else Title = tag_info.title;
                Year = tag_info.year;
            }catch(Exception)
            {
                MainClass.Files.Clear();
            }
        }
    }
}
