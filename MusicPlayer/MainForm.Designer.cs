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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.SettingButton = new System.Windows.Forms.PictureBox();
            this.MaximumButton = new System.Windows.Forms.PictureBox();
            this.MinimumButton = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.HomeButton = new System.Windows.Forms.PictureBox();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.ShuffleButton = new System.Windows.Forms.PictureBox();
            this.RepeatButton = new System.Windows.Forms.PictureBox();
            this.MusicSearchButton = new System.Windows.Forms.PictureBox();
            this.NowPlayInformationText = new System.Windows.Forms.Label();
            this.SongLenghtBar = new System.Windows.Forms.TrackBar();
            this.NowPlayInformationLabel = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.StopButton = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.PictureBox();
            this.VolumeButton = new System.Windows.Forms.PictureBox();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.MusicPlayButton = new System.Windows.Forms.PictureBox();
            this.PlaylistPanel = new System.Windows.Forms.Panel();
            this.PlayListTabControl = new System.Windows.Forms.TabControl();
            this.NowPlaylistTab = new System.Windows.Forms.TabPage();
            this.PlayListControlPanel = new System.Windows.Forms.Panel();
            this.NowPlayListDownloadButton = new System.Windows.Forms.Button();
            this.NowPlayListRemoveButton = new System.Windows.Forms.Button();
            this.NowPlayList = new System.Windows.Forms.ListView();
            this.NowPlaylistNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NowPlaylistTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NowPlaylistLenght = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlaylistTab = new System.Windows.Forms.TabPage();
            this.PlayListsTreeView = new System.Windows.Forms.TreeView();
            this.PlayListsControlPanel = new System.Windows.Forms.Panel();
            this.PlayListDownloadButton = new System.Windows.Forms.Button();
            this.PlayListsRemoveButton = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.DashBoardTabPage = new System.Windows.Forms.TabPage();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.PlayTabPage = new System.Windows.Forms.TabPage();
            this.LyricistLabel = new System.Windows.Forms.Label();
            this.YoutubePlayer = new System.Windows.Forms.WebBrowser();
            this.PlayAlbumCover = new System.Windows.Forms.PictureBox();
            this.SearchTabPage = new System.Windows.Forms.TabPage();
            this.MusicListPanel = new System.Windows.Forms.Panel();
            this.MusicListBar = new System.Windows.Forms.VScrollBar();
            this.SearchTabBottomPanel = new System.Windows.Forms.Panel();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.AddPlaylistButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SettingTabPage = new System.Windows.Forms.TabPage();
            this.MusicPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.TitlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).BeginInit();
            this.ToolBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShuffleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicSearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongLenghtBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayButton)).BeginInit();
            this.PlaylistPanel.SuspendLayout();
            this.PlayListTabControl.SuspendLayout();
            this.NowPlaylistTab.SuspendLayout();
            this.PlayListControlPanel.SuspendLayout();
            this.PlaylistTab.SuspendLayout();
            this.PlayListsControlPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.DashBoardTabPage.SuspendLayout();
            this.PlayTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayAlbumCover)).BeginInit();
            this.SearchTabPage.SuspendLayout();
            this.MusicListPanel.SuspendLayout();
            this.SearchTabBottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(179)))), ((int)(((byte)(194)))));
            this.TitlebarPanel.Controls.Add(this.SettingButton);
            this.TitlebarPanel.Controls.Add(this.MaximumButton);
            this.TitlebarPanel.Controls.Add(this.MinimumButton);
            this.TitlebarPanel.Controls.Add(this.CloseButton);
            this.TitlebarPanel.Controls.Add(this.HomeButton);
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
            this.SettingButton.Image = global::MusicPlayer.Properties.Resources.Setting;
            this.SettingButton.Location = new System.Drawing.Point(104, 3);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(25, 25);
            this.SettingButton.TabIndex = 10;
            this.SettingButton.TabStop = false;
            // 
            // MaximumButton
            // 
            this.MaximumButton.Image = global::MusicPlayer.Properties.Resources.Maximum;
            this.MaximumButton.Location = new System.Drawing.Point(760, 3);
            this.MaximumButton.Name = "MaximumButton";
            this.MaximumButton.Size = new System.Drawing.Size(75, 25);
            this.MaximumButton.TabIndex = 11;
            this.MaximumButton.TabStop = false;
            // 
            // MinimumButton
            // 
            this.MinimumButton.Image = global::MusicPlayer.Properties.Resources.Minimum;
            this.MinimumButton.Location = new System.Drawing.Point(845, 3);
            this.MinimumButton.Name = "MinimumButton";
            this.MinimumButton.Size = new System.Drawing.Size(75, 25);
            this.MinimumButton.TabIndex = 12;
            this.MinimumButton.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::MusicPlayer.Properties.Resources.Close;
            this.CloseButton.Location = new System.Drawing.Point(926, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 25);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Image = global::MusicPlayer.Properties.Resources.Home;
            this.HomeButton.Location = new System.Drawing.Point(3, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(95, 25);
            this.HomeButton.TabIndex = 14;
            this.HomeButton.TabStop = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.Yellow;
            this.ToolBarPanel.Controls.Add(this.ShuffleButton);
            this.ToolBarPanel.Controls.Add(this.RepeatButton);
            this.ToolBarPanel.Controls.Add(this.MusicSearchButton);
            this.ToolBarPanel.Controls.Add(this.NowPlayInformationText);
            this.ToolBarPanel.Controls.Add(this.SongLenghtBar);
            this.ToolBarPanel.Controls.Add(this.NowPlayInformationLabel);
            this.ToolBarPanel.Controls.Add(this.PlayButton);
            this.ToolBarPanel.Controls.Add(this.StopButton);
            this.ToolBarPanel.Controls.Add(this.NextButton);
            this.ToolBarPanel.Controls.Add(this.VolumeButton);
            this.ToolBarPanel.Controls.Add(this.VolumeBar);
            this.ToolBarPanel.Controls.Add(this.MusicPlayButton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 30);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(1007, 130);
            this.ToolBarPanel.TabIndex = 14;
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.BackColor = System.Drawing.Color.Transparent;
            this.ShuffleButton.Image = global::MusicPlayer.Properties.Resources.UnShuffle;
            this.ShuffleButton.Location = new System.Drawing.Point(735, 85);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(30, 30);
            this.ShuffleButton.TabIndex = 39;
            this.ShuffleButton.TabStop = false;
            // 
            // RepeatButton
            // 
            this.RepeatButton.BackColor = System.Drawing.Color.Transparent;
            this.RepeatButton.Image = global::MusicPlayer.Properties.Resources.AllRepeat;
            this.RepeatButton.Location = new System.Drawing.Point(771, 86);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(30, 30);
            this.RepeatButton.TabIndex = 38;
            this.RepeatButton.TabStop = false;
            // 
            // MusicSearchButton
            // 
            this.MusicSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.MusicSearchButton.Image = global::MusicPlayer.Properties.Resources.Search;
            this.MusicSearchButton.Location = new System.Drawing.Point(153, 18);
            this.MusicSearchButton.Name = "MusicSearchButton";
            this.MusicSearchButton.Size = new System.Drawing.Size(95, 95);
            this.MusicSearchButton.TabIndex = 37;
            this.MusicSearchButton.TabStop = false;
            this.MusicSearchButton.Click += new System.EventHandler(this.MusicSearchButton_Click);
            // 
            // NowPlayInformationText
            // 
            this.NowPlayInformationText.BackColor = System.Drawing.Color.Transparent;
            this.NowPlayInformationText.Font = new System.Drawing.Font("굴림", 14.25F);
            this.NowPlayInformationText.Location = new System.Drawing.Point(779, 13);
            this.NowPlayInformationText.Name = "NowPlayInformationText";
            this.NowPlayInformationText.Size = new System.Drawing.Size(206, 67);
            this.NowPlayInformationText.TabIndex = 34;
            // 
            // SongLenghtBar
            // 
            this.SongLenghtBar.AutoSize = false;
            this.SongLenghtBar.Location = new System.Drawing.Point(280, 96);
            this.SongLenghtBar.Maximum = 100;
            this.SongLenghtBar.Name = "SongLenghtBar";
            this.SongLenghtBar.Size = new System.Drawing.Size(434, 15);
            this.SongLenghtBar.TabIndex = 33;
            this.SongLenghtBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SongLenghtBar.Scroll += new System.EventHandler(this.SongLenghtBar_Scroll);
            // 
            // NowPlayInformationLabel
            // 
            this.NowPlayInformationLabel.AutoSize = true;
            this.NowPlayInformationLabel.BackColor = System.Drawing.Color.Transparent;
            this.NowPlayInformationLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NowPlayInformationLabel.Location = new System.Drawing.Point(710, 15);
            this.NowPlayInformationLabel.Name = "NowPlayInformationLabel";
            this.NowPlayInformationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NowPlayInformationLabel.Size = new System.Drawing.Size(71, 57);
            this.NowPlayInformationLabel.TabIndex = 32;
            this.NowPlayInformationLabel.Text = ": Artist\r\n: Album\r\n: Title";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.Location = new System.Drawing.Point(492, 45);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(50, 50);
            this.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayButton.TabIndex = 30;
            this.PlayButton.TabStop = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.Image = global::MusicPlayer.Properties.Resources.Stop;
            this.StopButton.Location = new System.Drawing.Point(446, 51);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(40, 40);
            this.StopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StopButton.TabIndex = 29;
            this.StopButton.TabStop = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.Location = new System.Drawing.Point(548, 51);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(40, 40);
            this.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextButton.TabIndex = 28;
            this.NextButton.TabStop = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // VolumeButton
            // 
            this.VolumeButton.BackColor = System.Drawing.Color.Transparent;
            this.VolumeButton.Image = global::MusicPlayer.Properties.Resources.UnMute;
            this.VolumeButton.Location = new System.Drawing.Point(807, 85);
            this.VolumeButton.Name = "VolumeButton";
            this.VolumeButton.Size = new System.Drawing.Size(30, 30);
            this.VolumeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VolumeButton.TabIndex = 27;
            this.VolumeButton.TabStop = false;
            // 
            // VolumeBar
            // 
            this.VolumeBar.AutoSize = false;
            this.VolumeBar.Location = new System.Drawing.Point(838, 91);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(145, 28);
            this.VolumeBar.TabIndex = 26;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeBar.Value = 50;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // MusicPlayButton
            // 
            this.MusicPlayButton.BackColor = System.Drawing.Color.Transparent;
            this.MusicPlayButton.Image = global::MusicPlayer.Properties.Resources.play;
            this.MusicPlayButton.Location = new System.Drawing.Point(29, 18);
            this.MusicPlayButton.Name = "MusicPlayButton";
            this.MusicPlayButton.Size = new System.Drawing.Size(92, 93);
            this.MusicPlayButton.TabIndex = 40;
            this.MusicPlayButton.TabStop = false;
            this.MusicPlayButton.Click += new System.EventHandler(this.MusicPlayButton_Click);
            // 
            // PlaylistPanel
            // 
            this.PlaylistPanel.Controls.Add(this.PlayListTabControl);
            this.PlaylistPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.PlaylistPanel.Location = new System.Drawing.Point(707, 160);
            this.PlaylistPanel.Name = "PlaylistPanel";
            this.PlaylistPanel.Size = new System.Drawing.Size(300, 474);
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
            this.PlayListTabControl.Size = new System.Drawing.Size(300, 474);
            this.PlayListTabControl.TabIndex = 0;
            // 
            // NowPlaylistTab
            // 
            this.NowPlaylistTab.Controls.Add(this.PlayListControlPanel);
            this.NowPlaylistTab.Controls.Add(this.NowPlayList);
            this.NowPlaylistTab.Location = new System.Drawing.Point(4, 34);
            this.NowPlaylistTab.Name = "NowPlaylistTab";
            this.NowPlaylistTab.Padding = new System.Windows.Forms.Padding(3);
            this.NowPlaylistTab.Size = new System.Drawing.Size(292, 436);
            this.NowPlaylistTab.TabIndex = 0;
            this.NowPlaylistTab.Text = "NowPlayList";
            this.NowPlaylistTab.UseVisualStyleBackColor = true;
            // 
            // PlayListControlPanel
            // 
            this.PlayListControlPanel.Controls.Add(this.NowPlayListDownloadButton);
            this.PlayListControlPanel.Controls.Add(this.NowPlayListRemoveButton);
            this.PlayListControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayListControlPanel.Location = new System.Drawing.Point(3, 402);
            this.PlayListControlPanel.Name = "PlayListControlPanel";
            this.PlayListControlPanel.Size = new System.Drawing.Size(286, 31);
            this.PlayListControlPanel.TabIndex = 1;
            // 
            // NowPlayListDownloadButton
            // 
            this.NowPlayListDownloadButton.Location = new System.Drawing.Point(84, 5);
            this.NowPlayListDownloadButton.Name = "NowPlayListDownloadButton";
            this.NowPlayListDownloadButton.Size = new System.Drawing.Size(75, 23);
            this.NowPlayListDownloadButton.TabIndex = 1;
            this.NowPlayListDownloadButton.Text = "Download";
            this.NowPlayListDownloadButton.UseVisualStyleBackColor = true;
            // 
            // NowPlayListRemoveButton
            // 
            this.NowPlayListRemoveButton.Location = new System.Drawing.Point(3, 5);
            this.NowPlayListRemoveButton.Name = "NowPlayListRemoveButton";
            this.NowPlayListRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.NowPlayListRemoveButton.TabIndex = 0;
            this.NowPlayListRemoveButton.Text = "Remove";
            this.NowPlayListRemoveButton.UseVisualStyleBackColor = true;
            // 
            // NowPlayList
            // 
            this.NowPlayList.AllowDrop = true;
            this.NowPlayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NowPlayList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NowPlaylistNumber,
            this.NowPlaylistTitle,
            this.NowPlaylistLenght});
            this.NowPlayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NowPlayList.FullRowSelect = true;
            this.NowPlayList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.NowPlayList.Location = new System.Drawing.Point(3, 3);
            this.NowPlayList.Name = "NowPlayList";
            this.NowPlayList.Size = new System.Drawing.Size(286, 430);
            this.NowPlayList.TabIndex = 2;
            this.NowPlayList.UseCompatibleStateImageBehavior = false;
            this.NowPlayList.View = System.Windows.Forms.View.Details;
            this.NowPlayList.DragDrop += new System.Windows.Forms.DragEventHandler(this.NowPlayList_DragDrop);
            this.NowPlayList.DragEnter += new System.Windows.Forms.DragEventHandler(this.NowPlayList_DragEnter);
            this.NowPlayList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NowPlayList_MouseDoubleClick);
            // 
            // NowPlaylistNumber
            // 
            this.NowPlaylistNumber.Text = "";
            this.NowPlaylistNumber.Width = 40;
            // 
            // NowPlaylistTitle
            // 
            this.NowPlaylistTitle.Text = "";
            this.NowPlaylistTitle.Width = 191;
            // 
            // NowPlaylistLenght
            // 
            this.NowPlaylistLenght.Text = "";
            this.NowPlaylistLenght.Width = 54;
            // 
            // PlaylistTab
            // 
            this.PlaylistTab.Controls.Add(this.PlayListsTreeView);
            this.PlaylistTab.Controls.Add(this.PlayListsControlPanel);
            this.PlaylistTab.Location = new System.Drawing.Point(4, 34);
            this.PlaylistTab.Name = "PlaylistTab";
            this.PlaylistTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlaylistTab.Size = new System.Drawing.Size(292, 436);
            this.PlaylistTab.TabIndex = 1;
            this.PlaylistTab.Text = "PlayLists";
            this.PlaylistTab.UseVisualStyleBackColor = true;
            // 
            // PlayListsTreeView
            // 
            this.PlayListsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayListsTreeView.Location = new System.Drawing.Point(3, 3);
            this.PlayListsTreeView.Name = "PlayListsTreeView";
            this.PlayListsTreeView.Size = new System.Drawing.Size(286, 399);
            this.PlayListsTreeView.TabIndex = 1;
            // 
            // PlayListsControlPanel
            // 
            this.PlayListsControlPanel.Controls.Add(this.PlayListDownloadButton);
            this.PlayListsControlPanel.Controls.Add(this.PlayListsRemoveButton);
            this.PlayListsControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayListsControlPanel.Location = new System.Drawing.Point(3, 402);
            this.PlayListsControlPanel.Name = "PlayListsControlPanel";
            this.PlayListsControlPanel.Size = new System.Drawing.Size(286, 31);
            this.PlayListsControlPanel.TabIndex = 2;
            // 
            // PlayListDownloadButton
            // 
            this.PlayListDownloadButton.Location = new System.Drawing.Point(84, 5);
            this.PlayListDownloadButton.Name = "PlayListDownloadButton";
            this.PlayListDownloadButton.Size = new System.Drawing.Size(75, 23);
            this.PlayListDownloadButton.TabIndex = 1;
            this.PlayListDownloadButton.Text = "Download";
            this.PlayListDownloadButton.UseVisualStyleBackColor = true;
            // 
            // PlayListsRemoveButton
            // 
            this.PlayListsRemoveButton.Location = new System.Drawing.Point(3, 5);
            this.PlayListsRemoveButton.Name = "PlayListsRemoveButton";
            this.PlayListsRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.PlayListsRemoveButton.TabIndex = 0;
            this.PlayListsRemoveButton.Text = "Remove";
            this.PlayListsRemoveButton.UseVisualStyleBackColor = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.DashBoardTabPage);
            this.MainTabControl.Controls.Add(this.PlayTabPage);
            this.MainTabControl.Controls.Add(this.SearchTabPage);
            this.MainTabControl.Controls.Add(this.SettingTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.ItemSize = new System.Drawing.Size(0, 30);
            this.MainTabControl.Location = new System.Drawing.Point(0, 160);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(707, 474);
            this.MainTabControl.TabIndex = 18;
            // 
            // DashBoardTabPage
            // 
            this.DashBoardTabPage.Controls.Add(this.vScrollBar1);
            this.DashBoardTabPage.Location = new System.Drawing.Point(4, 34);
            this.DashBoardTabPage.Name = "DashBoardTabPage";
            this.DashBoardTabPage.Size = new System.Drawing.Size(699, 436);
            this.DashBoardTabPage.TabIndex = 2;
            this.DashBoardTabPage.Text = "DashBoardTabPage";
            this.DashBoardTabPage.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(682, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 436);
            this.vScrollBar1.TabIndex = 0;
            // 
            // PlayTabPage
            // 
            this.PlayTabPage.Controls.Add(this.LyricistLabel);
            this.PlayTabPage.Controls.Add(this.YoutubePlayer);
            this.PlayTabPage.Controls.Add(this.PlayAlbumCover);
            this.PlayTabPage.Location = new System.Drawing.Point(4, 34);
            this.PlayTabPage.Name = "PlayTabPage";
            this.PlayTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PlayTabPage.Size = new System.Drawing.Size(699, 436);
            this.PlayTabPage.TabIndex = 0;
            this.PlayTabPage.Text = "PlayTabPage";
            this.PlayTabPage.UseVisualStyleBackColor = true;
            // 
            // LyricistLabel
            // 
            this.LyricistLabel.BackColor = System.Drawing.Color.Transparent;
            this.LyricistLabel.Location = new System.Drawing.Point(-2, 220);
            this.LyricistLabel.Name = "LyricistLabel";
            this.LyricistLabel.Size = new System.Drawing.Size(703, 219);
            this.LyricistLabel.TabIndex = 7;
            this.LyricistLabel.Text = "Lyricist";
            this.LyricistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LyricistLabel.Visible = false;
            // 
            // YoutubePlayer
            // 
            this.YoutubePlayer.Location = new System.Drawing.Point(-1, 0);
            this.YoutubePlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.YoutubePlayer.Name = "YoutubePlayer";
            this.YoutubePlayer.Size = new System.Drawing.Size(381, 217);
            this.YoutubePlayer.TabIndex = 5;
            this.YoutubePlayer.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // PlayAlbumCover
            // 
            this.PlayAlbumCover.Location = new System.Drawing.Point(386, 0);
            this.PlayAlbumCover.Name = "PlayAlbumCover";
            this.PlayAlbumCover.Size = new System.Drawing.Size(313, 217);
            this.PlayAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayAlbumCover.TabIndex = 6;
            this.PlayAlbumCover.TabStop = false;
            // 
            // SearchTabPage
            // 
            this.SearchTabPage.Controls.Add(this.MusicListPanel);
            this.SearchTabPage.Controls.Add(this.SearchTabBottomPanel);
            this.SearchTabPage.Controls.Add(this.SearchText);
            this.SearchTabPage.Controls.Add(this.SearchButton);
            this.SearchTabPage.Location = new System.Drawing.Point(4, 34);
            this.SearchTabPage.Name = "SearchTabPage";
            this.SearchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTabPage.Size = new System.Drawing.Size(699, 436);
            this.SearchTabPage.TabIndex = 1;
            this.SearchTabPage.Text = "SearchTabPage";
            this.SearchTabPage.UseVisualStyleBackColor = true;
            // 
            // MusicListPanel
            // 
            this.MusicListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MusicListPanel.Controls.Add(this.MusicListBar);
            this.MusicListPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MusicListPanel.Location = new System.Drawing.Point(3, 60);
            this.MusicListPanel.Name = "MusicListPanel";
            this.MusicListPanel.Size = new System.Drawing.Size(693, 342);
            this.MusicListPanel.TabIndex = 12;
            // 
            // MusicListBar
            // 
            this.MusicListBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.MusicListBar.Location = new System.Drawing.Point(664, 0);
            this.MusicListBar.Name = "MusicListBar";
            this.MusicListBar.Size = new System.Drawing.Size(29, 342);
            this.MusicListBar.TabIndex = 0;
            // 
            // SearchTabBottomPanel
            // 
            this.SearchTabBottomPanel.Controls.Add(this.DownloadButton);
            this.SearchTabBottomPanel.Controls.Add(this.AddPlaylistButton);
            this.SearchTabBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchTabBottomPanel.Location = new System.Drawing.Point(3, 402);
            this.SearchTabBottomPanel.Name = "SearchTabBottomPanel";
            this.SearchTabBottomPanel.Size = new System.Drawing.Size(693, 31);
            this.SearchTabBottomPanel.TabIndex = 13;
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
            // AddPlaylistButton
            // 
            this.AddPlaylistButton.Location = new System.Drawing.Point(615, 5);
            this.AddPlaylistButton.Name = "AddPlaylistButton";
            this.AddPlaylistButton.Size = new System.Drawing.Size(75, 23);
            this.AddPlaylistButton.TabIndex = 0;
            this.AddPlaylistButton.Text = "Add Playlist";
            this.AddPlaylistButton.UseVisualStyleBackColor = true;
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
            // SettingTabPage
            // 
            this.SettingTabPage.Location = new System.Drawing.Point(4, 34);
            this.SettingTabPage.Name = "SettingTabPage";
            this.SettingTabPage.Size = new System.Drawing.Size(699, 436);
            this.SettingTabPage.TabIndex = 3;
            this.SettingTabPage.Text = "SettingTabPage";
            this.SettingTabPage.UseVisualStyleBackColor = true;
            // 
            // MusicPlayTimer
            // 
            this.MusicPlayTimer.Enabled = true;
            this.MusicPlayTimer.Tick += new System.EventHandler(this.MusicPlayTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 634);
            this.ControlBox = false;
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.PlaylistPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.Controls.Add(this.TitlebarPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TitlebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).EndInit();
            this.ToolBarPanel.ResumeLayout(false);
            this.ToolBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShuffleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicSearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SongLenghtBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusicPlayButton)).EndInit();
            this.PlaylistPanel.ResumeLayout(false);
            this.PlayListTabControl.ResumeLayout(false);
            this.NowPlaylistTab.ResumeLayout(false);
            this.PlayListControlPanel.ResumeLayout(false);
            this.PlaylistTab.ResumeLayout(false);
            this.PlayListsControlPanel.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.DashBoardTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.TrackBar SongLenghtBar;
        private System.Windows.Forms.Label NowPlayInformationLabel;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.PictureBox StopButton;
        private System.Windows.Forms.PictureBox NextButton;
        private System.Windows.Forms.PictureBox VolumeButton;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.Panel PlaylistPanel;
        private System.Windows.Forms.TabControl PlayListTabControl;
        private System.Windows.Forms.TabPage NowPlaylistTab;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage DashBoardTabPage;
        private System.Windows.Forms.TabPage PlayTabPage;
        private System.Windows.Forms.Label LyricistLabel;
        private System.Windows.Forms.PictureBox PlayAlbumCover;
        private System.Windows.Forms.WebBrowser YoutubePlayer;
        private System.Windows.Forms.TabPage SearchTabPage;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Panel MusicListPanel;
        private System.Windows.Forms.VScrollBar MusicListBar;
        private System.Windows.Forms.TabPage SettingTabPage;
        private System.Windows.Forms.ListView NowPlayList;
        private System.Windows.Forms.Panel PlayListControlPanel;
        private System.Windows.Forms.Button NowPlayListDownloadButton;
        private System.Windows.Forms.Button NowPlayListRemoveButton;
        private System.Windows.Forms.Panel SearchTabBottomPanel;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button AddPlaylistButton;
        private System.Windows.Forms.Timer MusicPlayTimer;
        private System.Windows.Forms.Label NowPlayInformationText;
        private System.Windows.Forms.ColumnHeader NowPlaylistNumber;
        private System.Windows.Forms.ColumnHeader NowPlaylistTitle;
        private System.Windows.Forms.ColumnHeader NowPlaylistLenght;
        private System.Windows.Forms.TabPage PlaylistTab;
        private System.Windows.Forms.TreeView PlayListsTreeView;
        private System.Windows.Forms.Panel PlayListsControlPanel;
        private System.Windows.Forms.Button PlayListDownloadButton;
        private System.Windows.Forms.Button PlayListsRemoveButton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.PictureBox SettingButton;
        private System.Windows.Forms.PictureBox MusicSearchButton;
        private System.Windows.Forms.PictureBox ShuffleButton;
        private System.Windows.Forms.PictureBox RepeatButton;
        private System.Windows.Forms.PictureBox MusicPlayButton;
        private System.Windows.Forms.PictureBox MaximumButton;
        private System.Windows.Forms.PictureBox MinimumButton;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox HomeButton;
    }
}

