using IdSharp.Tagging.ID3v2;
using IdSharp.Tagging.ID3v2.Frames;
using System.Drawing;
using System.IO;

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
    class MP3Tag
    {
        public static void TagThis(string[] MusicInformation, string Path)
        {
            if(File.Exists(Path) == true)
            {
                string[] CrawlingResult = Crawling.ID3TagCrawlingResult(MusicInformation[1] + "-" + MusicInformation[0]);
                if (CrawlingResult[0] == null) CrawlingResult = MusicInformation;

                ID3v2Tag Information = new ID3v2Tag(Path);
                IAttachedPicture Albume = Information.PictureList.AddNew();

                Information.Title = CrawlingResult[0];
                Information.Artist = CrawlingResult[1];
                Information.Album = CrawlingResult[2];
                Information.Lyricist = CrawlingResult[3];
                if(File.Exists(CrawlingResult[4]) == true)
                {
                    Albume.Picture = Bitmap.FromFile(CrawlingResult[4]);
                }
                    
                Information.Save(Path);
            }
        } 
        public static string[] GetTag(string Path)
        {
            string[] MusicInformation = new string[6];
            ID3v2Tag Information = new ID3v2Tag(Path);
            MusicInformation[0] = Information.Title;
            MusicInformation[1] = Information.Artist;
            MusicInformation[2] = Information.Album;
            MusicInformation[3] = Information.Lyricist;
            Image AlbumPicture = Information.PictureList[0].Picture;
            MusicInformation[4] = AlbumPicture.ToString();

            return MusicInformation;
        }
        public static string[] MakeID3Tag(string [,] MusicInformations, int index)
        {
            string[] ResultInformation = new string[6];

            ResultInformation[0] = MusicInformations[index,0];
            ResultInformation[1] = MusicInformations[index,1];
            ResultInformation[2] = MusicInformations[index,2];
            ResultInformation[3] = MusicInformations[index,3];
            ResultInformation[4] = MusicInformations[index,4];
            ResultInformation[5] = MusicInformations[index,5];
            return ResultInformation;
        }
    }
}
