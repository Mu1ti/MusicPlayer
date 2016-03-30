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
                    RemoveIllegalPathCharacters(video.Title) + video.AudioExtension));


                audioDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage * 0.85);
                audioDownloader.AudioExtractionProgressChanged += (sender, args) => Console.WriteLine(85 + args.ProgressPercentage * 0.15);

                audioDownloader.Execute();

                //if (video.Title.Contains(" - ")) MainForm.YoutubeResult[index, 2] = video.Title.Split('-')[0];

                //MP3Tag.TagThis(MainForm.);
                return true;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
                return false;
            }
        }
        public static bool DownloadRemoteImageFile(string uri, string fileName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            bool bImage = response.ContentType.StartsWith("image",
                StringComparison.OrdinalIgnoreCase);
            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                bImage)
            {
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var Return = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return Return.Replace(path, "");
        }
    }
}
