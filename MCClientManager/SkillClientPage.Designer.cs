
namespace MCClientManager
{
    partial class SkillClientPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillClientPage));
            this.downloadskillclient18 = new Guna.UI2.WinForms.Guna2Button();
            this.description = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadskillclient18
            // 
            this.downloadskillclient18.Animated = true;
            this.downloadskillclient18.AnimatedGIF = true;
            this.downloadskillclient18.AutoRoundedCorners = true;
            this.downloadskillclient18.BorderRadius = 24;
            this.downloadskillclient18.CheckedState.Parent = this.downloadskillclient18;
            this.downloadskillclient18.CustomImages.Parent = this.downloadskillclient18;
            this.downloadskillclient18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.downloadskillclient18.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.downloadskillclient18.ForeColor = System.Drawing.Color.Black;
            this.downloadskillclient18.HoverState.Parent = this.downloadskillclient18;
            this.downloadskillclient18.Location = new System.Drawing.Point(50, 355);
            this.downloadskillclient18.Name = "downloadskillclient18";
            this.downloadskillclient18.PressedColor = System.Drawing.Color.White;
            this.downloadskillclient18.ShadowDecoration.Parent = this.downloadskillclient18;
            this.downloadskillclient18.Size = new System.Drawing.Size(200, 50);
            this.downloadskillclient18.TabIndex = 7;
            this.downloadskillclient18.Text = "SkillClient 1.8x";
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
            this.button1.Location = new System.Drawing.Point(25, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 42;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SkillClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadskillclient18);
            this.Controls.Add(this.description);
            this.Name = "SkillClientPage";
            this.Size = new System.Drawing.Size(300, 480);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button downloadskillclient18;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button button1;
    }
}
