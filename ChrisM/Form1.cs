using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using ChrisM.Classes;
using System.ComponentModel.Design;

namespace ChrisM
{
    public partial class Form1 : Form
    {
        private List<Song> songs = new List<Song>();

        public Form1()
        {
            InitializeComponent();

            UpdateButtonsColor();

            // Default values
            btnSearchFile.BackgroundImage = Helper.ChangeImageColor(btnSearchFile.BackgroundImage, Color.Black, Color.White);
        }

        #region EventsMethods

        private void btnSearchFile_Click(object sender, EventArgs e)
        {
            List<string> songsTitle = new List<string>();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    {
                        songs.Add(new Song(i, openFileDialog.SafeFileNames[i], openFileDialog.FileNames[i]));
                    }
                }

                // First add / search
                if(songs.Count != 0)
                {
                    lblTitleCurrentMusic.Text = songs[0].Title;
                    songs[0].Selected = true;
                }

                UpdateListOfSongs();
                
                UpdateButtonsColor();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(songs.Count != 0)
            {
                Song currentSong = GetCurrentSong();

                SoundPlayer song = new SoundPlayer(currentSong.Path);
                song.Play();

                // Change button image
                btnPlay.BackgroundImage = Helper.ChangeImageColor(Properties.Resources.pause, Color.Black, Color.White);
            }
            else
            {
                return;
            }
            
        }

        #endregion

        private Song GetCurrentSong()
        {
            foreach (Song song in songs)
            {
                if (song.Selected)
                    return song;
            }

            return null;
        }

        private void UpdateListOfSongs()
        {
            if(songs.Count != 0)
            {
                lbxTitleMusics.Items.Clear();

                foreach (Song song in songs)
                {
                    lbxTitleMusics.Items.Add(song.Title);
                }
            }
            else
            {
                return;
            }
        }

        private void UpdateButtonsColor()
        { 
            if(songs.Count == 0)
            {
                // All disabled
                foreach (Button button in pnlMenuButtons.Controls.OfType<Button>())
                {
                    if (button.Name != "btnSearchFile")
                        button.BackgroundImage = Helper.ChangeImageColor(button.BackgroundImage, Color.Black, Color.Gray);
                }
            }
            else if(songs.Count == 1)
            {
                // Play enable (1 song)
                btnPlay.BackgroundImage = Helper.ChangeImageColor(btnNext.BackgroundImage, Color.Black, Color.White);
            }
            else
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    // 
                    if (songs[i].Index != songs.Count)
                    {
                        btnNext.BackgroundImage = Helper.ChangeImageColor(btnNext.BackgroundImage, Color.Black, Color.White);
                        btnGoToLastMusic.BackgroundImage = Helper.ChangeImageColor(btnGoToLastMusic.BackgroundImage, Color.Black, Color.White);
                    }
                }
            }
            
        }

        enum SongState
        {
            Playing,
            Paused
        }
    }
}
