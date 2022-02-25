using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    [Serializable]
    public class Movie {
        public string Name { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Path { get; set; }
        public string Picture { get; set; }

        public string Genre { get; set;  }

        public int MovieIndex { get; set; }

        public Movie(string name, string director, int year, string path, string picture,
            string genre) {
            this.Name = name;
            this.Director = director;
            this.Year = year;
            this.Path = path;
            this.Picture = picture;
            this.Genre = genre;
        }

        public int CompareTo(string str) {
            if (this.Name[0] < str[0]) {
                return -1;
            }
            else if (this.Name[0] > str[0]) {
                return 1;
            }
            else return 0;
        }
    }
}
