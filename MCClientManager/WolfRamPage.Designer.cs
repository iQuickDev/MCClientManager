
namespace MCClientManager
{
    partial class WolfRamPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WolfRamPage));
            this.downloadwolfram18 = new Guna.UI2.WinForms.Guna2Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.downloadwolfram112 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // downloadwolfram18
            // 
            this.downloadwolfram18.Animated = true;
            this.downloadwolfram18.AnimatedGIF = true;
            this.downloadwolfram18.AutoRoundedCorners = true;
            this.downloadwolfram18.BorderRadius = 19;
            this.downloadwolfram18.CheckedState.Parent = this.downloadwolfram18;
            this.downloadwolfram18.CustomImages.Parent = this.downloadwolfram18;
            this.downloadwolfram18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.downloadwolfram18.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.downloadwolfram18.ForeColor = System.Drawing.Color.Black;
            this.downloadwolfram18.HoverState.Parent = this.downloadwolfram18;
            this.downloadwolfram18.Location = new System.Drawing.Point(50, 393);
            this.downloadwolfram18.Name = "downloadwolfram18";
            this.downloadwolfram18.PressedColor = System.Drawing.Color.White;
            this.downloadwolfram18.ShadowDecoration.Parent = this.downloadwolfram18;
            this.downloadwolfram18.Size = new System.Drawing.Size(200, 40);
            this.downloadwolfram18.TabIndex = 7;
            this.downloadwolfram18.Text = "Wolfram 1.8x";
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
            this.button1.Location = new System.Drawing.Point(25, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 44;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // downloadwolfram112
            // 
            this.downloadwolfram112.Animated = true;
            this.downloadwolfram112.AnimatedGIF = true;
            this.downloadwolfram112.AutoRoundedCorners = true;
            this.downloadwolfram112.BorderRadius = 19;
            this.downloadwolfram112.CheckedState.Parent = this.downloadwolfram112;
            this.downloadwolfram112.CustomImages.Parent = this.downloadwolfram112;
            this.downloadwolfram112.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.downloadwolfram112.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.downloadwolfram112.ForeColor = System.Drawing.Color.Black;
            this.downloadwolfram112.HoverState.Parent = this.downloadwolfram112;
            this.downloadwolfram112.Location = new System.Drawing.Point(50, 339);
            this.downloadwolfram112.Name = "downloadwolfram112";
            this.downloadwolfram112.PressedColor = System.Drawing.Color.White;
            this.downloadwolfram112.ShadowDecoration.Parent = this.downloadwolfram112;
            this.downloadwolfram112.Size = new System.Drawing.Size(200, 40);
            this.downloadwolfram112.TabIndex = 45;
            this.downloadwolfram112.Text = "Wolfram 1.12x";
            // 
            // WolfRamPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.downloadwolfram112);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadwolfram18);
            this.Controls.Add(this.description);
            this.Name = "WolfRamPage";
            this.Size = new System.Drawing.Size(300, 480);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button button1;
        internal Guna.UI2.WinForms.Guna2Button downloadwolfram18;
        internal Guna.UI2.WinForms.Guna2Button downloadwolfram112;
    }
}
