using IdSharp.Tagging.ID3v2;
using System.Drawing;

namespace MusicPlayer
{
    class MP3Tag
    {
        public static bool TagThis(string AlbumPath, string Artist, string Title, string Album, string Year, string Track, string Lyricist, string Path)
        {
            try
            {
                ID3v2Tag Information = new ID3v2Tag(Path);
                Information.Album = Album;
                Information.Title = Title;
                Information.Year = Year;
                Information.TrackNumber = Track;
                Information.Lyricist = Lyricist;

                //IAttachedPicture picture = Information.PictureList.AddNew();

                //picture.PictureData = File.ReadAllBytes(pictureFileName);

                Information.PictureList[0].Picture = Bitmap.FromFile(AlbumPath);
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
