using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    public partial class LoadingWin : Form {
        private Random rand;
        private int numOfElipses;
        private string FilePath;
        private string WatchListPath;
        private MainPanel mainPanel;
        private Movie[] moviesList;
        User user;

        public LoadingWin(string filePath, User user) {
            InitializeComponent();
            this.user = user;
            rand = new Random();
            numOfElipses = 0;
            this.FilePath = filePath + "\\data.save";
            this.WatchListPath = filePath + "\\watchInfo.save";

            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.ImageLocation = @".\resources\startPic.jpeg";
            this.circularProgressBar1.Value = 0;
            this.circularProgressBar1.Minimum = 0;
            this.circularProgressBar1.Maximum = 300;
            this.timer1.Start();
            this.timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            int incrementalVal = rand.Next(1, 90);
            this.circularProgressBar1.Value += incrementalVal;
            if(this.circularProgressBar1.Value >= 210) {
                this.timer1.Stop();
                this.timer2.Stop();

                mainPanel = new MainPanel(user);
                if (File.Exists(FilePath) && File.Exists(WatchListPath)) {
                    MessageBox.Show("Here");
                    moviesList = (Movie[])DataSerializer.binaryDeserialize(FilePath);
                    WatchList watchLists = (WatchList)DataSerializer.binaryDeserialize(WatchListPath);
                    mainPanel.watchLists = watchLists;
                    mainPanel.moviesList = moviesList;
                    mainPanel.FilePath = this.FilePath;
                }

                this.Hide();
                mainPanel.ShowDialog();
                DataSerializer.binarySerialize(mainPanel.moviesList, FilePath);
                DataSerializer.binarySerialize(mainPanel.watchLists, WatchListPath);
                Application.Exit();
            }
        }


        private void timer2_Tick(object sender, EventArgs e) {
            this.waitLbl.Text += '.';
            numOfElipses++;
            if(numOfElipses == 5) {
                numOfElipses = 0;
                this.waitLbl.Text = "Please Wait, Logging you in";
            }
        }
    }
}
