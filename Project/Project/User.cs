using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project {
    public class User {
        public string fullName { get; set; } 
        public string userName { get; set; }
        public string password { get; set; }
        public string dob { get; set; }
        public string picLocation { get; set; }

        public User(string fullName, string userName, string password, string dob, string picLocation) {
            this.fullName = fullName;
            this.userName = userName;
            this.password = password;
            this.dob = dob;
            this.picLocation = picLocation;
        }
    }
}
