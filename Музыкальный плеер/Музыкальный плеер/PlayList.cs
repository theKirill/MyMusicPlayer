using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Windows.Forms;

namespace Музыкальный_плеер
{
    class PlayList
    {
        int numberOfCurrentSong = -1;
        List<AudioFile> playlist = new List<AudioFile>();
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();
        bool pause = false;
        
        public List<AudioFile> Playlist
        {
            get
            {
                return playlist;
            }
        }

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

        public string CurrentPositionStr
        {
            get
            {
                return wmp.controls.currentPositionString;
            }
        }

        public string LengthOfCurrentSongStr
        {
            get
            {
                return wmp.currentMedia.durationString;
            }
        }

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

        public double LengthOfCurrentSong
        {
            get
            {
                return wmp.currentMedia.duration;
            }
        }

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

        public void DeleteSong(int ind)
        {
            playlist.RemoveAt(ind);
        }

        public bool Play()//
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

        public void Stop()
        {
            wmp.controls.stop();
        }

        public void Pause()
        {
            wmp.controls.pause();
            pause = true;
        }
    }
}