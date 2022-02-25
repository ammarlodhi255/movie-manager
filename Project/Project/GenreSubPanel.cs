using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project {
    public class GenreSubPanel : Panel {
        MainPanel parentForm;
        Movie currentMovie;

        PictureBox pic1;
        Label mLbl, dLbl, yLbl, gLbl, lblName, lblDirector, lblYear, lblGenre;
        Button btnPlay, btnEdit;

        public int panelCounter { get; set; } = 0;

        public GenreSubPanel(MainPanel parent, Movie movie, int Y) { // initial Y is 10
            parentForm = parent;
            currentMovie = movie;

            this.pic1 = new PictureBox();
            this.pic1.SizeMode = PictureBoxSizeMode.StretchImage;

            btnPlay = new Button();
            btnEdit = new Button();

            lblDirector = new Label();
            lblYear = new Label();
            lblGenre = new Label();
            lblName = new Label();

            mLbl = new Label();
            dLbl = new Label();
            yLbl = new Label();
            gLbl = new Label();

            this.Controls.Add(this.mLbl);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.yLbl);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.dLbl);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.gLbl);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblName);
            this.Location = new System.Drawing.Point(10, Y);
            this.Name = this.currentMovie.Genre + "Panel";
            this.Size = new System.Drawing.Size(1292, 400); // 1292, 226
            this.TabIndex = 32;

            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            // comedyPic1
            // 
            this.pic1.Location = new System.Drawing.Point(16, 6);
            this.pic1.Name = "pic" + panelCounter;
            this.pic1.Size = new System.Drawing.Size(280, 400); // 176, 210
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.ImageLocation = currentMovie.Picture;

            //mLbl
            this.mLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLbl.Location = new System.Drawing.Point(300, 6);
            this.mLbl.Name = "mLbl" + (panelCounter);
            this.mLbl.Size = new System.Drawing.Size(146, 31); // 146, 31
            this.mLbl.TabIndex = 23;
            this.mLbl.Text = "Movie Name:";

            // dLbl
            // 
            this.dLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLbl.Location = new System.Drawing.Point(300, 67);
            this.dLbl.Name = "dLbl" + panelCounter;
            this.dLbl.Size = new System.Drawing.Size(146, 31);
            this.dLbl.TabIndex = 25;
            this.dLbl.Text = "Director:";

            // yLbl
            // 
            this.yLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yLbl.Location = new System.Drawing.Point(300, 125);
            this.yLbl.Name = "yLbl" + panelCounter;
            this.yLbl.Size = new System.Drawing.Size(146, 31);
            this.yLbl.TabIndex = 24;
            this.yLbl.Text = "Year:";

            // gLbl
            // 
            this.gLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gLbl.Location = new System.Drawing.Point(300, 180);
            this.gLbl.Name = "gLbl" + panelCounter;
            this.gLbl.Size = new System.Drawing.Size(104, 31);
            this.gLbl.TabIndex = 26;
            this.gLbl.Text = "Genre:";

            // btnComedyEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.FlatAppearance.BorderSize = 7;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(1032, 113);
            this.btnEdit.Name = "edit" + currentMovie.MovieIndex;
            this.btnEdit.Size = new System.Drawing.Size(147, 49);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(parentForm.btnEdit_Click);
            // 
            // btnComedyPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnPlay.FlatAppearance.BorderSize = 7;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlay.Location = new System.Drawing.Point(1032, 20);
            this.btnPlay.Name = "btn" + currentMovie.MovieIndex;
            this.btnPlay.Size = new System.Drawing.Size(147, 49);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(parentForm.btnPlay_Click);
            // 
            // lblComedyGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(450, 180);
            this.lblGenre.Name = "lblGenre" + panelCounter;
            this.lblGenre.Size = new System.Drawing.Size(458, 31);
            this.lblGenre.TabIndex = 30;
            this.lblGenre.Text = currentMovie.Genre;
            // 
            // lblComedyDir
            // 
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(450, 67);
            this.lblDirector.Name = "lblDirector" + panelCounter;
            this.lblDirector.Size = new System.Drawing.Size(458, 31);
            this.lblDirector.TabIndex = 29;
            this.lblDirector.Text = currentMovie.Director;
            // 
            // lblComedyYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(450, 125);
            this.lblYear.Name = "lblYear" + panelCounter;
            this.lblYear.Size = new System.Drawing.Size(425, 31);
            this.lblYear.TabIndex = 28;
            this.lblYear.Text = currentMovie.Year.ToString();
            // 
            // lblComedyName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(450, 6);
            this.lblName.Name = "lblName"+ panelCounter;
            this.lblName.Size = new System.Drawing.Size(458, 31);
            this.lblName.TabIndex = 27;
            this.lblName.Text = currentMovie.Name;

            panelCounter++;
        }

    }
}
