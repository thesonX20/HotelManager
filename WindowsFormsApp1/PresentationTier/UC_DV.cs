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
    public partial class UC_DV : Form
    {
        public UC_DV()
        {
            InitializeComponent();
        }
        private int GetSelecttedRow(string DichVu)
        {
            for (int i = 0; i < dgvDV.Rows.Count; i++)
            {
                if (dgvDV.Rows[i].Cells[0].Value.ToString() == DichVu)
                {
                    return i;
                }
            }
            return -1;

        }
        private void NhapLieu(int selectedRow)
        {
            dgvDV.Rows[selectedRow].Cells[0].Value = txtMDV.Text;
            dgvDV.Rows[selectedRow].Cells[1].Value = cmbTenDV.Text;
            dgvDV.Rows[selectedRow].Cells[2].Value = float.Parse(txtGia.Text).ToString();
            dgvDV.Rows[selectedRow].Cells[3].Value = cmbDonViTinh.Text;
        }
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelecttedRow(txtMDV.Text);
            if (selectedRow == -1)
            {
                if (txtMDV.Text == "" || cmbTenDV.Text == "" || txtGia.Text == "" || cmbDonViTinh.Text == "")
                {
                    MessageBox.Show("Thông tin sinh viên thêm vào không được bỏ trống!", "Thông Báo", MessageBoxButtons.OK);
                    return;

                }
                selectedRow = dgvDV.Rows.Add();
                NhapLieu(selectedRow);
                MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mã sinh viên không được trùng!", "Thông Báo", MessageBoxButtons.OK);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (this.dgvDV.SelectedRows.Count > 0)
            {
                int selectedRow = GetSelecttedRow(txtMDV.Text);
                if (selectedRow != -1)
                {
                    txtMDV.Text = "";
                    txtMDV.Text = "";
                    txtMDV.Text = "";
                }
                dgvDV.Rows.RemoveAt(this.dgvDV.SelectedRows[0].Index);
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelecttedRow(txtMDV.Text);
            if (selectedRow != -1)
            {

                if (txtMDV.Text == "" || cmbTenDV.Text == "" || txtGia.Text == "" || cmbDonViTinh.Text == "")
                {
                    MessageBox.Show("Thông tin sinh viên không được bỏ trống!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
                NhapLieu(selectedRow);
                MessageBox.Show("Sửa thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mã sinh viên không có trong bảng!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void UC_DV_Load(object sender, EventArgs e)
        {
            try
            {
                DataTier.Models.DBQLKS context = new DataTier.Models.DBQLKS();

                List<DataTier.Models.DICHVU> dICHVUs = context.DICHVUs.ToList();    

                BindGrid(dICHVUs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<DataTier.Models.DICHVU> dICHVUs)
        {
            dgvDV.Rows.Clear();
            foreach (var item in dICHVUs)
            {
                int index = dgvDV.Rows.Add();
                dgvDV.Rows[index].Cells[0].Value = item.MADV;
                dgvDV.Rows[index].Cells[1].Value = item.TENDV;
                dgvDV.Rows[index].Cells[2].Value = item.GIA;
                dgvDV.Rows[index].Cells[3].Value = item.DVT;
            }
        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDV.Rows[e.RowIndex];
            txtMDV.Text = Convert.ToString(row.Cells[0].Value);
            cmbTenDV.Text = Convert.ToString(row.Cells[1].Value);
            txtGia.Text = Convert.ToString(row.Cells[2].Value);
            cmbDonViTinh.Text = Convert.ToString(row.Cells[3].Value);
        }
    }
}
