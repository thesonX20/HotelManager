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

namespace WindowsFormsApp1.PresentationTier
{
    public partial class UC_PHONG : Form
    {
        public UC_PHONG()
        {
            InitializeComponent();
        }

        private int GetSelectedRow(string maPhong)
        {
            for (int i = 0; i < dgvDSPhong.Rows.Count; i++)
            {
                if (dgvDSPhong.Rows[i].Cells[0].Value.ToString() == maPhong)
                {
                    return i;
                }
            }
            return -1;
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvDSPhong.Rows[selectedRow].Cells[0].Value = txtMaPhong.Text;
            dgvDSPhong.Rows[selectedRow].Cells[1].Value = txtHientrangP.Text;
            dgvDSPhong.Rows[selectedRow].Cells[2].Value = txtTang.Text;
            dgvDSPhong.Rows[selectedRow].Cells[3].Value = txtDientich.Text;
            dgvDSPhong.Rows[selectedRow].Cells[4].Value = txtMaloaiphong.Text;
        }

        private void BindGrid(List<DataTier.Models.PHONG> pHONGs)
        {
            dgvDSPhong.Rows.Clear();
            foreach (var item in pHONGs)
            {
                int index = dgvDSPhong.Rows.Add();
                dgvDSPhong.Rows[index].Cells[0].Value = item.MAPHONG;
                dgvDSPhong.Rows[index].Cells[1].Value = item.HIENTRANG;
                //dgvDSPhong.Rows[index].Cells[2].Value = item.TANG;
                dgvDSPhong.Rows[index].Cells[3].Value = item.DIENTICH;
                dgvDSPhong.Rows[index].Cells[4].Value = item.MALP;
            }
        }

        private void UC_PHONG_Load(object sender, EventArgs e)
        {
               try
               {
                   DataTier.Models.DBQLKS context = new DataTier.Models.DBQLKS();
                 //  List<DataTier.Models.KHACHHANG> kHACHHANGs = context.KHACHHANGs.ToList();
                   List<DataTier.Models.PHONG> pHONGs = context.PHONGs.ToList();
                   List<DataTier.Models.LOAIPHONG> lOAIPHONGs = context.LOAIPHONGs.ToList();
                   BindGrid(pHONGs);
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaPhong.Text);
            if (selectedRow == -1)
            {
                if (txtMaPhong.Text == "" || txtHientrangP.Text == "" || txtTang.Text == "" || txtDientich.Text == "" || txtMaloaiphong.Text == "")
                {
                    MessageBox.Show("Thông tin phòng thêm vào không được bỏ trống!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
                selectedRow = dgvDSPhong.Rows.Add();
                InsertUpdate(selectedRow);
                MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mã phòng không được trùng!", "Thông Báo", MessageBoxButtons.OK);
            }

        }

        private void btnSuaP_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaPhong.Text);
            if (selectedRow != -1)
            {
                if (txtMaPhong.Text == "" || txtHientrangP.Text == "" || txtTang.Text == "" || txtDientich.Text == "" || txtMaloaiphong.Text == "")
                {
                    MessageBox.Show("Thông tin sinh viên không được bỏ trống!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
                InsertUpdate(selectedRow);
                MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mã sinh viên không có trong bảng!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            if (this.dgvDSPhong.SelectedRows.Count > 0)
            {
                int selectedRow = GetSelectedRow(txtMaPhong.Text);
                if (selectedRow != -1)
                {
                    txtMaPhong.Text = "";
                    txtHientrangP.Text = "";
                    txtTang.Text = "";
                    txtDientich.Text = "";
                    txtMaloaiphong.Text = "";
                }
                dgvDSPhong.Rows.RemoveAt(this.dgvDSPhong.SelectedRows[0].Index);
            }
        }

        private void dgvDSPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dgvDSPhong.Rows[e.RowIndex];
                txtMaPhong.Text = Row.Cells[0].Value.ToString();
                txtHientrangP.Text = Row.Cells[1].Value.ToString();
                txtTang.Text = Row.Cells[2].Value.ToString();
                txtDientich.Text = Row.Cells[3].Value.ToString();
                txtMaloaiphong.Text = Row.Cells[4].Value.ToString();
            }
        }

        private void btnThoatP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
