namespace Target
{
    partial class FRMMain
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
            this.LBLStart = new System.Windows.Forms.Label();
            this.PCBBall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PCBBall)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLStart
            // 
            this.LBLStart.AutoSize = true;
            this.LBLStart.Font = new System.Drawing.Font("Tahoma", 20F);
            this.LBLStart.Location = new System.Drawing.Point(261, 102);
            this.LBLStart.Name = "LBLStart";
            this.LBLStart.Size = new System.Drawing.Size(427, 33);
            this.LBLStart.TabIndex = 0;
            this.LBLStart.Text = "برای شروع بازی روی دایره کلیک کنید";
            // 
            // PCBBall
            // 
            this.PCBBall.BackColor = System.Drawing.Color.Transparent;
            this.PCBBall.Image = global::Target.Properties.Resources.ball;
            this.PCBBall.Location = new System.Drawing.Point(376, 316);
            this.PCBBall.Name = "PCBBall";
            this.PCBBall.Size = new System.Drawing.Size(176, 185);
            this.PCBBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBBall.TabIndex = 1;
            this.PCBBall.TabStop = false;
            this.PCBBall.Click += new System.EventHandler(this.PCBBall_Click);
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 802);
            this.Controls.Add(this.PCBBall);
            this.Controls.Add(this.LBLStart);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "FRMMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بازی زدن به هدف";
            ((System.ComponentModel.ISupportInitialize)(this.PCBBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLStart;
        private System.Windows.Forms.PictureBox PCBBall;
    }
}

