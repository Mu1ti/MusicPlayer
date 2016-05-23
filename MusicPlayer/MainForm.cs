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
                YoutubePlayer.Visible = true;

                YoutubePlayer.Dock = DockStyle.Fill;

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
                AlbumePicture[ListCount].Click += new EventHandler(MusicItemClicked);
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
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if(SearchText.Text != "Search Here... (~￣▽￣)~")
            {
                MusicInformation = Crawling.SearchCrawlingResult(SearchText.Text);
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

        }
        #endregion

        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            s.Tag = new Point(e.X, e.Y);
        }
        private void TitlebarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            s.Parent.Left = this.Left + (e.X - ((Point)s.Tag).X);
            s.Parent.Top = this.Top + (e.Y - ((Point)s.Tag).Y);
        }

        private void MusicSearchButton_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = SearchTabPage;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = DashBoardTabPage;
        }
        private void MusicPlayButton_Click(object sender, EventArgs e)
        {
            MainTabControl.SelectedTab = PlayTabPage;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
