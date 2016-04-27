using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace MusicPlayer
{
    class Utility
    {
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

        public static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var Return = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return Return.Replace(path, "");
        }
        public static string[] RegexToStringArr(string reg, string str)
        {
            int i = 0;
            string[] Result = new string[20];
            foreach (Match match in Regex.Matches(str, reg,RegexOptions.None))
            {
                Result[i] = match.Value;
                i++;
            }
            return Result;

            /*
            Regex Parsed = new Regex(reg, RegexOptions.Compiled);
            MatchCollection mc = Parsed.Matches(str);
            string[] Result = new string[mc.Count];

            for (int i = 0; mc.Count > i; i++) Result[i] = System.Web.HttpUtility.HtmlDecode(mc[i].ToString());
            return Result;
            */
        }
        public static string GetSource(string url)

        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = (request.GetResponse() as HttpWebResponse);

            StreamReader reader = new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
        }
    }
}
