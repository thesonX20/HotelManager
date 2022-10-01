namespace WindowsFormsApp1.PresentationTier
{
    partial class UC_DV
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
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMDV = new System.Windows.Forms.TextBox();
            this.cmbDonViTinh = new System.Windows.Forms.ComboBox();
            this.cmbTenDV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.colMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLuuDV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimkiemDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnThemDV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DỊCH VỤ";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(765, 82);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(158, 22);
            this.txtGia.TabIndex = 20;
            // 
            // txtMDV
            // 
            this.txtMDV.Location = new System.Drawing.Point(209, 82);
            this.txtMDV.Name = "txtMDV";
            this.txtMDV.Size = new System.Drawing.Size(158, 22);
            this.txtMDV.TabIndex = 19;
            // 
            // cmbDonViTinh
            // 
            this.cmbDonViTinh.FormattingEnabled = true;
            this.cmbDonViTinh.Items.AddRange(new object[] {
            "VNĐ",
            "Đô La"});
            this.cmbDonViTinh.Location = new System.Drawing.Point(765, 158);
            this.cmbDonViTinh.Name = "cmbDonViTinh";
            this.cmbDonViTinh.Size = new System.Drawing.Size(158, 24);
            this.cmbDonViTinh.TabIndex = 18;
            // 
            // cmbTenDV
            // 
            this.cmbTenDV.FormattingEnabled = true;
            this.cmbTenDV.Items.AddRange(new object[] {
            "Tắm hơi ",
            "Đồ ăn ",
            "Masage ",
            "Câu cá "});
            this.cmbTenDV.Location = new System.Drawing.Point(209, 158);
            this.cmbTenDV.Name = "cmbTenDV";
            this.cmbTenDV.Size = new System.Drawing.Size(158, 24);
            this.cmbTenDV.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(648, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Giá ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tên Dịch Vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mã Dịch Vụ ";
            // 
            // dgvDV
            // 
            this.dgvDV.AllowUserToAddRows = false;
            this.dgvDV.AllowUserToDeleteRows = false;
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDV,
            this.colTenDV,
            this.colGia,
            this.colDVT});
            this.dgvDV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDV.Location = new System.Drawing.Point(0, 369);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.ReadOnly = true;
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.RowTemplate.Height = 24;
            this.dgvDV.Size = new System.Drawing.Size(1024, 216);
            this.dgvDV.TabIndex = 22;
            this.dgvDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDV_CellClick);
            // 
            // colMaDV
            // 
            this.colMaDV.HeaderText = "Mã dịch vụ ";
            this.colMaDV.MinimumWidth = 6;
            this.colMaDV.Name = "colMaDV";
            this.colMaDV.ReadOnly = true;
            // 
            // colTenDV
            // 
            this.colTenDV.HeaderText = "Tên Dịch vụ ";
            this.colTenDV.MinimumWidth = 6;
            this.colTenDV.Name = "colTenDV";
            this.colTenDV.ReadOnly = true;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colDVT
            // 
            this.colDVT.HeaderText = "ĐVT";
            this.colDVT.MinimumWidth = 6;
            this.colDVT.Name = "colDVT";
            this.colDVT.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.btnLuuDV);
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnTimkiemDV);
            this.panel4.Controls.Add(this.btnSuaDV);
            this.panel4.Controls.Add(this.btnXoaDV);
            this.panel4.Controls.Add(this.btnThemDV);
            this.panel4.Location = new System.Drawing.Point(0, 301);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1024, 73);
            this.panel4.TabIndex = 23;
            // 
            // btnLuuDV
            // 
            this.btnLuuDV.BackColor = System.Drawing.Color.White;
            this.btnLuuDV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDV.Image = global::WindowsFormsApp1.Properties.Resources.diskette;
            this.btnLuuDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuDV.Location = new System.Drawing.Point(80, 3);
            this.btnLuuDV.Name = "btnLuuDV";
            this.btnLuuDV.Size = new System.Drawing.Size(92, 69);
            this.btnLuuDV.TabIndex = 0;
            this.btnLuuDV.Text = "Lưu";
            this.btnLuuDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuDV.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::WindowsFormsApp1.Properties.Resources.logout;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(428, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 69);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimkiemDV
            // 
            this.btnTimkiemDV.BackColor = System.Drawing.Color.White;
            this.btnTimkiemDV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimkiemDV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemDV.Image = global::WindowsFormsApp1.Properties.Resources.search__1_;
            this.btnTimkiemDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimkiemDV.Location = new System.Drawing.Point(343, 3);
            this.btnTimkiemDV.Name = "btnTimkiemDV";
            this.btnTimkiemDV.Size = new System.Drawing.Size(92, 69);
            this.btnTimkiemDV.TabIndex = 0;
            this.btnTimkiemDV.Text = "Tìm kiếm";
            this.btnTimkiemDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimkiemDV.UseVisualStyleBackColor = false;
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.BackColor = System.Drawing.Color.White;
            this.btnSuaDV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDV.Image = global::WindowsFormsApp1.Properties.Resources.update;
            this.btnSuaDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaDV.Location = new System.Drawing.Point(169, 3);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(92, 67);
            this.btnSuaDV.TabIndex = 0;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaDV.UseVisualStyleBackColor = false;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.White;
            this.btnXoaDV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.btnXoaDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaDV.Location = new System.Drawing.Point(256, 3);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(92, 69);
            this.btnXoaDV.TabIndex = 0;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.White;
            this.btnThemDV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.Image = global::WindowsFormsApp1.Properties.Resources.add__1_;
            this.btnThemDV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemDV.Location = new System.Drawing.Point(0, 0);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(81, 73);
            this.btnThemDV.TabIndex = 0;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // UC_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 585);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMDV);
            this.Controls.Add(this.cmbDonViTinh);
            this.Controls.Add(this.cmbTenDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "UC_DV";
            this.Text = "UC_DV";
            this.Load += new System.EventHandler(this.UC_DV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMDV;
        private System.Windows.Forms.ComboBox cmbDonViTinh;
        private System.Windows.Forms.ComboBox cmbTenDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDVT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLuuDV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimkiemDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnThemDV;
    }
}