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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.NowPlayList = new System.Windows.Forms.ListBox();
            this.SettingIco = new System.Windows.Forms.PictureBox();
            this.PlayListIco = new System.Windows.Forms.PictureBox();
            this.SearchIco = new System.Windows.Forms.PictureBox();
            this.PlayIco = new System.Windows.Forms.PictureBox();
            this.PlayBar = new System.Windows.Forms.Panel();
            this.NowPlayInformationLabel = new System.Windows.Forms.Label();
            this.NowPlayInformationText = new System.Windows.Forms.TextBox();
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.StopButton = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.PictureBox();
            this.VolumeButton = new System.Windows.Forms.PictureBox();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.MusicListPanel = new System.Windows.Forms.Panel();
            this.MusicListBar = new System.Windows.Forms.VScrollBar();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PlayPanel = new System.Windows.Forms.Panel();
            this.LyricistLabel = new System.Windows.Forms.Label();
            this.PlayAlbumCover = new System.Windows.Forms.PictureBox();
            this.SoundVisualizer = new System.Windows.Forms.Panel();
            this.YoutubePlayer = new System.Windows.Forms.WebBrowser();
            this.PlayListPanel = new System.Windows.Forms.Panel();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.PlayListBar = new System.Windows.Forms.VScrollBar();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.HotKeyPanel = new System.Windows.Forms.Panel();
            this.AutoDown = new System.Windows.Forms.CheckBox();
            this.StartAgain = new System.Windows.Forms.CheckBox();
            this.SavePoint = new System.Windows.Forms.CheckBox();
            this.Tray = new System.Windows.Forms.CheckBox();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayListIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayIco)).BeginInit();
            this.PlayBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.SearchPanel.SuspendLayout();
            this.MusicListPanel.SuspendLayout();
            this.PlayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayAlbumCover)).BeginInit();
            this.PlayListPanel.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.NowPlayList);
            this.LeftPanel.Controls.Add(this.SettingIco);
            this.LeftPanel.Controls.Add(this.PlayListIco);
            this.LeftPanel.Controls.Add(this.SearchIco);
            this.LeftPanel.Controls.Add(this.PlayIco);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(98, 599);
            this.LeftPanel.TabIndex = 2;
            // 
            // NowPlayList
            // 
            this.NowPlayList.FormattingEnabled = true;
            this.NowPlayList.ItemHeight = 12;
            this.NowPlayList.Location = new System.Drawing.Point(0, 391);
            this.NowPlayList.Name = "NowPlayList";
            this.NowPlayList.Size = new System.Drawing.Size(98, 208);
            this.NowPlayList.TabIndex = 4;
            // 
            // SettingIco
            // 
            this.SettingIco.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingIco.Image = global::MusicPlayer.Properties.Resources.cogwheel;
            this.SettingIco.Location = new System.Drawing.Point(0, 294);
            this.SettingIco.Name = "SettingIco";
            this.SettingIco.Size = new System.Drawing.Size(98, 98);
            this.SettingIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingIco.TabIndex = 3;
            this.SettingIco.TabStop = false;
            // 
            // PlayListIco
            // 
            this.PlayListIco.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayListIco.Image = global::MusicPlayer.Properties.Resources._interface;
            this.PlayListIco.Location = new System.Drawing.Point(0, 196);
            this.PlayListIco.Name = "PlayListIco";
            this.PlayListIco.Size = new System.Drawing.Size(98, 98);
            this.PlayListIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayListIco.TabIndex = 2;
            this.PlayListIco.TabStop = false;
            // 
            // SearchIco
            // 
            this.SearchIco.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchIco.Image = global::MusicPlayer.Properties.Resources.square;
            this.SearchIco.Location = new System.Drawing.Point(0, 98);
            this.SearchIco.Name = "SearchIco";
            this.SearchIco.Size = new System.Drawing.Size(98, 98);
            this.SearchIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIco.TabIndex = 1;
            this.SearchIco.TabStop = false;
            this.SearchIco.Click += new System.EventHandler(this.SearchIco_Click);
            // 
            // PlayIco
            // 
            this.PlayIco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PlayIco.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayIco.Image = global::MusicPlayer.Properties.Resources.play;
            this.PlayIco.Location = new System.Drawing.Point(0, 0);
            this.PlayIco.Name = "PlayIco";
            this.PlayIco.Size = new System.Drawing.Size(98, 98);
            this.PlayIco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayIco.TabIndex = 0;
            this.PlayIco.TabStop = false;
            this.PlayIco.Click += new System.EventHandler(this.PlayIco_Click);
            // 
            // PlayBar
            // 
            this.PlayBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PlayBar.Controls.Add(this.NowPlayInformationLabel);
            this.PlayBar.Controls.Add(this.NowPlayInformationText);
            this.PlayBar.Controls.Add(this.PlayButton);
            this.PlayBar.Controls.Add(this.StopButton);
            this.PlayBar.Controls.Add(this.NextButton);
            this.PlayBar.Controls.Add(this.VolumeButton);
            this.PlayBar.Controls.Add(this.VolumeBar);
            this.PlayBar.Location = new System.Drawing.Point(98, 532);
            this.PlayBar.Name = "PlayBar";
            this.PlayBar.Size = new System.Drawing.Size(821, 66);
            this.PlayBar.TabIndex = 6;
            // 
            // NowPlayInformationLabel
            // 
            this.NowPlayInformationLabel.AutoSize = true;
            this.NowPlayInformationLabel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NowPlayInformationLabel.Location = new System.Drawing.Point(4, 6);
            this.NowPlayInformationLabel.Name = "NowPlayInformationLabel";
            this.NowPlayInformationLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NowPlayInformationLabel.Size = new System.Drawing.Size(71, 57);
            this.NowPlayInformationLabel.TabIndex = 6;
            this.NowPlayInformationLabel.Text = ": Artist\r\n: Album\r\n: Title";
            // 
            // NowPlayInformationText
            // 
            this.NowPlayInformationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NowPlayInformationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NowPlayInformationText.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NowPlayInformationText.Location = new System.Drawing.Point(79, 5);
            this.NowPlayInformationText.Multiline = true;
            this.NowPlayInformationText.Name = "NowPlayInformationText";
            this.NowPlayInformationText.ReadOnly = true;
            this.NowPlayInformationText.Size = new System.Drawing.Size(214, 58);
            this.NowPlayInformationText.TabIndex = 5;
            // 
            // PlayButton
            // 
            this.PlayButton.Image = global::MusicPlayer.Properties.Resources.Start;
            this.PlayButton.Location = new System.Drawing.Point(388, 9);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(50, 50);
            this.PlayButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayButton.TabIndex = 4;
            this.PlayButton.TabStop = false;
            // 
            // StopButton
            // 
            this.StopButton.Image = global::MusicPlayer.Properties.Resources.Stop;
            this.StopButton.Location = new System.Drawing.Point(342, 15);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(40, 40);
            this.StopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StopButton.TabIndex = 3;
            this.StopButton.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Image = global::MusicPlayer.Properties.Resources.Next;
            this.NextButton.Location = new System.Drawing.Point(444, 15);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(40, 40);
            this.NextButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NextButton.TabIndex = 2;
            this.NextButton.TabStop = false;
            // 
            // VolumeButton
            // 
            this.VolumeButton.Image = global::MusicPlayer.Properties.Resources.Volume;
            this.VolumeButton.Location = new System.Drawing.Point(605, 20);
            this.VolumeButton.Name = "VolumeButton";
            this.VolumeButton.Size = new System.Drawing.Size(28, 28);
            this.VolumeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VolumeButton.TabIndex = 1;
            this.VolumeButton.TabStop = false;
            // 
            // VolumeBar
            // 
            this.VolumeBar.AutoSize = false;
            this.VolumeBar.Location = new System.Drawing.Point(638, 23);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(145, 28);
            this.VolumeBar.TabIndex = 0;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeBar.Value = 50;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.MusicListPanel);
            this.SearchPanel.Controls.Add(this.SearchText);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.Location = new System.Drawing.Point(504, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(415, 262);
            this.SearchPanel.TabIndex = 7;
            this.SearchPanel.Visible = false;
            // 
            // MusicListPanel
            // 
            this.MusicListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MusicListPanel.Controls.Add(this.MusicListBar);
            this.MusicListPanel.Location = new System.Drawing.Point(0, 41);
            this.MusicListPanel.Name = "MusicListPanel";
            this.MusicListPanel.Size = new System.Drawing.Size(415, 221);
            this.MusicListPanel.TabIndex = 9;
            // 
            // MusicListBar
            // 
            this.MusicListBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.MusicListBar.Location = new System.Drawing.Point(386, 0);
            this.MusicListBar.Name = "MusicListBar";
            this.MusicListBar.Size = new System.Drawing.Size(29, 221);
            this.MusicListBar.TabIndex = 0;
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchText.ForeColor = System.Drawing.Color.Silver;
            this.SearchText.Location = new System.Drawing.Point(0, 0);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(344, 43);
            this.SearchText.TabIndex = 7;
            this.SearchText.Text = "Search Here... (~￣▽￣)~";
            this.SearchText.Enter += new System.EventHandler(this.SearchText_Enter);
            this.SearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchText_KeyPress);
            this.SearchText.Leave += new System.EventHandler(this.SearchText_Leave);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchButton.Location = new System.Drawing.Point(340, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 43);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "FIND";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PlayPanel
            // 
            this.PlayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PlayPanel.Controls.Add(this.LyricistLabel);
            this.PlayPanel.Controls.Add(this.PlayAlbumCover);
            this.PlayPanel.Controls.Add(this.SoundVisualizer);
            this.PlayPanel.Controls.Add(this.YoutubePlayer);
            this.PlayPanel.Location = new System.Drawing.Point(98, 1);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(405, 261);
            this.PlayPanel.TabIndex = 8;
            // 
            // LyricistLabel
            // 
            this.LyricistLabel.BackColor = System.Drawing.Color.Transparent;
            this.LyricistLabel.Location = new System.Drawing.Point(193, 135);
            this.LyricistLabel.Name = "LyricistLabel";
            this.LyricistLabel.Size = new System.Drawing.Size(212, 126);
            this.LyricistLabel.TabIndex = 4;
            this.LyricistLabel.Text = "Lyricist";
            this.LyricistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LyricistLabel.Visible = false;
            // 
            // PlayAlbumCover
            // 
            this.PlayAlbumCover.Image = global::MusicPlayer.Properties.Resources.NoImage;
            this.PlayAlbumCover.Location = new System.Drawing.Point(0, 135);
            this.PlayAlbumCover.Name = "PlayAlbumCover";
            this.PlayAlbumCover.Size = new System.Drawing.Size(195, 126);
            this.PlayAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayAlbumCover.TabIndex = 3;
            this.PlayAlbumCover.TabStop = false;
            // 
            // SoundVisualizer
            // 
            this.SoundVisualizer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SoundVisualizer.Location = new System.Drawing.Point(195, 0);
            this.SoundVisualizer.Name = "SoundVisualizer";
            this.SoundVisualizer.Size = new System.Drawing.Size(210, 135);
            this.SoundVisualizer.TabIndex = 2;
            this.SoundVisualizer.Visible = false;
            // 
            // YoutubePlayer
            // 
            this.YoutubePlayer.Location = new System.Drawing.Point(0, -1);
            this.YoutubePlayer.MinimumSize = new System.Drawing.Size(20, 20);
            this.YoutubePlayer.Name = "YoutubePlayer";
            this.YoutubePlayer.Size = new System.Drawing.Size(195, 136);
            this.YoutubePlayer.TabIndex = 0;
            this.YoutubePlayer.Url = new System.Uri("about:blank", System.UriKind.Absolute);
            // 
            // PlayListPanel
            // 
            this.PlayListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PlayListPanel.Controls.Add(this.ListPanel);
            this.PlayListPanel.Controls.Add(this.PlayListBar);
            this.PlayListPanel.Location = new System.Drawing.Point(98, 263);
            this.PlayListPanel.Name = "PlayListPanel";
            this.PlayListPanel.Size = new System.Drawing.Size(405, 268);
            this.PlayListPanel.TabIndex = 11;
            this.PlayListPanel.Visible = false;
            // 
            // ListPanel
            // 
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 0);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(388, 268);
            this.ListPanel.TabIndex = 1;
            // 
            // PlayListBar
            // 
            this.PlayListBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.PlayListBar.Location = new System.Drawing.Point(388, 0);
            this.PlayListBar.Name = "PlayListBar";
            this.PlayListBar.Size = new System.Drawing.Size(17, 268);
            this.PlayListBar.TabIndex = 0;
            // 
            // SettingPanel
            // 
            this.SettingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SettingPanel.Controls.Add(this.HotKeyPanel);
            this.SettingPanel.Controls.Add(this.AutoDown);
            this.SettingPanel.Controls.Add(this.StartAgain);
            this.SettingPanel.Controls.Add(this.SavePoint);
            this.SettingPanel.Controls.Add(this.Tray);
            this.SettingPanel.Location = new System.Drawing.Point(504, 263);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(415, 272);
            this.SettingPanel.TabIndex = 12;
            this.SettingPanel.Visible = false;
            // 
            // HotKeyPanel
            // 
            this.HotKeyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HotKeyPanel.Location = new System.Drawing.Point(47, 224);
            this.HotKeyPanel.Name = "HotKeyPanel";
            this.HotKeyPanel.Size = new System.Drawing.Size(308, 39);
            this.HotKeyPanel.TabIndex = 4;
            // 
            // AutoDown
            // 
            this.AutoDown.Appearance = System.Windows.Forms.Appearance.Button;
            this.AutoDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AutoDown.BackgroundImage = global::MusicPlayer.Properties.Resources.Download;
            this.AutoDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AutoDown.Location = new System.Drawing.Point(262, 31);
            this.AutoDown.Name = "AutoDown";
            this.AutoDown.Size = new System.Drawing.Size(93, 88);
            this.AutoDown.TabIndex = 3;
            this.AutoDown.UseVisualStyleBackColor = false;
            // 
            // StartAgain
            // 
            this.StartAgain.Appearance = System.Windows.Forms.Appearance.Button;
            this.StartAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StartAgain.BackgroundImage = global::MusicPlayer.Properties.Resources.Again;
            this.StartAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartAgain.Location = new System.Drawing.Point(47, 128);
            this.StartAgain.Name = "StartAgain";
            this.StartAgain.Size = new System.Drawing.Size(93, 88);
            this.StartAgain.TabIndex = 2;
            this.StartAgain.UseVisualStyleBackColor = false;
            // 
            // SavePoint
            // 
            this.SavePoint.Appearance = System.Windows.Forms.Appearance.Button;
            this.SavePoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SavePoint.BackgroundImage = global::MusicPlayer.Properties.Resources.AutoDown;
            this.SavePoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SavePoint.Location = new System.Drawing.Point(262, 128);
            this.SavePoint.Name = "SavePoint";
            this.SavePoint.Size = new System.Drawing.Size(93, 88);
            this.SavePoint.TabIndex = 1;
            this.SavePoint.UseVisualStyleBackColor = false;
            // 
            // Tray
            // 
            this.Tray.Appearance = System.Windows.Forms.Appearance.Button;
            this.Tray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Tray.BackgroundImage = global::MusicPlayer.Properties.Resources.balloon;
            this.Tray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tray.Location = new System.Drawing.Point(47, 31);
            this.Tray.Name = "Tray";
            this.Tray.Size = new System.Drawing.Size(93, 88);
            this.Tray.TabIndex = 0;
            this.Tray.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 599);
            this.Controls.Add(this.PlayBar);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.PlayListPanel);
            this.Controls.Add(this.PlayPanel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "MainForm";
            this.Text = "~(￣▽￣~) MusicPlayer (~￣▽￣)~";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayListIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayIco)).EndInit();
            this.PlayBar.ResumeLayout(false);
            this.PlayBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.MusicListPanel.ResumeLayout(false);
            this.PlayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayAlbumCover)).EndInit();
            this.PlayListPanel.ResumeLayout(false);
            this.SettingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.PictureBox SettingIco;
        private System.Windows.Forms.PictureBox PlayListIco;
        private System.Windows.Forms.PictureBox SearchIco;
        private System.Windows.Forms.PictureBox PlayIco;
        private System.Windows.Forms.Panel PlayBar;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Panel MusicListPanel;
        private System.Windows.Forms.VScrollBar MusicListBar;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox NowPlayList;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.Panel PlayPanel;
        private System.Windows.Forms.PictureBox PlayAlbumCover;
        private System.Windows.Forms.Panel SoundVisualizer;
        private System.Windows.Forms.WebBrowser YoutubePlayer;
        private System.Windows.Forms.Panel PlayListPanel;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.VScrollBar PlayListBar;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.CheckBox Tray;
        private System.Windows.Forms.Panel HotKeyPanel;
        private System.Windows.Forms.CheckBox AutoDown;
        private System.Windows.Forms.CheckBox StartAgain;
        private System.Windows.Forms.CheckBox SavePoint;
        private System.Windows.Forms.Label NowPlayInformationLabel;
        private System.Windows.Forms.TextBox NowPlayInformationText;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.PictureBox StopButton;
        private System.Windows.Forms.PictureBox NextButton;
        private System.Windows.Forms.PictureBox VolumeButton;
        private System.Windows.Forms.Label LyricistLabel;
    }
}

