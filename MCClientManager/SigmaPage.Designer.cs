
namespace MCClientManager
{
    partial class SigmaPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SigmaPage));
            this.downloadsigma18 = new Guna.UI2.WinForms.Guna2Button();
            this.warning = new System.Windows.Forms.PictureBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadsigma18
            // 
            this.downloadsigma18.Animated = true;
            this.downloadsigma18.AnimatedGIF = true;
            this.downloadsigma18.AutoRoundedCorners = true;
            this.downloadsigma18.BorderRadius = 24;
            this.downloadsigma18.CheckedState.Parent = this.downloadsigma18;
            this.downloadsigma18.CustomImages.Parent = this.downloadsigma18;
            this.downloadsigma18.FillColor = System.Drawing.Color.White;
            this.downloadsigma18.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.downloadsigma18.ForeColor = System.Drawing.Color.Black;
            this.downloadsigma18.HoverState.Parent = this.downloadsigma18;
            this.downloadsigma18.Location = new System.Drawing.Point(50, 380);
            this.downloadsigma18.Name = "downloadsigma18";
            this.downloadsigma18.PressedColor = System.Drawing.Color.White;
            this.downloadsigma18.ShadowDecoration.Parent = this.downloadsigma18;
            this.downloadsigma18.Size = new System.Drawing.Size(200, 50);
            this.downloadsigma18.TabIndex = 7;
            this.downloadsigma18.Text = "Sigma 1.8x";
            // 
            // warning
            // 
            this.warning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("warning.BackgroundImage")));
            this.warning.Location = new System.Drawing.Point(25, 324);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(250, 40);
            this.warning.TabIndex = 6;
            this.warning.TabStop = false;
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
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SigmaPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadsigma18);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.description);
            this.Name = "SigmaPage";
            this.Size = new System.Drawing.Size(300, 480);
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox warning;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button button1;
        internal Guna.UI2.WinForms.Guna2Button downloadsigma18;
    }
}
