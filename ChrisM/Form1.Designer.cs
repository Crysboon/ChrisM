namespace ChrisM
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.lblTitleCurrentMusic = new System.Windows.Forms.Label();
            this.pnlTitles = new System.Windows.Forms.Panel();
            this.lblTitlesMusics = new System.Windows.Forms.Label();
            this.lbxTitleMusics = new System.Windows.Forms.ListBox();
            this.pnlMarginLeftTitle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.panelMarginBottom = new System.Windows.Forms.Panel();
            this.pnlRightSide = new System.Windows.Forms.Panel();
            this.pbxMainImage = new System.Windows.Forms.PictureBox();
            this.btnGoToFirstMusic = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnGoToLastMusic = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlMainContent.SuspendLayout();
            this.pnlTitles.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.pbxMainImage);
            this.pnlMainContent.Controls.Add(this.lblTitleCurrentMusic);
            this.pnlMainContent.Controls.Add(this.pnlTitles);
            this.pnlMainContent.Controls.Add(this.pnlMarginLeftTitle);
            this.pnlMainContent.Controls.Add(this.pnlRightSide);
            this.pnlMainContent.Controls.Add(this.panelMarginBottom);
            this.pnlMainContent.Controls.Add(this.panel1);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(984, 461);
            this.pnlMainContent.TabIndex = 5;
            // 
            // lblTitleCurrentMusic
            // 
            this.lblTitleCurrentMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleCurrentMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCurrentMusic.ForeColor = System.Drawing.Color.White;
            this.lblTitleCurrentMusic.Location = new System.Drawing.Point(256, 0);
            this.lblTitleCurrentMusic.Name = "lblTitleCurrentMusic";
            this.lblTitleCurrentMusic.Size = new System.Drawing.Size(485, 96);
            this.lblTitleCurrentMusic.TabIndex = 6;
            this.lblTitleCurrentMusic.Text = "...";
            this.lblTitleCurrentMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitles
            // 
            this.pnlTitles.Controls.Add(this.lblTitlesMusics);
            this.pnlTitles.Controls.Add(this.lbxTitleMusics);
            this.pnlTitles.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitles.Location = new System.Drawing.Point(15, 0);
            this.pnlTitles.Name = "pnlTitles";
            this.pnlTitles.Size = new System.Drawing.Size(241, 340);
            this.pnlTitles.TabIndex = 4;
            // 
            // lblTitlesMusics
            // 
            this.lblTitlesMusics.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitlesMusics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlesMusics.ForeColor = System.Drawing.Color.White;
            this.lblTitlesMusics.Location = new System.Drawing.Point(0, 0);
            this.lblTitlesMusics.Name = "lblTitlesMusics";
            this.lblTitlesMusics.Size = new System.Drawing.Size(241, 53);
            this.lblTitlesMusics.TabIndex = 6;
            this.lblTitlesMusics.Text = "Titles";
            this.lblTitlesMusics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxTitleMusics
            // 
            this.lbxTitleMusics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbxTitleMusics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxTitleMusics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxTitleMusics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTitleMusics.ForeColor = System.Drawing.Color.White;
            this.lbxTitleMusics.FormattingEnabled = true;
            this.lbxTitleMusics.ItemHeight = 20;
            this.lbxTitleMusics.Location = new System.Drawing.Point(0, 60);
            this.lbxTitleMusics.Name = "lbxTitleMusics";
            this.lbxTitleMusics.Size = new System.Drawing.Size(241, 280);
            this.lbxTitleMusics.TabIndex = 5;
            // 
            // pnlMarginLeftTitle
            // 
            this.pnlMarginLeftTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMarginLeftTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlMarginLeftTitle.Name = "pnlMarginLeftTitle";
            this.pnlMarginLeftTitle.Size = new System.Drawing.Size(15, 340);
            this.pnlMarginLeftTitle.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.btnGoToFirstMusic);
            this.panel1.Controls.Add(this.btnPrevious);
            this.panel1.Controls.Add(this.tbVolume);
            this.panel1.Controls.Add(this.btnGoToLastMusic);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnSearchFile);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 3;
            // 
            // tbVolume
            // 
            this.tbVolume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbVolume.Location = new System.Drawing.Point(19, 35);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(200, 45);
            this.tbVolume.TabIndex = 10;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // panelMarginBottom
            // 
            this.panelMarginBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMarginBottom.Location = new System.Drawing.Point(0, 340);
            this.panelMarginBottom.Name = "panelMarginBottom";
            this.panelMarginBottom.Size = new System.Drawing.Size(984, 21);
            this.panelMarginBottom.TabIndex = 8;
            // 
            // pnlRightSide
            // 
            this.pnlRightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightSide.Location = new System.Drawing.Point(741, 0);
            this.pnlRightSide.Name = "pnlRightSide";
            this.pnlRightSide.Size = new System.Drawing.Size(243, 340);
            this.pnlRightSide.TabIndex = 9;
            // 
            // pbxMainImage
            // 
            this.pbxMainImage.BackgroundImage = global::ChrisM.Properties.Resources.kari_shea_YCQFgqOzLmU_unsplash;
            this.pbxMainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxMainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxMainImage.Location = new System.Drawing.Point(256, 96);
            this.pbxMainImage.Name = "pbxMainImage";
            this.pbxMainImage.Size = new System.Drawing.Size(485, 244);
            this.pbxMainImage.TabIndex = 7;
            this.pbxMainImage.TabStop = false;
            // 
            // btnGoToFirstMusic
            // 
            this.btnGoToFirstMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGoToFirstMusic.BackgroundImage = global::ChrisM.Properties.Resources.fast_backward;
            this.btnGoToFirstMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToFirstMusic.FlatAppearance.BorderSize = 0;
            this.btnGoToFirstMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToFirstMusic.Location = new System.Drawing.Point(343, 31);
            this.btnGoToFirstMusic.Name = "btnGoToFirstMusic";
            this.btnGoToFirstMusic.Size = new System.Drawing.Size(37, 33);
            this.btnGoToFirstMusic.TabIndex = 14;
            this.btnGoToFirstMusic.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrevious.BackgroundImage = global::ChrisM.Properties.Resources.next_left;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(406, 31);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(37, 33);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnGoToLastMusic
            // 
            this.btnGoToLastMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGoToLastMusic.BackgroundImage = global::ChrisM.Properties.Resources.fast_forward;
            this.btnGoToLastMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToLastMusic.FlatAppearance.BorderSize = 0;
            this.btnGoToLastMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToLastMusic.Location = new System.Drawing.Point(615, 31);
            this.btnGoToLastMusic.Name = "btnGoToLastMusic";
            this.btnGoToLastMusic.Size = new System.Drawing.Size(37, 33);
            this.btnGoToLastMusic.TabIndex = 12;
            this.btnGoToLastMusic.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnNext.BackgroundImage = global::ChrisM.Properties.Resources.next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(552, 31);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 33);
            this.btnNext.TabIndex = 11;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchFile.BackgroundImage = global::ChrisM.Properties.Resources.folder;
            this.btnSearchFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFile.FlatAppearance.BorderSize = 0;
            this.btnSearchFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFile.Location = new System.Drawing.Point(910, 26);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(45, 43);
            this.btnSearchFile.TabIndex = 9;
            this.btnSearchFile.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPlay.BackgroundImage = global::ChrisM.Properties.Resources.play_button;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(469, 21);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(57, 53);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlMainContent);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMainContent.ResumeLayout(false);
            this.pnlTitles.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlTitles;
        private System.Windows.Forms.Label lblTitlesMusics;
        private System.Windows.Forms.ListBox lbxTitleMusics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.Panel pnlMarginLeftTitle;
        private System.Windows.Forms.Button btnGoToFirstMusic;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnGoToLastMusic;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTitleCurrentMusic;
        private System.Windows.Forms.PictureBox pbxMainImage;
        private System.Windows.Forms.Panel pnlRightSide;
        private System.Windows.Forms.Panel panelMarginBottom;
    }
}

