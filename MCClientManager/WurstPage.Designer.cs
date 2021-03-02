
namespace MCClientManager
{
    partial class WurstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WurstPage));
            this.downloadwurst1165 = new Guna.UI2.WinForms.Guna2Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadwurst1165
            // 
            this.downloadwurst1165.Animated = true;
            this.downloadwurst1165.AnimatedGIF = true;
            this.downloadwurst1165.AutoRoundedCorners = true;
            this.downloadwurst1165.BorderRadius = 24;
            this.downloadwurst1165.CheckedState.Parent = this.downloadwurst1165;
            this.downloadwurst1165.CustomImages.Parent = this.downloadwurst1165;
            this.downloadwurst1165.Enabled = false;
            this.downloadwurst1165.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.downloadwurst1165.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.downloadwurst1165.ForeColor = System.Drawing.Color.Black;
            this.downloadwurst1165.HoverState.Parent = this.downloadwurst1165;
            this.downloadwurst1165.Location = new System.Drawing.Point(50, 380);
            this.downloadwurst1165.Name = "downloadwurst1165";
            this.downloadwurst1165.PressedColor = System.Drawing.Color.White;
            this.downloadwurst1165.ShadowDecoration.Parent = this.downloadwurst1165;
            this.downloadwurst1165.Size = new System.Drawing.Size(200, 50);
            this.downloadwurst1165.TabIndex = 7;
            this.downloadwurst1165.Text = "Wurst 1.16.5";
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(35, 106);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(230, 197);
            this.description.TabIndex = 5;
            this.description.Text = resources.GetString("description.Text");
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(50, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 40);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // WurstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadwurst1165);
            this.Controls.Add(this.description);
            this.Name = "WurstPage";
            this.Size = new System.Drawing.Size(300, 480);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal Guna.UI2.WinForms.Guna2Button downloadwurst1165;
    }
}
