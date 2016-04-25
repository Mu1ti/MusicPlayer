using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using YoutubeExtractor;

namespace MusicPlayer
{
    class Downloader
    {
        public static bool DownLoadThis(string Type, string path, string [,]MusicInformation, int index)
        {
            if(Type == "Youtube")
            {
            //    YoutubeDownloader(u)
            }
            //Thread Down = new Thread(() => Downloader.YoutubeDownloader(url, ".\\Music\\", Index));
            //if()

            return true;
        }

        public static bool YoutubeDownloader(string url, string path, int index)
        {
            try
            {
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

                audioDownloader.Execute();
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
