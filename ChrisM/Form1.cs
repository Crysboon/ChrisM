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

namespace ChrisM
{
    public partial class Form1 : Form
    {
        private List<string> songFilesPaths = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

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
                    //Get the path of specified file
                    foreach (string path in openFileDialog.FileNames)
                    {
                        songFilesPaths.Add(path);
                    }

                    foreach (string name in openFileDialog.SafeFileNames)
                    {
                        songsTitle.Add(name.Replace(".wav", ""));
                    }
                }

                if(lbxTitleMusics.Items != null)
                    lblTitleCurrentMusic.Text = openFileDialog.SafeFileNames[0].Replace(".wav", "");

                lbxTitleMusics.DataSource = songsTitle;
            }
        }
    }
}
