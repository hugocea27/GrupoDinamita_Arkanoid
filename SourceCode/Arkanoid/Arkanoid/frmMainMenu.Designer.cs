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
            this.pic_title = new System.Windows.Forms.PictureBox();
            this.btm_play = new System.Windows.Forms.Button();
            this.btm_ranking = new System.Windows.Forms.Button();
            this.btm_leave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pic_title)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_title
            // 
            this.pic_title.BackColor = System.Drawing.Color.Transparent;
            this.pic_title.Image = global::Arkanoid.Properties.Resources.title;
            this.pic_title.Location = new System.Drawing.Point(304, 143);
            this.pic_title.Name = "pic_title";
            this.pic_title.Size = new System.Drawing.Size(388, 122);
            this.pic_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_title.TabIndex = 0;
            this.pic_title.TabStop = false;
            // 
            // btm_play
            // 
            this.btm_play.BackColor = System.Drawing.Color.Black;
            this.btm_play.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btm_play.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.btm_play.Location = new System.Drawing.Point(433, 355);
            this.btm_play.Name = "btm_play";
            this.btm_play.Size = new System.Drawing.Size(136, 51);
            this.btm_play.TabIndex = 1;
            this.btm_play.Text = "JUGAR";
            this.btm_play.UseVisualStyleBackColor = false;
            this.btm_play.Click += new System.EventHandler(this.btmPlay_Click);
            // 
            // btm_ranking
            // 
            this.btm_ranking.BackColor = System.Drawing.Color.Black;
            this.btm_ranking.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btm_ranking.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.btm_ranking.Location = new System.Drawing.Point(433, 438);
            this.btm_ranking.Name = "btm_ranking";
            this.btm_ranking.Size = new System.Drawing.Size(136, 51);
            this.btm_ranking.TabIndex = 2;
            this.btm_ranking.Text = "RANKING";
            this.btm_ranking.UseVisualStyleBackColor = false;
            this.btm_ranking.Click += new System.EventHandler(this.button2_Click);
            // 
            // btm_leave
            // 
            this.btm_leave.BackColor = System.Drawing.Color.Black;
            this.btm_leave.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btm_leave.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.btm_leave.Location = new System.Drawing.Point(433, 526);
            this.btm_leave.Name = "btm_leave";
            this.btm_leave.Size = new System.Drawing.Size(136, 51);
            this.btm_leave.TabIndex = 3;
            this.btm_leave.Text = "SALIR";
            this.btm_leave.UseVisualStyleBackColor = false;
            this.btm_leave.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.btm_leave);
            this.Controls.Add(this.btm_ranking);
            this.Controls.Add(this.btm_play);
            this.Controls.Add(this.pic_title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARKANOID";
            ((System.ComponentModel.ISupportInitialize) (this.pic_title)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pic_title;
        private System.Windows.Forms.Button btm_play;
        private System.Windows.Forms.Button btm_leave;
        private System.Windows.Forms.Button btm_ranking;
    }
}