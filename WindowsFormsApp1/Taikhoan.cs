using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Taikhoan
    {
        private string tenTaiKhoan;
        private string matKhau;

        public Taikhoan()
        {

        }
        public string TenTaiKhoan
        {
            get => tenTaiKhoan;
            set => tenTaiKhoan = value;
        }

        
        public string MatKhau 
        { 
            get => matKhau; 
            set => matKhau = value; 
        }

        public Taikhoan(string tentaikhoan, string matkhau)
        {
            this.tenTaiKhoan = tentaikhoan;
            this.matKhau = matkhau;
        }
        

    }


 }
    

   
