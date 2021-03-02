
namespace MCClientManager
{
    partial class ImpactPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpactPage));
            this.button1 = new System.Windows.Forms.Button();
            this.downloadimpact18 = new Guna.UI2.WinForms.Guna2Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(51, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 49;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // downloadimpact18
            // 
            this.downloadimpact18.Animated = true;
            this.downloadimpact18.AnimatedGIF = true;
            this.downloadimpact18.AutoRoundedCorners = true;
            this.downloadimpact18.BorderRadius = 24;
            this.downloadimpact18.CheckedState.Parent = this.downloadimpact18;
            this.downloadimpact18.CustomImages.Parent = this.downloadimpact18;
            this.downloadimpact18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.downloadimpact18.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.downloadimpact18.ForeColor = System.Drawing.Color.Black;
            this.downloadimpact18.HoverState.Parent = this.downloadimpact18;
            this.downloadimpact18.Location = new System.Drawing.Point(50, 355);
            this.downloadimpact18.Name = "downloadimpact18";
            this.downloadimpact18.PressedColor = System.Drawing.Color.White;
            this.downloadimpact18.ShadowDecoration.Parent = this.downloadimpact18;
            this.downloadimpact18.Size = new System.Drawing.Size(200, 50);
            this.downloadimpact18.TabIndex = 48;
            this.downloadimpact18.Text = "Impact 1.8x";
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.description.Location = new System.Drawing.Point(36, 115);
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(230, 197);
            this.description.TabIndex = 47;
            this.description.Text = "";
            // 
            // ImpactPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadimpact18);
            this.Controls.Add(this.description);
            this.Name = "ImpactPage";
            this.Size = new System.Drawing.Size(300, 480);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        internal Guna.UI2.WinForms.Guna2Button downloadimpact18;
        private System.Windows.Forms.RichTextBox description;
    }
}
