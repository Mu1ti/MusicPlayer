using HtmlAgilityPack;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
namespace MusicPlayer
{
    /*
     * 로그인이 필요한 사이트 -
     * BGMStore
     * SoundCloud
     * 
     */

    class Crawling
    {
        public static MusicInformation[] SearchCrawlingResult(string KeyWord)
        {
            //Melon > Mnet > SoundCloud > etc... > Youtube > MP3Sites=
            MusicInformation[] YoutubeResult = Search_Youtube_Crawling(KeyWord);
            MusicInformation[] BloodCatResult = Search_BloodCat_Crawling(KeyWord);
            MusicInformation[] SoundCloudResult = Search_SoundCloud_Crawling(KeyWord);
            MusicInformation[] BGMStoreResult = MP3_BGMStore_Crawling(KeyWord);

            int AllCount = 0;

            if (YoutubeResult != null) AllCount += YoutubeResult.Length;
            if (BloodCatResult != null) AllCount += YoutubeResult.Length;
            if (SoundCloudResult != null) AllCount += YoutubeResult.Length;
            if (BGMStoreResult != null) AllCount += YoutubeResult.Length;

            MusicInformation[] Result = new MusicInformation[AllCount];
            int Result_Cnt = 0;

            

            if(YoutubeResult != null)
            {
                for (int i = 0; YoutubeResult.Length != i && 3 > i; i++) { Result[Result_Cnt] = YoutubeResult[i]; Result_Cnt++; }
            }

            if(BloodCatResult != null)
            {
                for (int i = 0; BloodCatResult.Length != i && 3 > i; i++) { Result[Result_Cnt] = BloodCatResult[i]; Result_Cnt++; }
            }

            if(BGMStoreResult != null)
            {
                for (int i = 0; BGMStoreResult.Length != i && 3 > i; i++) { Result[Result_Cnt] = BGMStoreResult[i]; Result_Cnt++; }
            }
            if(SoundCloudResult != null)
            {
                for(int i = 0; SoundCloudResult.Length != i && 3 > i; i++) { Result[Result_Cnt] = SoundCloudResult[i]; Result_Cnt++; }
            }
            return Result;
        }
        public static MusicInformation ID3TagCrawlingResult(string KeyWord)
        {
            //Melon > Mnet > SoundCloud > etc... > Youtube > MP3Sites
            MusicInformation Result;

            MusicInformation MainaDBResult = ID3Tag_ManiaDB_Crawling(KeyWord);
            MusicInformation BloodCatResult = ID3Tag_BloodCat_Crawling(KeyWord);

            Result = BloodCatResult;

            return Result;
        }

        private static MusicInformation[] Search_Youtube_Crawling(string KeyWord)
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
            string URL = "http://www.youtube.com/results?q=" + HttpUtility.UrlEncode(KeyWord);
            string Source = Utility.GetSource(URL);

            string[] URLResult = Utility.RegexToStringArr(@"(?<= ""><a href="").{20}", Source, RegexOptions.None);//("(?<=\"yt-lockup-title \"><a href=\").*(?=\" class=\"yt-uix-sessionlink yt)", Source);
            string[] TitleResult = Utility.RegexToStringArr("(?<=dir=\"ltr\">).*(?=<\\/a><sp)", Source, RegexOptions.None);
            string[] PlayTimeResult = Utility.RegexToStringArr(@"(?<=video-time.*.>).*.(?=</span)", Source, RegexOptions.None);
            string[] PicResult = new string[TitleResult.Length];
            string[] LyricistResult = new string[TitleResult.Length];
            string[] ArtistResult = new string[TitleResult.Length];
            string[] AlbumResult = new string[TitleResult.Length];
            
            MusicInformation[] Result = new MusicInformation[3];

            for (int i = 0; URLResult.Length > i; i++) URLResult[i] = "https://www.youtube.com" + URLResult[i];
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
            for (int i = 0; URLResult.Length > i; i++)
            {
                if (URLResult[i].IndexOf("user") > -1)
                {
                    TitleResult[i] = null;
                    PicResult[i] = null;
                    URLResult[i] = null;
                }
                else PicResult[i] = "http://img.youtube.com/vi/" + URLResult[i].Split('=')[1].Split('&')[0] + "/0.jpg";
            }
            for (int i = 0; 3 > i; i++)    //결과 추출
            {
                Result[i].Title = TitleResult[i];
                Result[i].Artist = ArtistResult[i];
                Result[i].Album = AlbumResult[i];
                Result[i].Lyricist = LyricistResult[i];
                Result[i].AlbumImage = Utility.GetAlbumBitmapImage(PicResult[i]);
                Result[i].URL = URLResult[i];
                Result[i].PlayTime = (int)TimeSpan.Parse(PlayTimeResult[i+1]).TotalSeconds;
            }

            return Result;
        }
        private static MusicInformation[] Search_BloodCat_Crawling(string KeyWord)
        {
            HtmlDocument doc = new HtmlDocument();
            HtmlNodeCollection nodeCol;
            MusicInformation[] Result = new MusicInformation[0];
            string URL = @"http://bloodcat.com/osu/?q=" + KeyWord + "&c=b&s=&m=";
            string Source = Utility.GetSource(URL);
            string id = null;

            doc.LoadHtml(Source);
            doc.LoadHtml(doc.DocumentNode.SelectNodes("//main")[0].InnerHtml);
            nodeCol = doc.DocumentNode.SelectNodes("//div");
            if (nodeCol != null )
            {

                Result = new MusicInformation[nodeCol.Count];
                for (int i = 0; i < nodeCol.Count; i++)
                {
                    id = Utility.RegexToStringArr(@"(?<=id.*."">).*.(?=</a> <a c)", nodeCol[i].InnerHtml, RegexOptions.None)[0];

                    Result[i].Title = Utility.RegexToStringArr(@"(?<= - ).*.(?=</a> <)", nodeCol[i].InnerHtml, RegexOptions.None)[0];
                    Result[i].Artist = Utility.RegexToStringArr(@"(?<=title.*>).*.(?= - )", nodeCol[i].InnerHtml, RegexOptions.None)[0];
                    Result[i].Album = null;
                    Result[i].AlbumImage = Utility.GetAlbumBitmapImage("http://b.ppy.sh/thumb/" + id + ".jpg");
                    Result[i].URL = "http://bloodcat.com/osu/s/" + id;
                    Result[i].PlayTime = (int)DateTime.ParseExact(Utility.RegexToStringArr(@"(?<=</a> \[).....(?=] )", nodeCol[i].InnerHtml, RegexOptions.None)[0], "mm:ss", CultureInfo.InvariantCulture).TimeOfDay.TotalSeconds;
                }

                return Result;
            }

            return null;

        }

        private static MusicInformation[] Search_SoundCloud_Crawling(string KeyWord)
        {
            string JsonStringResult = Utility.GetSource("https://api.soundcloud.com/tracks.json?client_id=a162f1f21992081b0eb58bfd70611886&client_secret=fc82d49acf4b98b64c2287cc9d187be5&q=" + HttpUtility.UrlEncode(KeyWord));
            JArray JsonArrayResult = JArray.Parse(JsonStringResult);

            MusicInformation[] Result = new MusicInformation[JsonArrayResult.Count];
            int cnt = 0;
            foreach (JToken Item in JsonArrayResult)
            {
                string Content = Item.ToString();

                Result[cnt].Title = Utility.RegexToStringArr(@"(?<=""title"": "").*.(?="",)", Content, RegexOptions.None)[0];
                Result[cnt].Artist = Utility.RegexToStringArr(@"(?<=""username"": "").*.(?="",)", Content, RegexOptions.None)[0];
                Result[cnt].Album = Result[cnt].Title;
                Result[cnt].Lyricist = null;
                Result[cnt].AlbumImage = Utility.GetAlbumBitmapImage(Utility.RegexToStringArr(@"(?<=""artwork_url"": "").*.(?="",)", Content, RegexOptions.None)[0]);
                Result[cnt].URL = Utility.RegexToStringArr(@"(?<=""permalink_url"": "").*.(?="",)", Content, RegexOptions.None)[0];
                Result[cnt].PlayURL = Utility.RegexToStringArr(@"(?<=""stream_url"": "").*.(?="",)", Content, RegexOptions.None)[0];
                Result[cnt].PlayTime = int.Parse(Utility.RegexToStringArr(@"(?<=""duration"": ).*.(?=,)", Content, RegexOptions.None)[0]) / 1000;

                cnt++;
            }
            return Result;
        }

        private static MusicInformation[] MP3_BGMStore_Crawling(string KeyWord)
        {
            HtmlDocument doc = new HtmlDocument();
            HtmlNodeCollection nodeCol;
            MusicInformation[] Result = new MusicInformation[0];
            string Source = Utility.GetSource("https://bgmstore.net/?q_type=title&q_mode=general&q=" + KeyWord);
            string lenght;
            doc.LoadHtml(Source);
            doc.LoadHtml(doc.DocumentNode.SelectNodes("//tbody")[0].InnerHtml);
            nodeCol = doc.DocumentNode.SelectNodes("//tr");

            if (nodeCol != null)
            {
                Result = new MusicInformation[nodeCol.Count];
                for(int i = 0; i < nodeCol.Count && !nodeCol[0].InnerHtml.Contains(@"없습니다."); i++)
                {
                    lenght = Utility.RegexToStringArr(@"(?<=font-size:10pt;"">\[).*.(?=]</span> )", nodeCol[i].InnerHtml, RegexOptions.None)[0];
                    //Result[i].Title = Utility.RegexToStringArr(@"(?<=mp3/).*(?="">mp3 )", nodeCol[i].InnerHtml, RegexOptions.None)[0];
                    Result[i].Title = Utility.RegexToStringArr(@"(?<=title"">).*.(?=</a> )", nodeCol[i].InnerHtml, RegexOptions.None)[0];
                    Result[i].Title = HttpUtility.UrlDecode(Result[i].Title);

                    Result[i].PlayTime = (int)DateTime.ParseExact(lenght, "mm:ss", CultureInfo.InvariantCulture).TimeOfDay.TotalSeconds;
                    Result[i].Artist = Utility.ExtractSongArtist(Result[i].Title);
                    Result[i].Title = Utility.ExtractSongTitle(Result[i].Title);
                    Result[i].URL = "http://bgmstore.net" + Utility.RegexToStringArr(@" / view/.*.(?="" class=""title)", nodeCol[i].InnerHtml, RegexOptions.None)[0];
                    Result[i].PlayURL = Utility.RegexToStringArr(@"http://d.*.(?="">mp3)", nodeCol[i].InnerHtml, RegexOptions.None)[0];
                    Result[i].Lyricist = null;
                    Result[i].AlbumImage = null;
                }
                return Result;
            }
            return null;
        }

        private static MusicInformation ID3Tag_ManiaDB_Crawling(string KeyWord)
        {
            HtmlDocument doc = new HtmlDocument();
            MusicInformation MusicInfo = new MusicInformation();
            string songTitle = Utility.ExtractSongTitle(KeyWord);
            string songArtist = Utility.ExtractSongArtist(KeyWord);
            string url = "http://www.maniadb.com/search/" + songTitle + "/?sr=S";
            string Source = Utility.GetSource(url);
            int max = 0;

            if (Source != null)
            {
                max = int.Parse(Utility.RegexToStringArr("(?<=>).*.(?= SONG SEARCH)", Source, RegexOptions.None)[0]);

                string[] Title = new string[max];
                string[] Artist = new string[max];
                string[] Album = new string[max];
                string[] Lyricist = new string[max];
                string[] URL = new string[max];
                string[] AlbumURL = new string[max];

                doc.LoadHtml(Source);
                HtmlNodeCollection nodeCol = doc.DocumentNode.SelectNodes("//table");
                if (max != 0)
                {
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
                            MusicInfo.Title = Title[(i - 3) / 2];
                            MusicInfo.Artist = Artist[(i - 3) / 2];
                            MusicInfo.Album = Album[(i - 3) / 2];
                            MusicInfo.Lyricist = Lyricist[(i - 3) / 2];
                            MusicInfo.URL = null;
                            MusicInfo.AlbumImage = Utility.GetAlbumBitmapImage(AlbumURL[(i - 3) / 2]);
                            break;
                        }
                    }
                }
            }
            return MusicInfo;
        }
        private static MusicInformation ID3Tag_BloodCat_Crawling(string KeyWord)
        {
            MusicInformation Result = new MusicInformation();
            HtmlDocument doc = new HtmlDocument();
            HtmlNodeCollection nodeCol = null;
            string URL = @"http://bloodcat.com/osu/?q=" + HttpUtility.UrlEncode(KeyWord) + "&c=b&s=&m=";
            string Source = Utility.GetSource(URL);
            string id = null;

            string Artist = Utility.ExtractSongArtist(KeyWord);
            string Title = Utility.ExtractSongTitle(KeyWord);

            doc.LoadHtml(Source);
            doc.LoadHtml(doc.DocumentNode.SelectNodes("//main")[0].InnerHtml);
            nodeCol = doc.DocumentNode.SelectNodes("//div");
            if (nodeCol != null)
            {
                for (int i = 0; i < nodeCol.Count; i++)
                {
                    id = Utility.RegexToStringArr(@"(?<=id.*."">).*.(?=</a> <a c)", nodeCol[i].InnerHtml, RegexOptions.None)[0];

                    Result.Title = HttpUtility.HtmlDecode(Utility.RegexToStringArr(@"(?<= - ).*.(?=</a> <)", nodeCol[i].InnerHtml, RegexOptions.None)[0]);
                    Result.Artist = HttpUtility.HtmlDecode(Utility.RegexToStringArr(@"(?<=title.*>).*.(?= - )", nodeCol[i].InnerHtml, RegexOptions.None)[0]);
                    if (Result.Title.Contains(Title) && Result.Artist.Contains(Artist))
                    {
                        Result.Album = null;
                        Result.AlbumImage = Utility.GetAlbumBitmapImage("http://b.ppy.sh/thumb/" + id + ".jpg");
                        Result.URL = "http://bloodcat.com/osu/s/" + id;
                        break;
                    }
                }
            }
            return Result;
        }
    }
}
