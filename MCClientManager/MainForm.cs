using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Drawing;
using System.Threading;
using System.Runtime.InteropServices;

namespace MCClientManager
{
    public partial class MainForm : Form
    {
        public JigSawPage jigsawpageselector = new JigSawPage();
        public AristoisPage aristoispageselector = new AristoisPage();
        public FluxPage fluxpageselector = new FluxPage();
        public gamesensePage gamesensepageselector = new gamesensePage();
        public SigmaPage sigmapageselector = new SigmaPage();
        public SkidPage skidpageselector = new SkidPage();
        public SkillClientPage skillclientpageselector = new SkillClientPage();
        public WolfRamPage wolframpageselector = new WolfRamPage();
        public WurstPage wurstpageselector = new WurstPage();
        public Credits credits = new Credits();
        public Updater updater = new Updater();

        const double MB = 1_048_576D;
        string versionspath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\.minecraft\\versions";
        string jigsaw18url = "https://github.com/iQuickGaming/MCClientManager/raw/master/Jigsaw.zip";
        string jigsaw110url = "";
        string gamesenseurl = "https://github.com/iQuickGaming/MCClientManager/raw/master/Exhibition%20%5Biquickgaming.weebly.com%5D.zip";
        string aristois1165url = "https://github.com/iQuickGaming/MCClientManager/raw/master/1.16.5-Aristois.zip";
        string fluxurl = "https://github.com/iQuickGaming/MCClientManager/raw/master/Flux%20b12%201.8x.zip";
        string sigmaurl = "https://github.com/iQuickGaming/MCClientManager/raw/master/Sigma%201.8x.zip";
        string skidurl = "https://github.com/iQuickGaming/MCClientManager/raw/master/Skid%201.8x.zip";
        string skillclienturl = "https://github.com/iQuickGaming/MCClientManager/raw/master/SkillClient%201.8x.zip";
        string wolfram18url = "https://github.com/iQuickGaming/MCClientManager/raw/master/Wolfram%20MC%201.8.zip";
        string wolfram112url = "https://github.com/iQuickGaming/MCClientManager/raw/master/Wolfram%20MC%201.12.zip";
        string impact18url = "";
        string wursturl = "";
        public WebClient downloader = new WebClient();
        int c = 1;
        bool wait = false;
        long ticks;


        [DllImport("Gdi32.dll")]
        internal static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public MainForm()
        {
            InitializeComponent();
            gamesensepageselector.Parent = skillclientpageselector.Parent = skidpageselector.Parent = wolframpageselector.Parent = wurstpageselector.Parent = sigmapageselector.Parent = aristoispageselector.Parent = jigsawpageselector.Parent =  fluxpageselector.Parent = credits.Parent = this;
            skillclientpageselector.Location = wolframpageselector.Location = wurstpageselector.Location = skidpageselector.Location = gamesensepageselector.Location = fluxpageselector.Location = aristoispageselector.Location = sigmapageselector.Location = jigsawpageselector.Location = credits.Location = new Point(350, 30);
            updater.Location = new Point(0, 30);
            if (updater.UpdateChecker())
            {
                updater.Parent = this;
                updater.BringToFront();
            }
            versionsfolder.Text = versionspath;

            // Handlers for downloads

            aristoispageselector.downloadaristois1165.Click += aristois1165download;
            jigsawpageselector.downloadjigsaw18.Click += jigsaw18download;
            gamesensepageselector.downloadgamesense.Click += gamesensedownload;
            fluxpageselector.downloadflux18.Click += fluxdownload;
            sigmapageselector.downloadsigma18.Click += sigmadownload;
            skidpageselector.downloadskid18.Click += skiddownload;
            skillclientpageselector.downloadskillclient18.Click += skillclientdownload;
            wolframpageselector.downloadwolfram18.Click += wolfram18download;
            wolframpageselector.downloadwolfram112.Click += wolfram112download;


            // Handlers for animation

            aristoispage.MouseEnter += aristoispage_MouseEnter;
            aristoispage.MouseLeave += aristoispage_MouseLeave;
            fluxpage.MouseEnter += fluxpage_MouseEnter;
            fluxpage.MouseLeave += fluxpage_MouseLeave;
            gamesensepage.MouseEnter += gamesensepage_MouseEnter;
            gamesensepage.MouseLeave += gamesensepage_MouseLeave;
            jigsawpage.MouseEnter += jigsawpage_MouseEnter;
            jigsawpage.MouseLeave += jigsawpage_MouseLeave;
            sigmapage.MouseEnter += sigmapage_MouseEnter;
            sigmapage.MouseLeave += sigmapage_MouseLeave;
            skidpage.MouseEnter += skidpage_MouseEnter;
            skidpage.MouseLeave += skidpage_MouseLeave;
            skillclientpage.MouseEnter += skillclient_MouseEnter;
            skillclientpage.MouseLeave += skillclient_MouseLeave;
            wolframpage.MouseEnter += wolframpage_MouseEnter;
            wolframpage.MouseLeave += wolframpage_MouseLeave;
            wurstpage.MouseEnter += wurstpage_MouseEnter;
            wurstpage.MouseLeave += wurstpage_MouseLeave;

            // Handlers for misc

            titlebar.MouseDown += titlebar_MouseDown;
            titlebar.MouseUp += titlebar_MouseUp;
            titlebar.MouseMove += titlebar_MouseMove;
            close.Click += close_Click;
            minimize.Click += minimize_Click;
            pin.Click += pin_Click;
            unpin.Click += unpin_Click;
            foldericon.Click += foldericon_Click;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            downloader.DownloadProgressChanged += (_, e) =>
            {
                downloadbar.Value = e.ProgressPercentage;
                var mbps = e.BytesReceived / MB / ((DateTime.Now.Ticks - ticks) / 10_000_000D);
                if (c == 5)
                {
                    label1.Text = mbps.ToString("0.## MB/s");
                    label2.Text = ((e.TotalBytesToReceive - e.BytesReceived) / MB / mbps).ToString("0 s left.");
                    c = 1;
                }
                else
                    c++;
            };

            downloader.DownloadFileCompleted += (_, e) =>
            {
                if (e.Error != null)
                    MessageBox.Show("Error");

                label1.Text = "0.00 MB/s";

                switch (e.UserState)
                {
                    case 0:
                        try
                        {
                            ZipFile.ExtractToDirectory(versionspath + "\\Jigsaw.zip", versionspath);
                            File.Delete(versionspath + "\\Jigsaw.zip");
                        }
                        catch (IOException)
                        {
                            try
                            {
                                Directory.Delete(versionspath + "\\Jigsaw", true);
                                ZipFile.ExtractToDirectory(versionspath + "\\Jigsaw.zip", versionspath);
                                File.Delete(versionspath + "\\Jigsaw.zip");
                            }
                            catch { }
                        }
                        break;

                    case 1:
                        try
                        {
                            ZipFile.ExtractToDirectory(versionspath + "\\gamesense.zip", versionspath);
                            File.Delete(versionspath + "\\gamesense.zip");
                        }
                        catch (IOException)
                        {
                            try
                            {
                                Directory.Delete(versionspath + "\\Exhibition", true);
                                ZipFile.ExtractToDirectory(versionspath + "\\Exhibition.zip", versionspath);
                                File.Delete(versionspath + "\\Exhibition");
                            }
                            catch { }
                        }
                        break;

                    case 2:
                        try
                        {
                            ZipFile.ExtractToDirectory(versionspath + "\\Aristois1165.zip", versionspath);
                            File.Delete(versionspath + "\\Aristois1165.zip");
                        }
                        catch (IOException)
                        {
                            try
                            {
                                Directory.Delete(versionspath + "\\Aristois1165.zip", true);
                                ZipFile.ExtractToDirectory(versionspath + "\\Aristois1165.zip", versionspath);
                                File.Delete(versionspath + "\\Aristois1165.zip");
                            }
                            catch { }
                        }
                        break;

                    case 3:
                        try
                        {
                            ZipFile.ExtractToDirectory(versionspath + "\\Flux.zip", versionspath);
                            File.Delete(versionspath + "\\Flux.zip");
                        }
                        catch (IOException)
                        {
                            try
                            {
                                Directory.Delete(versionspath + "\\Flux.zip", true);
                                ZipFile.ExtractToDirectory(versionspath + "\\Flux.zip", versionspath);
                                File.Delete(versionspath + "\\Flux.zip");
                            }
                            catch { }
                        }
                        break;

                    case 4:
                        try
                        {
                            ZipFile.ExtractToDirectory(versionspath + "\\Sigma.zip", versionspath);
                            File.Delete(versionspath + "\\Sigma.zip");
                        }
                        catch (IOException)
                        {
                            try
                            {
                                Directory.Delete(versionspath + "\\Sigma.zip", true);
                                ZipFile.ExtractToDirectory(versionspath + "\\Sigma.zip", versionspath);
                                File.Delete(versionspath + "\\Sigma.zip");
                            }
                            catch { }
                        }
                        break;

                    case 5:
                        try
                        {
                            ZipFile.ExtractToDirectory(versionspath + "\\Skid.zip", versionspath);
                            File.Delete(versionspath + "\\Skid.zip");
                        }
                        catch (IOException)
                        {
                            try
                            {
                                Directory.Delete(versionspath + "\\Skid.zip", true);
                                ZipFile.ExtractToDirectory(versionspath + "\\Skid.zip", versionspath);
                                File.Delete(versionspath + "\\Skid.zip");
                            }
                            catch { }
                        }
                        break;

                    case 6:
                        try
                        {
                            ZipFile.ExtractToDirectory(versionspath + "\\SkillClient.zip", versionspath);
                            File.Delete(versionspath + "\\SkillClient.zip");
                        }
                        catch (IOException)
                        {
                            try
                            {
                                Directory.Delete(versionspath + "\\SkillClient.zip", true);
                                ZipFile.ExtractToDirectory(versionspath + "\\SkillClient.zip", versionspath);
                                File.Delete(versionspath + "\\SkillClient.zip");
                            }
                            catch { }
                        }
                        break;

                    case 7:
                        try
                        {
                            ZipFile.ExtractToDirectory(versionspath + "\\WolfRam18.zip", versionspath);
                            File.Delete(versionspath + "\\WolfRam18.zip");
                        }
                        catch (IOException)
                        {
                            try
                            {
                                Directory.Delete(versionspath + "\\WolfRam18.zip", true);
                                ZipFile.ExtractToDirectory(versionspath + "\\WolfRam18.zip", versionspath);
                                File.Delete(versionspath + "\\WolfRam18.zip");
                            }
                            catch { }
                        }
                        break;

                    case 8:
                        try
                        {
                            ZipFile.ExtractToDirectory(versionspath + "\\WolfRam112.zip", versionspath);
                            File.Delete(versionspath + "\\WolfRam112.zip");
                        }
                        catch (IOException)
                        {
                            try
                            {
                                Directory.Delete(versionspath + "\\WolfRam112.zip", true);
                                ZipFile.ExtractToDirectory(versionspath + "\\WolfRam112.zip", versionspath);
                                File.Delete(versionspath + "\\WolfRam112.zip");
                            }
                            catch { }
                        }
                        break;

                    case 9:
                        try
                        {
                            ZipFile.ExtractToDirectory(versionspath + "\\Impact.zip", versionspath);
                            File.Delete(versionspath + "\\Impact.zip");
                        }
                        catch (IOException)
                        {
                            try
                            {
                                Directory.Delete(versionspath + "\\Impact18.zip", true);
                                ZipFile.ExtractToDirectory(versionspath + "\\Impact18.zip", versionspath);
                                File.Delete(versionspath + "\\Impact18.zip");
                            }
                            catch { }
                        }
                        break;
                }
                new Thread(() =>
                {
                    Thread.Sleep(1000);
                    wait = false;
                }).Start();
            };
        }

        #region misc

        private void foldericon_Click(object sender, EventArgs e)
        {
            versionspathdialog.ShowDialog();
            versionsfolder.Text = versionspathdialog.SelectedPath.ToString();
            versionspath = versionspathdialog.SelectedPath.ToString();
        }

        internal void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal void pin_Click(object sender, EventArgs e)
        {
            unpin.BringToFront();
            this.TopMost = true;
        }

        internal void unpin_Click(object sender, EventArgs e)
        {
            pin.BringToFront();
            this.TopMost = true;
        }

        internal void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion misc

        #region downloaders

        internal void impact18download(object sender, EventArgs e)
        {
            if (!wait)
            {
                ticks = DateTime.Now.Ticks;
                wait = true;
                downloader.DownloadFileAsync(new Uri(impact18url), versionspath + "\\Impact18", 8);
            }
        }

        internal void wolfram112download(object sender, EventArgs e)
        {
            if (!wait)
            {
                ticks = DateTime.Now.Ticks;
                wait = true;
                downloader.DownloadFileAsync(new Uri(wolfram112url), versionspath + "\\WolfRam112", 8);
            }
        }

        internal void wolfram18download(object sender, EventArgs e)
        {
            if (!wait)
            {
                ticks = DateTime.Now.Ticks;
                wait = true;
                downloader.DownloadFileAsync(new Uri(wolfram18url), versionspath + "\\WolfRam18", 7);
            }
        }

        internal void skillclientdownload(object sender, EventArgs e)
        {
            if (!wait)
            {
                ticks = DateTime.Now.Ticks;
                wait = true;
                downloader.DownloadFileAsync(new Uri(skillclienturl), versionspath + "\\SkillClient.zip", 6);
            }
        }

        internal void skiddownload(object sender, EventArgs e)
        {
            if (!wait)
            {
                ticks = DateTime.Now.Ticks;
                wait = true;
                downloader.DownloadFileAsync(new Uri(skidurl), versionspath + "\\Skid.zip", 5);
            }
        }

        internal void sigmadownload(object sender, EventArgs e)
        {
            if (!wait)
            {
                ticks = DateTime.Now.Ticks;
                wait = true;
                downloader.DownloadFileAsync(new Uri(sigmaurl), versionspath + "\\Sigma.zip", 4);
            }
        }

        internal void fluxdownload(object sender, EventArgs e)
        {
            if (!wait)
            {
                ticks = DateTime.Now.Ticks;
                wait = true;
                downloader.DownloadFileAsync(new Uri(fluxurl), versionspath + "\\Flux.zip", 3);
            }
        }

        internal void aristois1165download(object sender, EventArgs e)
        {
            if (!wait)
            {
                ticks = DateTime.Now.Ticks;
                wait = true;
                downloader.DownloadFileAsync(new Uri(aristois1165url), versionspath + "\\Aristois1165.zip", 2);
            }
        }

        internal void gamesensedownload(object sender, EventArgs e)
        {
            if (!wait)
            {
                ticks = DateTime.Now.Ticks;
                wait = true;
                downloader.DownloadFileAsync(new Uri(gamesenseurl), versionspath + "\\gamesense.zip", 1);
            }
        }

        internal void jigsaw18download(object sender, EventArgs e)
        {
            if (!wait)
            {
                ticks = DateTime.Now.Ticks;
                wait = true;
                downloader.DownloadFileAsync(new Uri(jigsaw18url), versionspath + "\\Jigsaw.zip", 0);
            }
        }

        #endregion

        #region draggable titlebar

        bool drag = false;
        Point start_point = new Point(0, 0);

        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void titlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void titlebar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        #endregion

        #region clientinfo

        private void jigsawpage_Click(object sender, EventArgs e)
        {
            jigsawpageselector.BringToFront();
        }

        private void gamesensepage_Click(object sender, EventArgs e)
        {
            gamesensepageselector.BringToFront();
        }

        internal void jigsawdownloader_Click(object sender, EventArgs e)
        {
            jigsawpageselector.BringToFront();
        }

        private void gamesensedownloader_Click(object sender, EventArgs e)
        {
            gamesensepageselector.BringToFront();
        }

        private void sigmapage_Click(object sender, EventArgs e)
        {
            sigmapageselector.BringToFront();
        }

        private void skillclientpage_Click(object sender, EventArgs e)
        {
            skillclientpageselector.BringToFront();
        }

        private void wolframpage_Click(object sender, EventArgs e)
        {
            wolframpageselector.BringToFront();
        }

        private void wurstpage_Click(object sender, EventArgs e)
        {
            wurstpageselector.BringToFront();
        }

        private void skidclientpage_Click(object sender, EventArgs e)
        {
            skidpageselector.BringToFront();
        }

        private void fluxpage_Click(object sender, EventArgs e)
        {
            fluxpageselector.BringToFront();
        }

        private void aristoispage_Click(object sender, EventArgs e)
        {
            aristoispageselector.BringToFront();
        }
        #endregion

        #region animation 

        Point oldpos = new Point(0, 0);
        Size oldsize = new Size(0, 0);
        Point posdecrement = new Point(-2, -2);
        Size sizeincrement = new Size(5, 5);

        private void aristoispage_MouseEnter(object sender, EventArgs e)
        {
            oldpos = aristoispage.Location;
            oldsize = aristoispage.Size;
            aristoispage.Location = Point.Add(aristoispage.Location, (Size)posdecrement);
            aristoispage.Size = Size.Add(aristoispage.Size, sizeincrement);
        }
        private void aristoispage_MouseLeave(object sender, EventArgs e)
        {
            aristoispage.Location = oldpos;
            aristoispage.Size = oldsize;
        }
        private void fluxpage_MouseEnter(object sender, EventArgs e)
        {
            oldpos = fluxpage.Location;
            oldsize = fluxpage.Size;
            fluxpage.Location = Point.Add(fluxpage.Location, (Size)posdecrement);
            fluxpage.Size = Size.Add(fluxpage.Size, sizeincrement);
        }
        private void fluxpage_MouseLeave(object sender, EventArgs e)
        {
            fluxpage.Location = oldpos;
            fluxpage.Size = oldsize;
        }
        private void gamesensepage_MouseEnter(object sender, EventArgs e)
        {
            oldpos = gamesensepage.Location;
            oldsize = gamesensepage.Size;
            gamesensepage.Location = Point.Add(gamesensepage.Location, (Size)posdecrement);
            gamesensepage.Size = Size.Add(gamesensepage.Size, sizeincrement);
        }
        private void gamesensepage_MouseLeave(object sender, EventArgs e)
        {
            gamesensepage.Location = oldpos;
            gamesensepage.Size = oldsize;
        }
        private void jigsawpage_MouseEnter(object sender, EventArgs e)
        {
            oldpos = jigsawpage.Location;
            oldsize = jigsawpage.Size;
            jigsawpage.Location = Point.Add(jigsawpage.Location, (Size)posdecrement);
            jigsawpage.Size = Size.Add(jigsawpage.Size, sizeincrement);
        }
        private void jigsawpage_MouseLeave(object sender, EventArgs e)
        {
            jigsawpage.Location = oldpos;
            jigsawpage.Size = oldsize;
        }
        private void sigmapage_MouseEnter(object sender, EventArgs e)
        {
            oldpos = sigmapage.Location;
            oldsize = sigmapage.Size;
            sigmapage.Location = Point.Add(sigmapage.Location, (Size)posdecrement);
            sigmapage.Size = Size.Add(sigmapage.Size, sizeincrement);
        }
        private void sigmapage_MouseLeave(object sender, EventArgs e)
        {
            sigmapage.Location = oldpos;
            sigmapage.Size = oldsize;
        }
        private void skidpage_MouseEnter(object sender, EventArgs e)
        {
            oldpos = skidpage.Location;
            oldsize = skidpage.Size;
            skidpage.Location = Point.Add(skidpage.Location, (Size)posdecrement);
            skidpage.Size = Size.Add(skidpage.Size, sizeincrement);
        }
        private void skidpage_MouseLeave(object sender, EventArgs e)
        {
            skidpage.Location = oldpos;
            skidpage.Size = oldsize;
        }
        private void skillclient_MouseEnter(object sender, EventArgs e)
        {
            oldpos = skillclientpage.Location;
            oldsize = skillclientpage.Size;
            skillclientpage.Location = Point.Add(skillclientpage.Location, (Size)posdecrement);
            skillclientpage.Size = Size.Add(skillclientpage.Size, sizeincrement);
        }
        private void skillclient_MouseLeave(object sender, EventArgs e)
        {
            skillclientpage.Location = oldpos;
            skillclientpage.Size = oldsize;
        }
        private void wolframpage_MouseEnter(object sender, EventArgs e)
        {
            oldpos = wolframpage.Location;
            oldsize = wolframpage.Size;
            wolframpage.Location = Point.Add(wolframpage.Location, (Size)posdecrement);
            wolframpage.Size = Size.Add(wolframpage.Size, sizeincrement);
        }
        private void wolframpage_MouseLeave(object sender, EventArgs e)
        {
            wolframpage.Location = oldpos;
            wolframpage.Size = oldsize;
        }
        private void wurstpage_MouseEnter(object sender, EventArgs e)
        {
            oldpos = wurstpage.Location;
            oldsize = wurstpage.Size;
            wurstpage.Location = Point.Add(wurstpage.Location, (Size)posdecrement);
            wurstpage.Size = Size.Add(wurstpage.Size, sizeincrement);
        }
        private void wurstpage_MouseLeave(object sender, EventArgs e)
        {
            wurstpage.Location = oldpos;
            wurstpage.Size = oldsize;
        }

        #endregion
    }
}
