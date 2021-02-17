
namespace MCClientManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.jigsawdownloader = new System.Windows.Forms.Button();
            this.gamesensedownloader = new System.Windows.Forms.Button();
            this.versionsfolder = new System.Windows.Forms.TextBox();
            this.titlebar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pin = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.unpin = new System.Windows.Forms.PictureBox();
            this.versionspathlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.versionspathdialog = new System.Windows.Forms.FolderBrowserDialog();
            this.foldericon = new System.Windows.Forms.PictureBox();
            this.sigmapage = new System.Windows.Forms.Button();
            this.skillclientpage = new System.Windows.Forms.Button();
            this.aristoispage = new System.Windows.Forms.Button();
            this.wolframpage = new System.Windows.Forms.Button();
            this.wurstpage = new System.Windows.Forms.Button();
            this.fluxpage = new System.Windows.Forms.Button();
            this.skidclientpage = new System.Windows.Forms.Button();
            this.downloadbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.infocontainer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foldericon)).BeginInit();
            this.infocontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // jigsawdownloader
            // 
            this.jigsawdownloader.BackColor = System.Drawing.Color.Transparent;
            this.jigsawdownloader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("jigsawdownloader.BackgroundImage")));
            this.jigsawdownloader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jigsawdownloader.FlatAppearance.BorderSize = 0;
            this.jigsawdownloader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.jigsawdownloader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.jigsawdownloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jigsawdownloader.Location = new System.Drawing.Point(20, 49);
            this.jigsawdownloader.Name = "jigsawdownloader";
            this.jigsawdownloader.Size = new System.Drawing.Size(100, 25);
            this.jigsawdownloader.TabIndex = 0;
            this.jigsawdownloader.UseVisualStyleBackColor = false;
            this.jigsawdownloader.Click += new System.EventHandler(this.jigsawdownloader_Click_1);
            // 
            // gamesensedownloader
            // 
            this.gamesensedownloader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamesensedownloader.BackgroundImage")));
            this.gamesensedownloader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamesensedownloader.FlatAppearance.BorderSize = 0;
            this.gamesensedownloader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gamesensedownloader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.gamesensedownloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesensedownloader.Location = new System.Drawing.Point(20, 96);
            this.gamesensedownloader.Name = "gamesensedownloader";
            this.gamesensedownloader.Size = new System.Drawing.Size(100, 25);
            this.gamesensedownloader.TabIndex = 1;
            this.gamesensedownloader.UseVisualStyleBackColor = true;
            this.gamesensedownloader.Click += new System.EventHandler(this.gamesensedownloader_Click_1);
            // 
            // versionsfolder
            // 
            this.versionsfolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.versionsfolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.versionsfolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.versionsfolder.ForeColor = System.Drawing.Color.White;
            this.versionsfolder.Location = new System.Drawing.Point(9, 467);
            this.versionsfolder.Margin = new System.Windows.Forms.Padding(0);
            this.versionsfolder.Name = "versionsfolder";
            this.versionsfolder.ReadOnly = true;
            this.versionsfolder.Size = new System.Drawing.Size(285, 18);
            this.versionsfolder.TabIndex = 2;
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.titlebar.Controls.Add(this.pictureBox2);
            this.titlebar.Controls.Add(this.pictureBox1);
            this.titlebar.Controls.Add(this.pin);
            this.titlebar.Controls.Add(this.close);
            this.titlebar.Controls.Add(this.minimize);
            this.titlebar.Controls.Add(this.unpin);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(650, 30);
            this.titlebar.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pin
            // 
            this.pin.BackColor = System.Drawing.Color.Transparent;
            this.pin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pin.Image = ((System.Drawing.Image)(resources.GetObject("pin.Image")));
            this.pin.Location = new System.Drawing.Point(558, 3);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(25, 25);
            this.pin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pin.TabIndex = 45;
            this.pin.TabStop = false;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(615, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 43;
            this.close.TabStop = false;
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(586, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 44;
            this.minimize.TabStop = false;
            // 
            // unpin
            // 
            this.unpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.unpin.Image = ((System.Drawing.Image)(resources.GetObject("unpin.Image")));
            this.unpin.Location = new System.Drawing.Point(558, 3);
            this.unpin.Name = "unpin";
            this.unpin.Size = new System.Drawing.Size(25, 25);
            this.unpin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unpin.TabIndex = 41;
            this.unpin.TabStop = false;
            // 
            // versionspathlabel
            // 
            this.versionspathlabel.AutoSize = true;
            this.versionspathlabel.ForeColor = System.Drawing.Color.White;
            this.versionspathlabel.Location = new System.Drawing.Point(6, 452);
            this.versionspathlabel.Name = "versionspathlabel";
            this.versionspathlabel.Size = new System.Drawing.Size(74, 13);
            this.versionspathlabel.TabIndex = 4;
            this.versionspathlabel.Text = "Versions path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "0.00 MB/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "0 s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Progress:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time:";
            // 
            // foldericon
            // 
            this.foldericon.Image = ((System.Drawing.Image)(resources.GetObject("foldericon.Image")));
            this.foldericon.Location = new System.Drawing.Point(297, 463);
            this.foldericon.Name = "foldericon";
            this.foldericon.Size = new System.Drawing.Size(25, 25);
            this.foldericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foldericon.TabIndex = 39;
            this.foldericon.TabStop = false;
            // 
            // sigmapage
            // 
            this.sigmapage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sigmapage.BackgroundImage")));
            this.sigmapage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sigmapage.FlatAppearance.BorderSize = 0;
            this.sigmapage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sigmapage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sigmapage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sigmapage.Location = new System.Drawing.Point(166, 49);
            this.sigmapage.Name = "sigmapage";
            this.sigmapage.Size = new System.Drawing.Size(100, 25);
            this.sigmapage.TabIndex = 40;
            this.sigmapage.UseVisualStyleBackColor = true;
            this.sigmapage.Click += new System.EventHandler(this.sigmapage_Click);
            // 
            // skillclientpage
            // 
            this.skillclientpage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skillclientpage.BackgroundImage")));
            this.skillclientpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skillclientpage.FlatAppearance.BorderSize = 0;
            this.skillclientpage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.skillclientpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.skillclientpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skillclientpage.Location = new System.Drawing.Point(20, 204);
            this.skillclientpage.Name = "skillclientpage";
            this.skillclientpage.Size = new System.Drawing.Size(120, 25);
            this.skillclientpage.TabIndex = 41;
            this.skillclientpage.UseVisualStyleBackColor = true;
            this.skillclientpage.Click += new System.EventHandler(this.skillclientpage_Click);
            // 
            // aristoispage
            // 
            this.aristoispage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aristoispage.BackgroundImage")));
            this.aristoispage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aristoispage.FlatAppearance.BorderSize = 0;
            this.aristoispage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.aristoispage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.aristoispage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aristoispage.Location = new System.Drawing.Point(196, 201);
            this.aristoispage.Name = "aristoispage";
            this.aristoispage.Size = new System.Drawing.Size(50, 50);
            this.aristoispage.TabIndex = 42;
            this.aristoispage.UseVisualStyleBackColor = true;
            this.aristoispage.Click += new System.EventHandler(this.aristoispage_Click);
            // 
            // wolframpage
            // 
            this.wolframpage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wolframpage.BackgroundImage")));
            this.wolframpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wolframpage.FlatAppearance.BorderSize = 0;
            this.wolframpage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wolframpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wolframpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wolframpage.Location = new System.Drawing.Point(166, 153);
            this.wolframpage.Name = "wolframpage";
            this.wolframpage.Size = new System.Drawing.Size(110, 25);
            this.wolframpage.TabIndex = 43;
            this.wolframpage.UseVisualStyleBackColor = true;
            this.wolframpage.Click += new System.EventHandler(this.wolframpage_Click);
            // 
            // wurstpage
            // 
            this.wurstpage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wurstpage.BackgroundImage")));
            this.wurstpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wurstpage.FlatAppearance.BorderSize = 0;
            this.wurstpage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.wurstpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.wurstpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wurstpage.Location = new System.Drawing.Point(20, 150);
            this.wurstpage.Name = "wurstpage";
            this.wurstpage.Size = new System.Drawing.Size(110, 30);
            this.wurstpage.TabIndex = 44;
            this.wurstpage.UseVisualStyleBackColor = true;
            this.wurstpage.Click += new System.EventHandler(this.wurstpage_Click);
            // 
            // fluxpage
            // 
            this.fluxpage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fluxpage.BackgroundImage")));
            this.fluxpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fluxpage.FlatAppearance.BorderSize = 0;
            this.fluxpage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fluxpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fluxpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fluxpage.Location = new System.Drawing.Point(20, 252);
            this.fluxpage.Name = "fluxpage";
            this.fluxpage.Size = new System.Drawing.Size(80, 50);
            this.fluxpage.TabIndex = 45;
            this.fluxpage.UseVisualStyleBackColor = true;
            this.fluxpage.Click += new System.EventHandler(this.fluxpage_Click);
            // 
            // skidclientpage
            // 
            this.skidclientpage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skidclientpage.BackgroundImage")));
            this.skidclientpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skidclientpage.FlatAppearance.BorderSize = 0;
            this.skidclientpage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.skidclientpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.skidclientpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skidclientpage.Location = new System.Drawing.Point(166, 96);
            this.skidclientpage.Name = "skidclientpage";
            this.skidclientpage.Size = new System.Drawing.Size(100, 25);
            this.skidclientpage.TabIndex = 46;
            this.skidclientpage.UseVisualStyleBackColor = true;
            this.skidclientpage.Click += new System.EventHandler(this.skidclientpage_Click);
            // 
            // downloadbar
            // 
            this.downloadbar.AutoRoundedCorners = true;
            this.downloadbar.BorderRadius = 5;
            this.downloadbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.downloadbar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.downloadbar.Location = new System.Drawing.Point(5, 88);
            this.downloadbar.Name = "downloadbar";
            this.downloadbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.downloadbar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.downloadbar.ShadowDecoration.Parent = this.downloadbar;
            this.downloadbar.Size = new System.Drawing.Size(175, 12);
            this.downloadbar.TabIndex = 48;
            this.downloadbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // infocontainer
            // 
            this.infocontainer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.infocontainer.BorderRadius = 8;
            this.infocontainer.Controls.Add(this.downloadbar);
            this.infocontainer.Controls.Add(this.label1);
            this.infocontainer.Controls.Add(this.label2);
            this.infocontainer.Controls.Add(this.label5);
            this.infocontainer.Controls.Add(this.label3);
            this.infocontainer.Controls.Add(this.label4);
            this.infocontainer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.infocontainer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.infocontainer.FillColor = System.Drawing.Color.Transparent;
            this.infocontainer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.infocontainer.ForeColor = System.Drawing.Color.White;
            this.infocontainer.Location = new System.Drawing.Point(20, 317);
            this.infocontainer.Name = "infocontainer";
            this.infocontainer.ShadowDecoration.Parent = this.infocontainer;
            this.infocontainer.Size = new System.Drawing.Size(187, 104);
            this.infocontainer.TabIndex = 48;
            this.infocontainer.Text = "Informations";
            this.infocontainer.TextOffset = new System.Drawing.Point(45, -8);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.skidclientpage);
            this.Controls.Add(this.fluxpage);
            this.Controls.Add(this.wurstpage);
            this.Controls.Add(this.wolframpage);
            this.Controls.Add(this.aristoispage);
            this.Controls.Add(this.skillclientpage);
            this.Controls.Add(this.sigmapage);
            this.Controls.Add(this.foldericon);
            this.Controls.Add(this.versionspathlabel);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.versionsfolder);
            this.Controls.Add(this.gamesensedownloader);
            this.Controls.Add(this.jigsawdownloader);
            this.Controls.Add(this.infocontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MCClientManager";
            this.titlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unpin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foldericon)).EndInit();
            this.infocontainer.ResumeLayout(false);
            this.infocontainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jigsawdownloader;
        private System.Windows.Forms.Button gamesensedownloader;
        private System.Windows.Forms.TextBox versionsfolder;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Label versionspathlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pin;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.PictureBox unpin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FolderBrowserDialog versionspathdialog;
        private System.Windows.Forms.PictureBox foldericon;
        private System.Windows.Forms.Button sigmapage;
        private System.Windows.Forms.Button skillclientpage;
        private System.Windows.Forms.Button aristoispage;
        private System.Windows.Forms.Button wolframpage;
        private System.Windows.Forms.Button wurstpage;
        private System.Windows.Forms.Button fluxpage;
        private System.Windows.Forms.Button skidclientpage;
        private Guna.UI2.WinForms.Guna2ProgressBar downloadbar;
        private Guna.UI2.WinForms.Guna2GroupBox infocontainer;
    }
}

