using System.ComponentModel;

namespace Arkanoid
{
    partial class frmLogin
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btm_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.lbl_name.Location = new System.Drawing.Point(314, 170);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(406, 61);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Ingresa tu nombre:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txt_name.Location = new System.Drawing.Point(367, 294);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(308, 26);
            this.txt_name.TabIndex = 1;
            // 
            // btm_play
            // 
            this.btm_play.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btm_play.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btm_play.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (0)))),
                ((int) (((byte) (0)))));
            this.btm_play.Location = new System.Drawing.Point(447, 406);
            this.btm_play.Name = "btm_play";
            this.btm_play.Size = new System.Drawing.Size(145, 73);
            this.btm_play.TabIndex = 2;
            this.btm_play.Text = "JUGAR";
            this.btm_play.UseVisualStyleBackColor = false;
            this.btm_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(973, 738);
            this.Controls.Add(this.btm_play);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARKANOID";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btm_play;
        private System.Windows.Forms.TextBox txt_name;
    }
}