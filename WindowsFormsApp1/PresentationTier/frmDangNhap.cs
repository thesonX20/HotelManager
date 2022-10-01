using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.PresentationTier;

namespace WindowsFormsApp1
{
    public partial class frmDangNhap : Form
    {

        public frmDangNhap()
        {
            InitializeComponent();
        }


        Modify modify = new Modify();

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tentk = txbTaikhoan.Text;
            string matkhau = txbMatkhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") {MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '"+tentk+"' and MatKhau = '" +matkhau+"'";
                if(modify.Taikhoans(query).Count!=0)
                {
                 //   MessageBox.Show("Đăng nhập thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lklblQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            quenMK.ShowDialog();
        }

        private void lklblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangky dangky = new Dangky();
            dangky.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Bạn muốn tắt hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            this.Close();
        }

        
    }
}
