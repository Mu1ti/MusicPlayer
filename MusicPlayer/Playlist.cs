using System.Text.RegularExpressions;
using System.IO;

namespace MusicPlayer
{
    class Playlist
    {
        static string DefaultPath = @".\PlayLists\";
        public static MusicPlayList[,] LoadPlayLists()
        {
            MusicPlayList[,] Result = new MusicPlayList[0, 0];

            if (Directory.Exists(DefaultPath))
            {
                string[] FileLists = Directory.GetFiles(DefaultPath);
                string[] PlayLists = new string[FileLists.Length];
                Result = new MusicPlayList[PlayLists.Length, 256];
                for(int i = 0; FileLists.Length > i; i++)
                {
                    if (FileLists[i].Contains(".pl")) PlayLists[i] = FileLists[i];
                    MusicPlayList[] FileResult = GetPlayListOnThis(PlayLists[i]);

                    for(int j = 0; PlayLists.Length > j ;j++)
                    {
                        Result[i, j] = FileResult[j];
                    }
                }
            }
            return Result;
        }
        public static void SavePlayList(MusicPlayList[] PlayList, string PlayListName)
        {
            if (File.Exists(@".\PlayLists\" + PlayListName)) File.Delete(@".\PlayLists\" + PlayListName);

            FileStream file = new FileStream(@".\PlayLists\" + PlayListName, FileMode.OpenOrCreate);
            StreamWriter write = new StreamWriter(file);
            for (int i = 0; PlayList.Length > i; i++)
                write.WriteLine(
                    PlayList[i].TItle + 
                    "\xde\xad\xbe\xef" + 
                    PlayList[i].URL + 
                    "\xde\xad\xbe\xef" + 
                    PlayList[i].PlayTime + 
                    "\xde\xad\xbe\xef"
                    );
            write.Close();
            file.Close();
        }

        private static MusicPlayList[] GetPlayListOnThis(string path)
        {
            MusicPlayList[] Result = new MusicPlayList[0];
            if (File.Exists(path))
            {
                int ItemCount = File.ReadAllLines(path).Length;
                Result = new MusicPlayList[ItemCount];
                FileStream file = new FileStream(path,FileMode.Open);
                StreamReader read = new StreamReader(file);
                string Content;
                string[] ParseResult = new string[4];
                for (int i = 0;ItemCount > i; i++)
                {

                    Content = read.ReadLine();
                    ParseResult = Utility.RegexToStringArr("\xdex\ad\xbe\xef", Content, RegexOptions.None);
                    Result[i].Number = i;
                    Result[i].TItle = ParseResult[0];
                    Result[i].URL = ParseResult[1];
                    Result[i].PlayTime = ParseResult[2];
                }
                read.Close();
                file.Close();
            }
            return Result;
        }
    }
}
