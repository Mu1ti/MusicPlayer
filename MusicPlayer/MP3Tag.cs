using IdSharp.Tagging.ID3v2;
using System.Drawing;

namespace MusicPlayer
{
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
                Information.PictureList[0].Picture = Bitmap.FromFile(MusicInformation[4]);

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


        }
    }
}
