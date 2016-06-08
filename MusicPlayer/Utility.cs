using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace MusicPlayer
{
    class Utility
    {
        public static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var Return = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return Return.Replace(path, "");
        }
        public static string[] RegexToStringArr(string reg, string str, RegexOptions Option)
        {
            try
            {
                int i = 0;

                string[] Result = new string[Regex.Matches(str, reg, Option).Count];
                if (Result.Length == 0) Result = new string[1];
                foreach (Match match in Regex.Matches(str, reg, Option))
                {
                    Result[i] = match.Value;
                    i++;
                }
                return Result;
            }
            catch (Exception)
            {
                string[] Result = new string[1];
                return Result;
            }
        }
        public static string GetSource(string url)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                StreamReader reader = new StreamReader(response.GetResponseStream());
                return reader.ReadToEnd();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string GetFolder(string Path)
        {
            if (Directory.Exists(Path) == false)
                Directory.CreateDirectory(Path);
            return Path;
        }

        public static string ExtractSongTitle(string KeyWord)
        {
            string song = null;
            if (KeyWord.Contains("-")) song = KeyWord.Split('-')[1];
            else song = KeyWord;

            song = song.Trim();

            return song;
        }
        public static string ExtractSongArtist(string KeyWord)
        {
            string song = null;
            if (KeyWord.Contains("-")) song = KeyWord.Split('-')[0];

            song = song.Trim();

            return song;
        }
        public static string ExtractSongFileName(MusicInformation MusicInfo)
        {
            return MusicInfo.Artist + " - " + MusicInfo.Title + ".mp3";
        }
        public static Bitmap GetAlbumBitmapImage(string url)
        {
            try
            {
                WebRequest request =
                WebRequest.Create(
                url);
                WebResponse response = request.GetResponse();
                Stream responseStream =
                    response.GetResponseStream();
                Bitmap bitmap2 = new Bitmap(responseStream);
                return bitmap2;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public static string GetYoutubePlaySource(string URL)
        {
            string htmlSrc = "<html><head><meta charset='UTF-8'></head><body style='margin:0px;padding:0px;'><div style='margin:0px;padding:0px;'><embed src='https://www.youtube.com/v/" + URL.Split('=')[1] + "?rel=0&showinfo=0&version=3&amp;hl=ko_KR&amp;vq=hd720&autoplay=1&controls=0&frameborder=0' type='application/x-shockwave-flash' width='100%' height='100%' ='always' allowfullscreen='true'></embed></div></body></html>";
            return htmlSrc;
        }

        public static int GetDurationMP3File(string Path)
        {
            WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
            WMPLib.IWMPMedia mp3file = wmp.newMedia(Path);

            return (int)mp3file.duration;
        }
    }
}
