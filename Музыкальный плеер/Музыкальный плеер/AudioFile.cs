using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Музыкальный_плеер
{
    class AudioFile
    {
        string name, path;
        double length;

        public AudioFile(string _path)
        {
            path = _path;
            Name = _path;
        }

        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                int ind = value.LastIndexOf('\\');
                name = value.Substring(ind+1);
            }
        }

        public string Path
        {
            get
            {
                return path;
            }   
            set
            {
                path = value;
            }         
        }

        public override bool Equals(object obj)
        {
            AudioFile _obj = (AudioFile)obj;
            return (this.path == _obj.path);
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
}