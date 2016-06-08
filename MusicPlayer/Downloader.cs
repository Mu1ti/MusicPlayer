using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using YoutubeExtractor;

namespace MusicPlayer
{
    class Downloader
    {
        public static bool DownLoadThis(string Type, string Value, MusicInformation MusicInfo)
        {
            if(Type == "Youtube")
            {
                YoutubeDownloader(Value, @"./\Music\", MusicInfo);
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
            else if (Type == "BloodCat")
            {
                BloodCatDownloader(Value.Split('\x01')[0], Value.Split('\x01')[1], MusicInfo);
            }
            return false;
        }
        private static bool YoutubeDownloader(string url, string path, MusicInformation MusicInfo)
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
                
                MP3Tag.TagThis(MusicInfo, path);
                return true;
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());

                return false;
            }
        }
        private static bool BloodCatDownloader(string url, string path, MusicInformation MusicInfo)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                StreamReader reader = new StreamReader(response.GetResponseStream());

                var zip = new ZipArchive(reader.BaseStream, ZipArchiveMode.Read);
                path = path + MusicInfo.Artist + " - " + MusicInfo.Title + ".mp3";

                foreach (var entry in zip.Entries)
                {
                    if (entry.FullName.Contains(".mp3"))
                    {
                        StreamReader MP3File = new StreamReader(entry.Open());
                        FileStream SaveFile = new FileStream(path, FileMode.CreateNew);
                        MemoryStream ms = new MemoryStream();

                        MP3File.BaseStream.CopyTo(ms);
                        byte[] Contents = ms.ToArray();

                        SaveFile.Write(Contents, 0, Contents.Length);
                        SaveFile.Flush();
                        SaveFile.Close();

                        break;
                    }
                }
                MP3Tag.TagThis(MusicInfo, path);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
