using System.ComponentModel;

namespace Arkanoid
{
    partial class frmRankingMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_rankingarkanoid = new System.Windows.Forms.Label();
            this.btm_gotomenu = new System.Windows.Forms.Button();
            this.dgw_ranking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.dgw_ranking)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_rankingarkanoid
            // 
            this.lbl_rankingarkanoid.BackColor = System.Drawing.Color.Black;
            this.lbl_rankingarkanoid.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lbl_rankingarkanoid.ForeColor = System.Drawing.Color.Red;
            this.lbl_rankingarkanoid.Location = new System.Drawing.Point(293, 65);
            this.lbl_rankingarkanoid.Name = "lbl_rankingarkanoid";
            this.lbl_rankingarkanoid.Size = new System.Drawing.Size(457, 43);
            this.lbl_rankingarkanoid.TabIndex = 3;
            this.lbl_rankingarkanoid.Text = "RANKING ARKANOID";
            this.lbl_rankingarkanoid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btm_gotomenu
            // 
            this.btm_gotomenu.BackColor = System.Drawing.Color.Black;
            this.btm_gotomenu.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btm_gotomenu.ForeColor = System.Drawing.Color.Red;
            this.btm_gotomenu.Location = new System.Drawing.Point(371, 467);
            this.btm_gotomenu.Name = "btm_gotomenu";
            this.btm_gotomenu.Size = new System.Drawing.Size(317, 45);
            this.btm_gotomenu.TabIndex = 24;
            this.btm_gotomenu.Text = "Salir al Menu";
            this.btm_gotomenu.UseVisualStyleBackColor = false;
            this.btm_gotomenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgw_ranking
            // 
            this.dgw_ranking.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgw_ranking.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ranking.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))),
                ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_ranking.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_ranking.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgw_ranking.Location = new System.Drawing.Point(409, 137);
            this.dgw_ranking.Name = "dgw_ranking";
            this.dgw_ranking.RowHeadersVisible = false;
            this.dgw_ranking.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgw_ranking.Size = new System.Drawing.Size(226, 282);
            this.dgw_ranking.TabIndex = 25;
            // 
            // frmRankingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arkanoid.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(973, 738);
            this.Controls.Add(this.dgw_ranking);
            this.Controls.Add(this.btm_gotomenu);
            this.Controls.Add(this.lbl_rankingarkanoid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRankingMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARKANOID";
            ((System.ComponentModel.ISupportInitialize) (this.dgw_ranking)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btm_gotomenu;
        private System.Windows.Forms.Label lbl_rankingarkanoid;
        private System.Windows.Forms.DataGridView dgw_ranking;
    }
}