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
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.LabelClose = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBarVolume = new MetroFramework.Controls.MetroTrackBar();
            this.pictureBoxEqu = new System.Windows.Forms.PictureBox();
            this.metroLabelCurrentPos = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEqu)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelURL
            // 
            this.LabelURL.AutoSize = true;
            this.LabelURL.Location = new System.Drawing.Point(147, 44);
            this.LabelURL.Name = "LabelURL";
            this.LabelURL.Size = new System.Drawing.Size(129, 19);
            this.LabelURL.TabIndex = 1;
            this.LabelURL.Text = "Введите URL-адрес:";
            // 
            // TextFieldURL
            // 
            this.TextFieldURL.Location = new System.Drawing.Point(309, 44);
            this.TextFieldURL.Name = "TextFieldURL";
            this.TextFieldURL.Size = new System.Drawing.Size(172, 23);
            this.TextFieldURL.TabIndex = 3;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.Location = new System.Drawing.Point(233, 99);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(178, 35);
            this.ButtonAdd.TabIndex = 6;
            this.ButtonAdd.Text = "Прослушать песню";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
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
            this.metroTrackBarVolume.Location = new System.Drawing.Point(257, 73);
            this.metroTrackBarVolume.Name = "metroTrackBarVolume";
            this.metroTrackBarVolume.Size = new System.Drawing.Size(138, 23);
            this.metroTrackBarVolume.TabIndex = 8;
            this.metroTrackBarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBarVolume_Scroll);
            // 
            // pictureBoxEqu
            // 
            this.pictureBoxEqu.Image = global::Музыкальный_плеер.Properties.Resources._21945286;
            this.pictureBoxEqu.Location = new System.Drawing.Point(487, 30);
            this.pictureBoxEqu.Name = "pictureBoxEqu";
            this.pictureBoxEqu.Size = new System.Drawing.Size(158, 85);
            this.pictureBoxEqu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEqu.TabIndex = 9;
            this.pictureBoxEqu.TabStop = false;
            this.pictureBoxEqu.Visible = false;
            // 
            // metroLabelCurrentPos
            // 
            this.metroLabelCurrentPos.AutoSize = true;
            this.metroLabelCurrentPos.Location = new System.Drawing.Point(300, 137);
            this.metroLabelCurrentPos.Name = "metroLabelCurrentPos";
            this.metroLabelCurrentPos.Size = new System.Drawing.Size(40, 19);
            this.metroLabelCurrentPos.TabIndex = 10;
            this.metroLabelCurrentPos.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ListenSongFromSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 165);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabelCurrentPos);
            this.Controls.Add(this.pictureBoxEqu);
            this.Controls.Add(this.metroTrackBarVolume);
            this.Controls.Add(this.LabelClose);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextFieldURL);
            this.Controls.Add(this.LabelURL);
            this.MaximumSize = new System.Drawing.Size(645, 165);
            this.MinimumSize = new System.Drawing.Size(645, 165);
            this.Name = "ListenSongFromSite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSongFromSite_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEqu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel LabelURL;
        private MetroFramework.Controls.MetroTextBox TextFieldURL;
        private System.Windows.Forms.Button ButtonAdd;
        private MetroFramework.Controls.MetroLabel LabelClose;
        private MetroFramework.Controls.MetroTrackBar metroTrackBarVolume;
        private System.Windows.Forms.PictureBox pictureBoxEqu;
        private MetroFramework.Controls.MetroLabel metroLabelCurrentPos;
        private System.Windows.Forms.Timer timer1;
    }
}