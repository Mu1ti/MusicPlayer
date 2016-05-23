namespace MusicPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.SettingButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.MaximalButton = new System.Windows.Forms.Button();
            this.MinimalButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.SongLenghtBar = new System.Windows.Forms.TrackBar();
            this.NowPlayInformationLabel = new System.Windows.Forms.Label();
            this.NowPlayInformationText = new System.Windows.Forms.TextBox();
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.StopButton = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.PictureBox();
            this.VolumeButton = new System.Windows.Forms.PictureBox();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.MusicSearchButton = new System.Windows.Forms.Button();
            this.MusicPlayButton = new System.Windows.Forms.Button();
            this.PlaylistPanel = new System.Windows.Forms.Panel();
            this.PlayListTabControl = new System.Windows.Forms.TabControl();
            this.NowPlaylistTab = new System.Windows.Forms.TabPage();
            this.NowPlayList = new System.Windows.Forms.ListView();
            this.PlayListControlPanel = new System.Windows.Forms.Panel();
            this.DownloadListitemButton = new System.Windows.Forms.Button();
            this.RemoveListitemButton = new System.Windows.Forms.Button();
            this.PlaylistTab = new System.Windows.Forms.TabPage();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.DashBoardTabPage = new System.Windows.Forms.TabPage();
            this.Top10ListPanel = new System.Windows.Forms.Panel();
            this.Top10Label = new System.Windows.Forms.Label();
            this.PlayTabPage = new System.Windows.Forms.TabPage();
            this.LyricistLabel = new System.Windows.Forms.Label();
            this.PlayAlbumCover = new System.Windows.Forms.PictureBox();
            this.YoutubePlayer = new System.Windows.Forms.WebBrowser();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MusicListPanel = new System.Windows.Forms.Panel();
            this.MusicListBar = new System.Windows.Forms.VScrollBar();
            this.SettingTabPage = new System.Windows.Forms.TabPage();
            this.SearchTabBottomPanel = new System.Windows.Forms.Panel();
            this.AddPlaylistButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.TitlebarPanel.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongLenghtBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.PlaylistPanel.SuspendLayout();
            this.PlayListTabControl.SuspendLayout();
            this.NowPlaylistTab.SuspendLayout();
            this.PlayListControlPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.DashBoardTabPage.SuspendLayout();
            this.Top10ListPanel.SuspendLayout();
            this.PlayTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayAlbumCover)).BeginInit();
            this.SearchTabPage.SuspendLayout();
            this.MusicListPanel.SuspendLayout();
            this.SearchTabBottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TitlebarPanel.Controls.Add(this.SettingButton);
            this.TitlebarPanel.Controls.Add(this.HomeButton);
            this.TitlebarPanel.Controls.Add(this.MaximalButton);
            this.TitlebarPanel.Controls.Add(this.MinimalButton);
            this.TitlebarPanel.Controls.Add(this.CloseButton);
            this.TitlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(1007, 30);
            this.TitlebarPanel.TabIndex = 16;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseDown);
            this.TitlebarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseMove);
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(101, 3);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(25, 25);
            this.SettingButton.TabIndex = 9;
            this.SettingButton.Text = "*";
            this.SettingButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(3, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(92, 23);
            this.HomeButton.TabIndex = 8;
            this.HomeButton.Text = "MusicPlayer";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MaximalButton
            // 
            this.MaximalButton.Location = new System.Drawing.Point(760, 3);
            this.MaximalButton.Name = "MaximalButton";
            this.MaximalButton.Size = new System.Drawing.Size(75, 23);
            this.MaximalButton.TabIndex = 7;
            this.MaximalButton.Text = "ㅁ";
            this.MaximalButton.UseVisualStyleBackColor = true;
            // 
            // MinimalButton
            // 
            this.MinimalButton.Location = new System.Drawing.Point(845, 3);
            this.MinimalButton.Name = "MinimalButton";
            this.MinimalButton.Size = new System.Drawing.Size(75, 23);
            this.MinimalButton.TabIndex = 6;
            this.MinimalButton.Text = "_____";
            this.MinimalButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(926, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ToolBarPanel.Controls.Add(this.SongLenghtBar);
            this.ToolBarPanel.Controls.Add(this.NowPlayInformationLabel);
            this.ToolBarPanel.Controls.Add(this.NowPlayInformationText);
            this.ToolBarPanel.Controls.Add(this.PlayButton);
            this.ToolBarPanel.Controls.Add(this.StopButton);
            this.ToolBarPanel.Controls.Add(this.NextButton);
            this.ToolBarPanel.Controls.Add(this.VolumeButton);
            this.ToolBarPanel.Controls.Add(this.VolumeBar);
            this.ToolBarPanel.Controls.Add(this.MusicSearchButton);
            this.ToolBarPanel.Controls.Add(this.MusicPlayButton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 30);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(1007, 127);
            this.ToolBarPanel.TabIndex = 14;
            // 
            // SongLenghtBar
            // 
            this.SongLenghtBar.AutoSize = false;
            this.SongLenghtBar.Location = new System.Drawing.Point(280, 96);
            this.SongLenghtBar.Name = "SongLenghtBar";
            this.SongLenghtBar.Size = new System.Drawing.Size(434, 15);
            this.SongLenghtBar.TabIndex = 33;
            this.SongLenghtBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // NowPlayInformationLabel
            // 
            this.NowPlayInformationLabel.AutoSize = true;
            this.NowPlayInformationLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NowPlayInformationLabel.Location = new System.Drawing.Point(707, 14);
            this.NowPlayInformationLabel.Name = "NowPlayInformationLabel";
            this.NowPlayInformationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NowPlayInformationLabel.Size = new System.Drawing.Size(71, 57);
            this.NowPlayInformationLabel.TabIndex = 32;
            this.NowPlayInformationLabel.Text = ": Artist\r\n: Album\r\n: Title";
            // 
            // NowPlayInformationText
            // 
            this.NowPlayInformationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NowPlayInformationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NowPlayInformationText.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NowPlayInformationText.Location = new System.Drawing.Point(784, 13);
            this.NowPlayInformationText.Multiline = true;
            this.NowPlayInformationText.Name = "NowPlayInformationText";
            this.NowPlayInformationText.ReadOnly = true;
            this.NowPlayInformationText.Size = new System.Drawing.Size(214, 58);
            this.NowPlayInformationText.TabIndex = 31;
            // 
            // PlayButton
            // 
            this.PlayButton.Image = global::MusicPlayer.Properties.Resources.Start;
            this.PlayButton.Location = new System.Drawing.Point(492, 45);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(50, 50);
            this.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayButton.TabIndex = 30;
            this.PlayButton.TabStop = false;
            // 
            // StopButton
            // 
            this.StopButton.Image = global::MusicPlayer.Properties.Resources.Stop;
            this.StopButton.Location = new System.Drawing.Point(446, 51);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(40, 40);
            this.StopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StopButton.TabIndex = 29;
            this.StopButton.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Image = global::MusicPlayer.Properties.Resources.Next;
            this.NextButton.Location = new System.Drawing.Point(548, 51);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(40, 40);
            this.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextButton.TabIndex = 28;
            this.NextButton.TabStop = false;
            // 
            // VolumeButton
            // 
            this.VolumeButton.Image = global::MusicPlayer.Properties.Resources.Volume;
            this.VolumeButton.Location = new System.Drawing.Point(807, 83);
            this.VolumeButton.Name = "VolumeButton";
            this.VolumeButton.Size = new System.Drawing.Size(28, 28);
            this.VolumeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VolumeButton.TabIndex = 27;
            this.VolumeButton.TabStop = false;
            // 
            // VolumeBar
            // 
            this.VolumeBar.AutoSize = false;
            this.VolumeBar.Location = new System.Drawing.Point(845, 83);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(145, 28);
            this.VolumeBar.TabIndex = 26;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeBar.Value = 50;
            // 
            // MusicSearchButton
            // 
            this.MusicSearchButton.Location = new System.Drawing.Point(144, 18);
            this.MusicSearchButton.Name = "MusicSearchButton";
            this.MusicSearchButton.Size = new System.Drawing.Size(90, 77);
            this.MusicSearchButton.TabIndex = 25;
            this.MusicSearchButton.Text = "Search";
            this.MusicSearchButton.UseVisualStyleBackColor = true;
            this.MusicSearchButton.Click += new System.EventHandler(this.MusicSearchButton_Click);
            // 
            // MusicPlayButton
            // 
            this.MusicPlayButton.Location = new System.Drawing.Point(26, 18);
            this.MusicPlayButton.Name = "MusicPlayButton";
            this.MusicPlayButton.Size = new System.Drawing.Size(91, 77);
            this.MusicPlayButton.TabIndex = 24;
            this.MusicPlayButton.Text = "Music";
            this.MusicPlayButton.UseVisualStyleBackColor = true;
            this.MusicPlayButton.Click += new System.EventHandler(this.MusicPlayButton_Click);
            // 
            // PlaylistPanel
            // 
            this.PlaylistPanel.Controls.Add(this.PlayListTabControl);
            this.PlaylistPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PlaylistPanel.Location = new System.Drawing.Point(707, 157);
            this.PlaylistPanel.Name = "PlaylistPanel";
            this.PlaylistPanel.Size = new System.Drawing.Size(300, 477);
            this.PlaylistPanel.TabIndex = 17;
            // 
            // PlayListTabControl
            // 
            this.PlayListTabControl.Controls.Add(this.NowPlaylistTab);
            this.PlayListTabControl.Controls.Add(this.PlaylistTab);
            this.PlayListTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayListTabControl.ItemSize = new System.Drawing.Size(500, 30);
            this.PlayListTabControl.Location = new System.Drawing.Point(0, 0);
            this.PlayListTabControl.Name = "PlayListTabControl";
            this.PlayListTabControl.SelectedIndex = 0;
            this.PlayListTabControl.Size = new System.Drawing.Size(300, 477);
            this.PlayListTabControl.TabIndex = 0;
            // 
            // NowPlaylistTab
            // 
            this.NowPlaylistTab.Controls.Add(this.NowPlayList);
            this.NowPlaylistTab.Controls.Add(this.PlayListControlPanel);
            this.NowPlaylistTab.Location = new System.Drawing.Point(4, 34);
            this.NowPlaylistTab.Name = "NowPlaylistTab";
            this.NowPlaylistTab.Padding = new System.Windows.Forms.Padding(3);
            this.NowPlaylistTab.Size = new System.Drawing.Size(292, 439);
            this.NowPlaylistTab.TabIndex = 0;
            this.NowPlaylistTab.Text = "NowPlayList";
            this.NowPlaylistTab.UseVisualStyleBackColor = true;
            // 
            // NowPlayList
            // 
            this.NowPlayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NowPlayList.Location = new System.Drawing.Point(3, 3);
            this.NowPlayList.Name = "NowPlayList";
            this.NowPlayList.Size = new System.Drawing.Size(286, 402);
            this.NowPlayList.TabIndex = 2;
            this.NowPlayList.UseCompatibleStateImageBehavior = false;
            // 
            // PlayListControlPanel
            // 
            this.PlayListControlPanel.Controls.Add(this.DownloadListitemButton);
            this.PlayListControlPanel.Controls.Add(this.RemoveListitemButton);
            this.PlayListControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayListControlPanel.Location = new System.Drawing.Point(3, 405);
            this.PlayListControlPanel.Name = "PlayListControlPanel";
            this.PlayListControlPanel.Size = new System.Drawing.Size(286, 31);
            this.PlayListControlPanel.TabIndex = 1;
            // 
            // DownloadListitemButton
            // 
            this.DownloadListitemButton.Location = new System.Drawing.Point(84, 5);
            this.DownloadListitemButton.Name = "DownloadListitemButton";
            this.DownloadListitemButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadListitemButton.TabIndex = 1;
            this.DownloadListitemButton.Text = "Download";
            this.DownloadListitemButton.UseVisualStyleBackColor = true;
            // 
            // RemoveListitemButton
            // 
            this.RemoveListitemButton.Location = new System.Drawing.Point(3, 5);
            this.RemoveListitemButton.Name = "RemoveListitemButton";
            this.RemoveListitemButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveListitemButton.TabIndex = 0;
            this.RemoveListitemButton.Text = "Remove";
            this.RemoveListitemButton.UseVisualStyleBackColor = true;
            // 
            // PlaylistTab
            // 
            this.PlaylistTab.Location = new System.Drawing.Point(4, 34);
            this.PlaylistTab.Name = "PlaylistTab";
            this.PlaylistTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlaylistTab.Size = new System.Drawing.Size(292, 502);
            this.PlaylistTab.TabIndex = 1;
            this.PlaylistTab.Text = "PlayLists";
            this.PlaylistTab.UseVisualStyleBackColor = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.DashBoardTabPage);
            this.MainTabControl.Controls.Add(this.PlayTabPage);
            this.MainTabControl.Controls.Add(this.SearchTabPage);
            this.MainTabControl.Controls.Add(this.SettingTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ItemSize = new System.Drawing.Size(0, 30);
            this.MainTabControl.Location = new System.Drawing.Point(0, 157);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(707, 477);
            this.MainTabControl.TabIndex = 18;
            // 
            // DashBoardTabPage
            // 
            this.DashBoardTabPage.Controls.Add(this.Top10ListPanel);
            this.DashBoardTabPage.Location = new System.Drawing.Point(4, 34);
            this.DashBoardTabPage.Name = "DashBoardTabPage";
            this.DashBoardTabPage.Size = new System.Drawing.Size(699, 502);
            this.DashBoardTabPage.TabIndex = 2;
            this.DashBoardTabPage.Text = "DashBoardTabPage";
            this.DashBoardTabPage.UseVisualStyleBackColor = true;
            // 
            // Top10ListPanel
            // 
            this.Top10ListPanel.Controls.Add(this.Top10Label);
            this.Top10ListPanel.Location = new System.Drawing.Point(8, 13);
            this.Top10ListPanel.Name = "Top10ListPanel";
            this.Top10ListPanel.Size = new System.Drawing.Size(677, 185);
            this.Top10ListPanel.TabIndex = 0;
            // 
            // Top10Label
            // 
            this.Top10Label.AutoSize = true;
            this.Top10Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top10Label.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Top10Label.Location = new System.Drawing.Point(0, 0);
            this.Top10Label.Name = "Top10Label";
            this.Top10Label.Size = new System.Drawing.Size(90, 24);
            this.Top10Label.TabIndex = 0;
            this.Top10Label.Text = "TOP 10";
            // 
            // PlayTabPage
            // 
            this.PlayTabPage.Controls.Add(this.LyricistLabel);
            this.PlayTabPage.Controls.Add(this.PlayAlbumCover);
            this.PlayTabPage.Controls.Add(this.YoutubePlayer);
            this.PlayTabPage.Location = new System.Drawing.Point(4, 34);
            this.PlayTabPage.Name = "PlayTabPage";
            this.PlayTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayTabPage.Size = new System.Drawing.Size(699, 502);
            this.PlayTabPage.TabIndex = 0;
            this.PlayTabPage.Text = "PlayTabPage";
            this.PlayTabPage.UseVisualStyleBackColor = true;
            // 
            // LyricistLabel
            // 
            this.LyricistLabel.BackColor = System.Drawing.Color.Transparent;
            this.LyricistLabel.Location = new System.Drawing.Point(271, 182);
            this.LyricistLabel.Name = "LyricistLabel";
            this.LyricistLabel.Size = new System.Drawing.Size(212, 126);
            this.LyricistLabel.TabIndex = 7;
            this.LyricistLabel.Text = "Lyricist";
            this.LyricistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LyricistLabel.Visible = false;
            // 
            // PlayAlbumCover
            // 
            this.PlayAlbumCover.Image = global::MusicPlayer.Properties.Resources.NoImage;
            this.PlayAlbumCover.Location = new System.Drawing.Point(78, 182);
            this.PlayAlbumCover.Name = "PlayAlbumCover";
            this.PlayAlbumCover.Size = new System.Drawing.Size(195, 126);
            this.PlayAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayAlbumCover.TabIndex = 6;
            this.PlayAlbumCover.TabStop = false;
            // 
            // YoutubePlayer
            // 
            this.YoutubePlayer.Location = new System.Drawing.Point(78, 46);
            this.YoutubePlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.YoutubePlayer.Name = "YoutubePlayer";
            this.YoutubePlayer.Size = new System.Drawing.Size(195, 136);
            this.YoutubePlayer.TabIndex = 5;
            this.YoutubePlayer.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.SearchTabBottomPanel);
            this.SearchTabPage.Controls.Add(this.SearchText);
            this.SearchTabPage.Controls.Add(this.SearchButton);
            this.SearchTabPage.Controls.Add(this.MusicListPanel);
            this.SearchTabPage.Location = new System.Drawing.Point(4, 34);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(699, 439);
            this.SearchTabPage.TabIndex = 1;
            this.SearchTabPage.Text = "SearchTabPage";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchText.ForeColor = System.Drawing.Color.Silver;
            this.SearchText.Location = new System.Drawing.Point(0, 0);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(617, 43);
            this.SearchText.TabIndex = 11;
            this.SearchText.Text = "Search Here... (~￣▽￣)~";
            this.SearchText.Enter += new System.EventHandler(this.SearchText_Enter);
            this.SearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchText_KeyPress);
            this.SearchText.Leave += new System.EventHandler(this.SearchText_Leave);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchButton.Location = new System.Drawing.Point(623, 1);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 43);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "FIND";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MusicListPanel
            // 
            this.MusicListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MusicListPanel.Controls.Add(this.MusicListBar);
            this.MusicListPanel.Location = new System.Drawing.Point(3, 49);
            this.MusicListPanel.Name = "MusicListPanel";
            this.MusicListPanel.Size = new System.Drawing.Size(693, 339);
            this.MusicListPanel.TabIndex = 12;
            // 
            // MusicListBar
            // 
            this.MusicListBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.MusicListBar.Location = new System.Drawing.Point(664, 0);
            this.MusicListBar.Name = "MusicListBar";
            this.MusicListBar.Size = new System.Drawing.Size(29, 339);
            this.MusicListBar.TabIndex = 0;
            // 
            // SettingTabPage
            // 
            this.SettingTabPage.Location = new System.Drawing.Point(4, 34);
            this.SettingTabPage.Name = "SettingTabPage";
            this.SettingTabPage.Size = new System.Drawing.Size(699, 502);
            this.SettingTabPage.TabIndex = 3;
            this.SettingTabPage.Text = "SettingTabPage";
            this.SettingTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchTabBottomPanel
            // 
            this.SearchTabBottomPanel.Controls.Add(this.DownloadButton);
            this.SearchTabBottomPanel.Controls.Add(this.AddPlaylistButton);
            this.SearchTabBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchTabBottomPanel.Location = new System.Drawing.Point(3, 405);
            this.SearchTabBottomPanel.Name = "SearchTabBottomPanel";
            this.SearchTabBottomPanel.Size = new System.Drawing.Size(693, 31);
            this.SearchTabBottomPanel.TabIndex = 13;
            // 
            // AddPlaylistButton
            // 
            this.AddPlaylistButton.Location = new System.Drawing.Point(615, 5);
            this.AddPlaylistButton.Name = "AddPlaylistButton";
            this.AddPlaylistButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlaylistButton.TabIndex = 0;
            this.AddPlaylistButton.Text = "Add Playlist";
            this.AddPlaylistButton.UseVisualStyleBackColor = true;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(534, 5);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1007, 634);
            this.ControlBox = false;
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.PlaylistPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.Controls.Add(this.TitlebarPanel);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TitlebarPanel.ResumeLayout(false);
            this.ToolBarPanel.ResumeLayout(false);
            this.ToolBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongLenghtBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.PlaylistPanel.ResumeLayout(false);
            this.PlayListTabControl.ResumeLayout(false);
            this.NowPlaylistTab.ResumeLayout(false);
            this.PlayListControlPanel.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.DashBoardTabPage.ResumeLayout(false);
            this.Top10ListPanel.ResumeLayout(false);
            this.Top10ListPanel.PerformLayout();
            this.PlayTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayAlbumCover)).EndInit();
            this.SearchTabPage.ResumeLayout(false);
            this.SearchTabPage.PerformLayout();
            this.MusicListPanel.ResumeLayout(false);
            this.SearchTabBottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Panel ToolBarPanel;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button MaximalButton;
        private System.Windows.Forms.Button MinimalButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TrackBar SongLenghtBar;
        private System.Windows.Forms.Label NowPlayInformationLabel;
        private System.Windows.Forms.TextBox NowPlayInformationText;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.PictureBox StopButton;
        private System.Windows.Forms.PictureBox NextButton;
        private System.Windows.Forms.PictureBox VolumeButton;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.Button MusicSearchButton;
        private System.Windows.Forms.Button MusicPlayButton;
        private System.Windows.Forms.Panel PlaylistPanel;
        private System.Windows.Forms.TabControl PlayListTabControl;
        private System.Windows.Forms.TabPage NowPlaylistTab;
        private System.Windows.Forms.TabPage PlaylistTab;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage DashBoardTabPage;
        private System.Windows.Forms.Panel Top10ListPanel;
        private System.Windows.Forms.TabPage PlayTabPage;
        private System.Windows.Forms.Label LyricistLabel;
        private System.Windows.Forms.PictureBox PlayAlbumCover;
        private System.Windows.Forms.WebBrowser YoutubePlayer;
        private System.Windows.Forms.TabPage SearchTabPage;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel MusicListPanel;
        private System.Windows.Forms.VScrollBar MusicListBar;
        private System.Windows.Forms.Label Top10Label;
        private System.Windows.Forms.TabPage SettingTabPage;
        private System.Windows.Forms.ListView NowPlayList;
        private System.Windows.Forms.Panel PlayListControlPanel;
        private System.Windows.Forms.Button DownloadListitemButton;
        private System.Windows.Forms.Button RemoveListitemButton;
        private System.Windows.Forms.Panel SearchTabBottomPanel;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button AddPlaylistButton;
    }
}

