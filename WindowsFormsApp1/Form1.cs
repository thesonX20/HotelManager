using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.PresentationTier;
using WindowsFormsApp1.DataTier.Models;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public bool isThoat = true;
        private const int W = 100;
        private const int H = 90;
        int ds_column = 5;
        int ds_row = 5;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }



        Button room = new Button();

        private void TaoNut(int x, int y,string maphong, Color color)
        {
            Button btn = new Button();
            btn.Location = new Point(x, y);
            btn.Size = new Size(W, H);
            btn.Text = maphong;
            btn.Name = maphong;
            btn.BackColor = color;
            //  btn.Image = new Bitmap(Picture/pic1.png);

            btn.Click += Button_Focus;
            pnlBan.Controls.Add(btn);
        }

        public void Button_Focus(object sender, EventArgs e)
        {
            room = (Button)sender;
        }

        private void KhoiTaoSoPhong(int dong, int cot)
        {
            DBQLKS context = new DBQLKS();

            int x, y = 26, count = 1;

            List<PHONG> listPhong = context.PHONGs.ToList();

            for(int i = 0; i < dong; i++)
            {
                x = 200;
                for(int j = 0; j < cot; j++)
                {
                    if (listPhong[count].HIENTRANG == "available")
                    {
                        TaoNut(x, y, listPhong[count].MAPHONG.ToString().Trim(), Color.White);
                    }
                    else
                    {
                        TaoNut(x, y, listPhong[count].MAPHONG.ToString().Trim(), Color.OrangeRed);
                    }
                    x += 250;
                    count += 1;

                    if(count>= listPhong.Count())
                    {
                        count = -1;
                        break;
                    }
                        
                }

                if(count == -1)
                {
                    break;
                }
                    
                y += 130;
            }
        }

        private void pnlBan_Load(object sender, PaintEventArgs e)
        {
            
        }



        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.ShowDialog();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isThoat)
                Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát chương trình", "Cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }    
                
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBan.Controls.Clear();
            KhoiTaoSoPhong(ds_row, ds_column);
        }

        private void btnKH_Click(object sender, EventArgs e)
        {   
                UC_KH uC_KH = new UC_KH();
                uC_KH.Show(); 
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            UC_PHONG uC_PHONG = new UC_PHONG();
            uC_PHONG.Show();
        }

        private void btnDichvu_Click(object sender, EventArgs e)
        {
            UC_DV add = new UC_DV();
            add.ShowDialog();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            if (room.Focus() == true)
            {
                DBQLKS context = new DBQLKS();

                PHONG p = context.PHONGs.Find(room.Name); // Tìm phòng theo MAPHONG

                if (p.HIENTRANG == "unavailable") // Phòng đã được nhận
                {
                    MessageBox.Show("Phòng đã được nhận!", "", MessageBoxButtons.OK);
                }
                else  // Phòng trống
                {
                    DialogResult dlg = MessageBox.Show("Bạn chắc chắn muốn nhận phòng?", "", MessageBoxButtons.OKCancel);
                    if (dlg == DialogResult.OK)
                    {
                        // thông tin khách hàng
                        Khachhang kh = new Khachhang(p,null);
                        kh.mode = "D"; // mode = D -> đặt phòng
                        this.Hide();
                        kh.ShowDialog();
                        this.Show();

                        Form1_Load(sender, e); // Load lại các phòng sau khi nhận
                        
                    }
                }

            }
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            if (room.Focus() == true)
            {
                DBQLKS context = new DBQLKS();

                PHONG p = context.PHONGs.Find(room.Name); // Tìm phòng theo MAPHONG

                if (p.HIENTRANG == "available") // Phòng trống
                {
                    MessageBox.Show("Phòng chưa được nhận!", "", MessageBoxButtons.OK);
                }
                else  // trả phòng
                {
                    DialogResult dlg = MessageBox.Show("Bạn chắc chắn muốn trả phòng?", "", MessageBoxButtons.OKCancel);
                    if (dlg == DialogResult.OK)
                    {
                        // thông tin khách hàng
                        KHACHHANG k = (from n in context.KHACHHANGs where n.MAPHONG == p.MAPHONG select n).FirstOrDefault();
                        Khachhang kh = new Khachhang(p, k);
                        kh.mode = "T";  // mode = T -> Trả phòng
                        this.Hide();
                        kh.ShowDialog();
                        this.Show();

                        Form1_Load(sender, e); // Load lại các phòng sau khi trả

                    }
                }

            }
        }
    }
}
