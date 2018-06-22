using System;
using MetroFramework.Forms;
using System.Windows.Forms;
using WMPLib;

namespace Музыкальный_плеер
{
    public partial class ListenSongFromSite : MetroForm
    {
        public string URL;
        public string result;
        bool close = false;

        Parser p;
        ParserWorker parser;
        WindowsMediaPlayer wmpFromSite = new WindowsMediaPlayer();

        public ListenSongFromSite()
        {
            InitializeComponent();
            p = new Parser();
            parser = new ParserWorker(p);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            wmpFromSite.controls.stop();
            close = true;
            this.Close();
        }

        private void metroTrackBarVolume_Scroll(object sender, ScrollEventArgs e)
        {
            wmpFromSite.settings.volume = metroTrackBarVolume.Value;//изменение громкости
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabelCurrentPos.Text = wmpFromSite.controls.currentPositionString;//обновление текущей позиции играющего трека
            if (metroLabelCurrentPos.Text == "")
                pictureBoxEqu.Visible = false;
            else
                pictureBoxEqu.Visible = true;
        }

        private void ListenSongFromSite_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
                e.Cancel = false;
            else
            {
                result = parser.Result;
                wmpFromSite.URL = this.result;//присваивание URL найденного трека с сайта
                wmpFromSite.controls.play();//проигрывание песни с сайта
                timer1.Enabled = true;
                pictureBoxEqu.Visible = true;
                e.Cancel = true;
            }
        }

        private void ButtonListen_Click(object sender, EventArgs e)
        {
            if (TextFieldURL.Text != "")
            {
                URL = TextFieldURL.Text;
                p.BaseURL = URL;
                parser.Start(this);//запуск парсера
            }
            else
            {
                MessageBox.Show("Введён пустой URL-адрес");
            }
        }
    }
}      