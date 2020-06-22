using System.ComponentModel;

namespace Arkanoid
{
    partial class frmGameOver
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(frmGameOver));
            this.lbl_gameover = new System.Windows.Forms.Label();
            this.lbl_finalscore = new System.Windows.Forms.Label();
            this.lbl_savename = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.btmSaveScore = new System.Windows.Forms.Button();
            this.lbl_maxscore = new System.Windows.Forms.Label();
            this.btm_gotomenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_gameover
            // 
            this.lbl_gameover.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_gameover, "lbl_gameover");
            this.lbl_gameover.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.lbl_gameover.Name = "lbl_gameover";
            // 
            // lbl_finalscore
            // 
            this.lbl_finalscore.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_finalscore, "lbl_finalscore");
            this.lbl_finalscore.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.lbl_finalscore.Name = "lbl_finalscore";
            // 
            // lbl_savename
            // 
            this.lbl_savename.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_savename, "lbl_savename");
            this.lbl_savename.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.lbl_savename.Name = "lbl_savename";
            // 
            // txt_nickname
            // 
            resources.ApplyResources(this.txt_nickname, "txt_nickname");
            this.txt_nickname.Name = "txt_nickname";
            // 
            // btmSaveScore
            // 
            this.btmSaveScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btmSaveScore, "btmSaveScore");
            this.btmSaveScore.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.btmSaveScore.Name = "btmSaveScore";
            this.btmSaveScore.UseVisualStyleBackColor = false;
            this.btmSaveScore.Click += new System.EventHandler(this.btmSaveScore_Click);
            // 
            // lbl_maxscore
            // 
            this.lbl_maxscore.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_maxscore, "lbl_maxscore");
            this.lbl_maxscore.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.lbl_maxscore.Name = "lbl_maxscore";
            // 
            // btm_gotomenu
            // 
            this.btm_gotomenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btm_gotomenu, "btm_gotomenu");
            this.btm_gotomenu.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.btm_gotomenu.Name = "btm_gotomenu";
            this.btm_gotomenu.UseVisualStyleBackColor = false;
            this.btm_gotomenu.Click += new System.EventHandler(this.btm_gotomenu_Click);
            // 
            // frmGameOver
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.background;
            this.Controls.Add(this.btm_gotomenu);
            this.Controls.Add(this.lbl_maxscore);
            this.Controls.Add(this.btmSaveScore);
            this.Controls.Add(this.txt_nickname);
            this.Controls.Add(this.lbl_savename);
            this.Controls.Add(this.lbl_finalscore);
            this.Controls.Add(this.lbl_gameover);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameOver";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btmSaveScore;
        private System.Windows.Forms.Label lbl_finalscore;
        private System.Windows.Forms.Label lbl_savename;
        private System.Windows.Forms.Label lbl_gameover;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Label lbl_maxscore;
        private System.Windows.Forms.Button btm_gotomenu;
    }
}