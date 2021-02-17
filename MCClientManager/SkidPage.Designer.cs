
namespace MCClientManager
{
    partial class SkidPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkidPage));
            this.downloadskid18 = new Guna.UI2.WinForms.Guna2Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.skidclientpage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadskid18
            // 
            this.downloadskid18.Animated = true;
            this.downloadskid18.AnimatedGIF = true;
            this.downloadskid18.AutoRoundedCorners = true;
            this.downloadskid18.BorderRadius = 24;
            this.downloadskid18.CheckedState.Parent = this.downloadskid18;
            this.downloadskid18.CustomImages.Parent = this.downloadskid18;
            this.downloadskid18.FillColor = System.Drawing.Color.LightGray;
            this.downloadskid18.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.downloadskid18.ForeColor = System.Drawing.Color.Black;
            this.downloadskid18.HoverState.Parent = this.downloadskid18;
            this.downloadskid18.Location = new System.Drawing.Point(50, 355);
            this.downloadskid18.Name = "downloadskid18";
            this.downloadskid18.PressedColor = System.Drawing.Color.White;
            this.downloadskid18.ShadowDecoration.Parent = this.downloadskid18;
            this.downloadskid18.Size = new System.Drawing.Size(200, 50);
            this.downloadskid18.TabIndex = 7;
            this.downloadskid18.Text = "Skid 1.8x";
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
            // skidclientpage
            // 
            this.skidclientpage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skidclientpage.BackgroundImage")));
            this.skidclientpage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skidclientpage.FlatAppearance.BorderSize = 0;
            this.skidclientpage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.skidclientpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.skidclientpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skidclientpage.Location = new System.Drawing.Point(50, 28);
            this.skidclientpage.Name = "skidclientpage";
            this.skidclientpage.Size = new System.Drawing.Size(200, 50);
            this.skidclientpage.TabIndex = 47;
            this.skidclientpage.UseVisualStyleBackColor = true;
            // 
            // SkidPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.skidclientpage);
            this.Controls.Add(this.downloadskid18);
            this.Controls.Add(this.description);
            this.Name = "SkidPage";
            this.Size = new System.Drawing.Size(300, 480);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button downloadskid18;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button skidclientpage;
    }
}
