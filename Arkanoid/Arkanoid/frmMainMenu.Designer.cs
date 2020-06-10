using System.ComponentModel;

namespace Arkanoid
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btmPlay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Arkanoid.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(304, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btmPlay
            // 
            this.btmPlay.BackColor = System.Drawing.Color.Black;
            this.btmPlay.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btmPlay.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.btmPlay.Location = new System.Drawing.Point(433, 355);
            this.btmPlay.Name = "btmPlay";
            this.btmPlay.Size = new System.Drawing.Size(137, 51);
            this.btmPlay.TabIndex = 1;
            this.btmPlay.Text = "JUGAR";
            this.btmPlay.UseVisualStyleBackColor = false;
            this.btmPlay.Click += new System.EventHandler(this.btmPlay_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.button2.Location = new System.Drawing.Point(433, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "RANKING";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(973, 738);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btmPlay);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkanoid";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btmPlay;
    }
}