using System;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace MCClientManager
{
    public partial class Updater : UserControl
    {
        internal string cversion = "0.1";
        internal WebClient updatedownloader = new WebClient();

        public Updater()
        {
            InitializeComponent();
        }

        internal bool UpdateChecker()
        {
            string versionfile = updatedownloader.DownloadString("https://raw.githubusercontent.com/iQuickGaming/MCClientManager/master/version");
            if (versionfile.Contains(cversion))
            {
                return false;
            }
            else
            {
                currentversion.Text = "v" + cversion;
                newversion.Text = "v" + versionfile;
                return true;
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                string desktopfolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string downloadfile = updatedownloader.DownloadString("https://raw.githubusercontent.com/iQuickGaming/MCClientManager/master/downloadlink");
                string updatepath = desktopfolder + "\\MCClientManagerv0.2.exe";
                updatedownloader.DownloadFile(downloadfile, updatepath);
                Process.Start(desktopfolder + "\\MCClientManagerv0.2.exe");
                Application.Exit();
            }).Start();
        }

        private void skipupdate_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
