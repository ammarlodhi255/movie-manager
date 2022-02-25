using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    [Serializable]
    public class Genre {

        public int comedyCount { get; set; }
        public int dramaCount { get; set; }
        public int thrillerCount { get; set; }
        public int scifiCount { get; set; }
        public int horrorCount { get; set; }

        public Movie[] Comedy { set; get; }
        public Movie[] Drama { get; set; }
        public Movie[] Thriller { get; set; }
        public Movie[] SciFi { get; set; }
        public Movie[] Horror { get; set; }
        public object[] Genres { get; set; }

        public Genre() {
            Comedy = new Movie[20];
            Drama = new Movie[20];
            Thriller = new Movie[20];
            SciFi = new Movie[20];
            Horror = new Movie[20];
            Genres = new object[5] { Comedy, Drama, Thriller, SciFi, Horror };
        }

        public int getGenreIndex(string genre) {
            if (genre == "Comedy") return 0;
            else if (genre == "Drama") return 1;
            else if (genre == "Thriller") return 2;
            else if (genre == "SciFi") return 3;
            else if (genre == "Horror") return 4;
            else return -1;
        }

        public int getGenreCount(string genre) {
            if (genre == "Comedy") return this.comedyCount;
            else if (genre == "Drama") return this.dramaCount;
            else if (genre == "Thriller") return this.thrillerCount;
            else if (genre == "SciFi") return this.scifiCount;
            else if (genre == "Horror") return this.horrorCount;
            else return -1;
        }
    }
}