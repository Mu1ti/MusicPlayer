using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    struct SettingInformation
    {
        public string Skin;
        public bool AutoPlay;
        public string MusicLocation;
        public int Volume;

        public bool Looping;
        public bool Shuffle;
        public bool AutoDownload;
    }
    class Setting
    {
        /*
         * Skin = "blabla"
         * autoplay = boolean
         * MusicLocation = "blabla"
         * Volume = int
         * 
         * SystemTray = boolean
         * 
         * Hotkeys...
         */
        static string path = @".\Setting.ini";
        public static SettingInformation DefaultSetting()
        {
            SettingInformation Result = new SettingInformation();

            Result.Skin = "Default";
            Result.AutoPlay = true;
            Result.MusicLocation = @".\Music\";
            Result.Volume = 50;

            return Result;
        }
        public static SettingInformation LoadSetting()
        {
            if (!File.Exists(path)) return DefaultSetting();
            FileStream SettingFile = new FileStream(path, FileMode.Open);
            StreamReader read = new StreamReader(SettingFile);
            StreamWriter write = new StreamWriter(SettingFile);
            SettingInformation Result = new SettingInformation();

            Result.Skin = read.ReadLine().Split('=')[1].Trim();
            Result.AutoPlay = Convert.ToBoolean(read.ReadLine().Split('=')[1]);
            Result.MusicLocation = read.ReadLine().Split('=')[1].Trim();
            Result.Volume = Convert.ToInt32(read.ReadLine().Split('=')[1].Trim());

            return Result;
        }
        public static void SaveSetting(SettingInformation SettingInfo)
        {
            if (File.Exists(path)) File.Delete(path);
            FileStream SettingFIle = new FileStream(path, FileMode.Create);
            StreamReader read = new StreamReader(SettingFIle);
            StreamWriter write = new StreamWriter(SettingFIle);

            write.AutoFlush = true;

            write.WriteLine("Skin = " + SettingInfo.Skin);
            write.WriteLine("Autoplay = " + SettingInfo.AutoPlay.ToString());
            write.WriteLine("MusicLocation = " + SettingInfo.MusicLocation);
            write.WriteLine("Volume = " + SettingInfo.Volume.ToString());

        }

    }
}
