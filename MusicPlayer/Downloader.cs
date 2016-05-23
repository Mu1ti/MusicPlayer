using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using YoutubeExtractor;

namespace MusicPlayer
{
    /*
        음악 정보 변수
        1. Title
        2. Artist
        3. Album
        4. Lyricist
        5. AlbumURL
        6. URL
    */
    class Downloader
    {
        public static bool DownLoadThis(string Type, string Value, string[] MusicInformations)
        {
            if(Type == "Youtube")
            {
                YoutubeDownloader(Value, @"./\Music\", MusicInformations);
            }
            else if (Type == "SoundCloud")
            {


                return true;
            }
            else if (Type == "LocalMp3")
            {


                return true;
            }
            else if (Type == "Mp3Site")
            {


                return true;
            }

            return false;
        }
        private static bool YoutubeDownloader(string url, string path, string[] MusicInformation)
        {
            try
            {
                path = Utility.GetFolder(path);
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(url, false);
                VideoInfo video = videoInfos
                    .Where(info => info.CanExtractAudio)
                    .OrderByDescending(info => info.AudioBitrate)
                    .First();

                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                }
                
                var audioDownloader = new AudioDownloader(video,
                    Path.Combine(path,
                    Utility.RemoveIllegalPathCharacters(video.Title) + video.AudioExtension));


                audioDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage * 0.85);
                audioDownloader.AudioExtractionProgressChanged += (sender, args) => Console.WriteLine(85 + args.ProgressPercentage * 0.15);

                path = audioDownloader.SavePath;

                audioDownloader.Execute();
                
                MP3Tag.TagThis(MusicInformation, path);
                return true;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());

                return false;
            }
        }
    }
}
