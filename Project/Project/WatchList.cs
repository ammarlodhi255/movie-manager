using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    [Serializable]
    public class WatchList {
        public string[] watchList { get; set; }
        public string[] watched { get; set; }

        public int watchListCounter { get; set; } = 0;
        public int watchedCounter { get; set; } = 0;

        public WatchList() {
            this.watchList = new string[20];
            this.watched = new string[20];
        }
    }
}
