using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using WMPLib;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.IO.Compression;

namespace MusicPlayer
{
    /* TO DO List
     * PlayList 만들기 (포맷 :: Title / URL or Path)
     * 스킨 기능
     * PlayList 재생 기능
     * Setting.ini 파일도 만들어야댐 ㅋㅋ
    */
    struct MusicInformation
    {
        public string Title;
        public string Artist;
        public string Album;
        public string Lyricist;
        public Bitmap AlbumImage;
        public string URL;
        public int PlayTime;
        public string PlayURL;
    }
    struct MusicPlayList
    {
        public int Number;
        public string TItle;
        public string PlayTime;
        public string URL;
    }
    struct SearchResult
    {
        public Panel ItemPanel;
        public PictureBox AlbumePicture;
        public Label InformationLabel;
        public TextBox InformationText;
        public PictureBox AddPlayList;
    }
    public partial class MainForm : Form
    {
        private SearchResult[] MusicItems = new SearchResult[256];
        private MusicInformation[] SearchResult = new MusicInformation[20];
        private MusicPlayList[] NowPlayListItems = new MusicPlayList[256];
        private MusicInformation MusicInfo = new MusicInformation();
        private int SelectedMusic = 0;
        int ListCount = 0;
        WindowsMediaPlayer Player;

        public MainForm()
        {
            Player = new WindowsMediaPlayer();
            InitializeComponent();
        }
        


        #region MusicPlay Functions

        private bool PlayMusic(string type, string value)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\AppData\Local\Temp\";
            string title = Utility.ExtractSongFileName(MusicInfo);

            if (type == "Youtube")
            {
                YoutubePlayer.Document.Write(Utility.GetYoutubePlaySource(value));
                YoutubePlayer.Refresh();

                PlayAlbumCover.Visible = false;
                LyricistLabel.Visible = false;
                YoutubePlayer.Visible = true;

                YoutubePlayer.Dock = DockStyle.Fill;

                Thread Down = new Thread(() => Downloader.DownLoadThis(type, value, MusicInfo));
                Down.Start();

                return true;
            }
            else if (type == "SoundCloud")
            {


                return true;
            }
            else if (type == "LocalMp3")
            {
                AddNowPlayList(Utility.ExtractSongFileName(MusicInfo), Utility.GetDurationMP3File(value));
                PlayLocalMP3(value);
                return true;
            }
            else if (type == "Mp3Site")
            {


                return true;
            }
            else if (type == "BloodCat")
            {
                Downloader.DownLoadThis(type, value + '\x01' + path, MusicInfo);
                AddNowPlayList(title, Utility.GetDurationMP3File(path+title));
                PlayLocalMP3(path + Utility.ExtractSongFileName(MusicInfo));
            }
            else if (type == "BGMStore")
            {
                return true;
            }
            return false;
        }
        private void PlayLocalMP3(string Path)
        {
            MusicInfo = MP3Tag.GetTag(Path);
            ShowMusicInfo();

            Player.controls.stop();
            Player = new WindowsMediaPlayer();
            Player.URL = Path;
            Player.controls.play();

            HighLightPlayListItem(SelectedMusic);

            SelectedMusic++;
        }
        private void PlayRemoteMP3(string URL)
        {
            Player.controls.stop();
            Player = new WindowsMediaPlayer();
            Player.URL = URL;
            Player.controls.play();

            HighLightPlayListItem(SelectedMusic);

            SelectedMusic++;
        }
        private void ShowMusicInfo()
        {
            NowPlayInformationText.Text = MusicInfo.Artist + "\r\n" + MusicInfo.Album + "\r\n" + MusicInfo.Title;
        }

        #endregion

        #region Initializations
        private void SettingInitialize()
        {
            SettingInformation SettingInfo = Setting.LoadSetting();

            
        }
        #endregion



        #region Controls Events

        //*******************************************
        //*        Custom Controls Events           *
        //*******************************************

        private void MusicItemClicked(object sender, EventArgs e)
        {
            int Index = Convert.ToInt32(((PictureBox)sender).Name.Trim());
            string indextext = MusicItems[Index].InformationText.Text;

            int urlstartposition = indextext.LastIndexOf("https://");
            string url = indextext.Remove(0, urlstartposition);
            

            if(indextext.Contains("youtube"))
            {
                //Youtube Item


                PlayMusic("Youtube", url);
            }
            else if(indextext.Contains("bloodcat"))
            {/*
                //BloodCat Item
                int urlstartposition = indextext.LastIndexOf("http://");
                string url = indextext.Remove(0, urlstartposition);
               */ 

                PlayMusic("BloodCat", url);
            }

        }
        private void Scrolled(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                for (int i = 0; MusicItems[i].ItemPanel != null; i++)
                {
                    MusicItems[i].ItemPanel.Top = MusicItems[i].ItemPanel.Top + MusicItems[i].ItemPanel.Height;
                    if (MusicItems[0].ItemPanel.Top > 0)
                    {
                        MusicItems[i].ItemPanel.Top = MusicItems[i].ItemPanel.Top - MusicItems[i].ItemPanel.Height;
                        break;
                    }
                }
                if(MusicListBar.Value != 0) MusicListBar.Value--;
            }
            else
            {
                for (int i = 0; MusicItems[i].ItemPanel != null; i++)
                    MusicItems[i].ItemPanel.Top = MusicItems[i].ItemPanel.Top - MusicItems[i].ItemPanel.Height;
                MusicListBar.Value++;
            }
        }
        private void AddPlayList(object sender, MouseEventArgs e)
        {

        }
        private bool RemoveMusicItem()
        {
            try
            {
                for (int i = 0; ListCount > i; i++)
                {
                    MusicItems[i].ItemPanel = new Panel();
                    MusicItems[i].AlbumePicture = new PictureBox();
                    MusicItems[i].InformationLabel = new Label();
                    MusicItems[i].InformationText = new TextBox();
                }
                ListCount = 0;
                return true;
            }
            catch(Exception)
            {
                return false;
            }

        }
        private bool CreateMusicItem(string Title, string Artist, string Album, Bitmap AlbumImage, string URL)
        {
            try
            {
                MusicItems[ListCount].ItemPanel = new Panel();
                MusicItems[ListCount].AlbumePicture = new PictureBox();
                MusicItems[ListCount].InformationLabel = new Label();
                MusicItems[ListCount].InformationText = new TextBox();
                MusicItems[ListCount].AddPlayList = new PictureBox();

                if (ListCount <= 0) MusicItems[ListCount].ItemPanel.Top = 0;
                else MusicItems[ListCount].ItemPanel.Top = MusicItems[ListCount - 1].ItemPanel.Top + MusicItems[ListCount - 1].ItemPanel.Height;
                MusicItems[ListCount].ItemPanel.Left = 0;
                MusicItems[ListCount].ItemPanel.Width = MusicListBar.Left;
                MusicItems[ListCount].ItemPanel.Height = 100;
                MusicItems[ListCount].ItemPanel.BackColor = Color.  AntiqueWhite;
                MusicItems[ListCount].ItemPanel.BorderStyle = BorderStyle.FixedSingle;
                MusicItems[ListCount].ItemPanel.MouseWheel += new MouseEventHandler(Scrolled);
                MusicListPanel.Controls.Add(MusicItems[ListCount].ItemPanel);

                MusicItems[ListCount].AlbumePicture.Left = 3;
                MusicItems[ListCount].AlbumePicture.Top = 3;
                MusicItems[ListCount].AlbumePicture.Width = 100 - 6;
                MusicItems[ListCount].AlbumePicture.Height = 100 - 6;
                if (AlbumImage == null) MusicItems[ListCount].AlbumePicture.BackgroundImage = Properties.Resources.NoImage;
                MusicItems[ListCount].AlbumePicture.BackgroundImageLayout = ImageLayout.Stretch;
                MusicItems[ListCount].AlbumePicture.Name = " " + ListCount + " ";
                MusicItems[ListCount].AlbumePicture.Image = AlbumImage;
                MusicItems[ListCount].AlbumePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                MusicItems[ListCount].AlbumePicture.DoubleClick += new EventHandler(MusicItemClicked);
                MusicItems[ListCount].AlbumePicture.MouseWheel += new MouseEventHandler(Scrolled);
                MusicItems[ListCount].ItemPanel.Controls.Add(MusicItems[ListCount].AlbumePicture);

                MusicItems[ListCount].InformationLabel.Left = MusicItems[ListCount].AlbumePicture.Left + MusicItems[ListCount].AlbumePicture.Width + 10;
                MusicItems[ListCount].InformationLabel.Top = MusicItems[ListCount].AlbumePicture.Top + 5;
                MusicItems[ListCount].InformationLabel.AutoSize = true;
                MusicItems[ListCount].InformationLabel.Text = "Title :\r\n\r\nArtist :\r\n\r\nAlbume :\r\n\r\nURL :";
                MusicItems[ListCount].InformationLabel.TextAlign = ContentAlignment.TopRight;
                MusicItems[ListCount].InformationLabel.MouseWheel += new MouseEventHandler(Scrolled);
                MusicItems[ListCount].ItemPanel.Controls.Add(MusicItems[ListCount].InformationLabel);

                MusicItems[ListCount].AddPlayList.Dock = DockStyle.Right;
                MusicItems[ListCount].AddPlayList.Width = 50;
                MusicItems[ListCount].AddPlayList.Image = Properties.Resources.AddPlayList;
                MusicItems[ListCount].AddPlayList.MouseClick += new MouseEventHandler(AddPlayList);
                MusicItems[ListCount].ItemPanel.Controls.Add(MusicItems[ListCount].AddPlayList);

                MusicItems[ListCount].InformationText.Left = MusicItems[ListCount].InformationLabel.Left + MusicItems[ListCount].InformationLabel.Width + 5;
                MusicItems[ListCount].InformationText.Top = MusicItems[ListCount].InformationLabel.Top + 1;
                MusicItems[ListCount].InformationText.Height = MusicItems[ListCount].InformationLabel.Height;
                MusicItems[ListCount].InformationText.Width = MusicItems[ListCount].ItemPanel.Width - MusicItems[ListCount].InformationText.Left - 10;
                MusicItems[ListCount].InformationText.Multiline = true;
                MusicItems[ListCount].InformationText.Text = Title + "\r\n\r\n" + Artist + "\r\n\r\n" + Album + "\r\n\r\n" + URL;
                MusicItems[ListCount].InformationText.BorderStyle = BorderStyle.None;
                MusicItems[ListCount].InformationText.BackColor = MusicItems[ListCount].ItemPanel.BackColor;
                MusicItems[ListCount].InformationText.ReadOnly = true;
                MusicItems[ListCount].InformationText.MouseWheel += new MouseEventHandler(Scrolled);
                MusicItems[ListCount].ItemPanel.Controls.Add(MusicItems[ListCount].InformationText);



                ListCount++;
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("WTF!!\r\n" + e);
                return false;
            }

        }
        private void HighLightPlayListItem(int Index)
        {
            for(int i = 0; NowPlayListView.Items.Count > i;i++)
            {
                if(NowPlayListView.Items[i].BackColor == Color.Black)
                {
                    NowPlayListView.Items[i].BackColor = Color.White;
                    NowPlayListView.Items[i].ForeColor = Color.Black;
                }
            }
            NowPlayListView.Items[Index].ForeColor = Color.LightGoldenrodYellow;
            NowPlayListView.Items[Index].BackColor = Color.Black;
        }
        private void UnHighLightPlayListItem()
        {
            for (int i = 0; NowPlayListView.Items.Count > i; i++)
            {
                if (NowPlayListView.Items[i].BackColor == Color.Black)
                {
                    NowPlayListView.Items[i].BackColor = Color.White;
                    NowPlayListView.Items[i].ForeColor = Color.Black;
                }
            }
        }
        private void AddNowPlayList(string Title, int SongLenght)
        {
            ListViewItem item = new ListViewItem();
            string lenght = TimeSpan.FromSeconds((double)SongLenght).ToString(@"mm\:ss");

            item.Text = (NowPlayListView.Items.Count+1).ToString();

            item.SubItems.Add(Title);
            item.SubItems.Add(lenght);
            NowPlayListView.Items.Add(item);
        }
        
        //*******************************************
        //*           Controls Events               *
        //*******************************************

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm_Resize(sender, e);
            MusicListPanel.MouseWheel += new MouseEventHandler(Scrolled);
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {

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
                SearchResult = Crawling.SearchCrawlingResult(SearchText.Text);
                for (int i = 0; (SearchResult.Length) > i; i++)
                    CreateMusicItem(
                        SearchResult[i].Title,
                        SearchResult[i].Artist,
                        SearchResult[i].Album,
                        SearchResult[i].AlbumImage,
                        SearchResult[i].URL);
                MusicListBar.Maximum = ListCount;
                MusicListBar.Value = 0;
            }
            MusicInfo = Crawling.ID3TagCrawlingResult(SearchText.Text);
            if (MusicInfo.Title == null) MusicInfo = SearchResult[0];
        }
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
        private void MusicPlayTimer_Tick(object sender, EventArgs e)
        {
            if(Player.URL != "")
            {
                double duration = Player.controls.currentItem.duration;

                SongLenghtBar.Maximum = (int)Player.controls.currentItem.duration;
                SongLenghtBar.Value = (int)Player.controls.currentPosition;
                if (SongLenghtBar.Maximum == SongLenghtBar.Value && SongLenghtBar.Maximum != 0)
                {
                    if (NowPlayListView.Items.Count > SelectedMusic) PlayLocalMP3(NowPlayListItems[SelectedMusic].URL);
                    else { Player.controls.stop(); UnHighLightPlayListItem(); NowPlayInformationText.Text = ""; SelectedMusic = 0; }
                }
            }
        }
        private void NowPlayList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
                int i = 0;
                Array.Sort(file);
                foreach (string str in file)
                {
                    ListViewItem PlayListItem = new ListViewItem((NowPlayListView.Items.Count + 1).ToString());
                    PlayListItem.SubItems.Add(Path.GetFileName(str));
                    PlayListItem.SubItems.Add("[??:??]");

                    NowPlayListView.Items.Add(PlayListItem);

                    NowPlayListItems[i].Number = i;
                    NowPlayListItems[i].TItle = Path.GetFileName(str);
                    NowPlayListItems[i].URL = str;
                    NowPlayListItems[i].PlayTime = "?";
                    i++;
                }
            }
        }
        private void NowPlayList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy | DragDropEffects.Scroll;
            }
        }
        private void NowPlayList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectedMusic = Convert.ToInt32(NowPlayListView.FocusedItem.SubItems[0].Text) - 1;
            PlayButton_Click(sender,e);
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            if(Player.status.Contains("재생"))
            {
                PlayButton.Image = Properties.Resources.Start;
                Player.controls.pause();
            }
            else if(Player.status.Contains("일시"))
            {
                PlayButton.Image = Properties.Resources.Pause;
                Player.controls.play();
            }
            else if(Player.status == "")
            {
                PlayButton.Image = Properties.Resources.Pause;
                PlayLocalMP3(NowPlayListItems[SelectedMusic].URL);
            }

        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            Player.controls.stop();// = new WindowsMediaPlayer();
            MusicInfo = new MusicInformation();
            SelectedMusic--;
        }
        private void SongLenghtBar_Scroll(object sender, EventArgs e)
        {
            Player.controls.currentPosition = SongLenghtBar.Value;
        }
        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = VolumeBar.Value;
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (SelectedMusic >= NowPlayListView.Items.Count) SelectedMusic = 0;

            PlayLocalMP3(NowPlayListItems[SelectedMusic].URL);
        }

        #endregion


    }
}
