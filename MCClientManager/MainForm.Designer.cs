
namespace MCClientManager
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.jigsawdownloader = new System.Windows.Forms.Button();
            this.gamesensedownloader = new System.Windows.Forms.Button();
            this.versionsfolder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // jigsawdownloader
            // 
            this.jigsawdownloader.Location = new System.Drawing.Point(71, 265);
            this.jigsawdownloader.Name = "jigsawdownloader";
            this.jigsawdownloader.Size = new System.Drawing.Size(104, 23);
            this.jigsawdownloader.TabIndex = 0;
            this.jigsawdownloader.Text = "Install Jigsaw 1.8x";
            this.jigsawdownloader.UseVisualStyleBackColor = true;
            // 
            // gamesensedownloader
            // 
            this.gamesensedownloader.Location = new System.Drawing.Point(71, 294);
            this.gamesensedownloader.Name = "gamesensedownloader";
            this.gamesensedownloader.Size = new System.Drawing.Size(125, 23);
            this.gamesensedownloader.TabIndex = 1;
            this.gamesensedownloader.Text = "Install gamesense 1.8x";
            this.gamesensedownloader.UseVisualStyleBackColor = true;
            // 
            // versionsfolder
            // 
            this.versionsfolder.Location = new System.Drawing.Point(47, 239);
            this.versionsfolder.Name = "versionsfolder";
            this.versionsfolder.Size = new System.Drawing.Size(200, 20);
            this.versionsfolder.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 450);
            this.Controls.Add(this.versionsfolder);
            this.Controls.Add(this.gamesensedownloader);
            this.Controls.Add(this.jigsawdownloader);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jigsawdownloader;
        private System.Windows.Forms.Button gamesensedownloader;
        private System.Windows.Forms.TextBox versionsfolder;
    }
}

