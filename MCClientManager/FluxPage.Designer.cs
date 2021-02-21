
namespace MCClientManager
{
    partial class FluxPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FluxPage));
            this.downloadflux18 = new Guna.UI2.WinForms.Guna2Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadflux18
            // 
            this.downloadflux18.Animated = true;
            this.downloadflux18.AnimatedGIF = true;
            this.downloadflux18.AutoRoundedCorners = true;
            this.downloadflux18.BorderRadius = 24;
            this.downloadflux18.CheckedState.Parent = this.downloadflux18;
            this.downloadflux18.CustomImages.Parent = this.downloadflux18;
            this.downloadflux18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(184)))), ((int)(((byte)(250)))));
            this.downloadflux18.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.downloadflux18.ForeColor = System.Drawing.Color.Black;
            this.downloadflux18.HoverState.Parent = this.downloadflux18;
            this.downloadflux18.Location = new System.Drawing.Point(50, 355);
            this.downloadflux18.Name = "downloadflux18";
            this.downloadflux18.PressedColor = System.Drawing.Color.White;
            this.downloadflux18.ShadowDecoration.Parent = this.downloadflux18;
            this.downloadflux18.Size = new System.Drawing.Size(200, 50);
            this.downloadflux18.TabIndex = 7;
            this.downloadflux18.Text = "Flux b12 1.8x";
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
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(70, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 80);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FluxPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadflux18);
            this.Controls.Add(this.description);
            this.Name = "FluxPage";
            this.Size = new System.Drawing.Size(300, 480);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button button1;
        internal Guna.UI2.WinForms.Guna2Button downloadflux18;
    }
}
