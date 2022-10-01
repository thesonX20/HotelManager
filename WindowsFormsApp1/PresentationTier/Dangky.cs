using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1.PresentationTier
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }
        public bool CheckedAcount(string ac)
        {
            return Regex.IsMatch(ac,"^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(String em)
        {
            return Regex.IsMatch(em,@"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tentk = txbTaikhoan.Text;
            string matkhau = txbMatkhau.Text;
            string xnmatkhau = txtXNMK.Text;
            string email = txtEmail.Text;
            if(!CheckedAcount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!");
                return;
            }
            if(!CheckedAcount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!");
                return;
            }   
            if(xnmatkhau != matkhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!");
                return ;
            }
            if (!CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email");
                return;
            }
            if(modify.Taikhoans("Select * from TaiKhoan where Email = '" + email + "'").Count !=0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký Email khác!");
                return;
            }
            try
            {
                string query = "Insert into TaiKhoan values ('"+tentk+"','"+matkhau+"','"+email+"')";
                modify.Command(query);
                if(MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }    
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác!");
                
            }
        }
    }
}
