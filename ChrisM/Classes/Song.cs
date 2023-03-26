using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ChrisM.Classes
{
    public class Song
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value.Replace(".wav", ""); }
        }
        public string Path { get; set; }
        public bool Selected { get; set; }

        public Song(string title, string path) 
        {
            Title = title;
            Path = path;
            Selected = false;
        }

        public Song(string title, string path, bool selected)
        {
            Title = title;
            Path = path;
            Selected = selected;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
