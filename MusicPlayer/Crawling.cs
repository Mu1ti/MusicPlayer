using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace MusicPlayer
{
    class Crawling
    {
        public static string[,] SearchCrawlingResult(string KeyWord)
        {
            string[,] Result;
            string[,] YoutubeResult = Search_Youtube_Crawling(KeyWord);
            string[,] SoundCloudResult = null;

            Result = YoutubeResult;

            return Result;
        }
        public static string[] ID3TagCrawlingResult(string KeyWord)
        {
            string[] MainaDBResult = ID3Tag_ManiaDB_Crawling(KeyWord);
            
            return MainaDBResult;
        }




        private static string[,] Search_Youtube_Crawling(string KeyWord)
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

            string[] URLResult = Utility.RegexToStringArr(@"(?<= ""><a href="").{20}", Source, RegexOptions.None);//("(?<=\"yt-lockup-title \"><a href=\").*(?=\" class=\"yt-uix-sessionlink yt)", Source);
            string[] TitleResult = Utility.RegexToStringArr("(?<=dir=\"ltr\">).*(?=<\\/a><sp)", Source, RegexOptions.None);
            string[] PicResult = new string[TitleResult.Length];
            string[] LyricistResult = new string[TitleResult.Length];
            string[] ArtistResult = new string[TitleResult.Length];
            string[] AlbumResult = new string[TitleResult.Length];

            string[,] Result = new string[TitleResult.Length, 6];

            for (int i = 0; URLResult.Length > i; i++) URLResult[i] = "https://www.youtube.com" + URLResult[i];
            for (int i = 0; URLResult.Length > i; i++)
            {
                if(URLResult[i].IndexOf("user") > -1)
                {
                    TitleResult[i] = null;
                    PicResult[i] = null;
                    URLResult[i] = null;
                }
                else PicResult[i] = "http://img.youtube.com/vi/" + URLResult[i].Split('=')[1].Split('&')[0] + "/0.jpg";
            }
            for (int i = 0; TitleResult.Length > i; i++)    //앨범 커버
            {
                Utility.DownloadRemoteImageFile(PicResult[i], @"./\YoutubePictures\" + i + ".jpg");
                PicResult[i] = @"./\YoutubePictures\" + i + ".jpg";

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
        private static string[,] Search_SoundCloud_Crawling(string KeyWord)
        {
            string Json = Utility.GetSource("https://api.soundcloud.com/tracks.json?client_id=a162f1f21992081b0eb58bfd70611886&client_secret=fc82d49acf4b98b64c2287cc9d187be5&q=" + System.Web.HttpUtility.UrlEncode(KeyWord));
            //object Information = JsonConvert.DeserializeObject(Json);
            

            return null;
        }
        private static string[] ID3Tag_ManiaDB_Crawling(string KeyWord)
        {
            HtmlDocument doc = new HtmlDocument();
            string songTitle = Utility.ExtractSongTitle(KeyWord);
            string songArtist = Utility.ExtractSongArtist(KeyWord);
            string url = "http://www.maniadb.com/search/" + songTitle + "/?sr=S";
            string Source = Utility.GetSource(url);

            int max = int.Parse(Utility.RegexToStringArr("...(?= SONG SEARCH)", Source, RegexOptions.None)[0]);

            string[] Title = new string[100];
            string[] Artist = new string[100];
            string[] Album = new string[100];
            string[] Lyricist = new string[100];
            string[] URL = new string[100];
            string[] AlbumURL = new string[100];
            string[] Result = new string[6];

            doc.LoadHtml(Source);
            HtmlNodeCollection nodeCol = doc.DocumentNode.SelectNodes("//table");

            for (int i = 3; max * 2 + 2 > i; i += 2)
            {
                Title[(i - 3) / 2] = Utility.RegexToStringArr(@"(?<="" alt="""">).*(?=</span>)", nodeCol[i].InnerHtml, RegexOptions.None)[0];
                Artist[(i - 3) / 2] = Utility.RegexToStringArr(@"(?<=performer"">).*.(?=</td>)", nodeCol[i].InnerHtml, RegexOptions.None)[0];
                Album[(i - 3) / 2] = Utility.RegexToStringArr(@"(?<=album/.*.alt="").*.(?="">)", nodeCol[i].InnerHtml, RegexOptions.None)[0];
                Lyricist[(i - 3) / 2] = Utility.RegexToStringArr(@"(?<=<textarea name=""songlyric"">).*(?=</textarea>)", nodeCol[i].InnerHtml, RegexOptions.Singleline)[0];
                AlbumURL[(i - 3) / 2] = Utility.RegexToStringArr(@"(?<=\);"" href="").*(?=""><img)", nodeCol[i].InnerHtml, RegexOptions.None)[0];

                if (Artist[(i - 3) / 2].Contains("</a>")) Artist[(i - 3) / 2] = Regex.Split(Artist[(i - 3) / 2], "</a>")[0].Split('>')[1].Trim();
                if (Album[(i - 3) / 2].Contains("-")) Album[(i - 3) / 2] = Album[(i - 3) / 2].Split('-')[1].Trim();
                if (Title[(i - 3) / 2].Contains(songTitle) && Artist[(i - 3) / 2].Contains(songArtist))
                {
                    Result[0] = Title[(i - 3) / 2];
                    Result[1] = Artist[(i - 3) / 2];
                    Result[2] = Album[(i - 3) / 2];
                    Result[3] = Lyricist[(i - 3) / 2];
                    Result[4] = null;
                    Result[5] = AlbumURL[(i - 3) / 2];
                    break;
                }
            }

            return Result;
        }
    }
}
