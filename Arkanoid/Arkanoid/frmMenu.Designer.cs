namespace Arkanoid
{
    partial class Form1
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
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.btmPlay = new System.Windows.Forms.Button();
            this.btmRanking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picTitle.Image = global::Arkanoid.Properties.Resources.title;
            this.picTitle.Location = new System.Drawing.Point(300, 58);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(433, 129);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 0;
            this.picTitle.TabStop = false;
            // 
            // btmPlay
            // 
            this.btmPlay.BackgroundImage = global::Arkanoid.Properties.Resources.btmPlay;
            this.btmPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmPlay.Location = new System.Drawing.Point(465, 310);
            this.btmPlay.Name = "btmPlay";
            this.btmPlay.Size = new System.Drawing.Size(128, 62);
            this.btmPlay.TabIndex = 1;
            this.btmPlay.UseVisualStyleBackColor = true;
            this.btmPlay.Click += new System.EventHandler(this.btmPlay_Click);
            // 
            // btmRanking
            // 
            this.btmRanking.BackgroundImage = global::Arkanoid.Properties.Resources.btmRanking;
            this.btmRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmRanking.Location = new System.Drawing.Point(465, 398);
            this.btmRanking.Name = "btmRanking";
            this.btmRanking.Size = new System.Drawing.Size(128, 62);
            this.btmRanking.TabIndex = 2;
            this.btmRanking.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(983, 749);
            this.Controls.Add(this.btmRanking);
            this.Controls.Add(this.btmPlay);
            this.Controls.Add(this.picTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.picTitle)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Button btmPlay;
        private System.Windows.Forms.Button btmRanking;
    }
}