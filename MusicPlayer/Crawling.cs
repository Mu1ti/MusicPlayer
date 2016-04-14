using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace MusicPlayer
{
    class Crawling
    {
        public string[,] CrawlingResult(string KeyWord)
        {
            string[,] Result;
            string[,] YoutubeResult = YoutubeCrawling(KeyWord);
            string[,] SoundCloudResult = null;

            Result = YoutubeResult;

            return Result;
        }

        public string[,] YoutubeCrawling(string KeyWord)
        {
            /*
                유튜브 결과
                1. 노래 이름
                2. 아티스트
                3. 앨범(모름)
                4. 가사(모름)
                5. 앨범 재킷 URL
                6. URL
            */
            string URL = "http://www.youtube.com/results?q=" + System.Web.HttpUtility.UrlEncode(KeyWord);
            string Source = GetSource(URL);

            string[] TitleResult = RegexToStringArr("(?<=dir=\"ltr\">).*(?=<\\/a><sp)", Source);
            string[] ArtistResult = new string[TitleResult.Length];
            string[] URLResult = RegexToStringArr("(?<=\"yt-lockup-title \"><a href=\").*(?=\" class=\"yt-uix-sessionlink yt)",Source);
            //string[] PicResult = RegexToStringArr(@"((?<=c=\"\\/\\/).*(?=\" alt=\"\" width=))|((?<=\" alt=\"\" data-thumb=\"\\/\\/).*(?=\" w))", Source);
            //string[] PicResult = RegexToStringArr(".{26}.mqdefault.jpg. alt=", Source);
            string[] PicResult = RegexToStringArr(".{26}.mqdefault.jpg", Source);
            string[,] Result = new string[TitleResult.Length, 6];

            for (int i = 0; URLResult.Length > i; i++) URLResult[i] = "https://www.youtube.com" + URLResult[i];
            for (int i = 0; PicResult.Length > i; i++) PicResult[i] = "https://" + PicResult[i];
            for (int i = 0; 20 > i; i++)
            {
                if(PicResult[i] != "")
                {
                    Downloader.DownloadRemoteImageFile(PicResult[i], @"./\YoutubePictures\" + i + ".jpg");
                    PicResult[i] = @"./\YoutubePictures\" + i + ".jpg";
                }
                else
                {

                }

            }
            for (int i = 0; TitleResult.Length > i; i++)
            {
                if (TitleResult[i].Contains("-"))
                {
                    ArtistResult[i] = TitleResult[i].Split('-')[0];
                    TitleResult[i] = TitleResult[i].Split('-')[1];
                }
                else
                {
                    ArtistResult[i] = "Unknown";
                }
            }
            for (int i = 0; TitleResult.Length > i; i++)
            {
                Result[i, 0] = TitleResult[i];
                Result[i, 1] = ArtistResult[i];
                Result[i, 2] = "Unknown";
                Result[i, 3] = "Unknown";
                Result[i, 4] = PicResult[i];
                Result[i, 5] = URLResult[i];
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
