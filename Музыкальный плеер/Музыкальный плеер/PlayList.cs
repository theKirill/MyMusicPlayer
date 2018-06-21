using System.Collections.Generic;
using System.Linq;
using WMPLib;
using System.Windows.Forms;

namespace Музыкальный_плеер
{
    class PlayList
    {
        int numberOfCurrentSong = -1;//номер текущего играющего трека, -1 - не играет ничего
        List<AudioFile> playlist = new List<AudioFile>();
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        bool pause = false;

        /// <summary>
        /// Свойство, возращающее все треки в плей-листе
        /// </summary>
        /// 
        public List<AudioFile> Playlist
        {
            get
            {
                return playlist;
            }
        }

        /// <summary>
        /// Свойство, возвращающее и устанавливающее текущую позицию играющего трека
        /// </summary>
        public double CurrentPosition
        {
            get
            {
                return wmp.controls.currentPosition;
            }

            set
            {
                wmp.controls.currentPosition = value;
            }
        }

        /// <summary>
        /// Свойство, возвращающее и устанавливающее текущую позицию играющего трека в виде строки
        /// </summary>
        public string CurrentPositionStr
        {
            get
            {
                return wmp.controls.currentPositionString;
            }
        }

        /// <summary>
        /// войство, возвращающее длину играющего трека
        /// </summary>
        public double LengthOfCurrentSong
        {
            get
            {
                return wmp.currentMedia.duration;
            }
        }

        /// <summary>
        /// Свойство, возвращающее длину играющего трека в виде строки
        /// </summary>
        public string LengthOfCurrentSongStr
        {
            get
            {
                return wmp.currentMedia.durationString;
            }
        }

        /// <summary>
        /// Свойство, возвращающее и устанавливающее номер текущего играющего трека
        /// </summary>
        public int NumberOfCurrentSong
        {
            get
            {
                return numberOfCurrentSong;
            }

            set
            {
                numberOfCurrentSong = value;
            }
        }

        /// <summary>
        /// Свойство, возвращающее и устанавливающее громкость
        /// </summary>
        public int Volume
        {
            get
            {
                return wmp.settings.volume;
            }

            set
            {
                wmp.settings.volume = value;
            }
        }

        /// <summary>
        /// Метод добавления песни в плей-лист
        /// </summary>
        /// <param name="f">Аудиофайл для добавления</param>
        public void AddSong(AudioFile f)
        {
            WindowsMediaPlayer current = new WindowsMediaPlayer();
            current.URL = f.Path;
            f.Length = current.currentMedia.duration;
            playlist.Add(f);
            current.controls.stop();

            if (numberOfCurrentSong == -1)
            {
                wmp = current;
                wmp.settings.volume = 0;
                wmp.controls.play();
            }
        }

        /// <summary>
        /// Удаление песни из плей-листа
        /// </summary>
        /// <param name="ind">Номер удаляемого трека</param>
        public void DeleteSong(int ind)
        {
            playlist.RemoveAt(ind);
        }

        /// <summary>
        /// Метод для проигрывания плей-листа
        /// </summary>
        /// <returns>Возвращает true, если можно начать проигрывать плей-лист</returns>
        public bool Play()
        {
            if (playlist.Count < 2)
            {
                MessageBox.Show("Плей-лист должен содержать минимум две песни!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
              if (wmp.URL == "" || numberOfCurrentSong == -1)
            {
                numberOfCurrentSong = 0;
            }

            if (pause)
                pause = false;
            else
                wmp.URL = (playlist.ElementAt(numberOfCurrentSong)).Path;

            wmp.controls.play();
            playlist.ElementAt(numberOfCurrentSong).Length = wmp.currentMedia.duration;

            return true;
        }

        /// <summary>
        /// Стоп плей-листа
        /// </summary>
        public void Stop()
        {
            wmp.controls.stop();
        }

        /// <summary>
        /// Постановка на паузу
        /// </summary>
        public void Pause()
        {
            wmp.controls.pause();
            pause = true;
        }
    }
}