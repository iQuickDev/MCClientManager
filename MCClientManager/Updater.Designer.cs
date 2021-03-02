
namespace MCClientManager
{
    partial class Updater
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.label1 = new System.Windows.Forms.Label();
            this.updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.currentversionlabel = new System.Windows.Forms.Label();
            this.newversionlabel = new System.Windows.Forms.Label();
            this.skipupdate = new Guna.UI2.WinForms.Guna2Button();
            this.currentversion = new System.Windows.Forms.Label();
            this.newversion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Updater";
            // 
            // updatebtn
            // 
            this.updatebtn.Animated = true;
            this.updatebtn.AnimatedGIF = true;
            this.updatebtn.BorderRadius = 12;
            this.updatebtn.CheckedState.Parent = this.updatebtn;
            this.updatebtn.CustomImages.Parent = this.updatebtn;
            this.updatebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.HoverState.Parent = this.updatebtn;
            this.updatebtn.Location = new System.Drawing.Point(99, 384);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.PressedColor = System.Drawing.Color.White;
            this.updatebtn.ShadowDecoration.Parent = this.updatebtn;
            this.updatebtn.Size = new System.Drawing.Size(220, 60);
            this.updatebtn.TabIndex = 1;
            this.updatebtn.Text = "Update";
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // currentversionlabel
            // 
            this.currentversionlabel.AutoSize = true;
            this.currentversionlabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.currentversionlabel.ForeColor = System.Drawing.Color.White;
            this.currentversionlabel.Location = new System.Drawing.Point(31, 160);
            this.currentversionlabel.Name = "currentversionlabel";
            this.currentversionlabel.Size = new System.Drawing.Size(205, 37);
            this.currentversionlabel.TabIndex = 2;
            this.currentversionlabel.Text = "Current Version:";
            // 
            // newversionlabel
            // 
            this.newversionlabel.AutoSize = true;
            this.newversionlabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.newversionlabel.ForeColor = System.Drawing.Color.White;
            this.newversionlabel.Location = new System.Drawing.Point(31, 202);
            this.newversionlabel.Name = "newversionlabel";
            this.newversionlabel.Size = new System.Drawing.Size(171, 37);
            this.newversionlabel.TabIndex = 3;
            this.newversionlabel.Text = "New Version:";
            // 
            // skipupdate
            // 
            this.skipupdate.Animated = true;
            this.skipupdate.AnimatedGIF = true;
            this.skipupdate.BorderRadius = 12;
            this.skipupdate.CheckedState.Parent = this.skipupdate;
            this.skipupdate.CustomImages.Parent = this.skipupdate;
            this.skipupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.skipupdate.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.skipupdate.ForeColor = System.Drawing.Color.White;
            this.skipupdate.HoverState.Parent = this.skipupdate;
            this.skipupdate.Location = new System.Drawing.Point(345, 384);
            this.skipupdate.Name = "skipupdate";
            this.skipupdate.PressedColor = System.Drawing.Color.White;
            this.skipupdate.ShadowDecoration.Parent = this.skipupdate;
            this.skipupdate.Size = new System.Drawing.Size(220, 60);
            this.skipupdate.TabIndex = 4;
            this.skipupdate.Text = "Postpone Update";
            this.skipupdate.Click += new System.EventHandler(this.skipupdate_Click);
            // 
            // currentversion
            // 
            this.currentversion.AutoSize = true;
            this.currentversion.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.currentversion.ForeColor = System.Drawing.Color.White;
            this.currentversion.Location = new System.Drawing.Point(229, 160);
            this.currentversion.Name = "currentversion";
            this.currentversion.Size = new System.Drawing.Size(136, 37);
            this.currentversion.TabIndex = 5;
            this.currentversion.Text = "Fetching...";
            // 
            // newversion
            // 
            this.newversion.AutoSize = true;
            this.newversion.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.newversion.ForeColor = System.Drawing.Color.White;
            this.newversion.Location = new System.Drawing.Point(194, 202);
            this.newversion.Name = "newversion";
            this.newversion.Size = new System.Drawing.Size(136, 37);
            this.newversion.TabIndex = 6;
            this.newversion.Text = "Fetching...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(428, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(170, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "A new version had been found!";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.newversion);
            this.Controls.Add(this.currentversion);
            this.Controls.Add(this.skipupdate);
            this.Controls.Add(this.newversionlabel);
            this.Controls.Add(this.currentversionlabel);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.label1);
            this.Name = "Updater";
            this.Size = new System.Drawing.Size(650, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button updatebtn;
        private System.Windows.Forms.Label currentversionlabel;
        private System.Windows.Forms.Label newversionlabel;
        private Guna.UI2.WinForms.Guna2Button skipupdate;
        private System.Windows.Forms.Label currentversion;
        private System.Windows.Forms.Label newversion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}
