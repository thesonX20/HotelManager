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
    public partial class UC_NV : Form
    {
        public UC_NV()
        {
            InitializeComponent();
        }


        private int GetSelectedRow(string maKH)
        {
            for (int i = 0; i < dgvNV.Rows.Count; i++)
            {
                if (dgvNV.Rows[i].Cells[0].Value.ToString() == maKH)
                {
                    return i;
                }
            }
            return -1;
        }

        private void BindGrid(List<DataTier.Models.NHANVIEN> nHANVIENs)
        {
            dgvNV.Rows.Clear();
            foreach (var item in nHANVIENs)
            {
                int index = dgvNV.Rows.Add();
                dgvNV.Rows[index].Cells[0].Value = item.MANV;
                dgvNV.Rows[index].Cells[1].Value = item.TENNV;
                dgvNV.Rows[index].Cells[2].Value = item.PHAI;
                dgvNV.Rows[index].Cells[3].Value = item.SDT;
                dgvNV.Rows[index].Cells[4].Value = item.DIACHI;
                dgvNV.Rows[index].Cells[5].Value = item.EMAIL;
                dgvNV.Rows[index].Cells[6].Value = item.CHUCVU;
            }
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvNV.Rows[selectedRow].Cells[0].Value = txtMaNV.Text;
            dgvNV.Rows[selectedRow].Cells[1].Value = txtTenNV.Text;
            dgvNV.Rows[selectedRow].Cells[2].Value = rbnNu.Checked ? "Nữ" : "Nam";
            dgvNV.Rows[selectedRow].Cells[3].Value = txtSDTNV.Text;
            dgvNV.Rows[selectedRow].Cells[4].Value = txtDiachiNV.Text;
            dgvNV.Rows[selectedRow].Cells[5].Value = txtEmailNV.Text;
            dgvNV.Rows[selectedRow].Cells[6].Value = txtChucVu.Text;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaNV.Text);
            if (selectedRow == -1)
            {
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiachiNV.Text == "" || txtChucVu.Text == "" || txtSDTNV.Text == "" || txtEmailNV.Text == "")
                {
                    MessageBox.Show("Thông tin sinh viên thêm vào không được bỏ trống!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
                selectedRow = dgvNV.Rows.Add();
                InsertUpdate(selectedRow);
                MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mã sinh viên không được trùng!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaNV.Text);
            if (selectedRow != -1)
            {
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiachiNV.Text == "" || txtChucVu.Text == "" || txtSDTNV.Text == "" || txtEmailNV.Text == "")
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

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (this.dgvNV.SelectedRows.Count > 0)
            {
                int selectedRow = GetSelectedRow(txtMaNV.Text);
                if (selectedRow != -1)
                {
                    txtMaNV.Text = "";
                    txtTenNV.Text = "";
                    txtDiachiNV.Text = "";
                    txtSDTNV.Text = "";
                    txtEmailNV.Text = "";
                    txtChucVu.Text = "";
                }
                dgvNV.Rows.RemoveAt(this.dgvNV.SelectedRows[0].Index);
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dgvNV.Rows[e.RowIndex];
                txtMaNV.Text = Row.Cells[0].Value.ToString();
                txtTenNV.Text = Row.Cells[1].Value.ToString();
                txtNamsinh.Text = Row.Cells[2].Value.ToString();
                txtSDTNV.Text = Row.Cells[3].Value.ToString();
                txtDiachiNV.Text = Row.Cells[4].Value.ToString();
                txtEmailNV.Text = Row.Cells[5].Value.ToString();
                txtChucVu.Text = Row.Cells[6].Value.ToString();
            }
        }
        private void UC_NV_Load(object sender, EventArgs e)
        {
            try
            {
                DataTier.Models.DBQLKS context = new DataTier.Models.DBQLKS();
                List<DataTier.Models.NHANVIEN> nHANVIENs = context.NHANVIENs.ToList();
                List<DataTier.Models.LOAIPHONG> lOAIPHONGs = context.LOAIPHONGs.ToList();
                BindGrid(nHANVIENs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
