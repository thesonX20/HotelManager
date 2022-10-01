namespace WindowsFormsApp1.PresentationTier
{
    partial class Dangky
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
            this.txbMatkhau = new System.Windows.Forms.TextBox();
            this.txbTaikhoan = new System.Windows.Forms.TextBox();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.lblTaikhoan = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtXNMK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMatkhau
            // 
            this.txbMatkhau.Location = new System.Drawing.Point(287, 235);
            this.txbMatkhau.Name = "txbMatkhau";
            this.txbMatkhau.Size = new System.Drawing.Size(220, 22);
            this.txbMatkhau.TabIndex = 6;
            this.txbMatkhau.UseSystemPasswordChar = true;
            // 
            // txbTaikhoan
            // 
            this.txbTaikhoan.Location = new System.Drawing.Point(287, 187);
            this.txbTaikhoan.Name = "txbTaikhoan";
            this.txbTaikhoan.Size = new System.Drawing.Size(220, 22);
            this.txbTaikhoan.TabIndex = 5;
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(72, 232);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(99, 25);
            this.lblMatkhau.TabIndex = 3;
            this.lblMatkhau.Text = "Mật khẩu:";
            // 
            // lblTaikhoan
            // 
            this.lblTaikhoan.AutoSize = true;
            this.lblTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaikhoan.Location = new System.Drawing.Point(72, 187);
            this.lblTaikhoan.Name = "lblTaikhoan";
            this.lblTaikhoan.Size = new System.Drawing.Size(137, 25);
            this.lblTaikhoan.TabIndex = 4;
            this.lblTaikhoan.Text = "Tên tài khoản:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(287, 335);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // txtXNMK
            // 
            this.txtXNMK.Location = new System.Drawing.Point(287, 290);
            this.txtXNMK.Name = "txtXNMK";
            this.txtXNMK.Size = new System.Drawing.Size(220, 22);
            this.txtXNMK.TabIndex = 9;
            this.txtXNMK.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Xác nhận mật khẩu:";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.AutoSize = true;
            this.btnDangnhap.BackColor = System.Drawing.Color.Blue;
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangnhap.Location = new System.Drawing.Point(235, 380);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(118, 47);
            this.btnDangnhap.TabIndex = 11;
            this.btnDangnhap.Text = "Đăng Ký";
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.anh_gif;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtXNMK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMatkhau);
            this.Controls.Add(this.txbTaikhoan);
            this.Controls.Add(this.lblMatkhau);
            this.Controls.Add(this.lblTaikhoan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dangky";
            this.Text = "Dangky";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMatkhau;
        private System.Windows.Forms.TextBox txbTaikhoan;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.Label lblTaikhoan;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtXNMK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}