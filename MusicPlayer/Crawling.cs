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
            string Source = Utility.GetSource(URL);

            string[] URLResult = Utility.RegexToStringArr(@"(?<= ""><a href="").{20}", Source);//("(?<=\"yt-lockup-title \"><a href=\").*(?=\" class=\"yt-uix-sessionlink yt)", Source);
            string[] TitleResult = Utility.RegexToStringArr("(?<=dir=\"ltr\">).*(?=<\\/a><sp)", Source);
            string[] PicResult = new string[TitleResult.Length];//Utility.RegexToStringArr(".{27}mqdefault.jpg", Source);
            string[] LyricistResult = new string[TitleResult.Length];
            string[] ArtistResult = new string[TitleResult.Length];
            string[] AlbumResult = new string[TitleResult.Length];

            string[,] Result = new string[TitleResult.Length, 6];

            for (int i = 0; URLResult.Length > i; i++) URLResult[i] = "https://www.youtube.com" + URLResult[i];
            
            for (; PicResult[TitleResult.Length - 1] == null;)
            {
                PicResult = Utility.RegexToStringArr(@"\/\/.{27}mqdefault.jpg", Source);
                if(PicResult.Length != TitleResult.Length) PicResult = new string[TitleResult.Length];
            }
            for (int i = 0; PicResult.Length > i; i++) PicResult[i] = "https:" + PicResult[i];
            for (int i = 0; TitleResult.Length > i; i++)    //앨범 커버
            {
                if (PicResult[i] != "")
                {
                    Utility.DownloadRemoteImageFile(PicResult[i], @"./\YoutubePictures\" + i + ".jpg");
                    PicResult[i] = @"./\YoutubePictures\" + i + ".jpg";
                }
                else
                {

                }

            }
            for (int i = 0; TitleResult.Length > i; i++)    //아티스트, 노래 제목
            {
                if (TitleResult[i].Contains("-"))
                {
                    ArtistResult[i] = TitleResult[i].Split('-')[0].Trim();
                    TitleResult[i] = TitleResult[i].Split('-')[1].Trim();
                    AlbumResult[i] = TitleResult[i];
                }
                else
                {
                    ArtistResult[i] = "Unknown";
                }
            }
            for (int i = 0; TitleResult.Length > i; i++)    //결과 추출
            {
                Result[i, 0] = TitleResult[i];
                Result[i, 1] = ArtistResult[i];
                Result[i, 2] = AlbumResult[i];
                Result[i, 3] = LyricistResult[i];
                Result[i, 4] = PicResult[i];
                Result[i, 5] = URLResult[i];
            }

            return Result;
        }
        public string[,] SoundCloudCrawling(string KeyWord)
        {
            string Json = Utility.GetSource("https://api.soundcloud.com/tracks.json?client_id=a162f1f21992081b0eb58bfd70611886&client_secret=fc82d49acf4b98b64c2287cc9d187be5&q=" + System.Web.HttpUtility.UrlEncode(KeyWord));
            object Information = JsonConvert.DeserializeObject(Json);
            

            return null;
        }
    }
}
