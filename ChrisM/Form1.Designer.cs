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
            this.gbxbuttonsbottom = new System.Windows.Forms.GroupBox();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.lbxTitleMusics = new System.Windows.Forms.ListBox();
            this.lblTitlesMusics = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGoToFirstMusic = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnGoToLastMusic = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.gbxbuttonsbottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxbuttonsbottom
            // 
            this.gbxbuttonsbottom.BackColor = System.Drawing.Color.White;
            this.gbxbuttonsbottom.Controls.Add(this.btnGoToFirstMusic);
            this.gbxbuttonsbottom.Controls.Add(this.btnPrevious);
            this.gbxbuttonsbottom.Controls.Add(this.tbVolume);
            this.gbxbuttonsbottom.Controls.Add(this.btnGoToLastMusic);
            this.gbxbuttonsbottom.Controls.Add(this.btnNext);
            this.gbxbuttonsbottom.Controls.Add(this.btnSearchFile);
            this.gbxbuttonsbottom.Controls.Add(this.btnPlay);
            this.gbxbuttonsbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxbuttonsbottom.Location = new System.Drawing.Point(0, 364);
            this.gbxbuttonsbottom.Name = "gbxbuttonsbottom";
            this.gbxbuttonsbottom.Size = new System.Drawing.Size(984, 97);
            this.gbxbuttonsbottom.TabIndex = 1;
            this.gbxbuttonsbottom.TabStop = false;
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(16, 40);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(200, 45);
            this.tbVolume.TabIndex = 2;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lbxTitleMusics
            // 
            this.lbxTitleMusics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbxTitleMusics.ForeColor = System.Drawing.Color.White;
            this.lbxTitleMusics.FormattingEnabled = true;
            this.lbxTitleMusics.Location = new System.Drawing.Point(15, 64);
            this.lbxTitleMusics.Name = "lbxTitleMusics";
            this.lbxTitleMusics.Size = new System.Drawing.Size(201, 277);
            this.lbxTitleMusics.TabIndex = 3;
            // 
            // lblTitlesMusics
            // 
            this.lblTitlesMusics.AutoSize = true;
            this.lblTitlesMusics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlesMusics.ForeColor = System.Drawing.Color.White;
            this.lblTitlesMusics.Location = new System.Drawing.Point(12, 25);
            this.lblTitlesMusics.Name = "lblTitlesMusics";
            this.lblTitlesMusics.Size = new System.Drawing.Size(54, 24);
            this.lblTitlesMusics.TabIndex = 4;
            this.lblTitlesMusics.Text = "Titles";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(303, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 322);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnGoToFirstMusic
            // 
            this.btnGoToFirstMusic.BackgroundImage = global::ChrisM.Properties.Resources.rewind_left_outline;
            this.btnGoToFirstMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToFirstMusic.Location = new System.Drawing.Point(303, 19);
            this.btnGoToFirstMusic.Name = "btnGoToFirstMusic";
            this.btnGoToFirstMusic.Size = new System.Drawing.Size(71, 66);
            this.btnGoToFirstMusic.TabIndex = 7;
            this.btnGoToFirstMusic.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = global::ChrisM.Properties.Resources.skip_back_outline;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.Location = new System.Drawing.Point(380, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(71, 66);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnGoToLastMusic
            // 
            this.btnGoToLastMusic.BackgroundImage = global::ChrisM.Properties.Resources.rewind_right_outline;
            this.btnGoToLastMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToLastMusic.Location = new System.Drawing.Point(611, 19);
            this.btnGoToLastMusic.Name = "btnGoToLastMusic";
            this.btnGoToLastMusic.Size = new System.Drawing.Size(71, 66);
            this.btnGoToLastMusic.TabIndex = 5;
            this.btnGoToLastMusic.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::ChrisM.Properties.Resources.skip_forward_outline;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Location = new System.Drawing.Point(534, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 66);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.BackgroundImage = global::ChrisM.Properties.Resources.folder_outline;
            this.btnSearchFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFile.Location = new System.Drawing.Point(900, 19);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(71, 66);
            this.btnSearchFile.TabIndex = 1;
            this.btnSearchFile.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::ChrisM.Properties.Resources.play_circle_outline;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(457, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(71, 66);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.lblTitlesMusics);
            this.Controls.Add(this.lbxTitleMusics);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxbuttonsbottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxbuttonsbottom.ResumeLayout(false);
            this.gbxbuttonsbottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox gbxbuttonsbottom;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Button btnGoToLastMusic;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbxTitleMusics;
        private System.Windows.Forms.Label lblTitlesMusics;
        private System.Windows.Forms.Button btnGoToFirstMusic;
        private System.Windows.Forms.Button btnPrevious;
    }
}

