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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainForm_Resize(sender, e);
            MusicListPanel.MouseWheel += new MouseEventHandler(Scrolled);
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
                AlbumePicture[ListCount].Click += new System.EventHandler(DownloadButton);
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
            SearchButton.Left = Width - SearchButton.Width - 25;
            SearchText.Width = SearchButton.Left - 20;

            MusicListPanel.Left = SearchText.Left;
            MusicListPanel.Width = SearchButton.Left + SearchButton.Width - 13;
            //MusicListPanel.Height = PlayBar.Top - 75;

            if(ListCount > 0)
            {
                for(int i = 0 ; ListCount > i ; i++)
                {
                    MusicItemPanel[i].Width = MusicListBar.Left;
                    MusicInformationText[i].Width = MusicItemPanel[1].Width - (MusicInformationText[1].Left + 10);
                }
            }
        }
        
        private void DownloadButton(object sender, EventArgs e)
        {
            int Index = Convert.ToInt32(((PictureBox)sender).Name.Trim());
            string indextext = MusicInformationText[Index].Text;
            int urlstartposition = indextext.LastIndexOf("https://");
            string url = indextext.Remove(0, urlstartposition);

            Thread Down = new Thread(() => Downloader.YoutubeDownloader(url, ".\\Music\\", Index));
            Down.Start();

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

        }
    }
}
