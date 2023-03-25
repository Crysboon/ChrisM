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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoToFirstMusic = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.btnGoToLastMusic = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlTitles = new System.Windows.Forms.Panel();
            this.lblTitlesMusics = new System.Windows.Forms.Label();
            this.lbxTitleMusics = new System.Windows.Forms.ListBox();
            this.pnlMainContent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.pnlTitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.pnlTitles);
            this.pnlMainContent.Controls.Add(this.panel1);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(984, 461);
            this.pnlMainContent.TabIndex = 5;
            // 
            // panel1
            // 
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
            // btnGoToFirstMusic
            // 
            this.btnGoToFirstMusic.BackgroundImage = global::ChrisM.Properties.Resources.rewind_left_outline;
            this.btnGoToFirstMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToFirstMusic.Location = new System.Drawing.Point(313, 21);
            this.btnGoToFirstMusic.Name = "btnGoToFirstMusic";
            this.btnGoToFirstMusic.Size = new System.Drawing.Size(60, 53);
            this.btnGoToFirstMusic.TabIndex = 14;
            this.btnGoToFirstMusic.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackgroundImage = global::ChrisM.Properties.Resources.skip_back_outline;
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrevious.Location = new System.Drawing.Point(390, 21);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(60, 53);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // tbVolume
            // 
            this.tbVolume.Location = new System.Drawing.Point(19, 35);
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(200, 45);
            this.tbVolume.TabIndex = 10;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // btnGoToLastMusic
            // 
            this.btnGoToLastMusic.BackgroundImage = global::ChrisM.Properties.Resources.rewind_right_outline;
            this.btnGoToLastMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToLastMusic.Location = new System.Drawing.Point(621, 21);
            this.btnGoToLastMusic.Name = "btnGoToLastMusic";
            this.btnGoToLastMusic.Size = new System.Drawing.Size(60, 53);
            this.btnGoToLastMusic.TabIndex = 12;
            this.btnGoToLastMusic.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = global::ChrisM.Properties.Resources.skip_forward_outline;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Location = new System.Drawing.Point(544, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 53);
            this.btnNext.TabIndex = 11;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.BackgroundImage = global::ChrisM.Properties.Resources.folder_outline;
            this.btnSearchFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFile.Location = new System.Drawing.Point(915, 26);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(50, 43);
            this.btnSearchFile.TabIndex = 9;
            this.btnSearchFile.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::ChrisM.Properties.Resources.play_circle_outline;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Location = new System.Drawing.Point(467, 21);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 53);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // pnlTitles
            // 
            this.pnlTitles.Controls.Add(this.lblTitlesMusics);
            this.pnlTitles.Controls.Add(this.lbxTitleMusics);
            this.pnlTitles.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitles.Location = new System.Drawing.Point(0, 0);
            this.pnlTitles.Name = "pnlTitles";
            this.pnlTitles.Size = new System.Drawing.Size(241, 361);
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
            this.lblTitlesMusics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxTitleMusics
            // 
            this.lbxTitleMusics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.lbxTitleMusics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxTitleMusics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTitleMusics.ForeColor = System.Drawing.Color.White;
            this.lbxTitleMusics.FormattingEnabled = true;
            this.lbxTitleMusics.ItemHeight = 20;
            this.lbxTitleMusics.Location = new System.Drawing.Point(0, 57);
            this.lbxTitleMusics.Name = "lbxTitleMusics";
            this.lbxTitleMusics.Size = new System.Drawing.Size(241, 304);
            this.lbxTitleMusics.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMainContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.pnlTitles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlTitles;
        private System.Windows.Forms.Label lblTitlesMusics;
        private System.Windows.Forms.ListBox lbxTitleMusics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGoToFirstMusic;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.Button btnGoToLastMusic;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.Button btnPlay;
    }
}

