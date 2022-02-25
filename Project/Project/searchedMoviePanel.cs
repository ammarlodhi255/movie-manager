using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    class searchedMoviePanel : Panel {
        Label lblSearchedMovieDuration, label14, lblSearchedMovieDirector, label12,
            lblSearchedMovieYear, label10, lblSearchedMovieName, label3;
        PictureBox searchedMoviePicBox;
        Button btnSearchedMovieEdit, btnSearchedMoviePlay;
        MainPanel parent;
        Movie currentMovie;

        public searchedMoviePanel(MainPanel parent, Movie currentMovie) {
            this.currentMovie = currentMovie;
            this.parent = parent;

            lblSearchedMovieDuration = new Label();
            label14 = new Label();
            lblSearchedMovieDirector = new Label();
            label12 = new Label();
            lblSearchedMovieYear = new Label();
            label10 = new Label();
            lblSearchedMovieName = new Label();
            label3 = new Label();
            searchedMoviePicBox = new PictureBox();
            btnSearchedMovieEdit = new Button();
            btnSearchedMoviePlay = new Button();

            // searchedMoviePicBox
            // 
            this.searchedMoviePicBox.Location = new System.Drawing.Point(59, 70);
            this.searchedMoviePicBox.Name = "searchedMoviePicBox";
            this.searchedMoviePicBox.Size = new System.Drawing.Size(604, 801);
            this.searchedMoviePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchedMoviePicBox.TabIndex = 0;
            this.searchedMoviePicBox.TabStop = false;
            this.searchedMoviePicBox.ImageLocation = currentMovie.Picture;

            // lblSearchedMovieName
            // 
            this.lblSearchedMovieName.AutoSize = true;
            this.lblSearchedMovieName.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedMovieName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchedMovieName.Location = new System.Drawing.Point(904, 187);
            this.lblSearchedMovieName.Name = "lblSearchedMovieName";
            this.lblSearchedMovieName.Size = new System.Drawing.Size(346, 33);
            this.lblSearchedMovieName.TabIndex = 11;
            this.lblSearchedMovieName.Text = "Space Odyssey 1969";
            this.lblSearchedMovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSearchedMovieName.Text = currentMovie.Name;

            // lblSearchedMovieYear
            // 
            this.lblSearchedMovieYear.AutoSize = true;
            this.lblSearchedMovieYear.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedMovieYear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchedMovieYear.Location = new System.Drawing.Point(904, 251);
            this.lblSearchedMovieYear.Name = "lblSearchedMovieYear";
            this.lblSearchedMovieYear.Size = new System.Drawing.Size(95, 33);
            this.lblSearchedMovieYear.TabIndex = 13;
            this.lblSearchedMovieYear.Text = "1969";
            this.lblSearchedMovieYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSearchedMovieYear.Text = currentMovie.Year.ToString();

            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(709, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 33);
            this.label10.TabIndex = 12;
            this.label10.Text = "Year:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearchedMovieDirector
            // 
            this.lblSearchedMovieDirector.AutoSize = true;
            this.lblSearchedMovieDirector.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedMovieDirector.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchedMovieDirector.Location = new System.Drawing.Point(904, 315);
            this.lblSearchedMovieDirector.Name = "lblSearchedMovieDirector";
            this.lblSearchedMovieDirector.Size = new System.Drawing.Size(346, 33);
            this.lblSearchedMovieDirector.TabIndex = 15;
            this.lblSearchedMovieDirector.Text = "Space Odyssey 1969";
            this.lblSearchedMovieDirector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSearchedMovieDirector.Text = currentMovie.Director;

            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(729, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 33);
            this.label12.TabIndex = 14;
            this.label12.Text = "Director:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSearchedMovieDuration
            // 
            this.lblSearchedMovieDuration.AutoSize = true;
            this.lblSearchedMovieDuration.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchedMovieDuration.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearchedMovieDuration.Location = new System.Drawing.Point(904, 378);
            this.lblSearchedMovieDuration.Name = "lblSearchedMovieDuration";
            this.lblSearchedMovieDuration.Size = new System.Drawing.Size(130, 33);
            this.lblSearchedMovieDuration.TabIndex = 17;
            this.lblSearchedMovieDuration.Text = "1:00:28";
            this.lblSearchedMovieDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSearchedMovieDuration.Text = parent.getDuration(currentMovie.Path);
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(727, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 33);
            this.label14.TabIndex = 16;
            this.label14.Text = "Duration:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(727, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            // btnSearchedMovieEdit
            // 
            this.btnSearchedMovieEdit.BackColor = System.Drawing.Color.Black;
            this.btnSearchedMovieEdit.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchedMovieEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchedMovieEdit.Location = new System.Drawing.Point(976, 546);
            this.btnSearchedMovieEdit.Name = "edit" + currentMovie.MovieIndex;
            this.btnSearchedMovieEdit.Size = new System.Drawing.Size(143, 42);
            this.btnSearchedMovieEdit.TabIndex = 18;
            this.btnSearchedMovieEdit.Text = "Edit";
            this.btnSearchedMovieEdit.UseVisualStyleBackColor = false;
            this.btnSearchedMovieEdit.Click += new System.EventHandler(parent.btnEdit_Click);
            // 
            // btnSearchedMoviePlay
            // 
            this.btnSearchedMoviePlay.BackColor = System.Drawing.Color.Black;
            this.btnSearchedMoviePlay.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchedMoviePlay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchedMoviePlay.Location = new System.Drawing.Point(787, 546);
            this.btnSearchedMoviePlay.Name = "play" + currentMovie.MovieIndex;
            this.btnSearchedMoviePlay.Size = new System.Drawing.Size(147, 42);
            this.btnSearchedMoviePlay.TabIndex = 19;
            this.btnSearchedMoviePlay.Text = "Play";
            this.btnSearchedMoviePlay.UseVisualStyleBackColor = false;
            this.btnSearchedMoviePlay.Click += new System.EventHandler(parent.btnPlay_Click);


            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnSearchedMovieEdit);
            this.Controls.Add(this.btnSearchedMoviePlay);
            this.Controls.Add(this.lblSearchedMovieDuration);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblSearchedMovieDirector);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblSearchedMovieYear);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblSearchedMovieName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchedMoviePicBox);
            this.Location = new System.Drawing.Point(315, 62);
            this.Name = "movieSearchPanel";
            this.Size = new System.Drawing.Size(1310, 909);
            this.TabIndex = 0;
        }
    }
}
