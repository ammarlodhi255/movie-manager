using System;
using System.Windows.Forms;

namespace Project {
    class movieSubPanel : Panel {
        Movie currentMovie;
        PictureBox movieSubPic;
        Label lblMovieName;
        Button btnMovieSubPlay;
        Button btnMovieSubEdit;
        MainPanel parent;

        public movieSubPanel(MainPanel parent, Movie currentMovie, int X, int Y) {

            this.parent = parent;
            this.currentMovie = currentMovie;
            movieSubPic = new PictureBox();
            btnMovieSubPlay = new Button();
            btnMovieSubEdit = new Button();
            lblMovieName = new Label();

            // movieSubPic
            // 
            this.movieSubPic.Location = new System.Drawing.Point(56, 35);
            this.movieSubPic.Name = "movieSubPic";
            this.movieSubPic.ImageLocation = currentMovie.Picture;
            this.movieSubPic.Size = new System.Drawing.Size(428, 608);
            this.movieSubPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movieSubPic.TabIndex = 0;
            this.movieSubPic.TabStop = false;

            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.btnMovieSubEdit);
            this.Controls.Add(this.btnMovieSubPlay);
            this.Controls.Add(this.movieSubPic);
            this.Location = new System.Drawing.Point(X, Y);
            this.Name = "panel3";
            this.Size = new System.Drawing.Size(540, 834);
            this.TabIndex = 0;

            // lblMovieName
            // 
            this.lblMovieName.Font = new System.Drawing.Font("Orbitron", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMovieName.Location = new System.Drawing.Point(56, 657);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(428, 33);
            this.lblMovieName.TabIndex = 10;
            this.lblMovieName.Text = currentMovie.Name;
            this.lblMovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnMovieSubEdit
            // 
            this.btnMovieSubEdit.BackColor = System.Drawing.Color.Black;
            this.btnMovieSubEdit.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieSubEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMovieSubEdit.Location = new System.Drawing.Point(188, 756);
            this.btnMovieSubEdit.Name = "edit" + currentMovie.MovieIndex;
            this.btnMovieSubEdit.Size = new System.Drawing.Size(156, 48);
            this.btnMovieSubEdit.TabIndex = 19;
            this.btnMovieSubEdit.Text = "Edit";
            this.btnMovieSubEdit.UseVisualStyleBackColor = false;
            this.btnMovieSubEdit.Click += new System.EventHandler(parent.btnEdit_Click);
            // btnMovieSubPlay
            // 
            this.btnMovieSubPlay.BackColor = System.Drawing.Color.Black;
            this.btnMovieSubPlay.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieSubPlay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMovieSubPlay.Location = new System.Drawing.Point(188, 702);
            this.btnMovieSubPlay.Name = "play" + currentMovie.MovieIndex;
            this.btnMovieSubPlay.Size = new System.Drawing.Size(156, 48);
            this.btnMovieSubPlay.TabIndex = 18;
            this.btnMovieSubPlay.Text = "Play";
            this.btnMovieSubPlay.UseVisualStyleBackColor = false;
            this.btnMovieSubPlay.Click += new System.EventHandler(parent.btnPlay_Click);

        }
    }
}
