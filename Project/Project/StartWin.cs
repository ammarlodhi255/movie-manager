using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Project {
    public partial class StartWin : Form {
        private string logoLabel = "MOVIE MANAGER";
        private int index = 0;
        private string mainPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.users";
        public StartWin() {
            InitializeComponent();
            if (!File.Exists(mainPath)) {
                DirectoryInfo dInfo = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.users");
                dInfo.Create();
            }
            this.pictureBox1.ImageLocation = @".\resources\startPic.jpeg";
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.timer1.Start();
            checkRememberState();
        }

        private void checkRememberState() {
            if(File.Exists(mainPath + "\\remember_me.txt")) {
                string[] line = File.ReadAllLines(mainPath + "\\remember_me.txt");
                string name = line[0].Split(',')[0];
                string userName = line[0].Split(',')[1];
                string pass = line[0].Split(',')[2];
                string picLocation = line[0].Split(',')[3];

                User remUser = new User(name, userName, pass, null, picLocation);
                this.Hide();
                new LoadingWin(mainPath + "\\" + remUser.userName, remUser).ShowDialog();
            }
        }

        private void btnSignin_Click(object sender, EventArgs e) {
            this.Hide();
            this.timer1.Stop();
            new LoginPanel().ShowDialog();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (this.logoLbl.Text != logoLabel) {
                this.logoLbl.Text += logoLabel[index++] + "";
            }
            else this.timer1.Stop();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e) {
            MessageBox.Show("\t            MOVIE MANAGER\nContact: ammarlodhi68@gmail.com\nGithub: https://github.com/ammarlodhi255 \nDevelopers: Ammar Ahmed & Muhammad Haseeb");
        }

        private void btnSignUp_Click(object sender, EventArgs e) {
            this.Hide();
            new UserEdit().ShowDialog();
        }
    }
}
