//using DevExpress.ClipboardSource.SpreadsheetML;
//using DevExpress.XtraExport.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.DataTier.Models;

namespace WindowsFormsApp1
{
    public partial class UC_KH : Form
    {
        public UC_KH()
        {
            InitializeComponent();
        }

        private int GetSelectedRow(string maKH)
        {
            for (int i = 0; i < dgvKH.Rows.Count; i++)
            {
                if (dgvKH.Rows[i].Cells[0].Value.ToString() == maKH)
                {
                    return i;
                }
            }
            return -1;
        }

        private void BindGrid(List<DataTier.Models.KHACHHANG> kHACHHANGs)
        {
            dgvKH.Rows.Clear();
            foreach (var item in kHACHHANGs)
            {
                int index = dgvKH.Rows.Add();
                dgvKH.Rows[index].Cells[0].Value = item.MAKH;
                dgvKH.Rows[index].Cells[1].Value = item.TENKH;
                dgvKH.Rows[index].Cells[2].Value = item.SODT;
                dgvKH.Rows[index].Cells[3].Value = item.CCCD;
                dgvKH.Rows[index].Cells[4].Value = item.DIACHI;
                dgvKH.Rows[index].Cells[5].Value = item.EMAIL;
            }
        }

        private void InsertUpdate(int selectedRow)
        {
            dgvKH.Rows[selectedRow].Cells[0].Value = txtMaKH.Text;
            dgvKH.Rows[selectedRow].Cells[1].Value = txtTenKH.Text;
            dgvKH.Rows[selectedRow].Cells[2].Value = txtSDT.Text;
            dgvKH.Rows[selectedRow].Cells[3].Value = txtCCCD.Text;
            dgvKH.Rows[selectedRow].Cells[4].Value = txtDiachiKH.Text;
            dgvKH.Rows[selectedRow].Cells[5].Value = txtEmail.Text;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaKH.Text);
            if (selectedRow == -1)
            {
                if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiachiKH.Text == "" || txtCCCD.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Thông tin sinh viên thêm vào không được bỏ trống!", "Thông Báo", MessageBoxButtons.OK);
                    return;
                }
                selectedRow = dgvKH.Rows.Add();
                InsertUpdate(selectedRow);
                MessageBox.Show("Thêm thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mã sinh viên không được trùng!", "Thông Báo", MessageBoxButtons.OK);
            }

        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            int selectedRow = GetSelectedRow(txtMaKH.Text);
            if (selectedRow != -1)
            {
                if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtDiachiKH.Text == "" || txtCCCD.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
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

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (this.dgvKH.SelectedRows.Count > 0)
            {
                int selectedRow = GetSelectedRow(txtMaKH.Text);
                if (selectedRow != -1)
                {
                    txtMaKH.Text = "";
                    txtTenKH.Text = "";
                    txtDiachiKH.Text = "";
                    txtCCCD.Text = "";
                    txtSDT.Text = "";
                    txtEmail.Text = "";
                }
                dgvKH.Rows.RemoveAt(this.dgvKH.SelectedRows[0].Index);
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Row = dgvKH.Rows[e.RowIndex];
                txtMaKH.Text = Row.Cells[0].Value.ToString();
                txtTenKH.Text = Row.Cells[1].Value.ToString();
                txtSDT.Text = Row.Cells[2].Value.ToString();
                txtCCCD.Text = Row.Cells[3].Value.ToString();
                txtDiachiKH.Text = Row.Cells[4].Value.ToString();
                txtEmail.Text = Row.Cells[5].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTimkiem_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTimkiem.Checked == true)
            {
                chkTimMa.Visible = true;
                txtTimMakh.Visible = true;
                chkTimTen.Visible = true;
                txtTenkhtk.Visible = true;
                chkTimCCCD.Visible = true;
                txtCccdkhtk.Visible = true;
                chkTimSDT.Visible = true;
                txtSdtkhtk.Visible = true;
                chkTimEmail.Visible = true;
                txtEmailkhtk.Visible = true;
            }
            else
            {
                chkTimMa.Visible = false;
                txtTimMakh.Visible = false;
                chkTimTen.Visible = false;
                txtTenkhtk.Visible = false;
                chkTimCCCD.Visible = false;
                txtCccdkhtk.Visible = false;
                chkTimSDT.Visible = false;
                txtSdtkhtk.Visible = false;
                chkTimEmail.Visible = false;
                txtEmailkhtk.Visible = false;
            }
        }

        private void UC_KH_Load(object sender, EventArgs e)
        {
            try
            {
                DataTier.Models.DBQLKS context = new DataTier.Models.DBQLKS();
                List<DataTier.Models.KHACHHANG> kHACHHANGs = context.KHACHHANGs.ToList();
              //  List<DataTier.Models.PHONG> pHONGs = context.PHONGs.ToList();
                
                BindGrid(kHACHHANGs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            chkTimkiem_CheckedChanged(sender, e);
        }

        private void txtTimMakh_TextChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
