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

namespace ChrisM
{
    public partial class Form1 : Form
    {
        private List<Song> songs = new List<Song>();

        public Form1()
        {
            InitializeComponent();

            // Default button color
            NoSongsButtonsColor();
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
                        songs.Add(new Song(openFileDialog.SafeFileNames[i], openFileDialog.FileNames[i]));
                    }
                }

                // First add / search
                if(isListOfSongsEmpty())
                {
                    lblTitleCurrentMusic.Text = songs[0].Title;
                    songs[0].Selected = true;
                }

                UpdateListOfSongs();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(isListOfSongsEmpty())
            {
                Song currentSong = GetCurrentSong();

                SoundPlayer song = new SoundPlayer(currentSong.Path);
                song.Play();
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
            if(isListOfSongsEmpty())
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

        private bool isListOfSongsEmpty()
        {
            return songs.Count > 0 ? true : false;
        }

        private void NoSongsButtonsColor()
        {
            foreach (Button button in pnlMenuButtons.Controls.OfType<Button>())
            {
                if (button.Name != "btnSearchFile")
                    button.BackgroundImage = Helper.ChangeImageColor(button.BackgroundImage, Color.Black, Color.Gray);
                else
                    button.BackgroundImage = Helper.ChangeImageColor(button.BackgroundImage, Color.Black, Color.White);
            }
        }

        enum SongState
        {
            Playing,
            Paused
        }

        
    }
}
