using System;
using System.IO;
using System.Windows.Forms;

namespace Project {
    public partial class UserEdit : Form {
        OpenFileDialog imageSelect;
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.users";
        private string[] usernames = new string[0];
        User user;
        public bool edit = false;
        public string editName;
        public MainPanel mPanel;

        public UserEdit() {
            InitializeComponent();
            readAllUsers();
            this.txtPassword.UseSystemPasswordChar = true;
            userPic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.StartPosition = FormStartPosition.CenterScreen;
            userPic.ImageLocation = @".\resources\smallUser.JPG";
            this.Visible = false;
        }

        public UserEdit(MainPanel mPanel) : this() {
            this.mPanel = mPanel;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (txtFullName.Text == "" || txtUserName.Text == "" || 
                txtPassword.Text == "") {
                MessageBox.Show("Fill all the fields");
            }
            else {
                if(edit) {
                    string newUsername = this.txtUserName.Text;
                    string newFullName = this.txtFullName.Text;
                    string newPassword = this.txtPassword.Text;
                    string newPicLocation = this.userPic.ImageLocation;

                    User newUser = new User(newFullName, newUsername, newPassword, null, newPicLocation);
                    if(editName != newUsername) {
                        if (!validateUserName(newUser)) {
                            MessageBox.Show("Username is already in use");
                            return;
                        }
                    }
                    string[] allInfo = File.ReadAllLines(path + "\\users.txt");
                    StreamWriter sWriter = new StreamWriter(path + "\\users.txt");
                    for (int i = 0; i < allInfo.Length; i++) {
                        string userName = allInfo[i].Split(',')[1];
                        if (userName != editName)
                            sWriter.WriteLine(allInfo[i]);
                        else
                            sWriter.WriteLine(newUser.fullName + "," + newUser.userName + "," +
                                newUser.password + "," + newUser.picLocation);
                    }
                    this.mPanel.user = newUser;
                    sWriter.Close();
                    this.Hide();
                    this.Dispose();
                    Directory.Move(path + "\\" + editName, path + "\\" + newUsername);
                    return;
                }
                user =  new User(txtFullName.Text, txtUserName.Text, txtPassword.Text, 
                                    dateTimePicker1.Text, userPic.ImageLocation);
                if (validateUserName(user)) {
                    saveUser(user);
                    DirectoryInfo dInfo = new DirectoryInfo(path + "\\" + user.userName);
                    dInfo.Create();
                    this.Hide();
                    new StartWin().ShowDialog();
                } else {
                    MessageBox.Show("This username already exists");
                }
            }
        }

        private void btnPic_Click(object sender, EventArgs e) {
            imageSelect = new OpenFileDialog();
            imageSelect.Multiselect = false;
            imageSelect.InitialDirectory = @".\resources";
            if (imageSelect.ShowDialog() == DialogResult.OK)
                this.userPic.ImageLocation = imageSelect.FileName;
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Hide();
            this.Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Hide();
            this.Dispose();
            new StartWin().ShowDialog();
        }

        private void readAllUsers() {
            if (!File.Exists(path + "\\users.txt")) return;
            string filepath = path + "\\users.txt";
            string[] allLines = File.ReadAllLines(filepath);
            usernames = new string[allLines.Length];
            int i = 0;
            foreach (string line in allLines) {
                usernames[i++] = line.Split(',')[1];
            }
        }

        private bool validateUserName(User user) {
            foreach (string username in usernames) { 
                if (username == user.userName) return false;
            }
            return true;
        }

        private void saveUser(User user) {
            FileInfo f = new FileInfo(path + "\\users.txt");
            StreamWriter swriter = f.AppendText();
            swriter.WriteLine(user.fullName + "," + user.userName + "," + user.password + "," + user.picLocation);
            swriter.Close();
        }

        public void setPic(string location) {
            this.userPic.ImageLocation = location;
        }
    }
}
