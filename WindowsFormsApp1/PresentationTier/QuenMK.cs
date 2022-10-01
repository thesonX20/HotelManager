using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.PresentationTier
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
            lblKetqua.Text = "";
        }

        private void QuenMK_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            string email = txbEmailDK.Text;
            if(email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email đăng ký!");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if(modify.Taikhoans(query).Count() != 0)
                {
                    lblKetqua.ForeColor = Color.Blue;
                    lblKetqua.Text = "Mật khẩu:" + modify.Taikhoans(query)[0].MatKhau;
                }
                else
                {
                    lblKetqua.ForeColor = Color.Red;
                    lblKetqua.Text = "Email này chưa được đăng ký!";
                }
            }
        }
    }
}
