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
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lblSaveName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btmSaveScore = new System.Windows.Forms.Button();
            this.btmRanking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore2
            // 
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblScore2, "lblScore2");
            this.lblScore2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.lblScore2.Name = "lblScore2";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblFinalScore, "lblFinalScore");
            this.lblFinalScore.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.lblFinalScore.Name = "lblFinalScore";
            // 
            // lblSaveName
            // 
            this.lblSaveName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblSaveName, "lblSaveName");
            this.lblSaveName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.lblSaveName.Name = "lblSaveName";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
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
            // btmRanking
            // 
            this.btmRanking.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btmRanking, "btmRanking");
            this.btmRanking.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.btmRanking.Name = "btmRanking";
            this.btmRanking.UseVisualStyleBackColor = false;
            this.btmRanking.Click += new System.EventHandler(this.btmRanking_Click);
            // 
            // frmGameOver
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.background;
            this.Controls.Add(this.btmRanking);
            this.Controls.Add(this.btmSaveScore);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSaveName);
            this.Controls.Add(this.lblFinalScore);
            this.Controls.Add(this.lblScore2);
            this.Name = "frmGameOver";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSaveName;
        private System.Windows.Forms.Button btmSaveScore;
        private System.Windows.Forms.Button btmRanking;
        private System.Windows.Forms.Label lblFinalScore;
    }
}