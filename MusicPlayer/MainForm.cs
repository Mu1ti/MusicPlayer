using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace MusicPlayer
{
    public partial class MainForm : Form
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
        private Panel[] MusicItemPanel = new Panel[256];
        private PictureBox[] AlbumePicture = new PictureBox[256];
        private Label[] MusicInformationLabel = new Label[256];
        private TextBox[] MusicInformationText = new TextBox[256];
        public static string[,] MusicInformation;
        int ListCount = 0;
        
        private string Play_Youtube(string URL)
        {
            string htmlSrc = "<html><head><meta charset='UTF-8'></head><body style='margin:0px;padding:0px;'><div style='margin:0px;padding:0px;'><embed src='https://www.youtube.com/v/"+URL.Split('=')[1]+"?rel=0&showinfo=0&version=3&amp;hl=ko_KR&amp;vq=hd720&autoplay=1&controls=0&frameborder=0' type='application/x-shockwave-flash' width='100%' height='100%' ='always' allowfullscreen='true'></embed></div></body></html>";
            return htmlSrc;
        }
        private bool PlayMusic(string type, string value)
        {
            if (type == "Youtube")
            {
                YoutubePlayer.Document.Write(Play_Youtube(value));
                YoutubePlayer.Refresh();

                PlayAlbumCover.Visible = false;
                LyricistLabel.Visible = false;
                SoundVisualizer.Visible = false;
                YoutubePlayer.Visible = true;

                Thread Down = new Thread(() => Downloader.DownLoadThis(type, value, MP3Tag.MakeID3Tag(MusicInformation, 0)));
                Down.Start();

                return true;
            }
            else if (type == "SoundCloud")
            {


                return true;
            }
            else if (type == "LocalMp3")
            {


                return true;
            }
            else if (type == "Mp3Site")
            {


                return true;
            }
            return false;
        }
        

          #region Controls Events

        //*******************************************
        //*        Custom Controls Events           *
        //*******************************************

        private void MusicItemClicked(object sender, EventArgs e)
        {
            int Index = Convert.ToInt32(((PictureBox)sender).Name.Trim());
            string indextext = MusicInformationText[Index].Text;

            if(indextext.Contains("youtube"))
            {
                //Youtube Item
                int urlstartposition = indextext.LastIndexOf("https://");
                string url = indextext.Remove(0, urlstartposition);

                PlayMusic("Youtube", url);

                //Thread Down = new Thread(() => Downloader.YoutubeDownloader(url, ".\\Music\\", Index));
                //Down.Start();

            }


        }
        private void Scrolled(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                for (int i = 0; MusicItemPanel[i] != null; i++)
                {
                    MusicItemPanel[i].Top = MusicItemPanel[i].Top + MusicItemPanel[i].Height;
                    if (MusicItemPanel[0].Top > 0)
                    {
                        MusicItemPanel[i].Top = MusicItemPanel[i].Top - MusicItemPanel[i].Height;
                        break;
                    }
                }
                if(MusicListBar.Value != 0) MusicListBar.Value--;
            }
            else
            {
                for (int i = 0; MusicItemPanel[i] != null; i++)
                    MusicItemPanel[i].Top = MusicItemPanel[i].Top - MusicItemPanel[i].Height;
                MusicListBar.Value++;
            }
        }
        private bool RemoveMusicItem()
        {
            try
            {
                for (int i = 0; ListCount > i; i++)
                {
                    MusicItemPanel[i] = new Panel();
                    AlbumePicture[i] = new PictureBox();
                    MusicInformationLabel[i] = new Label();
                    MusicInformationText[i] = new TextBox();
                }
                ListCount = 0;
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }
        private bool CreateMusicItem(string Title, string Artist, string Album, string Lyricist, string AlbumPath, string URL)
        {
            try
            {
                MusicItemPanel[ListCount] = new Panel();
                AlbumePicture[ListCount] = new PictureBox();
                MusicInformationLabel[ListCount] = new Label();
                MusicInformationText[ListCount] = new TextBox();
                
                if (ListCount <= 0) MusicItemPanel[ListCount].Top = 0;
                else MusicItemPanel[ListCount].Top = MusicItemPanel[ListCount - 1].Top + MusicItemPanel[ListCount - 1].Height;
                MusicItemPanel[ListCount].Left = 0;
                MusicItemPanel[ListCount].Width = MusicListBar.Left;
                MusicItemPanel[ListCount].Height = 100;
                MusicItemPanel[ListCount].BackColor = Color.AntiqueWhite;
                MusicItemPanel[ListCount].BorderStyle = BorderStyle.FixedSingle;
                MusicItemPanel[ListCount].MouseWheel += new MouseEventHandler(Scrolled);
                MusicListPanel.Controls.Add(MusicItemPanel[ListCount]);

                AlbumePicture[ListCount].Left = 3;
                AlbumePicture[ListCount].Top = 3;
                AlbumePicture[ListCount].Width = 100 - 6;
                AlbumePicture[ListCount].Height = 100 - 6;
                if (AlbumPath == null) AlbumePicture[ListCount].BackgroundImage = Properties.Resources.NoImage;
                AlbumePicture[ListCount].BackgroundImageLayout = ImageLayout.Stretch;
                AlbumePicture[ListCount].Name = " " + ListCount + " ";
                AlbumePicture[ListCount].Image = Image.FromFile(AlbumPath);
                AlbumePicture[ListCount].SizeMode = PictureBoxSizeMode.StretchImage;
                AlbumePicture[ListCount].Click += new System.EventHandler(MusicItemClicked);
                AlbumePicture[ListCount].MouseWheel += new MouseEventHandler(Scrolled);
                MusicItemPanel[ListCount].Controls.Add(AlbumePicture[ListCount]);

                MusicInformationLabel[ListCount].Left = AlbumePicture[ListCount].Left + AlbumePicture[ListCount].Width + 10;
                MusicInformationLabel[ListCount].Top = AlbumePicture[ListCount].Top + 5;
                MusicInformationLabel[ListCount].AutoSize = true;
                MusicInformationLabel[ListCount].Text = "Title :\r\n\r\nArtist :\r\n\r\nAlbume :\r\n\r\nURL :";
                MusicInformationLabel[ListCount].TextAlign = ContentAlignment.TopRight;
                MusicInformationLabel[ListCount].MouseWheel += new MouseEventHandler(Scrolled);
                MusicItemPanel[ListCount].Controls.Add(MusicInformationLabel[ListCount]);

                MusicInformationText[ListCount].Left = MusicInformationLabel[ListCount].Left + MusicInformationLabel[ListCount].Width + 5;
                MusicInformationText[ListCount].Top = MusicInformationLabel[ListCount].Top + 1;
                MusicInformationText[ListCount].Height = MusicInformationLabel[ListCount].Height;
                MusicInformationText[ListCount].Width = MusicItemPanel[ListCount].Width - MusicInformationText[ListCount].Left - 10;
                MusicInformationText[ListCount].Multiline = true;
                MusicInformationText[ListCount].Text = Title + "\r\n\r\n" + Artist + "\r\n\r\n" + Album + "\r\n\r\n" + URL;
                MusicInformationText[ListCount].BorderStyle = BorderStyle.None;
                MusicInformationText[ListCount].BackColor = MusicItemPanel[ListCount].BackColor;
                MusicInformationText[ListCount].ReadOnly = true;
                MusicInformationText[ListCount].MouseWheel += new MouseEventHandler(Scrolled);
                MusicItemPanel[ListCount].Controls.Add(MusicInformationText[ListCount]);
                
                ListCount++;
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("WTF!!\r\n" + e);
                return false;
            }

        }

        //*******************************************
        //*           Controls Events               *
        //*******************************************

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm_Resize(sender, e);
            MusicListPanel.MouseWheel += new MouseEventHandler(Scrolled);
        }
        private void SearchText_Enter(object sender, EventArgs e)
        {
            if (SearchText.Text == "Search Here... (~￣▽￣)~")
            {
                SearchText.Text = null;
                SearchText.ForeColor = Color.Black;
            }
        }
        private void SearchText_Leave(object sender, EventArgs e)
        {
            if(SearchText.Text == null)
            {
                SearchText.Text = "Search Here... (~￣▽￣)~";
                SearchText.ForeColor = Color.Gray;
            }
        }
        private void SearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(SearchText.Text != null) {if (e.KeyChar == 13) SearchButton_Click(sender, e); }
            
        }
        private void PlayIco_Click(object sender, EventArgs e)
        {
            MainForm_Resize(sender, e);

            SearchPanel.Visible = false;
            PlayPanel.Visible = true;
        }
        private void SearchIco_Click(object sender, EventArgs e)
        {
            MainForm_Resize(sender, e);

            SearchPanel.Visible = true;
            PlayPanel.Visible = false;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SearchText.Text != "Search Here... (~￣▽￣)~")
            {
                Crawling crawling = new Crawling( );
                MusicInformation = crawling.CrawlingResult(SearchText.Text);
                for (int i = 0; (MusicInformation.Length / 6) > i; i++)
                    CreateMusicItem(
                        MusicInformation[i,0], 
                        MusicInformation[i,1],
                        MusicInformation[i,2],
                        MusicInformation[i,3],
                        MusicInformation[i,4],
                        MusicInformation[i,5]);
                MusicListBar.Maximum = ListCount;
                MusicListBar.Value = 0;
            }
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {

            //*******************************************
            //*              Panels Resize              *
            //*******************************************
            
            LeftPanel.Width = (int)(Width * 0.1);
            PlayBar.Left = LeftPanel.Width;
            PlayBar.Width = Width - PlayBar.Left - 15;
            PlayBar.Top = Height - PlayBar.Height - 39;

            PlayPanel.Top = 0;
            PlayPanel.Left = LeftPanel.Width;
            PlayPanel.Width = Width - PlayPanel.Left - 15;
            PlayPanel.Height = PlayBar.Top;

            SearchPanel.Top = 0;
            SearchPanel.Left = LeftPanel.Width;
            SearchPanel.Width = Width - SearchPanel.Left - 15;
            SearchPanel.Height = PlayBar.Top;

            SettingPanel.Top = 0;
            SettingPanel.Left = LeftPanel.Width;
            SettingPanel.Width = Width - SettingPanel.Left - 15;
            SettingPanel.Height = PlayBar.Top - 39;
            
            PlayListPanel.Top = 0;
            PlayListPanel.Left = LeftPanel.Width;
            PlayListPanel.Width = Width - PlayListPanel.Left - 15;
            PlayListPanel.Height = PlayBar.Top;
            
            NowPlayList.Top = SettingIco.Top + SettingIco.Height;
            NowPlayList.Height = Width - NowPlayList.Top;
            NowPlayList.Width = LeftPanel.Width;

            //*******************************************
            //*        PlayPanel Items Resize           *
            //*******************************************

            LyricistLabel.Top = 0;
            LyricistLabel.Left = 0;
            LyricistLabel.Height = PlayPanel.Height;
            LyricistLabel.Width = PlayPanel.Width;

            PlayAlbumCover.Top = 0;
            PlayAlbumCover.Left = 0;
            PlayAlbumCover.Height = PlayPanel.Height;
            PlayAlbumCover.Width = PlayPanel.Width;

            YoutubePlayer.Top = 0;
            YoutubePlayer.Left = 0;
            YoutubePlayer.Height = PlayPanel.Height;
            YoutubePlayer.Width = PlayPanel.Width;

            SoundVisualizer.Top = 0;
            SoundVisualizer.Left = 0;
            SoundVisualizer.Height = PlayPanel.Height;
            SoundVisualizer.Width = PlayPanel.Width;

            //*******************************************
            //*        SearchPanel Item Resize          *
            //*******************************************

            SearchText.Left = 0;
            SearchText.Width = (int)(SearchPanel.Width * 0.9);
            SearchButton.Left = SearchText.Width;
            SearchButton.Width = SearchPanel.Width - SearchButton.Left;

            MusicListPanel.Top = SearchText.Height;
            MusicListPanel.Left = SearchText.Left;
            MusicListPanel.Width = SearchPanel.Width;
            MusicListPanel.Height = PlayBar.Top;

            //*******************************************
            //*       PlayListPanel Item Resize         *
            //*******************************************



            //*******************************************
            //*        SettingPanel Item Resize         *
            //*******************************************



            //*******************************************
            //*        PlayBarPanel Item Resize         *
            //*******************************************

            NowPlayInformationLabel.Left = 20;
            NowPlayInformationText.Left = NowPlayInformationLabel.Left + NowPlayInformationLabel.Width + 5;
            NowPlayInformationText.Width = StopButton.Left - NowPlayInformationText.Left - 10;
            PlayButton.Left = (int)((PlayBar.Width * 0.5) - (PlayButton.Width * 0.5));
            StopButton.Left = PlayButton.Left - StopButton.Width - 6;
            NextButton.Left = PlayButton.Left + PlayButton.Width + 6;
            VolumeBar.Left = PlayBar.Width - VolumeBar.Width - 20;
            VolumeButton.Left = VolumeBar.Left - VolumeButton.Width - 6;

            //*******************************************
            //*         SearchPanel Item Resize         *
            //*******************************************
            
            for( int i = 0; MusicItemPanel[i] != null; i++ ){
                MusicItemPanel[i].Width = MusicListBar.Left;
                MusicInformationText[i].Width = MusicItemPanel[i].Width - 20;
            }

        }
        #endregion
    }
}
