using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace MCClientManager
{
    public partial class Credits : UserControl
    {
        public Credits()
        {
            InitializeComponent();

            youtube.Click += youtube_Click;
            github.Click += github_Click;
            discord.Click += discord_Click;
            steam.Click += steam_Click;
            website.Click += website_Click;
            quicksense.Click += quicksense_Click;
            youtube.MouseEnter += youtube_MouseEnter;
            youtube.MouseLeave += youtube_MouseLeave;
            github.MouseEnter += github_MouseEnter;
            github.MouseLeave += github_MouseLeave;
            discord.MouseEnter += discord_MouseEnter;
            discord.MouseLeave += discord_MouseLeave;
            steam.MouseEnter += steam_MouseEnter;
            steam.MouseLeave += steam_MouseLeave;
            website.MouseEnter += website_MouseEnter;
            website.MouseLeave += website_MouseLeave;
            quicksense.MouseEnter += quicksense_MouseEnter;
            quicksense.MouseLeave += quicksense_MouseLeave;
        }

        internal Size defaultsize = new Size(50, 50);
        internal Size hoversize = new Size(55, 55);
        internal Point youtubelocation = new Point(15, 214);
        internal Point youtubelocationhover = new Point(13, 212);
        internal Point githublocation = new Point(123, 214);
        internal Point githublocationhover = new Point(121, 212);
        internal Point discordlocation = new Point(235, 214);
        internal Point discordlocationhover = new Point(233, 212);
        internal Point steamlocation = new Point(15, 272);
        internal Point steamlocationhover = new Point(13, 270);
        internal Point websitelocation = new Point(123, 272);
        internal Point websitelocationhover = new Point(121, 270);
        internal Point quicksenselocation = new Point(235, 272);
        internal Point quicksenselocationhover = new Point(233, 270);

        private void youtube_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/c/iQuickGaming/featured");
        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/iQuickGaming");
        }

        private void discord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/eNDZrQZ");
        }

        private void steam_Click(object sender, EventArgs e)
        {
            Process.Start("https://steamcommunity.com/id/iQuickGaming/");
        }

        private void website_Click(object sender, EventArgs e)
        {
            Process.Start("https://iquickgaming.weebly.com");
        }

        private void quicksense_Click(object sender, EventArgs e)
        {
            Process.Start("https://quicksense.xyz");
        }

        // YouTube animation

        private void youtube_MouseEnter(object sender, EventArgs e)
        {
            youtube.Location = youtubelocationhover;
            youtube.Size = hoversize;
        }

        private void youtube_MouseLeave(object sender, EventArgs e)
        {
            youtube.Location = youtubelocation;
            youtube.Size = defaultsize;
        }

        // GitHub animation

        private void github_MouseEnter(object sender, EventArgs e)
        {
            github.Location = githublocationhover;
            github.Size = hoversize;
        }
        private void github_MouseLeave(object sender, EventArgs e)
        {
            github.Location = githublocation;
            github.Size = defaultsize;
        }

        // Discord animation

        private void discord_MouseEnter(object sender, EventArgs e)
        {
            discord.Location = discordlocationhover;
            discord.Size = hoversize;
        }
        private void discord_MouseLeave(object sender, EventArgs e)
        {
            discord.Location = discordlocation;
            discord.Size = defaultsize;
        }

        // Steam animation

        private void steam_MouseEnter(object sender, EventArgs e)
        {
            steam.Location = steamlocationhover;
            steam.Size = hoversize;
        }
        private void steam_MouseLeave(object sender, EventArgs e)
        {
            steam.Location = steamlocation;
            steam.Size = defaultsize;
        }

        // Website animation

        private void website_MouseEnter(object sender, EventArgs e)
        {
            website.Location = websitelocationhover;
            website.Size = hoversize;
        }
        private void website_MouseLeave(object sender, EventArgs e)
        {
            website.Location = websitelocation;
            website.Size = defaultsize;
        }

        // QuickSense animation

        private void quicksense_MouseEnter(object sender, EventArgs e)
        {
            quicksense.Location = quicksenselocationhover;
            quicksense.Size = hoversize;
        }
        private void quicksense_MouseLeave(object sender, EventArgs e)
        {
            quicksense.Location = quicksenselocation;
            quicksense.Size = defaultsize;
        }
    }
}