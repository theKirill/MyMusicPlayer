namespace Музыкальный_плеер
{
    partial class ListenSongFromSite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LabelURL = new MetroFramework.Controls.MetroLabel();
            this.TextFieldURL = new MetroFramework.Controls.MetroTextBox();
            this.ButtonListen = new System.Windows.Forms.Button();
            this.LabelClose = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBarVolume = new MetroFramework.Controls.MetroTrackBar();
            this.pictureBoxEqu = new System.Windows.Forms.PictureBox();
            this.metroLabelCurrentPos = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEqu)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelURL
            // 
            this.LabelURL.AutoSize = true;
            this.LabelURL.Location = new System.Drawing.Point(147, 47);
            this.LabelURL.Name = "LabelURL";
            this.LabelURL.Size = new System.Drawing.Size(129, 19);
            this.LabelURL.TabIndex = 1;
            this.LabelURL.Text = "Введите URL-адрес:";
            // 
            // TextFieldURL
            // 
            this.TextFieldURL.Location = new System.Drawing.Point(309, 47);
            this.TextFieldURL.Name = "TextFieldURL";
            this.TextFieldURL.Size = new System.Drawing.Size(172, 23);
            this.TextFieldURL.TabIndex = 3;
            // 
            // ButtonListen
            // 
            this.ButtonListen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonListen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonListen.Location = new System.Drawing.Point(233, 102);
            this.ButtonListen.Name = "ButtonListen";
            this.ButtonListen.Size = new System.Drawing.Size(178, 35);
            this.ButtonListen.TabIndex = 6;
            this.ButtonListen.Text = "Прослушать песню";
            this.ButtonListen.UseVisualStyleBackColor = true;
            this.ButtonListen.Click += new System.EventHandler(this.ButtonListen_Click);
            // 
            // LabelClose
            // 
            this.LabelClose.AutoSize = true;
            this.LabelClose.Location = new System.Drawing.Point(587, 5);
            this.LabelClose.Name = "LabelClose";
            this.LabelClose.Size = new System.Drawing.Size(58, 19);
            this.LabelClose.TabIndex = 7;
            this.LabelClose.Text = "Закрыть";
            this.LabelClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // metroTrackBarVolume
            // 
            this.metroTrackBarVolume.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBarVolume.Location = new System.Drawing.Point(257, 76);
            this.metroTrackBarVolume.Name = "metroTrackBarVolume";
            this.metroTrackBarVolume.Size = new System.Drawing.Size(138, 23);
            this.metroTrackBarVolume.TabIndex = 8;
            this.metroTrackBarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarVolume_Scroll);
            // 
            // pictureBoxEqu
            // 
            this.pictureBoxEqu.Image = global::Музыкальный_плеер.Properties.Resources._21945286;
            this.pictureBoxEqu.Location = new System.Drawing.Point(486, 47);
            this.pictureBoxEqu.Name = "pictureBoxEqu";
            this.pictureBoxEqu.Size = new System.Drawing.Size(158, 71);
            this.pictureBoxEqu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEqu.TabIndex = 9;
            this.pictureBoxEqu.TabStop = false;
            this.pictureBoxEqu.Visible = false;
            // 
            // metroLabelCurrentPos
            // 
            this.metroLabelCurrentPos.AutoSize = true;
            this.metroLabelCurrentPos.Location = new System.Drawing.Point(300, 140);
            this.metroLabelCurrentPos.Name = "metroLabelCurrentPos";
            this.metroLabelCurrentPos.Size = new System.Drawing.Size(40, 19);
            this.metroLabelCurrentPos.TabIndex = 10;
            this.metroLabelCurrentPos.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(134, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(393, 15);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Внимание! Песню можно прослушать пока только с сайта zaycev.net!";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(156, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(99, 15);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Пример ссылки:";
            // 
            // metroLink1
            // 
            this.metroLink1.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.metroLink1.Location = new System.Drawing.Point(261, 23);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(251, 23);
            this.metroLink1.TabIndex = 13;
            this.metroLink1.Text = "http://zaycev.net/pages/71718/7171893.shtml";
            // 
            // ListenSongFromSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 165);
            this.ControlBox = false;
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelCurrentPos);
            this.Controls.Add(this.pictureBoxEqu);
            this.Controls.Add(this.metroTrackBarVolume);
            this.Controls.Add(this.LabelClose);
            this.Controls.Add(this.ButtonListen);
            this.Controls.Add(this.TextFieldURL);
            this.Controls.Add(this.LabelURL);
            this.MaximumSize = new System.Drawing.Size(645, 165);
            this.MinimumSize = new System.Drawing.Size(645, 165);
            this.Name = "ListenSongFromSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListenSongFromSite_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEqu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel LabelURL;
        private MetroFramework.Controls.MetroTextBox TextFieldURL;
        private System.Windows.Forms.Button ButtonListen;
        private MetroFramework.Controls.MetroLabel LabelClose;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarVolume;
        private System.Windows.Forms.PictureBox pictureBoxEqu;
        private MetroFramework.Controls.MetroLabel metroLabelCurrentPos;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}