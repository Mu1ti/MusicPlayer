using IdSharp.Tagging.ID3v2;
using System.Drawing;

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
        public static bool TagThis(string[] MusicInformation, string Path)
        {
            try
            {
                ID3v2Tag Information = new ID3v2Tag(Path);
                Information.Title = MusicInformation[0];
                Information.Artist = MusicInformation[1];
                Information.Album = MusicInformation[2];
                Information.Lyricist = MusicInformation[3];
                Information.PictureList[0].Picture = Bitmap.FromFile(MusicInformation[5]);

                Information.Save(Path);
                return true;
            }
            catch
            {
                
                return false;
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
            string[] ResultInformation = new string[5];

            ResultInformation[0] = MusicInformations[index,0];
            ResultInformation[1] = MusicInformations[index,1];
            ResultInformation[2] = MusicInformations[index,2];
            ResultInformation[3] = MusicInformations[index,3];
            ResultInformation[4] = MusicInformations[index,4];

            return ResultInformation;
        }
    }
}
