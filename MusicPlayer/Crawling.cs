using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace MusicPlayer
{
    class Crawling
    {
        public string[,] YoutubeCrawling(string KeyWord)
        {
            /*
                유튜브 결과
                1. 노래 이름
                2. 아티스트
                3. 앨범 재킷 URL
                4. URL
            */
            string URL = "https://www.youtube.com/results?search_query=" + System.Web.HttpUtility.UrlEncode(KeyWord);
            string Source = GetSource(URL);
            string[] TitleResult = RegexToStringArr("(?<=dir=\"ltr\">).*(?=<\\/a><sp)", Source);
            string[] URLResult = RegexToStringArr("(?<=\"yt-lockup-title \"><a href=\").*(?=\" class=\"yt-uix-sessionlink yt)",Source);
            string[] PicResult = RegexToStringArr("((?<=c=\"\\/\\/).*(?=\" alt=\"\" width=))|((?<=\" alt=\"\" data-thumb=\"\\/\\/).*(?=\" w))", Source);
            string[,] Result = new string[TitleResult.Length, 5];

            for (int i = 0; URLResult.Length > i; i++) URLResult[i] = "https://www.youtube.com" + URLResult[i];
            for (int i = 0; PicResult.Length > i; i++) PicResult[i] = "https://" + PicResult[i];
            for (int i = 0; PicResult.Length > i; i++)
            {
                Downloader.DownloadRemoteImageFile(PicResult[i], @"./\YoutubePictures\" + i + ".jpg");
                PicResult[i] = @"./\YoutubePictures\" + i + ".jpg";
            }
            for (int i = 0; TitleResult.Length > i; i++)
            {
                Result[i, 0] = TitleResult[i];

                Result[i, 1] = URLResult[i];
                Result[i, 2] = PicResult[i];
            }

            return Result;
        }
        public string[,] SoundCloudCrawling(string KeyWord)
        {
            string Json = GetSource("https://api.soundcloud.com/tracks.json?client_id=a162f1f21992081b0eb58bfd70611886&client_secret=fc82d49acf4b98b64c2287cc9d187be5&q=" + System.Web.HttpUtility.UrlEncode(KeyWord));
            object Information = JsonConvert.DeserializeObject(Json);
            

            return null;
        }
        public static string[] RegexToStringArr(string reg, string str)
        {
            Regex Parsed = new Regex(reg, RegexOptions.IgnoreCase);
            MatchCollection mc = Parsed.Matches(str);
            string[] Result = new string[mc.Count];

            for (int i = 0; mc.Count > i; i++) Result[i] = System.Web.HttpUtility.HtmlDecode(mc[i].ToString());
            return Result;
        }
        public static string GetSource(string url)

        {
            HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = (request.GetResponse() as HttpWebResponse);

            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
        }

    }
}
