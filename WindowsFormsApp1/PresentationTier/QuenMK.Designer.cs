namespace WindowsFormsApp1.PresentationTier
{
    partial class QuenMK
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
            this.txbEmailDK = new System.Windows.Forms.TextBox();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.lblEmailDK = new System.Windows.Forms.Label();
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbEmailDK
            // 
            this.txbEmailDK.Location = new System.Drawing.Point(208, 110);
            this.txbEmailDK.Name = "txbEmailDK";
            this.txbEmailDK.Size = new System.Drawing.Size(220, 22);
            this.txbEmailDK.TabIndex = 9;
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.Location = new System.Drawing.Point(44, 162);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(86, 25);
            this.lblKetqua.TabIndex = 7;
            this.lblKetqua.Text = "Kết quả:";
            // 
            // lblEmailDK
            // 
            this.lblEmailDK.AutoSize = true;
            this.lblEmailDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailDK.Location = new System.Drawing.Point(44, 106);
            this.lblEmailDK.Name = "lblEmailDK";
            this.lblEmailDK.Size = new System.Drawing.Size(134, 25);
            this.lblEmailDK.TabIndex = 8;
            this.lblEmailDK.Text = "Email đăng kí:";
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.AutoSize = true;
            this.btnQuenMK.BackColor = System.Drawing.Color.Blue;
            this.btnQuenMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuenMK.Location = new System.Drawing.Point(83, 270);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(169, 47);
            this.btnQuenMK.TabIndex = 12;
            this.btnQuenMK.Text = "Lấy lại mật khẩu";
            this.btnQuenMK.UseVisualStyleBackColor = false;
            this.btnQuenMK.Click += new System.EventHandler(this.btnQuenMK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.anh_gif1;
            this.pictureBox1.Location = new System.Drawing.Point(1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuenMK);
            this.Controls.Add(this.txbEmailDK);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.lblEmailDK);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuenMK";
            this.Text = "QuenMK";
            this.Load += new System.EventHandler(this.QuenMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbEmailDK;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.Label lblEmailDK;
        private System.Windows.Forms.Button btnQuenMK;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}