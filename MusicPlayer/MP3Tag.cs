using IdSharp.Tagging.ID3v2;
using IdSharp.Tagging.ID3v2.Frames;
using System.Drawing;
using System.IO;

namespace MusicPlayer
{
    class MP3Tag
    {
        public static void TagThis(MusicInformation MusicInfo, string Path)
        {
            if(File.Exists(Path) == true)
            {
                ID3v2Tag Information = new ID3v2Tag(Path);
                IAttachedPicture Albume = Information.PictureList.AddNew();

                Information.Title = MusicInfo.Title;
                Information.Artist = MusicInfo.Artist;
                Information.Album = MusicInfo.Album;
                Information.Lyricist = MusicInfo.Lyricist;
                if(MusicInfo.AlbumImage != null) Albume.Picture = MusicInfo.AlbumImage;
                Information.Save(Path);
                
            }
        } 
        public static MusicInformation GetTag(string Path)
        {
            MusicInformation MusicInformation = new MusicInformation();
            if (Path != null)
            {
                ID3v2Tag Information = new ID3v2Tag(Path);
                MusicInformation.Title = Information.Title;
                MusicInformation.Artist = Information.Artist;
                MusicInformation.Album = Information.Album;
                MusicInformation.Lyricist = Information.Lyricist;
                if (Information.PictureList.Count > 0) MusicInformation.AlbumImage = new Bitmap(Information.PictureList[0].Picture);
            }

            return MusicInformation;
        }
    }
}
