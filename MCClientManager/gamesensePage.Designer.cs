
namespace MCClientManager
{
    partial class gamesensePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gamesensePage));
            this.downloadgamesense = new Guna.UI2.WinForms.Guna2Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.gamesensedownloader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadgamesense
            // 
            this.downloadgamesense.Animated = true;
            this.downloadgamesense.AnimatedGIF = true;
            this.downloadgamesense.AutoRoundedCorners = true;
            this.downloadgamesense.BorderRadius = 24;
            this.downloadgamesense.CheckedState.Parent = this.downloadgamesense;
            this.downloadgamesense.CustomImages.Parent = this.downloadgamesense;
            this.downloadgamesense.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(221)))), ((int)(((byte)(86)))));
            this.downloadgamesense.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.downloadgamesense.ForeColor = System.Drawing.Color.Black;
            this.downloadgamesense.HoverState.Parent = this.downloadgamesense;
            this.downloadgamesense.Location = new System.Drawing.Point(50, 355);
            this.downloadgamesense.Name = "downloadgamesense";
            this.downloadgamesense.PressedColor = System.Drawing.Color.White;
            this.downloadgamesense.ShadowDecoration.Parent = this.downloadgamesense;
            this.downloadgamesense.Size = new System.Drawing.Size(200, 50);
            this.downloadgamesense.TabIndex = 7;
            this.downloadgamesense.Text = "gamesense 1.8x";
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.description.Location = new System.Drawing.Point(35, 106);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(230, 197);
            this.description.TabIndex = 5;
            this.description.Text = "";
            // 
            // gamesensedownloader
            // 
            this.gamesensedownloader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamesensedownloader.BackgroundImage")));
            this.gamesensedownloader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamesensedownloader.FlatAppearance.BorderSize = 0;
            this.gamesensedownloader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gamesensedownloader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.gamesensedownloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesensedownloader.Location = new System.Drawing.Point(25, 28);
            this.gamesensedownloader.Name = "gamesensedownloader";
            this.gamesensedownloader.Size = new System.Drawing.Size(250, 50);
            this.gamesensedownloader.TabIndex = 9;
            this.gamesensedownloader.UseVisualStyleBackColor = true;
            // 
            // gamesensePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.gamesensedownloader);
            this.Controls.Add(this.downloadgamesense);
            this.Controls.Add(this.description);
            this.Name = "gamesensePage";
            this.Size = new System.Drawing.Size(300, 480);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button gamesensedownloader;
        internal Guna.UI2.WinForms.Guna2Button downloadgamesense;
    }
}
