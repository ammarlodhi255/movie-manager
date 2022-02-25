using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project {
    public partial class LoginPanel : Form {
        private int index = 0;
        private string usersPath;
        private string usersFilePath;
        private string[] usernames = new string[0];
        private string[] passwords = new string[0];
        private string[] picLocations = new string[0];

        public LoginPanel() {
            InitializeComponent();
            usersPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.users";
            usersFilePath = usersPath + "\\users.txt";
            readAllUsers();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtPassword.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (validateUser()) {
                string name = getName(this.txtUsername.Text);
                string picLocation = getPicLocation(this.txtUsername.Text);
                User user = new User(name, this.txtUsername.Text, this.txtPassword.Text, null, picLocation);

                if(cBoxRemMe.Checked) {
                    StreamWriter sWriter;
                    using(sWriter = new StreamWriter(usersPath + "\\remember_me.txt")) {
                        sWriter.WriteLine(user.fullName + "," + user.userName + "," + user.password + "," + user.picLocation);
                    }
                }
                this.Hide();
                new LoadingWin(usersPath + "\\" + this.txtUsername.Text, user).ShowDialog();
            }
        }

        private string getName(string uname) {
            return ((File.ReadAllLines(usersFilePath))[getUserIndex(uname)]).Split(',')[0];
        }

        private string getPicLocation(string uname) {
            return ((File.ReadAllLines(usersFilePath))[getUserIndex(uname)]).Split(',')[3];
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Hide();
            new StartWin().ShowDialog();
        }

        private bool validateUser() {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Text;
            if (validateUserName(username)) {
                if (validatePassword(username, password)) return true;
                else {
                    MessageBox.Show("Incorrect password", "Password incorrect!");
                    return false;
                }
            }
            else {
                MessageBox.Show("No user with username " + username + " exists");
                return false;
            }
        }

        private bool validateUserName(string username) {
            foreach(string user in usernames) {
                if (user == username) return true;
            }
            return false;
        }

        private bool validatePassword(string username, string password) {
            int userIndex = this.getUserIndex(username);
            return passwords[userIndex] == password;
        }

        private int getUserIndex(string username) {
            for(int i = 0; i < usernames.Length; i++)
                if(username == usernames[i]) return i;
            return -1;
        }

        private void readAllUsers() {
            if (!File.Exists(usersFilePath)) return;
            string[] allLines = File.ReadAllLines(usersFilePath);
            usernames = new string[allLines.Length];
            passwords = new string[allLines.Length];
            int i = 0;
            foreach(string line in allLines) {
                usernames[i] = line.Split(',')[1];
                passwords[i++] = line.Split(',')[2];
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) this.btnLogin_Click(sender, e);
        }
    }
}
