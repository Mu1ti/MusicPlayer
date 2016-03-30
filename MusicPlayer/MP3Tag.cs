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

    }
}
