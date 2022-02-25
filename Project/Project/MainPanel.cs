using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using WMPLib;

namespace Project {

    public partial class MainPanel : Form {

        #region Variable Declaration

        private int movieCounter;
        private bool begin;
        private bool init;
        private int selectedIndex;
        private Panel currentPanel;
        private Color buttonColor;
        private OpenFileDialog movieSelectDialog;
        private OpenFileDialog movieImageSelectDialog;
        public User user;

        public Movie[] moviesList { get; set; }
        public WatchList watchLists { get; set; }

        public string FilePath { get; set; }
        public Genre genre;

        #endregion

        #region Constructor
        public MainPanel(User user) {
            InitializeComponent();
            this.user = user;
            this.userPicBox.ImageLocation = user.picLocation;
            this.lblUsername.Text = user.fullName;

            currentPanel = moviePanel;
            begin = true;
            init = true;
            moviesList = new Movie[20];
            watchLists = new WatchList();
            genre = new Genre();
            movieCounter = 0;
            this.btnPlay.Visible = false;
            this.btnEdit.Visible = false;
            buttonColor = this.btnPlay.BackColor;

            setButtonLocations('h');
            movieSelectDialog = new OpenFileDialog();
            movieImageSelectDialog = new OpenFileDialog();

            this.txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            this.lblTop.Text = "All Movies";
            this.moviesSubMenuPanel.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            moviePic1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.editMovieImage.SizeMode = PictureBoxSizeMode.StretchImage;

            setAutoScroll(comedyPanel);
            setAutoScroll(moviePanel);
            setAutoScroll(sidePanel);
            setAutoScroll(dirSearchPanel);
            setAutoScroll(watchListSubPanel);
            setAutoScroll(watchedSubPanel);

            this.movieImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.movieImage.ImageLocation = @".\resources\imageholder.png";

            this.btnComedy.Click += new EventHandler(genreEventHandler);
            this.btnDrama.Click += new EventHandler(genreEventHandler);
            this.btnThriller.Click += new EventHandler(genreEventHandler);
            this.btnHorror.Click += new EventHandler(genreEventHandler);
            this.btnScifi.Click += new EventHandler(genreEventHandler);
            this.btnAllMovies.Click += new EventHandler(genreEventHandler);
        }

        #endregion

        #region Buttons MovieSelect and ImageSelect
        private void btnMovieSelect_Click(object sender, EventArgs e) {
            movieSelectDialog.Filter = "Mp4 Files (*.mp4)|*.mp4";
            movieSelectDialog.FilterIndex = 1;
            movieSelectDialog.Multiselect = false;
            if(movieSelectDialog.ShowDialog() == DialogResult.OK)
                this.btnMovieSelect.BackColor  = Color.Green;
        }

        private void btnImageSelect_Click(object sender, EventArgs e) {
            movieImageSelectDialog.Filter = "Image Files (*.jpg;*.png) | *.jpg;*.png";
            movieImageSelectDialog.Multiselect = false;

            if (movieImageSelectDialog.ShowDialog() == DialogResult.OK) {
                if (((Button)sender).Name == "btnEditImage")
                    this.editMovieImage.ImageLocation = movieImageSelectDialog.FileName;
                else
                    this.movieImage.ImageLocation = movieImageSelectDialog.FileName;
            }
        }
        #endregion

        #region Save Button Logic
        private void btnSave_Click(object sender, EventArgs e) {
            if (!init) {
                string movieName = this.txtMovieName.Text;
                string movieDirector = this.txtMovieDirector.Text;
                int movieYear = 0;
                string movieGenre = (this.comboSelectGenre.SelectedItem == null) ? "" : this.comboSelectGenre.SelectedItem.ToString();

                if (this.txtMovieYear.Text.Length != 0) {
                    try {
                        movieYear = int.Parse(this.txtMovieYear.Text);
                    }
                    catch (System.FormatException fe) {
                        MessageBox.Show("Enter correct year format", "ERROR");
                    }
                }
                else MessageBox.Show("Please enter a year");
                if (movieName.Length == 0 || movieDirector.Length == 0 ||
                    movieSelectDialog.FileName.Length == 0 || movieGenre == "Select"
                    || movieGenre.Length == 0) {
                    MessageBox.Show("Please fill out all the required info", "ERROR");
                    return;
                }
                else {
                    string imgPath = this.movieImage.ImageLocation;
                    Movie myMovie = new Movie(movieName, movieDirector, movieYear,
                        movieSelectDialog.FileName, imgPath, movieGenre);

                    if (movieCounter == moviesList.Length) {
                        moviesList = (Movie[]) expandArray(moviesList, movieCounter);
                    }

                    moviesList[movieCounter++] = myMovie;
                    addToGenre(moviesList[movieCounter - 1]);
                    moviesList[movieCounter - 1].MovieIndex = movieCounter - 1;
                }
            }

            configurePanel();

            if (!init) {
                this.Controls.Remove(addPanel);
                this.Controls.Add(moviePanel);
                this.totalMoviesLbl.Text = "Total Movies: " + movieCounter;
                this.movieImage.ImageLocation = @".\resources\imageholder.png";
                this.txtMovieDirector.Text = "";
                this.txtMovieName.Text = "";
                this.txtMovieYear.Text = "";
            }
            this.btnMovieSelect.BackColor = buttonColor;
            currentPanel = moviePanel;
        }

        public void configurePanel() {
            if (begin) {
                this.moviePic1.ImageLocation = moviesList[movieCounter - 1].Picture;
                movieNameLbl.Text = moviesList[movieCounter - 1].Name + " (" + moviesList[movieCounter - 1].Year + ")";
                begin = false;
                this.btnPlay.Visible = true;
                this.btnEdit.Visible = true;
                this.moviePic1.Name = "moviePic" + (movieCounter - 1);
                this.movieNameLbl.Name = "movieLbl" + (movieCounter - 1);
                this.btnPlay.Name = "play" + (movieCounter - 1);
                this.btnEdit.Name = "edit" + (movieCounter - 1);
            }
            else {
                PictureBox movieBox = new PictureBox();
                Label lbl = new Label();
                Button btn = new Button();
                Button btn2 = new Button();

                movieBox.Height = this.moviePic1.Height;
                movieBox.Width = this.moviePic1.Width;
                movieBox.SizeMode = PictureBoxSizeMode.StretchImage;

                lbl.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl.Size = new System.Drawing.Size(335, 27);
                lbl.TabIndex = 3;
                lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                btn.BackColor =
                    System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
                btn.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.WhiteSmoke;
                btn.Name = "btnPlay";
                btn.Size = new System.Drawing.Size(147, 49);
                btn.TabIndex = 8;
                btn.Text = "Play";
                btn.UseVisualStyleBackColor = false;

                btn2.BackColor =
                    System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
                btn2.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
                btn2.Name = "btnEdit";
                btn2.Size = new System.Drawing.Size(147, 49);
                btn2.TabIndex = 9;
                btn2.Text = "Edit";
                btn2.UseVisualStyleBackColor = false;

                if ((movieCounter - 1) % 3 != 0) {
                    movieBox.Top = this.moviePanel.Controls["moviePic" + (movieCounter - 2)].Top;
                    movieBox.Left = this.moviePanel.Controls["moviePic" + (movieCounter - 2)].Left +
                    (moviePic1.Width + 80);

                    lbl.Top = this.moviePanel.Controls["movieLbl" + (movieCounter - 2)].Top;
                    lbl.Left = this.moviePanel.Controls["movieLbl" + (movieCounter - 2)].Left +
                    (movieNameLbl.Width + 80);

                    btn.Top = this.moviePanel.Controls["play" + (movieCounter - 2)].Top;
                    btn.Left = this.moviePanel.Controls["play" + (movieCounter - 2)].Left +
                    (btnPlay.Width + 270);

                    btn2.Top = this.moviePanel.Controls["edit" + (movieCounter - 2)].Top;
                    btn2.Left = this.moviePanel.Controls["edit" + (movieCounter - 2)].Left +
                    (btnEdit.Width + 270);
                }
                else {
                    movieBox.Top = this.moviePanel.Controls["moviePic" + (movieCounter - 2)].Top +
                            this.moviePanel.Controls["moviePic" + (movieCounter - 2)].Height + 170;
                    movieBox.Left = this.moviePic1.Left;

                    lbl.Top = movieBox.Top +
                            this.moviePanel.Controls["moviePic" + (movieCounter - 2)].Height + 10;
                    lbl.Left = this.movieNameLbl.Left;

                    btn.Top = this.moviePanel.Controls["play" + (movieCounter - 2)].Top +
                            this.moviePanel.Controls["moviePic" + (movieCounter - 2)].Height + 165;
                    btn.Left = this.btnPlay.Left;

                    btn2.Top = this.moviePanel.Controls["edit" + (movieCounter - 2)].Top +
                            this.moviePanel.Controls["moviePic" + (movieCounter - 2)].Height + 164;
                    btn2.Left = this.btnEdit.Left;
                }

                movieBox.Name = "moviePic" + (movieCounter - 1);
                movieBox.ImageLocation = moviesList[movieCounter - 1].Picture;
                lbl.Text = moviesList[movieCounter - 1].Name + " (" + moviesList[movieCounter - 1].Year + ")";
                lbl.Name = "movieLbl" + (movieCounter - 1);
                btn.Name = "play" + (movieCounter - 1);
                btn2.Name = "edit" + (movieCounter - 1);

                this.moviePanel.Controls.Add(movieBox);
                this.moviePanel.Controls.Add(lbl);
                this.moviePanel.Controls.Add(btn);
                this.moviePanel.Controls.Add(btn2);
                btn2.Click += new System.EventHandler(btnEdit_Click);
                btn.Click += new System.EventHandler(btnPlay_Click);
            }
        }

        #endregion BtnSave Logic

        public Movie[] expandArray(Movie[] movies, int len) {
            Movie[] newArr = new Movie[movies.Length * 2];
            for (int i = 0; i < len; i++) 
                newArr[i] = movies[i];
            return newArr;
        }

        #region AddToGenre Method
        private void addToGenre(Movie movie) {
            if (movie.Genre == "Comedy") {
                Movie[] comedies = ((Movie[])genre.Genres[genre.getGenreIndex("Comedy")]);
                if (genre.comedyCount == comedies.Length)
                    comedies = (Movie[]) expandArray(comedies, genre.comedyCount);
                ((Movie[])(genre.Genres[0]))[genre.comedyCount++] = movie;
            }
            else if (movie.Genre == "Drama") {
                Movie[] dramas = ((Movie[])genre.Genres[genre.getGenreIndex("Drama")]);
                if (genre.dramaCount == dramas.Length)
                    dramas = (Movie[])expandArray(dramas, genre.dramaCount);
                ((Movie[])(genre.Genres[1]))[genre.dramaCount++] = movie;
            }
            else if (movie.Genre == "Thriller") {
                Movie[] thrillers = ((Movie[])genre.Genres[genre.getGenreIndex("Thriller")]);
                if (genre.thrillerCount == thrillers.Length)
                    thrillers = (Movie[])expandArray(thrillers, genre.thrillerCount);
                ((Movie[])(genre.Genres[2]))[genre.thrillerCount++] = movie;
            }
            else if (movie.Genre == "SciFi") {
                Movie[] scifis = ((Movie[])genre.Genres[genre.getGenreIndex("SciFi")]);
                if (genre.scifiCount == scifis.Length)
                    scifis = (Movie[])expandArray(scifis, genre.scifiCount);
                ((Movie[])(genre.Genres[3]))[genre.scifiCount++] = movie;
            }
            else if (movie.Genre == "Horror") {
                Movie[] horrors = ((Movie[])genre.Genres[genre.getGenreIndex("Horror")]);
                if (genre.horrorCount == horrors.Length)
                    horrors = (Movie[])expandArray(horrors, genre.horrorCount);
                ((Movie[])(genre.Genres[4]))[genre.horrorCount++] = movie;
            }
        }
        #endregion

        #region Initialize All Movies init_Movies()
        private void init_Movies() {
            movieCounter = 1;
            foreach (Movie movie in moviesList) {
                if (movie == null) return;
                btnSave_Click(new object(), new EventArgs());
                addToGenre(moviesList[movieCounter - 1]);
                this.totalMoviesLbl.Text = "Total Movies: " + movieCounter;
                movieCounter++;
            }
        }
        #endregion

        #region Btn Play and Btn Edit
        public void btnPlay_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            int num = int.Parse(btn.Name[btn.Name.IndexOf("y") + 1] + "");
            Process.Start(this.moviesList[num].Path);
        }

        public void btnEdit_Click(object sender, EventArgs e) {
            this.Controls.Remove(currentPanel);
            this.Controls.Add(editPanel);
            Button editButton = (Button)sender;
            int num = int.Parse(editButton.Name[editButton.Name.IndexOf("t") + 1] + "");
            selectedIndex = num;
            this.btnRemove.Name = selectedIndex.ToString();
            string movieName = moviesList[num].Name;
            string movieDir = moviesList[num].Director;
            string movieImage = moviesList[num].Picture;
            int movieYear = moviesList[num].Year;

            this.txtEditMovie.Text = movieName;
            this.txtEditDirector.Text = movieDir;
            this.txtEditYear.Text = movieYear.ToString();
            this.editMovieImage.ImageLocation = movieImage;
            this.comboEditGenre.Text = moviesList[num].Genre;

            currentPanel = editPanel;
        }
        #endregion

        #region MainPanel Load
        private void MainPanel_Load(object sender, EventArgs e) {
            if (File.Exists(FilePath)) {
                init_Movies();
                movieCounter -= 1;
            }

            populateWatchList();
            populateWatched();
            init = false;
        }

        #endregion

        #region Sorting 
        private Movie[] sortByYear(Movie[] moviesArr, int length) {
            bool flag = false;
            for (int i = 0; i < length - 1; i++) {
                flag = false;
                for (int j = 0; j < (length - 1 - i); j++) {
                    if (moviesArr[j].Year > moviesArr[j + 1].Year) {
                        swapValues(moviesArr, j, j + 1);
                        flag = true;
                    }
                }
                if (!flag) break;
            }
            return moviesArr;
        }

        private Movie[] sortByName(Movie[] moviesArr, int length) {
            int l = length;
            for (int i = 0; i < l; i++) {
                for (int j = 0; j < l - 1; j++) {
                    if (moviesArr[j].CompareTo(moviesArr[j + 1].Name) > 0) {
                        swapValues(moviesArr, j, j + 1);
                    }
                }
            }
            return moviesArr;
        }

        private void swapValues(Movie[] moviesArr, int index1, int index2) {
            Movie temp = moviesArr[index1];
            moviesArr[index1] = moviesArr[index2];
            moviesArr[index2] = temp;
        }

        #endregion Sorting

        private void setAutoScroll(Panel panel) {
            panel.AutoScrollPosition = new Point(0, 0);
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = false;
            panel.VerticalScroll.Visible = false;
            panel.AutoScroll = true;
        }

        #region ComboBox Sorting
        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (currentPanel == moviePanel && movieCounter != 0) {
                sortMovieArray("MOVIES");
                reAdd();
            } else if(currentPanel == comedyPanel && genre.comedyCount != 0) {
                sortMovieArray("Comedy");
                comedyPanel.Controls.Clear();
                setAutoScroll(comedyPanel);
                genreEventHandler(this.btnComedy, new EventArgs());
            }
            else if (currentPanel == dramaPanel && genre.dramaCount != 0) {
                sortMovieArray("Drama");
                dramaPanel.Controls.Clear();
                setAutoScroll(dramaPanel);
                genreEventHandler(this.btnDrama, new EventArgs());
            }
            else if (currentPanel == thrillerPanel && genre.thrillerCount != 0) {
                sortMovieArray("Thriller");
                thrillerPanel.Controls.Clear();
                setAutoScroll(thrillerPanel);
                genreEventHandler(this.btnThriller, new EventArgs());
            }
            else if (currentPanel == scifiPanel && genre.scifiCount != 0) {
                sortMovieArray("SciFi");
                scifiPanel.Controls.Clear();
                setAutoScroll(scifiPanel);
                genreEventHandler(this.btnScifi, new EventArgs());
            }
            else if (currentPanel == horrorPanel && genre.horrorCount != 0) {
                sortMovieArray("Horror");
                horrorPanel.Controls.Clear();
                setAutoScroll(horrorPanel);
                genreEventHandler(this.btnHorror, new EventArgs());
            }
        }

        private void sortMovieArray(string genreName) {
            this.sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (genreName != "MOVIES") {
                int i = genre.getGenreIndex(genreName);
                int count = genre.getGenreCount(genreName);

                if (this.sortComboBox.Items[this.sortComboBox.SelectedIndex].ToString() == "Year")
                    genre.Genres[i] = sortByYear((Movie[])genre.Genres[i], count);
                else if (this.sortComboBox.Items[this.sortComboBox.SelectedIndex].ToString() == "Name")
                    genre.Genres[i] = sortByName((Movie[])genre.Genres[i], count);
            }
            else {
                if (this.sortComboBox.SelectedIndex >= 0) {
                    if (this.sortComboBox.Items[this.sortComboBox.SelectedIndex].ToString() == "Year")
                        moviesList = sortByYear(moviesList, movieCounter);
                    else if (this.sortComboBox.Items[this.sortComboBox.SelectedIndex].ToString() == "Name")
                        moviesList = sortByName(moviesList, movieCounter);
                }
            }
        }

        private void clearComponents() {
            init = true;
            begin = true;
            this.moviePanel.AutoScrollPosition = new Point(0, 0);
            this.moviePanel.Controls.Clear();
        }

        private void reAdd() {
            clearComponents();
            this.moviePanel.Controls.Add(this.btnPlay);
            this.moviePanel.Controls.Add(this.totalMoviesLbl);
            this.moviePanel.Controls.Add(this.movieNameLbl);
            this.moviePanel.Controls.Add(this.moviePic1);
            this.moviePanel.Controls.Add(this.btnEdit);
            moviePanel.HorizontalScroll.Maximum = 0;
            moviePanel.AutoScroll = false;
            moviePanel.VerticalScroll.Visible = false;
            moviePanel.AutoScroll = true;

            int numOfMovies = movieCounter;
            movieCounter = 0;

            for (int i = 0; i < numOfMovies; i++) {
                movieCounter++;
                btnSave_Click(new object(), new EventArgs());
            }
            init = false;
        }

        #endregion

        #region Genre Event Handler
        private void genreEventHandler(object sender, EventArgs e) {
            this.sortComboBox.Visible = true;
            this.btnAdd.Visible = false;
            moviesSubMenuPanel.Visible = false;
            setButtonLocations('h');
            Button btnGenre = (Button)sender;
            
            if (btnGenre.Name == "btnComedy") {
                showPanel(comedyPanel, "Comedy");
                addGenrePanel(currentPanel, (Movie[])genre.Genres[0], genre.comedyCount);
            }
            else if (btnGenre.Name == "btnThriller") {
                showPanel(thrillerPanel, "Thriller");
                addGenrePanel(currentPanel, (Movie[])genre.Genres[2], genre.thrillerCount);
            } 
            else if(btnGenre.Name == "btnDrama") {
                showPanel(dramaPanel, "Drama");
                addGenrePanel(currentPanel, (Movie[])genre.Genres[1], genre.dramaCount);
            } 
            else if(btnGenre.Name == "btnScifi") {
                showPanel(scifiPanel, "Sci-Fi");
                addGenrePanel(currentPanel, (Movie[])genre.Genres[3], genre.scifiCount);
            } 
            else if(btnGenre.Name == "btnHorror") {
                showPanel(horrorPanel, "Horror");
                addGenrePanel(currentPanel, (Movie[])genre.Genres[4], genre.horrorCount);
            }
            else if (btnGenre.Name == "btnAllMovies") {
                this.btnAdd.Visible = true;
                this.lblTop.Text = "All Movies";
                this.Controls.Remove(currentPanel);
                this.Controls.Add(moviePanel);
                currentPanel = moviePanel;
            }
        }

        public void addGenrePanel(Panel panel, Movie[] movies, int len) {
            for (int i = 0; i < len; i++) {
                int Y = i * 450;
                if (i == 0) Y = 10;
                panel.Controls.Add(new GenreSubPanel(this, movies[i], Y));
            }
        }

        public void showPanel(Panel panel, string text) {
            this.lblTop.Text = "Genre: " + text;
            clearGenrePanelComponents(panel);
            this.Controls.Remove(currentPanel);
            this.Controls.Add(panel);
            currentPanel = panel;
        }

        public void clearGenrePanelComponents(Panel panel) {
            panel.Controls.Clear();
            panel.AutoScrollPosition = new Point(0, 0);
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = false;
            panel.VerticalScroll.Visible = false;
            panel.AutoScroll = true;
        }

        #endregion

        #region Btn Cancel (AddPanel and Edit Panel)
        private void btnCancel_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            if (btn.Name == "btnCancelAddPanel") {
                this.Controls.Remove(addPanel);
                this.Controls.Add(moviePanel);
            }
            else if (btn.Name == "btnCancelEditPanel") {
                this.Controls.Remove(editPanel);
                this.Controls.Add(moviePanel);
            }
            currentPanel = moviePanel;
        }

        #endregion

        #region Btn Save Changes
        private void btnSaveChanges_Click(object sender, EventArgs e) {
            string movieName = this.txtEditMovie.Text;
            string movieDirector = this.txtEditDirector.Text;
            int movieYear = 0;
            string genre = this.comboEditGenre.SelectedItem.ToString();

            if (this.txtEditYear.Text.Length != 0) {
                try {
                    movieYear = int.Parse(this.txtEditYear.Text);
                }
                catch (System.FormatException fe) {
                    MessageBox.Show("Enter correct year format", "ERROR");
                }
            }
            else MessageBox.Show("Please enter a year");
            if (movieName.Length == 0 || movieDirector.Length == 0
                || genre.Length == 0 || genre == "Select") {
                MessageBox.Show("Please fill out all the required info", "ERROR");
                return;
            }

            moviesList[selectedIndex].Name = movieName;
            moviesList[selectedIndex].Director = movieDirector;
            moviesList[selectedIndex].Year = movieYear;
            moviesList[selectedIndex].Picture = this.editMovieImage.ImageLocation;
            moviesList[selectedIndex].Genre = genre;

            this.moviePanel.Controls["movieLbl" + selectedIndex].Text = movieName + " (" + movieYear + ")";
            ((PictureBox)(this.moviePanel.Controls["moviePic" + selectedIndex])).ImageLocation =
                this.editMovieImage.ImageLocation;
            this.Controls.Remove(editPanel);
            this.Controls.Add(moviePanel);
            currentPanel = moviePanel;
        }
        #endregion

        #region MainPanel OnPanel Buttons
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            this.Controls.Remove(moviePanel);
            this.Controls.Add(addPanel);
            currentPanel = addPanel;
        }

        private void btnMovieGenres_Click(object sender, EventArgs e) {
            if (moviesSubMenuPanel.Visible) {
                moviesSubMenuPanel.Visible = false;
                setButtonLocations('h');
            }
            else {
                moviesSubMenuPanel.Visible = true;
                setButtonLocations('s');
            }
        }
        #endregion

        private void setButtonLocations(char stat) {
            if (stat == 'h') {
                this.btnSearch.Top = 0;
                this.btnSearch.Top += this.btnMovieGenres.Top + this.btnMovieGenres.Height + 5;
                this.btnWatchList.Top = 0;
                this.btnWatchList.Top += this.btnSearch.Top + this.btnSearch.Height + 5;
                this.btnSettings.Top = 0;
                this.btnSettings.Top += this.btnWatchList.Top + this.btnWatchList.Height + 5;
                
            }
            else if (stat == 's') {
                this.btnSearch.Top += this.moviesSubMenuPanel.Height + 5;
                this.btnWatchList.Top = 0;
                this.btnWatchList.Top += this.btnSearch.Top + this.btnSearch.Height + 5;
                this.btnSettings.Top = 0;
                this.btnSettings.Top += this.btnWatchList.Top + this.btnWatchList.Height + 5;
            }
        }

        #region Methods related to searching
        private void btnSearch_Click(object sender, EventArgs e) {
            init_Names();
            this.Controls.Remove(currentPanel);
            this.Controls.Add(searchPanel);
            this.lblTop.Text = "Search Movie";
            this.sortComboBox.Visible = false;
            currentPanel = this.searchPanel;
        }

        private void comboSearchBy_SelectedIndexChanged(object sender, EventArgs e) {
            this.sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (this.comboSearchBy.SelectedItem.ToString() == "Name") init_Names();
            else init_Directors();
        }

        private void init_Names() {
            string[] arr = new string[movieCounter];
            for (int i = 0; i < movieCounter; i++)
                arr[i] = moviesList[i].Name;
            setAutoCompleteCustomSource(arr);
        }

        private void init_Directors() {
            string[] arr = new string[movieCounter];
            for (int i = 0; i < movieCounter; i++) 
                arr[i] = moviesList[i].Director;
            setAutoCompleteCustomSource(arr);
        }

        private void setAutoCompleteCustomSource(string[] arr) {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(arr);
            this.txtSearch.AutoCompleteCustomSource = collection;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e) { 
            string searchName = this.txtSearch.Text;
            if(searchName.Length == 0) return;
            if(e.KeyCode == Keys.Enter) {
                if (this.comboSearchBy.SelectedItem.ToString() == "Name" ||
                    this.comboSearchBy.SelectedItem.ToString() == "Search By") {
                    int index = containsMovie(searchName);
                    if (index != -1) {
                        Panel SearchedMoviePanel = new searchedMoviePanel(this, moviesList[index]);
                        this.Controls.Remove(currentPanel);
                        this.Controls.Add(SearchedMoviePanel);
                        currentPanel = SearchedMoviePanel;
                    }
                    else MessageBox.Show("No such movie exists");
                } else {
                    int index = containsDirector(searchName);
                    if(index != -1) {
                        this.Controls.Remove(searchPanel);
                        this.Controls.Add(dirSearchPanel);
                        addDirSearchResults(searchName);
                    } else MessageBox.Show("No such director exists");
                    this.currentPanel = dirSearchPanel;
                }
            }
        }

        private int containsMovie(string movieName) {
            for(int i = 0; i < movieCounter; i++) {
                if (movieName == moviesList[i].Name) return i;
            }
            return -1;
        }
        private int containsDirector(string dirName) {
            for (int i = 0; i < movieCounter; i++) {
                if (dirName == moviesList[i].Director) return i;
            }
            return -1;
        }

        #endregion

        #region Removing Logic
        private void btnRemove_Click(object sender, EventArgs e) {
            int index = int.Parse(((Button)sender).Name);
            string whichGenre = moviesList[index].Genre;
            removeGenre(index);
            removeMovie(index);
            if (movieCounter == 0) clearComponents();
            else reAdd();
            
            this.Controls.Remove(editPanel);
            this.updateMovieIndices();
            /*if (lblTop.Text == "All Movies") {
                this.Controls.Add(moviePanel);
                currentPanel = moviePanel;
            } else if(lblTop.Text == "Genre: Comedy") {
                this.Controls.Add(comedyPanel);
                currentPanel = comedyPanel;
            }
            else if (lblTop.Text == "Genre: Drama") {
                this.Controls.Add(dramaPanel);
                currentPanel = dramaPanel;
            }
            else if (lblTop.Text == "Genre: Thriller") {
                this.Controls.Add(thrillerPanel);
                currentPanel = thrillerPanel;
            }
            else if (lblTop.Text == "Genre: Sci-Fi") {
                this.Controls.Add(scifiPanel);
                currentPanel = scifiPanel;
            }
            else if (lblTop.Text == "Genre: Horror") {
                this.Controls.Add(horrorPanel);
                currentPanel = horrorPanel;
            }*/
            this.Controls.Add(moviePanel);
            currentPanel = moviePanel;
        }

        //Make sure that the movie does indeed exists, before calling this subroutine
        private void removeMovie(int index) {
            if (movieCounter == 1) {
                movieCounter = 0;
                moviesList = new Movie[20];
            }
            else {
                Movie[] newList = new Movie[movieCounter - 1];
                int j = 0;
                for (int i = 0; i < movieCounter; i++) {
                    if (i != index) {
                        newList[j++] = moviesList[i];
                    }
                }
                moviesList = newList;
                movieCounter--;
            }
        }

        public void removeGenre(int index) {
            string whichGenre = moviesList[index].Genre;
            int indexOfGenre = genre.getGenreIndex(whichGenre);
            Movie[] genreMovies = (Movie[])genre.Genres[indexOfGenre];
            Movie[] newArr = new Movie[genre.getGenreCount(whichGenre)];
            int k = 0;

            for (int i = 0; i < genre.getGenreCount(whichGenre); i++) {
                if (genreMovies[i].Name != moviesList[index].Name)
                    newArr[k++] = genreMovies[i];
            }

            genre.Genres[indexOfGenre] = newArr;
            if (whichGenre == "Comedy") {
                genre.comedyCount--;
                genreEventHandler(this.btnComedy, new EventArgs());
            } 
            else if (whichGenre == "Drama") {
                genre.dramaCount--;
                genreEventHandler(this.btnDrama, new EventArgs()); 
            }
            else if (whichGenre == "Thriller") {
                genre.thrillerCount--;
                genreEventHandler(this.btnThriller, new EventArgs());
            }
            else if (whichGenre == "SciFi") {
                genre.scifiCount--;
                genreEventHandler(this.btnScifi, new EventArgs());
            }
            else if (whichGenre == "Horror") {
                genre.horrorCount--;
                genreEventHandler(this.btnHorror, new EventArgs());
            }
        }

        private void updateMovieIndices() {
            for(int i = 0; i < movieCounter; i++) {
                moviesList[i].MovieIndex = i;
            }
        }

        #endregion

        private void addDirSearchResults(string director) {
            int X = 16;
            int Y = 14;
            int numOfPanels = 1;
            int prevPanel;
            for (int i = 0; i < movieCounter; i++) {
                if (moviesList[i].Director == director) {
                    movieSubPanel myPanel = new movieSubPanel(this, moviesList[i], X, Y);
                    this.dirSearchPanel.Controls.Add(myPanel);
                    prevPanel = myPanel.Top + myPanel.Height;

                    if (numOfPanels % 2 != 0)
                        X = 696;
                    else {
                        X = 16;
                        Y = prevPanel + 5;
                    }
                    numOfPanels++;
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e) {
            MessageBox.Show("A Modern Movie Manager\nDevelopers: Ammar Ahmed and Muhammad Haseeb");
        }

        public string getDuration(string filepath) {
            WindowsMediaPlayer wmp = new WindowsMediaPlayer();
            IWMPMedia mediaInfo = wmp.newMedia(filepath);
            double minDuration = (int) (mediaInfo.duration / 60);
            double hourDuration = 0;
            if (minDuration >= 60) {
                hourDuration = Math.Floor((minDuration / 60));
                minDuration = (int)((minDuration / 60) - hourDuration) * 60;
            }
            return hourDuration + " hrs " + minDuration + " mins";
        }

        private void btnLogOut_Click(object sender, EventArgs e) {
            this.Hide();
            this.Dispose();
            string remPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.users\\remember.me.txt";
            if (File.Exists(remPath)) File.Delete(remPath);
            new StartWin().ShowDialog();
        }

        #region Watch List
        private void btnWatchList_Click(object sender, EventArgs e) {
            this.Controls.Remove(this.currentPanel);
            this.Controls.Add(this.watchListPanel);
            this.currentPanel = watchListPanel;
            this.lblTop.Text = "Watch List";
        }

        private void btnAddToWatchList_Click(object sender, EventArgs e) {
            if (this.watchListTxt.Text.Length == 0) {
                MessageBox.Show("Enter Valid Movie Name");
                return;
            }
            string movieName = this.watchListTxt.Text;
            if (watchLists.watchList.Length == watchLists.watchListCounter) 
                watchLists.watchList = expandWatch(watchLists.watchList, watchLists.watchListCounter);
            this.watchLists.watchList[this.watchLists.watchListCounter++] = movieName;
            addWatchListMovie(movieName, this.watchLists.watchListCounter);
            this.watchListTxt.Clear();
        }

        private void addWatchListMovie(string name, int onPosition) {
            CheckBox cBoxMovie = new CheckBox();
            cBoxMovie.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            cBoxMovie.FlatAppearance.BorderSize = 0;
            cBoxMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            cBoxMovie.Size = new System.Drawing.Size(632, 77);
            cBoxMovie.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if(onPosition == 1)
                cBoxMovie.Location = new System.Drawing.Point(4, 13);
            else
                cBoxMovie.Location = new System.Drawing.Point(4, 
                   this.watchListSubPanel.Controls["" + (onPosition-1)].Location.Y + (cBoxMovie.Height + 10));
            cBoxMovie.Name = "" + onPosition;
            cBoxMovie.TabIndex = 12;
            cBoxMovie.Text = name;
            cBoxMovie.UseVisualStyleBackColor = true;
            cBoxMovie.CheckedChanged += new EventHandler(watchListCheckEvent);
            this.watchListSubPanel.Controls.Add(cBoxMovie);
        }

        private void populateWatchList() {
            int onPosition = 0;
            for (int i = 0; i < this.watchLists.watchListCounter; i++) {
                onPosition++;
                addWatchListMovie(watchLists.watchList[i], onPosition);
            }
        }

        public string[] expandWatch(string[] watches, int len) {
            string[] newArr = new string[watches.Length * 2];
            for (int i = 0; i < len; i++)
                newArr[i] = watches[i];
            return newArr;
        }

        private void watchListCheckEvent(object sender, EventArgs e) {
            int index = int.Parse(((CheckBox)sender).Name) - 1;
            string nameOfTheMovie = this.watchLists.watchList[index];
            removeFromWatchList(index);
            this.watchListSubPanel.Controls.Clear();
            setAutoScroll(watchListSubPanel);
            populateWatchList();
            if (this.watchLists.watched.Length == this.watchLists.watchedCounter)
                this.watchLists.watched = expandWatch(this.watchLists.watched, this.watchLists.watchedCounter);
            this.watchLists.watched[this.watchLists.watchedCounter++] = nameOfTheMovie;
            addWatchedMovie(nameOfTheMovie, this.watchLists.watchedCounter);
        }

        private void removeFromWatchList(int index) {
            string[] watchListArray = new string[this.watchLists.watchList.Length];
            int j = 0;
            for(int i = 0; i < this.watchLists.watchListCounter; i++) {
                if (i != index)
                    watchListArray[j++] = this.watchLists.watchList[i];
            }

            this.watchLists.watchList = watchListArray;
            this.watchLists.watchListCounter--;
        }

        private void addWatchedMovie(string name, int onPosition) {
            TextBox tBoxMovie = new TextBox();
            tBoxMovie.Size = new System.Drawing.Size(632, 77);
            tBoxMovie.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if (onPosition == 1)
                tBoxMovie.Location = new System.Drawing.Point(4, 13);
            else
                tBoxMovie.Location = new System.Drawing.Point(4,
                   this.watchedSubPanel.Controls["" + (onPosition - 1)].Location.Y + (tBoxMovie.Height + 10));
            tBoxMovie.Name = "" + onPosition;
            tBoxMovie.Text = name;
            this.watchedSubPanel.Controls.Add(tBoxMovie);
        }

        private void populateWatched() {
            int onPosition = 0;
            for(int i = 0; i < this.watchLists.watchedCounter; i++) 
                addWatchedMovie(this.watchLists.watched[i], ++onPosition);
        }

        private void btnClearWatched_Click(object sender, EventArgs e) {
            this.watchedSubPanel.Controls.Clear();
            setAutoScroll(watchedSubPanel);
            this.watchLists.watched = new string[20];
            this.watchLists.watchedCounter = 0;
        }

        #endregion

        private void btnSettings_Click(object sender, EventArgs e) {
            UserEdit userSettings = new UserEdit(this);
            userSettings.edit = true;
            userSettings.editName = user.userName;
            userSettings.txtFullName.Text = user.fullName;
            userSettings.txtPassword.Text = user.password;
            userSettings.txtUserName.Text = user.userName;
            userSettings.setPic(user.picLocation);
            userSettings.lblDob.Visible = false;
            userSettings.dateTimePicker1.Visible = false;
            userSettings.ShowDialog();
            this.userPicBox.ImageLocation = user.picLocation;
            this.lblUsername.Text = user.fullName;
        }

        private void watchListTxt_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) this.btnAddToWatchList_Click(sender, e);
        }
    }
}
