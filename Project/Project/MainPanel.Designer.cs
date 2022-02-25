using System;

namespace Project {
    partial class MainPanel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel editPanel;
        public System.Windows.Forms.Panel comedyPanel;
        public System.Windows.Forms.Panel thrillerPanel;
        public System.Windows.Forms.Panel dramaPanel;
        public System.Windows.Forms.Panel scifiPanel;
        public System.Windows.Forms.Panel horrorPanel;
        public System.Windows.Forms.Panel searchPanel;
        public System.Windows.Forms.Panel dirSearchPanel;
        public System.Windows.Forms.Panel watchListPanel;

        private void InitializeComponent() {
            this.watchListPanel = new System.Windows.Forms.Panel();
            this.btnClearWatched = new System.Windows.Forms.Button();
            this.watchedLbl = new System.Windows.Forms.Label();
            this.watchListLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddToWatchList = new System.Windows.Forms.Button();
            this.watchListTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.watchedSubPanel = new System.Windows.Forms.Panel();
            this.watchListSubPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.comboSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dirSearchPanel = new System.Windows.Forms.Panel();
            this.thrillerPanel = new System.Windows.Forms.Panel();
            this.comedyPanel = new System.Windows.Forms.Panel();
            this.dramaPanel = new System.Windows.Forms.Panel();
            this.horrorPanel = new System.Windows.Forms.Panel();
            this.scifiPanel = new System.Windows.Forms.Panel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancelEditPanel = new System.Windows.Forms.Button();
            this.comboEditGenre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnEditImage = new System.Windows.Forms.Button();
            this.txtEditDirector = new System.Windows.Forms.TextBox();
            this.txtEditYear = new System.Windows.Forms.TextBox();
            this.txtEditMovie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editMovieImage = new System.Windows.Forms.PictureBox();
            this.addPanel = new System.Windows.Forms.Panel();
            this.comboSelectGenre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelAddPanel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImageSelect = new System.Windows.Forms.Button();
            this.btnMovieSelect = new System.Windows.Forms.Button();
            this.txtMovieDirector = new System.Windows.Forms.TextBox();
            this.txtMovieYear = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jlabel = new System.Windows.Forms.Label();
            this.movieImage = new System.Windows.Forms.PictureBox();
            this.moviePanel = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.totalMoviesLbl = new System.Windows.Forms.Label();
            this.movieNameLbl = new System.Windows.Forms.Label();
            this.moviePic1 = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnWatchList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.userPicBox = new OvalPictureBox();
            this.moviesSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnAllMovies = new System.Windows.Forms.Button();
            this.btnHorror = new System.Windows.Forms.Button();
            this.btnScifi = new System.Windows.Forms.Button();
            this.btnThriller = new System.Windows.Forms.Button();
            this.btnDrama = new System.Windows.Forms.Button();
            this.btnComedy = new System.Windows.Forms.Button();
            this.btnMovieGenres = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.watchListPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editMovieImage)).BeginInit();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).BeginInit();
            this.moviePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePic1)).BeginInit();
            this.sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).BeginInit();
            this.moviesSubMenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // watchListPanel
            // 
            this.watchListPanel.Controls.Add(this.btnClearWatched);
            this.watchListPanel.Controls.Add(this.watchedLbl);
            this.watchListPanel.Controls.Add(this.watchListLbl);
            this.watchListPanel.Controls.Add(this.panel4);
            this.watchListPanel.Controls.Add(this.panel3);
            this.watchListPanel.Controls.Add(this.watchedSubPanel);
            this.watchListPanel.Controls.Add(this.watchListSubPanel);
            this.watchListPanel.Location = new System.Drawing.Point(315, 62);
            this.watchListPanel.Name = "watchListPanel";
            this.watchListPanel.Size = new System.Drawing.Size(1310, 909);
            this.watchListPanel.TabIndex = 0;
            // 
            // btnClearWatched
            // 
            this.btnClearWatched.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnClearWatched.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnClearWatched.FlatAppearance.BorderSize = 7;
            this.btnClearWatched.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearWatched.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearWatched.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearWatched.Location = new System.Drawing.Point(855, 856);
            this.btnClearWatched.Name = "btnClearWatched";
            this.btnClearWatched.Size = new System.Drawing.Size(262, 44);
            this.btnClearWatched.TabIndex = 13;
            this.btnClearWatched.Text = "Clear Watched";
            this.btnClearWatched.UseVisualStyleBackColor = false;
            this.btnClearWatched.Click += new System.EventHandler(this.btnClearWatched_Click);
            // 
            // watchedLbl
            // 
            this.watchedLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.watchedLbl.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchedLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.watchedLbl.Location = new System.Drawing.Point(664, 11);
            this.watchedLbl.Name = "watchedLbl";
            this.watchedLbl.Size = new System.Drawing.Size(639, 87);
            this.watchedLbl.TabIndex = 10;
            this.watchedLbl.Text = "Watched";
            this.watchedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // watchListLbl
            // 
            this.watchListLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.watchListLbl.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchListLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.watchListLbl.Location = new System.Drawing.Point(4, 11);
            this.watchListLbl.Name = "watchListLbl";
            this.watchListLbl.Size = new System.Drawing.Size(639, 87);
            this.watchListLbl.TabIndex = 10;
            this.watchListLbl.Text = "Watch List";
            this.watchListLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel4.Controls.Add(this.btnAddToWatchList);
            this.panel4.Controls.Add(this.watchListTxt);
            this.panel4.Location = new System.Drawing.Point(1, 846);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(640, 60);
            this.panel4.TabIndex = 11;
            // 
            // btnAddToWatchList
            // 
            this.btnAddToWatchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAddToWatchList.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAddToWatchList.FlatAppearance.BorderSize = 7;
            this.btnAddToWatchList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToWatchList.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToWatchList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddToWatchList.Location = new System.Drawing.Point(420, 9);
            this.btnAddToWatchList.Name = "btnAddToWatchList";
            this.btnAddToWatchList.Size = new System.Drawing.Size(205, 40);
            this.btnAddToWatchList.TabIndex = 10;
            this.btnAddToWatchList.Text = "Add To Watchlist";
            this.btnAddToWatchList.UseVisualStyleBackColor = false;
            this.btnAddToWatchList.Click += new System.EventHandler(this.btnAddToWatchList_Click);
            // 
            // watchListTxt
            // 
            this.watchListTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchListTxt.Location = new System.Drawing.Point(34, 9);
            this.watchListTxt.Multiline = true;
            this.watchListTxt.Name = "watchListTxt";
            this.watchListTxt.Size = new System.Drawing.Size(380, 40);
            this.watchListTxt.TabIndex = 12;
            this.watchListTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.watchListTxt_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel3.Location = new System.Drawing.Point(648, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 907);
            this.panel3.TabIndex = 13;
            // 
            // watchedSubPanel
            // 
            this.watchedSubPanel.Location = new System.Drawing.Point(663, 101);
            this.watchedSubPanel.Name = "watchedSubPanel";
            this.watchedSubPanel.Size = new System.Drawing.Size(644, 749);
            this.watchedSubPanel.TabIndex = 12;
            // 
            // watchListSubPanel
            // 
            this.watchListSubPanel.Location = new System.Drawing.Point(4, 103);
            this.watchListSubPanel.Name = "watchListSubPanel";
            this.watchListSubPanel.Size = new System.Drawing.Size(641, 746);
            this.watchListSubPanel.TabIndex = 11;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.Black;
            this.searchPanel.Controls.Add(this.comboSearchBy);
            this.searchPanel.Controls.Add(this.lblSearch);
            this.searchPanel.Controls.Add(this.txtSearch);
            this.searchPanel.Location = new System.Drawing.Point(315, 66);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1310, 905);
            this.searchPanel.TabIndex = 0;
            // 
            // comboSearchBy
            // 
            this.comboSearchBy.BackColor = System.Drawing.Color.Black;
            this.comboSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSearchBy.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSearchBy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboSearchBy.FormattingEnabled = true;
            this.comboSearchBy.Items.AddRange(new object[] {
            "Name",
            "Director"});
            this.comboSearchBy.Location = new System.Drawing.Point(991, 338);
            this.comboSearchBy.Name = "comboSearchBy";
            this.comboSearchBy.Size = new System.Drawing.Size(157, 35);
            this.comboSearchBy.TabIndex = 10;
            this.comboSearchBy.Text = "Search By";
            this.comboSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboSearchBy_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Location = new System.Drawing.Point(322, 302);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(663, 33);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(322, 338);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(663, 40);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dirSearchPanel
            // 
            this.dirSearchPanel.Location = new System.Drawing.Point(315, 62);
            this.dirSearchPanel.Name = "dirSearchPanel";
            this.dirSearchPanel.Size = new System.Drawing.Size(1307, 909);
            this.dirSearchPanel.TabIndex = 0;
            // 
            // thrillerPanel
            // 
            this.thrillerPanel.Location = new System.Drawing.Point(316, 67);
            this.thrillerPanel.Name = "thrillerPanel";
            this.thrillerPanel.Size = new System.Drawing.Size(1307, 905);
            this.thrillerPanel.TabIndex = 0;
            // 
            // comedyPanel
            // 
            this.comedyPanel.Location = new System.Drawing.Point(311, 68);
            this.comedyPanel.Name = "comedyPanel";
            this.comedyPanel.Size = new System.Drawing.Size(1314, 901);
            this.comedyPanel.TabIndex = 5;
            // 
            // dramaPanel
            // 
            this.dramaPanel.Location = new System.Drawing.Point(316, 67);
            this.dramaPanel.Name = "dramaPanel";
            this.dramaPanel.Size = new System.Drawing.Size(1307, 905);
            this.dramaPanel.TabIndex = 0;
            // 
            // horrorPanel
            // 
            this.horrorPanel.Location = new System.Drawing.Point(316, 67);
            this.horrorPanel.Name = "horrorPanel";
            this.horrorPanel.Size = new System.Drawing.Size(1307, 905);
            this.horrorPanel.TabIndex = 0;
            // 
            // scifiPanel
            // 
            this.scifiPanel.Location = new System.Drawing.Point(316, 67);
            this.scifiPanel.Name = "scifiPanel";
            this.scifiPanel.Size = new System.Drawing.Size(1307, 905);
            this.scifiPanel.TabIndex = 0;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.btnRemove);
            this.editPanel.Controls.Add(this.btnCancelEditPanel);
            this.editPanel.Controls.Add(this.comboEditGenre);
            this.editPanel.Controls.Add(this.label7);
            this.editPanel.Controls.Add(this.btnSaveChanges);
            this.editPanel.Controls.Add(this.btnEditImage);
            this.editPanel.Controls.Add(this.txtEditDirector);
            this.editPanel.Controls.Add(this.txtEditYear);
            this.editPanel.Controls.Add(this.txtEditMovie);
            this.editPanel.Controls.Add(this.label4);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.label6);
            this.editPanel.Controls.Add(this.editMovieImage);
            this.editPanel.Location = new System.Drawing.Point(311, 63);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(1314, 909);
            this.editPanel.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnRemove.FlatAppearance.BorderSize = 7;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(677, 710);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(252, 49);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove Current Movie";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancelEditPanel
            // 
            this.btnCancelEditPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnCancelEditPanel.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnCancelEditPanel.FlatAppearance.BorderSize = 7;
            this.btnCancelEditPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelEditPanel.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelEditPanel.Location = new System.Drawing.Point(677, 629);
            this.btnCancelEditPanel.Name = "btnCancelEditPanel";
            this.btnCancelEditPanel.Size = new System.Drawing.Size(252, 49);
            this.btnCancelEditPanel.TabIndex = 21;
            this.btnCancelEditPanel.Text = "Cancel";
            this.btnCancelEditPanel.UseVisualStyleBackColor = false;
            this.btnCancelEditPanel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboEditGenre
            // 
            this.comboEditGenre.BackColor = System.Drawing.Color.White;
            this.comboEditGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEditGenre.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEditGenre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboEditGenre.FormattingEnabled = true;
            this.comboEditGenre.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Thriller",
            "SciFi",
            "Horror"});
            this.comboEditGenre.Location = new System.Drawing.Point(824, 353);
            this.comboEditGenre.Name = "comboEditGenre";
            this.comboEditGenre.Size = new System.Drawing.Size(241, 35);
            this.comboEditGenre.TabIndex = 10;
            this.comboEditGenre.Text = "Select";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "Genre:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnSaveChanges.FlatAppearance.BorderSize = 7;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveChanges.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveChanges.Location = new System.Drawing.Point(677, 551);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(252, 49);
            this.btnSaveChanges.TabIndex = 19;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnEditImage
            // 
            this.btnEditImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnEditImage.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnEditImage.FlatAppearance.BorderSize = 7;
            this.btnEditImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditImage.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditImage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditImage.Location = new System.Drawing.Point(677, 472);
            this.btnEditImage.Name = "btnEditImage";
            this.btnEditImage.Size = new System.Drawing.Size(252, 49);
            this.btnEditImage.TabIndex = 18;
            this.btnEditImage.Text = "Select Image";
            this.btnEditImage.UseVisualStyleBackColor = false;
            this.btnEditImage.Click += new System.EventHandler(this.btnImageSelect_Click);
            // 
            // txtEditDirector
            // 
            this.txtEditDirector.Location = new System.Drawing.Point(824, 254);
            this.txtEditDirector.Name = "txtEditDirector";
            this.txtEditDirector.Size = new System.Drawing.Size(241, 26);
            this.txtEditDirector.TabIndex = 17;
            // 
            // txtEditYear
            // 
            this.txtEditYear.Location = new System.Drawing.Point(824, 307);
            this.txtEditYear.Name = "txtEditYear";
            this.txtEditYear.Size = new System.Drawing.Size(105, 26);
            this.txtEditYear.TabIndex = 16;
            // 
            // txtEditMovie
            // 
            this.txtEditMovie.Location = new System.Drawing.Point(824, 189);
            this.txtEditMovie.Name = "txtEditMovie";
            this.txtEditMovie.Size = new System.Drawing.Size(241, 26);
            this.txtEditMovie.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(672, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Director:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(672, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Year:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(672, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Movie Name:";
            // 
            // editMovieImage
            // 
            this.editMovieImage.Location = new System.Drawing.Point(200, 159);
            this.editMovieImage.Name = "editMovieImage";
            this.editMovieImage.Size = new System.Drawing.Size(406, 602);
            this.editMovieImage.TabIndex = 11;
            this.editMovieImage.TabStop = false;
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.comboSelectGenre);
            this.addPanel.Controls.Add(this.label8);
            this.addPanel.Controls.Add(this.btnCancelAddPanel);
            this.addPanel.Controls.Add(this.btnSave);
            this.addPanel.Controls.Add(this.btnImageSelect);
            this.addPanel.Controls.Add(this.btnMovieSelect);
            this.addPanel.Controls.Add(this.txtMovieDirector);
            this.addPanel.Controls.Add(this.txtMovieYear);
            this.addPanel.Controls.Add(this.txtMovieName);
            this.addPanel.Controls.Add(this.label2);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Controls.Add(this.jlabel);
            this.addPanel.Controls.Add(this.movieImage);
            this.addPanel.Location = new System.Drawing.Point(311, 63);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(1314, 907);
            this.addPanel.TabIndex = 5;
            // 
            // comboSelectGenre
            // 
            this.comboSelectGenre.BackColor = System.Drawing.Color.White;
            this.comboSelectGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSelectGenre.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSelectGenre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboSelectGenre.FormattingEnabled = true;
            this.comboSelectGenre.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Thriller",
            "SciFi",
            "Horror"});
            this.comboSelectGenre.Location = new System.Drawing.Point(791, 344);
            this.comboSelectGenre.Name = "comboSelectGenre";
            this.comboSelectGenre.Size = new System.Drawing.Size(241, 35);
            this.comboSelectGenre.TabIndex = 21;
            this.comboSelectGenre.Text = "Select";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(639, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 31);
            this.label8.TabIndex = 22;
            this.label8.Text = "Genre:";
            // 
            // btnCancelAddPanel
            // 
            this.btnCancelAddPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnCancelAddPanel.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnCancelAddPanel.FlatAppearance.BorderSize = 7;
            this.btnCancelAddPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelAddPanel.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelAddPanel.Location = new System.Drawing.Point(644, 647);
            this.btnCancelAddPanel.Name = "btnCancelAddPanel";
            this.btnCancelAddPanel.Size = new System.Drawing.Size(252, 49);
            this.btnCancelAddPanel.TabIndex = 11;
            this.btnCancelAddPanel.Text = "Cancel";
            this.btnCancelAddPanel.UseVisualStyleBackColor = false;
            this.btnCancelAddPanel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 7;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(644, 573);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(252, 49);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Add Movie";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImageSelect
            // 
            this.btnImageSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnImageSelect.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnImageSelect.FlatAppearance.BorderSize = 7;
            this.btnImageSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImageSelect.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImageSelect.Location = new System.Drawing.Point(644, 494);
            this.btnImageSelect.Name = "btnImageSelect";
            this.btnImageSelect.Size = new System.Drawing.Size(252, 49);
            this.btnImageSelect.TabIndex = 9;
            this.btnImageSelect.Text = "Select Image";
            this.btnImageSelect.UseVisualStyleBackColor = false;
            this.btnImageSelect.Click += new System.EventHandler(this.btnImageSelect_Click);
            // 
            // btnMovieSelect
            // 
            this.btnMovieSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnMovieSelect.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnMovieSelect.FlatAppearance.BorderSize = 7;
            this.btnMovieSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovieSelect.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMovieSelect.Location = new System.Drawing.Point(644, 415);
            this.btnMovieSelect.Name = "btnMovieSelect";
            this.btnMovieSelect.Size = new System.Drawing.Size(252, 49);
            this.btnMovieSelect.TabIndex = 8;
            this.btnMovieSelect.Text = "Select Movie";
            this.btnMovieSelect.UseVisualStyleBackColor = false;
            this.btnMovieSelect.Click += new System.EventHandler(this.btnMovieSelect_Click);
            // 
            // txtMovieDirector
            // 
            this.txtMovieDirector.Location = new System.Drawing.Point(791, 236);
            this.txtMovieDirector.Name = "txtMovieDirector";
            this.txtMovieDirector.Size = new System.Drawing.Size(241, 26);
            this.txtMovieDirector.TabIndex = 7;
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(791, 289);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(105, 26);
            this.txtMovieYear.TabIndex = 6;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(791, 171);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(241, 26);
            this.txtMovieName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Director:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year:";
            // 
            // jlabel
            // 
            this.jlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jlabel.Location = new System.Drawing.Point(639, 170);
            this.jlabel.Name = "jlabel";
            this.jlabel.Size = new System.Drawing.Size(146, 31);
            this.jlabel.TabIndex = 1;
            this.jlabel.Text = "Movie Name:";
            // 
            // movieImage
            // 
            this.movieImage.Location = new System.Drawing.Point(158, 138);
            this.movieImage.Name = "movieImage";
            this.movieImage.Size = new System.Drawing.Size(406, 602);
            this.movieImage.TabIndex = 0;
            this.movieImage.TabStop = false;
            // 
            // moviePanel
            // 
            this.moviePanel.Controls.Add(this.btnEdit);
            this.moviePanel.Controls.Add(this.btnPlay);
            this.moviePanel.Controls.Add(this.totalMoviesLbl);
            this.moviePanel.Controls.Add(this.movieNameLbl);
            this.moviePanel.Controls.Add(this.moviePic1);
            this.moviePanel.Location = new System.Drawing.Point(316, 63);
            this.moviePanel.Name = "moviePanel";
            this.moviePanel.Size = new System.Drawing.Size(1309, 911);
            this.moviePanel.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnEdit.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(159, 633);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 49);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnPlay.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlay.Location = new System.Drawing.Point(159, 578);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(147, 49);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // totalMoviesLbl
            // 
            this.totalMoviesLbl.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMoviesLbl.Location = new System.Drawing.Point(5, 6);
            this.totalMoviesLbl.Name = "totalMoviesLbl";
            this.totalMoviesLbl.Size = new System.Drawing.Size(1306, 32);
            this.totalMoviesLbl.TabIndex = 4;
            this.totalMoviesLbl.Text = "Total Movies: 0";
            this.totalMoviesLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // movieNameLbl
            // 
            this.movieNameLbl.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieNameLbl.Location = new System.Drawing.Point(71, 536);
            this.movieNameLbl.Name = "movieNameLbl";
            this.movieNameLbl.Size = new System.Drawing.Size(335, 27);
            this.movieNameLbl.TabIndex = 3;
            this.movieNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moviePic1
            // 
            this.moviePic1.Location = new System.Drawing.Point(71, 61);
            this.moviePic1.Name = "moviePic1";
            this.moviePic1.Size = new System.Drawing.Size(335, 467);
            this.moviePic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moviePic1.TabIndex = 2;
            this.moviePic1.TabStop = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Black;
            this.sidePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sidePanel.Controls.Add(this.btnSettings);
            this.sidePanel.Controls.Add(this.btnAbout);
            this.sidePanel.Controls.Add(this.btnLogOut);
            this.sidePanel.Controls.Add(this.btnWatchList);
            this.sidePanel.Controls.Add(this.btnSearch);
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.moviesSubMenuPanel);
            this.sidePanel.Controls.Add(this.btnMovieGenres);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(315, 971);
            this.sidePanel.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnSettings.FlatAppearance.BorderSize = 7;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSettings.Location = new System.Drawing.Point(-2, 706);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(313, 73);
            this.btnSettings.TabIndex = 18;
            this.btnSettings.Text = "User Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAbout.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbout.Location = new System.Drawing.Point(192, 915);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(115, 42);
            this.btnAbout.TabIndex = 16;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnLogOut.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Location = new System.Drawing.Point(3, 915);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(115, 42);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnWatchList
            // 
            this.btnWatchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.btnWatchList.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnWatchList.FlatAppearance.BorderSize = 7;
            this.btnWatchList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWatchList.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnWatchList.Location = new System.Drawing.Point(-2, 626);
            this.btnWatchList.Name = "btnWatchList";
            this.btnWatchList.Size = new System.Drawing.Size(312, 73);
            this.btnWatchList.TabIndex = 14;
            this.btnWatchList.Text = "Watchlist ⌚";
            this.btnWatchList.UseVisualStyleBackColor = false;
            this.btnWatchList.Click += new System.EventHandler(this.btnWatchList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnSearch.FlatAppearance.BorderSize = 7;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(0, 547);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(312, 73);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search 🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.userPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 219);
            this.panel1.TabIndex = 12;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.Location = new System.Drawing.Point(3, 163);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(307, 33);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPicBox
            // 
            this.userPicBox.BackColor = System.Drawing.Color.DarkGray;
            this.userPicBox.Location = new System.Drawing.Point(95, 28);
            this.userPicBox.Name = "userPicBox";
            this.userPicBox.Size = new System.Drawing.Size(113, 108);
            this.userPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPicBox.TabIndex = 0;
            this.userPicBox.TabStop = false;
            // 
            // moviesSubMenuPanel
            // 
            this.moviesSubMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.moviesSubMenuPanel.Controls.Add(this.btnAllMovies);
            this.moviesSubMenuPanel.Controls.Add(this.btnHorror);
            this.moviesSubMenuPanel.Controls.Add(this.btnScifi);
            this.moviesSubMenuPanel.Controls.Add(this.btnThriller);
            this.moviesSubMenuPanel.Controls.Add(this.btnDrama);
            this.moviesSubMenuPanel.Controls.Add(this.btnComedy);
            this.moviesSubMenuPanel.Location = new System.Drawing.Point(0, 306);
            this.moviesSubMenuPanel.Name = "moviesSubMenuPanel";
            this.moviesSubMenuPanel.Size = new System.Drawing.Size(307, 235);
            this.moviesSubMenuPanel.TabIndex = 11;
            // 
            // btnAllMovies
            // 
            this.btnAllMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnAllMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllMovies.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAllMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllMovies.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMovies.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAllMovies.Location = new System.Drawing.Point(0, 190);
            this.btnAllMovies.Name = "btnAllMovies";
            this.btnAllMovies.Size = new System.Drawing.Size(307, 38);
            this.btnAllMovies.TabIndex = 17;
            this.btnAllMovies.Text = "All Movies";
            this.btnAllMovies.UseVisualStyleBackColor = false;
            this.btnAllMovies.Click += new System.EventHandler(this.genreEventHandler);
            // 
            // btnHorror
            // 
            this.btnHorror.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnHorror.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorror.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHorror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorror.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorror.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHorror.Location = new System.Drawing.Point(0, 152);
            this.btnHorror.Name = "btnHorror";
            this.btnHorror.Size = new System.Drawing.Size(307, 38);
            this.btnHorror.TabIndex = 16;
            this.btnHorror.Text = "Horror";
            this.btnHorror.UseVisualStyleBackColor = false;
            this.btnHorror.Click += new System.EventHandler(this.genreEventHandler);
            // 
            // btnScifi
            // 
            this.btnScifi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnScifi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScifi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnScifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScifi.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScifi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnScifi.Location = new System.Drawing.Point(0, 114);
            this.btnScifi.Name = "btnScifi";
            this.btnScifi.Size = new System.Drawing.Size(307, 38);
            this.btnScifi.TabIndex = 15;
            this.btnScifi.Text = "Sci-Fi";
            this.btnScifi.UseVisualStyleBackColor = false;
            this.btnScifi.Click += new System.EventHandler(this.genreEventHandler);
            // 
            // btnThriller
            // 
            this.btnThriller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnThriller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThriller.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThriller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThriller.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThriller.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThriller.Location = new System.Drawing.Point(0, 76);
            this.btnThriller.Name = "btnThriller";
            this.btnThriller.Size = new System.Drawing.Size(307, 38);
            this.btnThriller.TabIndex = 14;
            this.btnThriller.Text = "Thriller";
            this.btnThriller.UseVisualStyleBackColor = false;
            this.btnThriller.Click += new System.EventHandler(this.genreEventHandler);
            // 
            // btnDrama
            // 
            this.btnDrama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnDrama.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrama.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDrama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrama.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrama.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDrama.Location = new System.Drawing.Point(0, 38);
            this.btnDrama.Name = "btnDrama";
            this.btnDrama.Size = new System.Drawing.Size(307, 38);
            this.btnDrama.TabIndex = 13;
            this.btnDrama.Text = "Drama";
            this.btnDrama.UseVisualStyleBackColor = false;
            this.btnDrama.Click += new System.EventHandler(this.genreEventHandler);
            // 
            // btnComedy
            // 
            this.btnComedy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(47)))), ((int)(((byte)(60)))));
            this.btnComedy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnComedy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnComedy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComedy.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComedy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnComedy.Location = new System.Drawing.Point(0, 0);
            this.btnComedy.Name = "btnComedy";
            this.btnComedy.Size = new System.Drawing.Size(307, 38);
            this.btnComedy.TabIndex = 12;
            this.btnComedy.Text = "Comedy";
            this.btnComedy.UseVisualStyleBackColor = false;
            this.btnComedy.Click += new System.EventHandler(this.genreEventHandler);
            // 
            // btnMovieGenres
            // 
            this.btnMovieGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.btnMovieGenres.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnMovieGenres.FlatAppearance.BorderSize = 7;
            this.btnMovieGenres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovieGenres.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieGenres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMovieGenres.Location = new System.Drawing.Point(-2, 227);
            this.btnMovieGenres.Name = "btnMovieGenres";
            this.btnMovieGenres.Size = new System.Drawing.Size(312, 73);
            this.btnMovieGenres.TabIndex = 10;
            this.btnMovieGenres.Text = "Movies";
            this.btnMovieGenres.UseVisualStyleBackColor = false;
            this.btnMovieGenres.Click += new System.EventHandler(this.btnMovieGenres_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(1261, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.sortComboBox);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.lblTop);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(315, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 66);
            this.panel2.TabIndex = 4;
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.Color.Black;
            this.sortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortComboBox.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortComboBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Year",
            "Name"});
            this.sortComboBox.Location = new System.Drawing.Point(1058, 15);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(157, 35);
            this.sortComboBox.TabIndex = 9;
            this.sortComboBox.Text = "Sort By";
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.FlatAppearance.BorderSize = 7;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(12, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 49);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add +";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTop.Location = new System.Drawing.Point(581, 12);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(142, 33);
            this.lblTop.TabIndex = 6;
            this.lblTop.Text = "Mystery";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1625, 971);
            this.Controls.Add(this.moviePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPanel";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.watchListPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editMovieImage)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).EndInit();
            this.moviePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviePic1)).EndInit();
            this.sidePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).EndInit();
            this.moviesSubMenuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox moviePic1;
        private System.Windows.Forms.Panel moviePanel;
        private System.Windows.Forms.Label movieNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label jlabel;
        private System.Windows.Forms.PictureBox movieImage;
        private System.Windows.Forms.TextBox txtMovieDirector;
        private System.Windows.Forms.TextBox txtMovieYear;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label totalMoviesLbl;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImageSelect;
        private System.Windows.Forms.Button btnMovieSelect;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Panel moviesSubMenuPanel;
        private System.Windows.Forms.Button btnHorror;
        private System.Windows.Forms.Button btnScifi;
        private System.Windows.Forms.Button btnThriller;
        private System.Windows.Forms.Button btnDrama;
        private System.Windows.Forms.Button btnComedy;
        private System.Windows.Forms.Button btnMovieGenres;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox comboEditGenre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnEditImage;
        private System.Windows.Forms.TextBox txtEditDirector;
        private System.Windows.Forms.TextBox txtEditYear;
        private System.Windows.Forms.TextBox txtEditMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox editMovieImage;
        private System.Windows.Forms.Button btnCancelAddPanel;
        private System.Windows.Forms.Button btnCancelEditPanel;
        private System.Windows.Forms.ComboBox comboSelectGenre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAllMovies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnWatchList;
        private System.Windows.Forms.Button btnRemove;
        private OvalPictureBox userPicBox;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel watchedSubPanel;
        private System.Windows.Forms.Label watchedLbl;
        private System.Windows.Forms.Panel watchListSubPanel;
        private System.Windows.Forms.Label watchListLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddToWatchList;
        private System.Windows.Forms.TextBox watchListTxt;
        private System.Windows.Forms.Button btnClearWatched;
        private System.Windows.Forms.Button btnSettings;
    }
}

