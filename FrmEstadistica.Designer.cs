
namespace Proyecto_Vacuna
{
    partial class FrmEstadistica
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalDosis2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 61);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Dosis";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotalDosis2
            // 
            this.lblTotalDosis2.AutoSize = true;
            this.lblTotalDosis2.BackColor = System.Drawing.Color.White;
            this.lblTotalDosis2.ForeColor = System.Drawing.Color.Black;
            this.lblTotalDosis2.Location = new System.Drawing.Point(23, 44);
            this.lblTotalDosis2.Name = "lblTotalDosis2";
            this.lblTotalDosis2.Size = new System.Drawing.Size(35, 13);
            this.lblTotalDosis2.TabIndex = 6;
            this.lblTotalDosis2.Text = "label1";
            this.lblTotalDosis2.Click += new System.EventHandler(this.lblTotalDosis2_Click);
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalDosis2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmEstadistica";
            this.Text = "FrmEstadistica";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTotalDosis2;
    }
}