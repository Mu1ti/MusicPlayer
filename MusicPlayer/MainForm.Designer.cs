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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.PlayBar = new System.Windows.Forms.Panel();
            this.MusicListPanel = new System.Windows.Forms.Panel();
            this.MusicListBar = new System.Windows.Forms.VScrollBar();
            this.MusicListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchButton.Location = new System.Drawing.Point(609, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 43);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "FIND";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchText.ForeColor = System.Drawing.Color.Silver;
            this.SearchText.Location = new System.Drawing.Point(12, 12);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(591, 43);
            this.SearchText.TabIndex = 1;
            this.SearchText.Text = "Search Here... (~￣▽￣)~";
            this.SearchText.Enter += new System.EventHandler(this.SearchText_Enter);
            this.SearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchText_KeyPress);
            this.SearchText.Leave += new System.EventHandler(this.SearchText_Leave);
            // 
            // PlayBar
            // 
            this.PlayBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PlayBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayBar.Location = new System.Drawing.Point(0, 477);
            this.PlayBar.Name = "PlayBar";
            this.PlayBar.Size = new System.Drawing.Size(696, 47);
            this.PlayBar.TabIndex = 2;
            // 
            // MusicListPanel
            // 
            this.MusicListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MusicListPanel.Controls.Add(this.MusicListBar);
            this.MusicListPanel.Location = new System.Drawing.Point(12, 61);
            this.MusicListPanel.Name = "MusicListPanel";
            this.MusicListPanel.Size = new System.Drawing.Size(672, 410);
            this.MusicListPanel.TabIndex = 3;
            // 
            // MusicListBar
            // 
            this.MusicListBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.MusicListBar.Location = new System.Drawing.Point(643, 0);
            this.MusicListBar.Name = "MusicListBar";
            this.MusicListBar.Size = new System.Drawing.Size(29, 410);
            this.MusicListBar.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 524);
            this.Controls.Add(this.MusicListPanel);
            this.Controls.Add(this.PlayBar);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.SearchButton);
            this.Name = "MainForm";
            this.Text = "~(￣▽￣~) MusicPlayer (~￣▽￣)~";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.MusicListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Panel PlayBar;
        private System.Windows.Forms.Panel MusicListPanel;
        private System.Windows.Forms.VScrollBar MusicListBar;
    }
}

