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
    public partial class MainForm : MetroForm
    {
        int oldIndexDrive = 0;
        string oldDir = "";
        bool left = true;
        bool pause = false;
        bool stop = false;
        List<string> filesForSearch = new List<string>();//список файлов в каталоге, среди которых осуществляется поиск нужных mp3 файлов

        public MainForm()
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

        /// <summary>
        /// Изменение громкости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            pL.Volume = trackVolume.Value;
            toolTip1.SetToolTip(trackVolume, trackVolume.Value.ToString());
            wmp.settings.volume = trackVolume.Value;
        }

        /// <summary>
        /// Переход на любую позицию трека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackLength_Scroll(object sender, EventArgs e)
        {
            pL.CurrentPosition = trackLength.Value;
            toolTip1.SetToolTip(trackLength, trackLength.Value.ToString());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pL.NumberOfCurrentSong != -1)//если что-то проигрывается
            {
                //установка параметров трека на элементы управления
                trackLength.Maximum = Convert.ToInt32(pL.LengthOfCurrentSong);
                trackLength.Value = Convert.ToInt32(pL.CurrentPosition);
                labelCurrentPosition.Text = pL.CurrentPositionStr;
                labelLength.Text = pL.LengthOfCurrentSongStr;

                labelCurrentSongName.Text = pL.Playlist.ElementAt(pL.NumberOfCurrentSong).Name;
                //////////////////////////////////////////////////////

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

                if (вСлучайномПорядкеToolStripMenuItem.Checked)//если в случайном порядке
                {
                    if (pL.CurrentPosition + 1 >= pL.LengthOfCurrentSong)//если трек заканчивается
                    {
                        if (!повторятьТрекToolStripMenuItem.Checked)//если не надо повторять трек
                        {
                            Random randNumberOfSong = new Random();
                            int r = randNumberOfSong.Next(pL.Playlist.Count);//выбор случайного трека из списка
                            pL.NumberOfCurrentSong = r;
                            playListLB.SelectedIndex = pL.NumberOfCurrentSong;
                        }
                        pL.Play();
                        //wmp.URL = playListLB.SelectedItem.ToString();
                    }
                }
                else
                {
                    if (pL.NumberOfCurrentSong != pL.Playlist.Count - 1)//если трек не последний
                    {
                        if (pL.CurrentPosition + 1 >= pL.LengthOfCurrentSong)//если трек заканчивается
                        {
                            if (!повторятьТрекToolStripMenuItem.Checked)//если не надо повторять трек
                            {
                                pL.NumberOfCurrentSong += 1;//переход к следующему
                                playListLB.SelectedIndex = pL.NumberOfCurrentSong;
                            }
                            pL.Play();
                        }
                    }
                    else//если трек последний
                    {
                        if (pL.CurrentPosition + 1 >= pL.LengthOfCurrentSong)//если трек заканчивается
                            if (!повторятьПлейлистToolStripMenuItem.Checked)//если не надо повторять плей-лист
                            {
                                if (!повторятьТрекToolStripMenuItem.Checked)//если не надо повторять трек
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
                            else//надо повторять плей-лист
                            {
                                pL.NumberOfCurrentSong = 0;//переход на первый трек
                                playListLB.SelectedIndex = pL.NumberOfCurrentSong;
                                pL.Play();
                            }
                    }
                }
            }
        }

        /// <summary>
        /// Переход в другой диск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Запоминание диска и папки для исключения ошибки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DriveLB_Click(object sender, EventArgs e)
        {
            oldIndexDrive = DriveLB.SelectedIndex;
            oldDir = DirLB.Path;
        }

        /// <summary>
        /// Переход в другую папку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DirLB_Change(object sender, EventArgs e)
        {
            FileLB.Path = DirLB.Path;
            FileLB.Visible = true;
            FileLB2.Visible = false;
            textBoxSearch.Text = "";
        }

        /// <summary>
        /// Добавление двойным щелчком мыши песни в плей-лист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pL.AddSong(new AudioFile(FileLB.Path + "\\" + FileLB.SelectedItem));
            playListLB.Items.Add(FileLB.Path + "\\" + FileLB.SelectedItem);
        }

        /// <summary>
        /// Возможность выделение трека с помощью нажатия правой кнопки мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    FileLB.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Проигрывание плей-листа двойным нажатием кнопки мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Удаление песни из плей-листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (playListLB.Items.Count != 0 && playListLB.SelectedIndex != -1)
            {
                //удалять можно все песни, кроме проигрывающейся
                if (pL.NumberOfCurrentSong == -1 || (pL.Playlist.ElementAt(pL.NumberOfCurrentSong).Path == playListLB.SelectedItem.ToString() && stop) || (pL.Playlist.ElementAt(pL.NumberOfCurrentSong).Path != playListLB.SelectedItem.ToString()))
                {
                    pL.DeleteSong(playListLB.SelectedIndex);
                    playListLB.Items.Remove(playListLB.SelectedItem);
                }
                else
                    MessageBox.Show("Невозможно удалить текущую песню из плей-листа", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Возможность выделение трека с помощью нажатия правой кнопки мыши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    playListLB.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Открытие плей-листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        string path = sr.ReadLine();
                        pL.AddSong(new AudioFile(path));
                        playListLB.Items.Add(path);
                    }

                    sr.Close();
                }
            }
            catch (Exception o)
            {
                MessageBox.Show("Произошла ошибка: " + o.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение плей-листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Проигрывание отдельного трека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void прослушатьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!pause || wmp.URL != FileLB.Path + FileLB.SelectedItem)
                wmp.URL = FileLB.Path + "\\" + FileLB.SelectedItem;
            else
                pause = false;
            wmp.settings.volume = trackVolume.Value;
            wmp.controls.play();
            прослушатьToolStripMenuItem.Enabled = false;
            паузаToolStripMenuItem.Enabled = true;
            стопToolStripMenuItem.Enabled = true;
        }

        /// <summary>
        /// Приостановка отдельно проигрываемого трека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void паузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.controls.pause();
            паузаToolStripMenuItem.Enabled = false;
            pause = true;
        }

        /// <summary>
        /// Остановка отдельно проигрываемого трека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void стопToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
            паузаToolStripMenuItem.Enabled = false;
            стопToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Открытие контекстного меню для прослушивания отдельного трека из папки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenu2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string[] files = Directory.GetFiles(DirLB.get_DirList(DirLB.DirListIndex));
            int count = files.Count(t => t.Contains(".mp3"));//подсчитывание количества файлов с расширением mp3

            if (count != 0)
            {
                if (FileLB.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите нужный трек!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    прослушатьToolStripMenuItem.Enabled = false;
                    паузаToolStripMenuItem.Enabled = false;
                    стопToolStripMenuItem.Enabled = false;
                }
                else
                {
                    if (wmp.URL == FileLB.Path + "\\" + FileLB.SelectedItem || wmp.URL == FileLB.Path + FileLB.SelectedItem)
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
            else
            {
                прослушатьToolStripMenuItem.Enabled = false;
                паузаToolStripMenuItem.Enabled = false;
                стопToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// Открытие контекстного меню для удаления песни из плей-листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Справка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Янюшкин Кирилл Александрович\nИзготовлено по заказу ВятГУ\n2018 г.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Поиск файлов по подстроке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                FileLB.Visible = true;//FileLB предназначен для вывода всех аудиофайлов в папке
                FileLB2.Visible = false;//FileLB2 предназначен для вывода всех аудиофайлов в папке, которые были найдены при поиске по подстроке
            }
            else
            {
                filesForSearch = Directory.GetFiles(DirLB.get_DirList(DirLB.DirListIndex)).ToList();//получение всех файлов в выделенной папке
                //filesForSearch.TakeWhile(elem => elem.Substring(elem.Length - 4) == ".mp3");//выбор только mp3 файлов

                FileLB.Visible = false;
                FileLB2.Items.Clear();
                FileLB2.Visible = true;

                for (int i = 0; i < filesForSearch.Count; i++)
                {
                    //если найдена подстрока в названии файла и этот файл mp3
                    if (SearchSubstring(filesForSearch[i].Substring(filesForSearch[i].LastIndexOf("\\") + 1), textBoxSearch.Text) != -1 && SearchSubstring(filesForSearch[i].Substring(filesForSearch[i].LastIndexOf("\\") + 1), ".mp3") != -1)
                        FileLB2.Items.Add(filesForSearch[i].Substring(filesForSearch[i].LastIndexOf("\\") + 1));//вывод данной песни
                    else
                    {
                        filesForSearch.Remove(filesForSearch[i]);//иначе удаление из списка файлов
                        i -= 1;
                    }
                }
            }
        }

        /// <summary>
        /// Перемещение треков в плей-листе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playListLB_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Shift && e.KeyCode == Keys.Up)//перетаскивание песни вверх
                {
                    int indexOfSelectedItem = playListLB.SelectedIndex;

                    if (indexOfSelectedItem != 0)
                    {
                        //замена
                        AudioFile tmpAudio = pL.Playlist.ElementAt(indexOfSelectedItem);
                        pL.Playlist[indexOfSelectedItem] = pL.Playlist[indexOfSelectedItem - 1];
                        pL.Playlist[indexOfSelectedItem - 1] = tmpAudio;
                        RefreshLBPL();//обновление
                        playListLB.SelectedIndex = indexOfSelectedItem;
                    }
                }
                else
                if (e.Shift && e.KeyCode == Keys.Down)//перетаскивание песни вниз
                {
                    int indexOfSelectedItem = playListLB.SelectedIndex;

                    if (indexOfSelectedItem != pL.Playlist.Count - 1)
                    {
                        //замена
                        AudioFile tmpAudio = pL.Playlist.ElementAt(indexOfSelectedItem);
                        pL.Playlist[indexOfSelectedItem] = pL.Playlist[indexOfSelectedItem + 1];
                        pL.Playlist[indexOfSelectedItem + 1] = tmpAudio;
                        RefreshLBPL();//обновление
                        playListLB.SelectedIndex = indexOfSelectedItem;
                    }
                }
                else
            if (e.KeyCode == Keys.Delete)//удаление песни
                {
                    удалитьToolStripMenuItem_Click(sender, e);
                }
                else
                if (e.KeyCode == Keys.Enter)//при нажатии на Enter на песню - проигрывание с выделенной песни
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
            catch
            {

            }
        }

        /// <summary>
        /// Начать проигрывать плей-лист
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Приоставнока плей-листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPause_Click(object sender, EventArgs e)
        {
            pL.Pause();
            timer.Enabled = false;
            labelCurrentSongName.Text = "---";
        }

        /// <summary>
        /// Остановка плей-листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop = true;
            pL.Stop();
            timer.Enabled = false;
            labelCurrentPosition.Text = "0:00";
            trackLength.Value = 0;
            labelCurrentSongName.Text = "---";
        }

        /// <summary>
        /// Переключение на предыдущий трек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Переключение на след трек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Установка на произвольный порядок песен
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Установка на повтор песни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Установка на повтор плей-листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Добавление трека в плей-лист нажатием Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileLB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pL.AddSong(new AudioFile(FileLB.Path + "\\" + FileLB.SelectedItem));
                RefreshLBPL();
            }
        }

        /// <summary>
        /// Обновление плей-листа в listTextBox
        /// </summary>
        private void RefreshLBPL()
        {
            playListLB.Items.Clear();

            foreach (AudioFile audio in pL.Playlist)
                playListLB.Items.Add(audio.Path);
        }

        /// <summary>
        /// Обновление плей-листа
        /// </summary>
        /// <param name="files"></param>
        private void RefreshPlayList(List<string> files)
        {
            pL.Stop();
            timer.Enabled = false;
            labelCurrentPosition.Text = "0:00";
            labelLength.Text = "0:00";
            trackLength.Value = 0;
            labelCurrentSongName.Text = "---";
            pL = new PlayList();//очистка плей-листа
            for (int i = 0; i < files.Count; i++)//добавление новых треков
            {
                pL.AddSong(new AudioFile(files[i]));
            }
        }

        /// <summary>
        /// Сортировка плей-листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                playListLB.Items.Clear();//очистка

                foreach (string audio in files)//добавление отсортированных файлов на компоненте listbox
                    playListLB.Items.Add(audio);

                RefreshPlayList(files); //(обновление в playlist)
            }
            else
                MessageBox.Show("В плей-листе нет композиций", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shift">Массив сдвигов</param>
        /// <param name="bpos">Положения границы</param>
        /// <param name="sub">Подстрока</param>
        /// <param name="m">Длина подстроки</param>
        private void PreprocessStrongSuffix(int[] shift, int[] bpos, string sub, int m)
        {
            int i = m, j = m + 1;
            bpos[i] = j;

            while (i > 0)
            {
                //если символ [i-1] не равен [j-1], поиск продолжается справа
                while (j <= m && sub[i - 1] != sub[j - 1])
                {
                    if (shift[j] == 0)
                        shift[j] = j - i;
                    //обновление положения следующей границы
                    j = bpos[j];
                }
                //символ [i-1] равен [j-1] => граница найдена
                i--;
                j--;
                //хранение начального положения границы
                bpos[i] = j;
            }
        }

        /// <summary>
        /// Установка значений массива сдвигов
        /// </summary>
        /// <param name="shift"></param>
        /// <param name="bpos"></param>
        /// <param name="m"></param>
        private void SetShift(int[] shift, int[] bpos, int m)
        {
            int i, j;
            j = bpos[0];
            for (i = 0; i <= m; i++)
            {
                //установка положения границы первого символа подстроки для всех индексов в массиве сдвигов (при shift[i]=0)
                if (shift[i] == 0)
                    shift[i] = j;

                //if (i == j)
                //    j = bpos[j];
            }
        }

        /// <summary>
        /// Поиск по подстроке по алгоритму Бойера-Мура
        /// </summary>
        /// <param name="text">Строка, в которой осуществляется поиск</param>
        /// <param name="sub">Подстрока, которую необходимо найти</param>
        /// <returns></returns>
        private int SearchSubstring(string text, string sub)
        {
            int s = 0, j;//s - сдвиг подстроки (начало входа подстроки в строку)
            int m = sub.Length;
            int n = text.Length;

            int[] bpos = new int[m + 1];
            int[] shift = new int[m + 1];

            for (int i = 0; i < m + 1; i++)
                shift[i] = 0;

            PreprocessStrongSuffix(shift, bpos, sub, m);
            SetShift(shift, bpos, m);

            while (s <= n - m)
            {
                j = m - 1;

                //уменьшение индекса j подстроки, пока символы подстроки и исходной строки совпадают при это сдвиге
                while (j >= 0 && sub[j] == text[s + j])
                    j--;

                //если подстрока присутствует при текущем сдвиге
                if (j < 0)//j станет -1 при нахождении подстроки
                {
                    return s;//результат - индекс в исходной строке, с которого начинается подстрока
                }
                else
                    s += shift[j + 1];//сдвиг подстроки
            }
            return -1;//-1 при отсутствии подстроки в строке
        }

        /// <summary>
        /// Добавление песни в плей-лист из найденных по поиску двойным щелчком мыши 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileLB2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pL.AddSong(new AudioFile(filesForSearch[FileLB2.SelectedIndex]));
            RefreshLBPL();
            wmp.settings.volume = 0;
        }

        /// <summary>
        /// Очистка плей-листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Открытие второй формы для прослушивания песни с сайта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonURL_Click(object sender, EventArgs e)
        {
            ListenSongFromSite form2 = new ListenSongFromSite();
            form2.ShowDialog();
        }
    }

    /// <summary>
    /// Класс для сравнения строк
    /// </summary>
    public class Compare : IComparer<string>
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