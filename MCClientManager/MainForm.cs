using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace MCClientManager
{
    public partial class MainForm : Form
    {
        string versionspath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\.minecraft\\versions";
        string jigsawurl = "";
        string gamesenseurl = "";
        WebClient downloader = new WebClient();
        public MainForm()
        {
            InitializeComponent();
            jigsawdownloader.Click += jigsawdownloader_Click;
            gamesensedownloader.Click += gamesensedownloader_Click;
            versionsfolder.Text = versionspath;
        }

        internal void jigsawdownloader_Click(object sender, EventArgs e)
        {
            downloader.DownloadFile(jigsawurl, "Jigsaw.zip");
        }

        internal void gamesensedownloader_Click(object sender, EventArgs e)
        {
            downloader.DownloadFile(gamesenseurl, "gamesense.zip");
            ZipFile.ExtractToDirectory(versionspath + "\\gamesense.zip", versionspath);
        }
    }
}
