
namespace MCClientManager
{
    partial class JigSawPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JigSawPage));
            this.description = new System.Windows.Forms.RichTextBox();
            this.downloadgamesense = new Guna.UI2.WinForms.Guna2Button();
            this.jigsawdownloader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.description.Location = new System.Drawing.Point(35, 96);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(230, 197);
            this.description.TabIndex = 1;
            this.description.Text = "";
            // 
            // downloadgamesense
            // 
            this.downloadgamesense.Animated = true;
            this.downloadgamesense.AnimatedGIF = true;
            this.downloadgamesense.AutoRoundedCorners = true;
            this.downloadgamesense.BorderRadius = 24;
            this.downloadgamesense.CheckedState.Parent = this.downloadgamesense;
            this.downloadgamesense.CustomImages.Parent = this.downloadgamesense;
            this.downloadgamesense.FillColor = System.Drawing.Color.White;
            this.downloadgamesense.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.downloadgamesense.ForeColor = System.Drawing.Color.Black;
            this.downloadgamesense.HoverState.Parent = this.downloadgamesense;
            this.downloadgamesense.Location = new System.Drawing.Point(50, 355);
            this.downloadgamesense.Name = "downloadgamesense";
            this.downloadgamesense.PressedColor = System.Drawing.Color.White;
            this.downloadgamesense.ShadowDecoration.Parent = this.downloadgamesense;
            this.downloadgamesense.Size = new System.Drawing.Size(200, 50);
            this.downloadgamesense.TabIndex = 3;
            this.downloadgamesense.Text = "JigSaw 1.8x";
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
            this.jigsawdownloader.Location = new System.Drawing.Point(50, 25);
            this.jigsawdownloader.Name = "jigsawdownloader";
            this.jigsawdownloader.Size = new System.Drawing.Size(200, 50);
            this.jigsawdownloader.TabIndex = 4;
            this.jigsawdownloader.UseVisualStyleBackColor = false;
            // 
            // JigSawPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.jigsawdownloader);
            this.Controls.Add(this.downloadgamesense);
            this.Controls.Add(this.description);
            this.Name = "JigSawPage";
            this.Size = new System.Drawing.Size(300, 480);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox description;
        private Guna.UI2.WinForms.Guna2Button downloadgamesense;
        private System.Windows.Forms.Button jigsawdownloader;
    }
}
