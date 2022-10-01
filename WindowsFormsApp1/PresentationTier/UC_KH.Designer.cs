namespace WindowsFormsApp1
{
    partial class UC_KH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.Makhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienthoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccdKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtDiachiKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimMakh = new System.Windows.Forms.TextBox();
            this.chkTimkiem = new System.Windows.Forms.CheckBox();
            this.txtEmailkhtk = new System.Windows.Forms.TextBox();
            this.txtSdtkhtk = new System.Windows.Forms.TextBox();
            this.txtCccdkhtk = new System.Windows.Forms.TextBox();
            this.chkTimEmail = new System.Windows.Forms.CheckBox();
            this.chkTimSDT = new System.Windows.Forms.CheckBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.chkTimCCCD = new System.Windows.Forms.CheckBox();
            this.chkTimTen = new System.Windows.Forms.CheckBox();
            this.chkTimMa = new System.Windows.Forms.CheckBox();
            this.txtTenkhtk = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimkiemKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(372, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 74);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 104);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.btnLuuKH);
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnTimkiemKH);
            this.panel4.Controls.Add(this.btnSuaKH);
            this.panel4.Controls.Add(this.btnXoaKH);
            this.panel4.Controls.Add(this.btnThemKH);
            this.panel4.Location = new System.Drawing.Point(0, 407);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(977, 73);
            this.panel4.TabIndex = 4;
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.AllowUserToDeleteRows = false;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makhach,
            this.TenKH,
            this.DienthoaiKH,
            this.cccdKH,
            this.diachiKH,
            this.EmailKH});
            this.dgvKH.Location = new System.Drawing.Point(0, 474);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.Size = new System.Drawing.Size(977, 214);
            this.dgvKH.TabIndex = 5;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // Makhach
            // 
            this.Makhach.HeaderText = "Mã khách";
            this.Makhach.MinimumWidth = 6;
            this.Makhach.Name = "Makhach";
            this.Makhach.ReadOnly = true;
            this.Makhach.Width = 125;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.MinimumWidth = 6;
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            this.TenKH.Width = 150;
            // 
            // DienthoaiKH
            // 
            this.DienthoaiKH.HeaderText = "Điện thoại";
            this.DienthoaiKH.MinimumWidth = 6;
            this.DienthoaiKH.Name = "DienthoaiKH";
            this.DienthoaiKH.ReadOnly = true;
            this.DienthoaiKH.Width = 125;
            // 
            // cccdKH
            // 
            this.cccdKH.HeaderText = "CCCD";
            this.cccdKH.MinimumWidth = 6;
            this.cccdKH.Name = "cccdKH";
            this.cccdKH.ReadOnly = true;
            this.cccdKH.Width = 125;
            // 
            // diachiKH
            // 
            this.diachiKH.HeaderText = "Địa chỉ";
            this.diachiKH.MinimumWidth = 6;
            this.diachiKH.Name = "diachiKH";
            this.diachiKH.ReadOnly = true;
            this.diachiKH.Width = 170;
            // 
            // EmailKH
            // 
            this.EmailKH.HeaderText = "Email";
            this.EmailKH.MinimumWidth = 6;
            this.EmailKH.Name = "EmailKH";
            this.EmailKH.ReadOnly = true;
            this.EmailKH.Width = 125;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(22, 36);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(113, 18);
            this.lblMaKH.TabIndex = 6;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(22, 81);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(117, 18);
            this.lblTenKH.TabIndex = 6;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.Location = new System.Drawing.Point(25, 127);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(56, 18);
            this.lblCCCD.TabIndex = 6;
            this.lblCCCD.Text = "CCCD:";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(430, 36);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(57, 18);
            this.lblDiachi.TabIndex = 6;
            this.lblDiachi.Text = "Địa chỉ:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(430, 81);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(42, 18);
            this.lblSDT.TabIndex = 6;
            this.lblSDT.Text = "SĐT:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(169, 81);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(211, 27);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(169, 36);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(121, 27);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtDiachiKH
            // 
            this.txtDiachiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachiKH.Location = new System.Drawing.Point(507, 33);
            this.txtDiachiKH.Name = "txtDiachiKH";
            this.txtDiachiKH.Size = new System.Drawing.Size(228, 24);
            this.txtDiachiKH.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(507, 77);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(184, 27);
            this.txtSDT.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(507, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(184, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.txtTimMakh);
            this.groupBox1.Controls.Add(this.chkTimkiem);
            this.groupBox1.Controls.Add(this.txtEmailkhtk);
            this.groupBox1.Controls.Add(this.txtSdtkhtk);
            this.groupBox1.Controls.Add(this.txtCccdkhtk);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.chkTimEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.chkTimSDT);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.lblCCCD);
            this.groupBox1.Controls.Add(this.chkTimCCCD);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.txtDiachiKH);
            this.groupBox1.Controls.Add(this.lblDiachi);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.chkTimTen);
            this.groupBox1.Controls.Add(this.chkTimMa);
            this.groupBox1.Controls.Add(this.lblMaKH);
            this.groupBox1.Controls.Add(this.txtTenkhtk);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblTenKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(977, 340);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtTimMakh
            // 
            this.txtTimMakh.Location = new System.Drawing.Point(178, 242);
            this.txtTimMakh.Name = "txtTimMakh";
            this.txtTimMakh.Size = new System.Drawing.Size(175, 27);
            this.txtTimMakh.TabIndex = 14;
            this.txtTimMakh.TextChanged += new System.EventHandler(this.txtTimMakh_TextChanged);
            // 
            // chkTimkiem
            // 
            this.chkTimkiem.AutoSize = true;
            this.chkTimkiem.Location = new System.Drawing.Point(16, 186);
            this.chkTimkiem.Name = "chkTimkiem";
            this.chkTimkiem.Size = new System.Drawing.Size(153, 24);
            this.chkTimkiem.TabIndex = 13;
            this.chkTimkiem.Text = "Tìm kiếm dữ liệu";
            this.chkTimkiem.UseVisualStyleBackColor = true;
            this.chkTimkiem.CheckedChanged += new System.EventHandler(this.chkTimkiem_CheckedChanged);
            // 
            // txtEmailkhtk
            // 
            this.txtEmailkhtk.Location = new System.Drawing.Point(552, 301);
            this.txtEmailkhtk.Name = "txtEmailkhtk";
            this.txtEmailkhtk.Size = new System.Drawing.Size(167, 27);
            this.txtEmailkhtk.TabIndex = 11;
            // 
            // txtSdtkhtk
            // 
            this.txtSdtkhtk.Location = new System.Drawing.Point(552, 262);
            this.txtSdtkhtk.Name = "txtSdtkhtk";
            this.txtSdtkhtk.Size = new System.Drawing.Size(167, 27);
            this.txtSdtkhtk.TabIndex = 10;
            // 
            // txtCccdkhtk
            // 
            this.txtCccdkhtk.Location = new System.Drawing.Point(552, 221);
            this.txtCccdkhtk.Name = "txtCccdkhtk";
            this.txtCccdkhtk.Size = new System.Drawing.Size(167, 27);
            this.txtCccdkhtk.TabIndex = 9;
            // 
            // chkTimEmail
            // 
            this.chkTimEmail.AutoSize = true;
            this.chkTimEmail.Location = new System.Drawing.Point(398, 304);
            this.chkTimEmail.Name = "chkTimEmail";
            this.chkTimEmail.Size = new System.Drawing.Size(148, 24);
            this.chkTimEmail.TabIndex = 12;
            this.chkTimEmail.Text = "Tìm theo Email:";
            this.chkTimEmail.UseVisualStyleBackColor = true;
            // 
            // chkTimSDT
            // 
            this.chkTimSDT.AutoSize = true;
            this.chkTimSDT.Location = new System.Drawing.Point(398, 265);
            this.chkTimSDT.Name = "chkTimSDT";
            this.chkTimSDT.Size = new System.Drawing.Size(139, 24);
            this.chkTimSDT.TabIndex = 12;
            this.chkTimSDT.Text = "Tìm theo SĐT:";
            this.chkTimSDT.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(169, 123);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(184, 27);
            this.txtCCCD.TabIndex = 3;
            // 
            // chkTimCCCD
            // 
            this.chkTimCCCD.AutoSize = true;
            this.chkTimCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimCCCD.Location = new System.Drawing.Point(397, 226);
            this.chkTimCCCD.Name = "chkTimCCCD";
            this.chkTimCCCD.Size = new System.Drawing.Size(140, 22);
            this.chkTimCCCD.TabIndex = 12;
            this.chkTimCCCD.Text = "Tìm theo CCCD:";
            this.chkTimCCCD.UseVisualStyleBackColor = true;
            // 
            // chkTimTen
            // 
            this.chkTimTen.AutoSize = true;
            this.chkTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimTen.Location = new System.Drawing.Point(16, 293);
            this.chkTimTen.Name = "chkTimTen";
            this.chkTimTen.Size = new System.Drawing.Size(141, 22);
            this.chkTimTen.TabIndex = 12;
            this.chkTimTen.Text = "Tìm theo tên KH:";
            this.chkTimTen.UseVisualStyleBackColor = true;
            // 
            // chkTimMa
            // 
            this.chkTimMa.AutoSize = true;
            this.chkTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTimMa.Location = new System.Drawing.Point(16, 247);
            this.chkTimMa.Name = "chkTimMa";
            this.chkTimMa.Size = new System.Drawing.Size(142, 22);
            this.chkTimMa.TabIndex = 12;
            this.chkTimMa.Text = "Tìm theo Mã KH:";
            this.chkTimMa.UseVisualStyleBackColor = true;
            // 
            // txtTenkhtk
            // 
            this.txtTenkhtk.Location = new System.Drawing.Point(178, 290);
            this.txtTenkhtk.Name = "txtTenkhtk";
            this.txtTenkhtk.Size = new System.Drawing.Size(184, 27);
            this.txtTenkhtk.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(430, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.BackColor = System.Drawing.Color.White;
            this.btnLuuKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuKH.Image = global::WindowsFormsApp1.Properties.Resources.diskette;
            this.btnLuuKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLuuKH.Location = new System.Drawing.Point(80, 3);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(92, 69);
            this.btnLuuKH.TabIndex = 0;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLuuKH.UseVisualStyleBackColor = false;
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
            // btnTimkiemKH
            // 
            this.btnTimkiemKH.BackColor = System.Drawing.Color.White;
            this.btnTimkiemKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTimkiemKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemKH.Image = global::WindowsFormsApp1.Properties.Resources.search__1_;
            this.btnTimkiemKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTimkiemKH.Location = new System.Drawing.Point(343, 3);
            this.btnTimkiemKH.Name = "btnTimkiemKH";
            this.btnTimkiemKH.Size = new System.Drawing.Size(92, 69);
            this.btnTimkiemKH.TabIndex = 0;
            this.btnTimkiemKH.Text = "Tìm kiếm";
            this.btnTimkiemKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTimkiemKH.UseVisualStyleBackColor = false;
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.BackColor = System.Drawing.Color.White;
            this.btnSuaKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKH.Image = global::WindowsFormsApp1.Properties.Resources.update;
            this.btnSuaKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaKH.Location = new System.Drawing.Point(169, 3);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(92, 67);
            this.btnSuaKH.TabIndex = 0;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaKH.UseVisualStyleBackColor = false;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.Color.White;
            this.btnXoaKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.Image = global::WindowsFormsApp1.Properties.Resources.delete;
            this.btnXoaKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaKH.Location = new System.Drawing.Point(256, 3);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(92, 69);
            this.btnXoaKH.TabIndex = 0;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.Color.White;
            this.btnThemKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.Image = global::WindowsFormsApp1.Properties.Resources.add__1_;
            this.btnThemKH.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemKH.Location = new System.Drawing.Point(0, 3);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(81, 64);
            this.btnThemKH.TabIndex = 0;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // UC_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 756);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_KH";
            this.Text = "UC_KH";
            this.Load += new System.EventHandler(this.UC_KH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnTimkiemKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtDiachiKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox chkTimkiem;
        private System.Windows.Forms.TextBox txtEmailkhtk;
        private System.Windows.Forms.TextBox txtSdtkhtk;
        private System.Windows.Forms.TextBox txtCccdkhtk;
        private System.Windows.Forms.CheckBox chkTimEmail;
        private System.Windows.Forms.CheckBox chkTimSDT;
        private System.Windows.Forms.CheckBox chkTimCCCD;
        private System.Windows.Forms.CheckBox chkTimTen;
        private System.Windows.Forms.CheckBox chkTimMa;
        private System.Windows.Forms.TextBox txtTenkhtk;
        private System.Windows.Forms.TextBox txtTimMakh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienthoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccdKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailKH;
    }
}