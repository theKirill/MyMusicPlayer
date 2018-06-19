using System;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using MetroFramework.Forms;

namespace Музыкальный_плеер
{
    public partial class Form1 : MetroForm
    {
        int oldIndexDrive = 0;
        string oldDir = "";
        bool left = true;
        bool pause = false;
        bool stop = false;
        List<string> filesForSearch = new List<string>();

        public Form1()
        {
            InitializeComponent();
            справкаToolStripMenuItem.ShortcutKeys = Keys.F1;
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, buttonPrev.Width, buttonPrev.Height);
            Region myRegion = new Region(myPath);
            buttonPrev.Region = myRegion;
            buttonPlay.Region = myRegion;
            buttonNext.Region = myRegion;
            buttonPause.Region = myRegion;
            buttonStop.Region = myRegion;
            buttonRand.Region = myRegion;
            buttonRepeatSong.Region = myRegion;
            buttonRepeatPL.Region = myRegion;
        }

        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        PlayList pL = new PlayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            pL.Volume = trackVolume.Value;
            oldIndexDrive = DriveLB.SelectedIndex;
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            pL.Volume = trackVolume.Value;
            toolTip1.SetToolTip(trackVolume, trackVolume.Value.ToString());
            wmp.settings.volume = trackVolume.Value;
        }

        private void trackLength_Scroll(object sender, EventArgs e)
        {
            pL.CurrentPosition = trackLength.Value;
            toolTip1.SetToolTip(trackLength, trackLength.Value.ToString());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pL.NumberOfCurrentSong != -1)
            {
                trackLength.Maximum = Convert.ToInt32(pL.LengthOfCurrentSong);
                trackLength.Value = Convert.ToInt32(pL.CurrentPosition);
                labelCurrentPosition.Text = pL.CurrentPositionStr;
                labelLength.Text = pL.LengthOfCurrentSongStr;

                labelCurrentSongName.Text = pL.Playlist.ElementAt(pL.NumberOfCurrentSong).Name;

                if ((labelCurrentSongName.Left > labelCurrentSong.Left + labelCurrentSong.Width) && left)
                    labelCurrentSongName.Left -= 1;
                else
                if (labelCurrentSongName.Left + labelCurrentSongName.Width + 15 < this.Width)
                {
                    labelCurrentSongName.Left += 1;
                    left = false;
                }
                else
                    left = true;

                if (вСлучайномПорядкеToolStripMenuItem.Checked)
                {
                    if (pL.CurrentPosition + 1 >= pL.LengthOfCurrentSong)
                    {
                        if (!повторятьТрекToolStripMenuItem.Checked)
                        {
                            Random randNumberOfSong = new Random();
                            int r = randNumberOfSong.Next(pL.Playlist.Count);
                            pL.NumberOfCurrentSong = r;
                            playListLB.SelectedIndex = pL.NumberOfCurrentSong;
                        }
                        pL.Play();
                        //wmp.URL = playListLB.SelectedItem.ToString();//
                    }
                }
                else
                {
                    if (pL.NumberOfCurrentSong != pL.Playlist.Count - 1)
                    {
                        if (pL.CurrentPosition + 1 >= pL.LengthOfCurrentSong)
                        {
                            if (!повторятьТрекToolStripMenuItem.Checked)
                            {
                                pL.NumberOfCurrentSong += 1;
                                playListLB.SelectedIndex = pL.NumberOfCurrentSong;
                            }
                            pL.Play();
                        }
                    }
                    else
                    {
                        if (pL.CurrentPosition + 1 >= pL.LengthOfCurrentSong)
                            if (!повторятьПлейлистToolStripMenuItem.Checked)
                            {
                                if (!повторятьТрекToolStripMenuItem.Checked)
                                {
                                    trackLength.Maximum = 0;
                                    trackLength.Value = 0;
                                    pL.NumberOfCurrentSong = -1;
                                    labelCurrentPosition.Text = "0:00";
                                    labelLength.Text = "0:00";
                                    labelCurrentSongName.Text = "---";
                                }
                                else
                                    pL.Play();
                            }
                            else
                            {
                                pL.NumberOfCurrentSong = 0;
                                playListLB.SelectedIndex = pL.NumberOfCurrentSong;
                                pL.Play();
                            }
                    }
                }
            }
        }

        private void DriveLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DirLB.Path = DriveLB.Drive;
            }
            catch (Exception o)
            {
                MessageBox.Show("ПРОИЗОШЛА ОШИБКА: " + o.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DriveLB.SelectedIndex = oldIndexDrive;
                DirLB.Path = oldDir;
            }
        }

        private void DriveLB_Click(object sender, EventArgs e)
        {
            oldIndexDrive = DriveLB.SelectedIndex;
            oldDir = DirLB.Path;
        }

        private void DirLB_Change(object sender, EventArgs e)
        {
            FileLB.Path = DirLB.Path;
            FileLB.Visible = true;
            FileLB2.Visible = false;
            textBoxSearch.Text = "";
        }

        private void FileLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int y = e.Y / FileLB.GetItemHeight(1);
                FileLB.SelectedIndex = y;

                pL.AddSong(new AudioFile(FileLB.Path + "\\" + FileLB.SelectedItem));
            }
            catch
            {
                FileLB.SelectedIndex = 0;
                pL.AddSong(new AudioFile(FileLB.Path + "\\" + FileLB.SelectedItem));
            }
            finally
            {
                playListLB.Items.Add(FileLB.Path + "\\" + FileLB.SelectedItem);
                //wmp.settings.volume = 0;
            }
        }

        private void FileLB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                try
                {
                    int y = e.Y / FileLB.GetItemHeight(1);
                    FileLB.SelectedIndex = y;
                }
                catch
                {

                }
            }
        }

        private void playListLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pL.Play())
            {
                pL.NumberOfCurrentSong = playListLB.SelectedIndex;
                pL.Volume = trackVolume.Value;
                pL.Play();
                timer.Enabled = true;
                stop = false;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (playListLB.Items.Count != 0 && playListLB.SelectedIndex != -1)
            {
                if (pL.NumberOfCurrentSong == -1 || (pL.Playlist.ElementAt(pL.NumberOfCurrentSong).Path == playListLB.SelectedItem.ToString() && stop) || (pL.Playlist.ElementAt(pL.NumberOfCurrentSong).Path != playListLB.SelectedItem.ToString()))
                {
                    pL.DeleteSong(playListLB.SelectedIndex);
                    playListLB.Items.Remove(playListLB.SelectedItem);
                }
                else
                    MessageBox.Show("Невозможно удалить текущую песню из плей-листа", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void playListLB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                try
                {
                    int y = e.Y / FileLB.GetItemHeight(1);
                    playListLB.SelectedIndex = y;
                }
                catch
                {

                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);

                    int count = int.Parse(sr.ReadLine());

                    for (int i = 0; i < count; i++)
                    {
                        pL.AddSong(new AudioFile(sr.ReadLine()));
                        playListLB.Items.Add(sr.ReadLine());
                    }

                    sr.Close();
                }
            }
            catch (Exception o)
            {
                MessageBox.Show("Произошла ошибка: " + o.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);

                    sw.WriteLine(pL.Playlist.Count);

                    for (int i = 0; i < pL.Playlist.Count; i++)
                    {
                        sw.WriteLine(pL.Playlist.ElementAt(i).Path);
                    }

                    sw.Close();
                }
            }
            catch (Exception o)
            {
                MessageBox.Show("Произошла ошибка: " + o.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void прослушатьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!pause || wmp.URL != FileLB.Path + FileLB.SelectedItem)
                wmp.URL = FileLB.Path + "\\"+FileLB.SelectedItem;
            else
                pause = false;
            wmp.settings.volume = trackVolume.Value;
            wmp.controls.play();
            прослушатьToolStripMenuItem.Enabled = false;
            паузаToolStripMenuItem.Enabled = true;
            стопToolStripMenuItem.Enabled = true;
        }

        private void паузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();
            паузаToolStripMenuItem.Enabled = false;
            pause = true;
        }

        private void стопToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
            паузаToolStripMenuItem.Enabled = false;
            стопToolStripMenuItem.Enabled = false;
        }

        private void contextMenu2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] files = Directory.GetFiles(DirLB.get_DirList(DirLB.DirListIndex));
            int count = files.Count(t => t.Contains(".mp3"));

            if (count != 0)
            {
                if (FileLB.SelectedIndex == -1)
                    MessageBox.Show("Выберите нужный трек!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                if (count == 0)
                {
                    прослушатьToolStripMenuItem.Enabled = false;
                    паузаToolStripMenuItem.Enabled = false;
                    стопToolStripMenuItem.Enabled = false;
                }
                else
                if (wmp.URL == FileLB.Path + "\\"+FileLB.SelectedItem|| wmp.URL == FileLB.Path + FileLB.SelectedItem)
                {
                    if (!pause)
                    {
                        прослушатьToolStripMenuItem.Enabled = true;
                        паузаToolStripMenuItem.Enabled = true;
                        стопToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        прослушатьToolStripMenuItem.Enabled = true;
                        паузаToolStripMenuItem.Enabled = false;
                        стопToolStripMenuItem.Enabled = true;
                    }
                }
                else
                {
                    прослушатьToolStripMenuItem.Enabled = true;
                    паузаToolStripMenuItem.Enabled = false;
                    стопToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void contextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (playListLB.Items.Count == 0 || playListLB.SelectedIndex == -1)
            {
                удалитьToolStripMenuItem.Enabled = false;
            }
            else
            {
                удалитьToolStripMenuItem.Enabled = true;
            }
        }

        private void textBoxSearch_MouseMove(object sender, MouseEventArgs e)
        {
            while (MessageBox.Show("Катя, эта штука пока не работает!\nОставь её в покое!\nПоняла???", "Внимание!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                ;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Янюшкин Кирилл Александрович\nИзготовлено по заказу ВятГУ\n2018 г.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                FileLB.Visible = true;
                FileLB2.Visible = false;
            }
            else
            {
                filesForSearch = Directory.GetFiles(DirLB.get_DirList(DirLB.DirListIndex)).ToList();
                filesForSearch.TakeWhile(elem => elem.Substring(elem.Length - 4) == ".mp3");

                FileLB.Visible = false;
                FileLB2.Items.Clear();
                FileLB2.Visible = true;
                
                for (int i=0; i<filesForSearch.Count; i++)
                {
                    if (SearchSubstring(filesForSearch[i].Substring(filesForSearch[i].LastIndexOf("\\")), textBoxSearch.Text) != -1)
                        FileLB2.Items.Add(filesForSearch[i].Substring(filesForSearch[i].LastIndexOf("\\") + 1));
                    else
                    {
                        filesForSearch.Remove(filesForSearch[i]);
                        i -= 1;
                    }
                }
            }
        }

        private void playListLB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Up)
            {
                int indexOfSelectedItem = playListLB.SelectedIndex;

                if (indexOfSelectedItem != 0)
                {
                    AudioFile tmpAudio = pL.Playlist.ElementAt(indexOfSelectedItem);
                    pL.Playlist[indexOfSelectedItem] = pL.Playlist[indexOfSelectedItem - 1];
                    pL.Playlist[indexOfSelectedItem - 1] = tmpAudio;
                    playListLB.Items.Clear();

                    foreach (AudioFile audio in pL.Playlist)
                        playListLB.Items.Add(audio.Path);

                    playListLB.SelectedIndex = indexOfSelectedItem;
                }
            }
            else
            if (e.Shift && e.KeyCode == Keys.Down)
            {
                int indexOfSelectedItem = playListLB.SelectedIndex;

                if (indexOfSelectedItem != pL.Playlist.Count - 1)
                {
                    AudioFile tmpAudio = pL.Playlist.ElementAt(indexOfSelectedItem);
                    pL.Playlist[indexOfSelectedItem] = pL.Playlist[indexOfSelectedItem + 1];
                    pL.Playlist[indexOfSelectedItem + 1] = tmpAudio;
                    playListLB.Items.Clear();

                    foreach (AudioFile audio in pL.Playlist)
                        playListLB.Items.Add(audio.Path);

                    playListLB.SelectedIndex = indexOfSelectedItem;
                }
            }
            else
            if (e.KeyCode == Keys.Delete)
            {
                удалитьToolStripMenuItem_Click(sender, e);
            }
            else
                if (e.KeyCode == Keys.Enter)
            {
                if (pL.Playlist.Count >= 2)
                {
                    pL.NumberOfCurrentSong = playListLB.SelectedIndex;
                    pL.Volume = trackVolume.Value;
                    pL.Play();
                    timer.Enabled = true;
                }
                else
                    MessageBox.Show("Плей-лист должен содержать минимум две песни!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (pL.Play())
            {
                playListLB.SelectedIndex = pL.NumberOfCurrentSong;
                pL.Volume = trackVolume.Value;
                stop = false;
                timer.Enabled = true;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            pL.Pause();
            timer.Enabled = false;
            labelCurrentSongName.Text = "---";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop = true;
            pL.Stop();
            timer.Enabled = false;
            labelCurrentPosition.Text = "0:00";
            trackLength.Value = 0;
            labelCurrentSongName.Text = "---";
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (playListLB.SelectedIndex - 1 != -1)
            {
                playListLB.SelectedIndex -= 1;
                pL.NumberOfCurrentSong = playListLB.SelectedIndex;
                pL.Volume = trackVolume.Value;
                pL.Play();
                timer.Enabled = true;
            }
            else
                MessageBox.Show("Предыдущей композиции нет", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (playListLB.SelectedIndex + 1 < playListLB.Items.Count)
            {
                playListLB.SelectedIndex += 1;
                pL.NumberOfCurrentSong = playListLB.SelectedIndex;
                pL.Volume = trackVolume.Value;
                pL.Play();
                timer.Enabled = true;
            }
            else
                MessageBox.Show("Следующей композиции нет", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRand_Click(object sender, EventArgs e)
        {
            if (buttonRand.BackColor != Color.Crimson)
            {
                buttonRand.BackColor = Color.Crimson;
                вСлучайномПорядкеToolStripMenuItem.Checked = true;
            }
            else
            {
                buttonRand.BackColor = this.BackColor;
                вСлучайномПорядкеToolStripMenuItem.Checked = false;
            }
        }

        private void buttonRepeatSong_Click(object sender, EventArgs e)
        {
            if (buttonRepeatSong.BackColor != Color.Crimson)
            {
                buttonRepeatSong.BackColor = Color.Crimson;
                повторятьТрекToolStripMenuItem.Checked = true;
            }
            else
            {
                buttonRepeatSong.BackColor = this.BackColor;
                повторятьТрекToolStripMenuItem.Checked = false;
            }
        }

        private void buttonRepeatPL_Click(object sender, EventArgs e)
        {
            if (buttonRepeatPL.BackColor != Color.Crimson)
            {
                buttonRepeatPL.BackColor = Color.Crimson;
                повторятьПлейлистToolStripMenuItem.Checked = true;
            }
            else
            {
                buttonRepeatPL.BackColor = this.BackColor;
                повторятьПлейлистToolStripMenuItem.Checked = false;
            }
        }

        private void повторятьТрекToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FileLB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pL.AddSong(new AudioFile(FileLB.Path + "\\" + FileLB.SelectedItem));
                RefreshLBPL();
            }
        }

        private void RefreshLBPL()
        {
            playListLB.Items.Clear();

            foreach (AudioFile audio in pL.Playlist)
                playListLB.Items.Add(audio.Path);
        }

        private void RefreshPlayList(List<string>files)
        {
            pL.Stop();
            timer.Enabled = false;
            labelCurrentPosition.Text = "0:00";
            trackLength.Value = 0;
            labelCurrentSongName.Text = "---";
            pL = new PlayList();
            for (int i = 0; i < files.Count; i++)
            {
                pL.AddSong(new AudioFile(files[i]));
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (pL.Playlist.Count != 0)
            {

                List<string> files = new List<string>();
                bool sortByName = false;

                if (MessageBox.Show("Сортировать по имени файла? - Нажмите \"Да\",\nиначе нажмите \"Нет\"", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    sortByName = true;

                for (int i = 0; i < playListLB.Items.Count; i++)
                {
                    playListLB.SelectedIndex = i;
                    files.Add(playListLB.SelectedItem.ToString());
                }
                playListLB.SelectedIndex = -1;

                if (MessageBox.Show("Сортировать по возрастанию?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    files.Sort(new Compare(true, sortByName));
                else
                    files.Sort(new Compare(false, sortByName));

                playListLB.Items.Clear();

                foreach (string audio in files)
                    playListLB.Items.Add(audio);

                RefreshPlayList(files);
            }
            else
                MessageBox.Show("В плей-листе нет композиций", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PreprocessStrongSuffix(int[] shift, int[] bpos, string pat, int m)
        {
            int i = m, j = m + 1;
            bpos[i] = j;

            while (i > 0)
            {
                while (j <= m && pat[i - 1] != pat[j - 1])
                {
                    if (shift[j] == 0)
                        shift[j] = j - i;
 
                    j = bpos[j];
                }
                i--; j--;
                bpos[i] = j;
            }
        }

        void PreprocessCase2(int[] shift, int[] bpos, string pat, int m)
        {
            int i, j;
            j = bpos[0];
            for (i = 0; i <= m; i++)
            {
                if (shift[i] == 0)
                    shift[i] = j;

                if (i == j)
                    j = bpos[j];
            }
        }

        private int SearchSubstring(string text, string pat)
        {
            int s = 0, j;
            int m = pat.Length;
            int n = text.Length;

            int[] bpos = new int[m + 1];
            int[]shift = new int[m + 1];

            for (int i = 0; i < m + 1; i++) shift[i] = 0;

            PreprocessStrongSuffix(shift, bpos, pat, m);
            PreprocessCase2(shift, bpos, pat, m);

            while (s <= n - m)
            {
                j = m - 1;

                while (j >= 0 && pat[j] == text[s + j])
                    j--;

                if (j < 0)
                {
                    return s;
                }
                else
                    s += shift[j + 1];
            }
            return -1;
            
        }

        private void FileLB2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int y = e.Y / FileLB2.GetItemHeight(1);
                FileLB2.SelectedIndex = y;
                pL.AddSong(new AudioFile(filesForSearch[FileLB2.SelectedIndex]));
            }
            catch
            {
                FileLB2.SelectedIndex = 0;
                List<string> kek = filesForSearch;
                pL.AddSong(new AudioFile(filesForSearch[FileLB2.SelectedIndex]));
            }
            finally
            {
                RefreshLBPL();
                wmp.settings.volume = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wmp.URL = "http://cdndl.zaycev.net/2976/7417939/adele_-_rolling_in_the_deep_%28zaycev.net%29.mp3";
            //wmp.settings.volume = 100;
            //wmp.controls.play();
            AddSongFromSite form2 = new AddSongFromSite();
            form2.ShowDialog();
            if (form2.input)
            {
                Parser kek = new Parser();
                kek.BaseURL = form2.URL;
                ParserWorker parser = new ParserWorker(kek);
                parser.Start();
                playListLB.Items.Add(form2.URL);
                pL.AddSong(new AudioFile(form2.URL));
            }
        }

        private void buttonClearPL_Click(object sender, EventArgs e)
        {
            playListLB.Items.Clear();
            pL.Playlist.Clear();
            pL.NumberOfCurrentSong = -1;
            pL.Stop();
            trackLength.Maximum = 0;
            trackLength.Value = 0;
            pL.NumberOfCurrentSong = -1;
            labelCurrentPosition.Text = "0:00";
            labelLength.Text = "0:00";
            labelCurrentSongName.Text = "---";
        }
        //регулярные выражения
    }

    public class Compare : IComparer<string>//класс для сравнения строк
    {
        bool how;//false - сортировка по убыванию
        bool sortByName;//true - сортировка по имени, иначе - по пути

        public Compare(bool _how, bool _sortByName)
        {
            how = _how;
            sortByName = _sortByName;
        }

        int IComparer<string>.Compare(string x, string y)
        {
            int res;
            if (sortByName)
                res = x.Substring(x.LastIndexOf('\\') + 1).CompareTo(y.Substring(y.LastIndexOf('\\') + 1));
            else
                res = x.CompareTo(y);
            if (!how)
                res *= -1;
            return res;
        }
    }
}