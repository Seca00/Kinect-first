namespace Kinect_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMidSpineX = new System.Windows.Forms.TextBox();
            this.txtMidSpineY = new System.Windows.Forms.TextBox();
            this.txtMidSpineZ = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mid Spine X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mid Spine Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mid Spine Z";
            // 
            // txtMidSpineX
            // 
            this.txtMidSpineX.Location = new System.Drawing.Point(83, 8);
            this.txtMidSpineX.Name = "txtMidSpineX";
            this.txtMidSpineX.Size = new System.Drawing.Size(100, 20);
            this.txtMidSpineX.TabIndex = 3;
            // 
            // txtMidSpineY
            // 
            this.txtMidSpineY.Location = new System.Drawing.Point(83, 35);
            this.txtMidSpineY.Name = "txtMidSpineY";
            this.txtMidSpineY.Size = new System.Drawing.Size(100, 20);
            this.txtMidSpineY.TabIndex = 4;
            // 
            // txtMidSpineZ
            // 
            this.txtMidSpineZ.Location = new System.Drawing.Point(83, 60);
            this.txtMidSpineZ.Name = "txtMidSpineZ";
            this.txtMidSpineZ.Size = new System.Drawing.Size(100, 20);
            this.txtMidSpineZ.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(206, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 353);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMidSpineZ);
            this.Controls.Add(this.txtMidSpineY);
            this.Controls.Add(this.txtMidSpineX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMidSpineX;
        private System.Windows.Forms.TextBox txtMidSpineY;
        private System.Windows.Forms.TextBox txtMidSpineZ;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

