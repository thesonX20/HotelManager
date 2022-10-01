using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataTier.Models;

namespace WindowsFormsApp1
{
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }

        DBQLKS context = new DBQLKS();

        public PHONG phong { get; set; }
        public KHACHHANG khachhang { set; get; }
        public string mode { set; get; }
        public Khachhang(PHONG p, KHACHHANG k)
        {
            phong = p;
            khachhang = k;
            InitializeComponent();
        }
 
        private void Khachhang_Load(object sender, EventArgs e)
        {
            maphong_lb.Text = $"PHONG {phong.MAPHONG}";
            hientrang_txt.Text = phong.HIENTRANG;
           
            LOAIPHONG lp = context.LOAIPHONGs.Find(phong.MALP);  // tìm tên loại phòng
            loaiphong_txt.Text = lp.TENLP;

            dientich_txt.Text = phong.DIENTICH.ToString();

            //tang_txt.Text = phong.TANG.ToString(); // xóa cột TANG rồi

            datphong_btn.Text = (mode == "D" ? "Đặt Phòng" : "Trả Phòng");

            if(khachhang != null)
            {
                tenkh_txt.Text = khachhang.TENKH;
                sdt_txt.Text = khachhang.SODT;
                cccd_txt.Text = khachhang.CCCD;
                diachi_txt.Text = khachhang.DIACHI;
                email_txt.Text = khachhang.EMAIL;
            }              
        }

        private void datphong_btn_Click(object sender, EventArgs e)
        {
            if(mode == "D")
            {
                if (tenkh_txt.Text != "" && cccd_txt.Text != "" && sdt_txt.Text != "" && diachi_txt.Text != "" && email_txt.Text != "")
                {
                    // Lưu thông tin đã nhập...
                    KHACHHANG kh = new KHACHHANG();
                    kh.MAKH = FindMaxMaKH(); // Tìm ra khách hàng có MAKH lớn nhất -> MAKH mới lớn hơn 1
                    kh.TENKH = tenkh_txt.Text;
                    kh.SODT = sdt_txt.Text;
                    kh.CCCD = cccd_txt.Text;
                    kh.DIACHI = diachi_txt.Text;
                    kh.EMAIL = email_txt.Text;
                    kh.MAPHONG = phong.MAPHONG; // Server -> Sửa Bảng KHACHHANG -> thêm cột MAPHONG -> đặt khóa ngoại -> cập nhật Entity

                    // Thêm Khách hàng
                    context.KHACHHANGs.Add(kh); // insert

                    // Cập nhật phòng đã được đặt

                    PHONG p = context.PHONGs.Find(phong.MAPHONG);
                    p.HIENTRANG = "unavailable"; // update

                    int done = context.SaveChanges();

                    if (done == 2) // Thực hiện thành công trên 2 dòng dữ liệu
                    {
                        MessageBox.Show("Nhân phòng thành công!");
                    }
                    else  // không thành công
                    {
                        MessageBox.Show("Nhân phòng không thành công!");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng điển đầy đủ thông tin!");
                }
            }    
            else
            {
                

                // Cập nhật phòng đã được trả
                PHONG p = context.PHONGs.Find(phong.MAPHONG);
                p.HIENTRANG = "available";

                int done = context.SaveChanges();

                if (done == 1) // Thực hiện thành công 1 dòng dữ liệu
                {
                    MessageBox.Show("Trả phòng thành công!");
                }
                else  // không thành công
                {
                    MessageBox.Show("Trả phòng không thành công!");
                }
            }

            this.Close();
            
        }

        private string FindMaxMaKH()
        {
            string k = (from n in context.KHACHHANGs select n.MAKH).Max(); // Tìm MAKH lớn nhất
            if(k != null) // đã có khách hàng trước đó
            {
                int max = Int32.Parse(k); // ép kiểu về int

                string rs = $"00{max + 1}"; // tăng 1 đơn vị cho MAKH
                return rs;
            }
            else // Chưa có khách hàng nào sẽ là 001.
            {
                return "001";
            } 
                
            
        }
        private void huy_btn_Click(object sender, EventArgs e)
        {
            // thoát
            this.Close();
        }
    }
}
