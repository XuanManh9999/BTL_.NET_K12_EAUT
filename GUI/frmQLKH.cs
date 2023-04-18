using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQLKH : Form
    {
        BUS_QLKH BUS_QLKH = new BUS_QLKH();
        public frmQLKH()
        {
            InitializeComponent();
        }
        // Hàm load form
        private void frmQLKH_Load(object sender, EventArgs e)
        {
            Load_DataGrid(BUS_QLKH.getData()); ;
            panel_TimKiem.Hide();
        }
        // Hàm xử lý khi click vào cell datagrid
        int index;
        private void dtGridQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                txtMaKH.Text = dtGridQLKH.Rows[index].Cells[0].Value.ToString();
                txtTenKH.Text = dtGridQLKH.Rows[index].Cells[1].Value.ToString();
                txtCMND.Text = dtGridQLKH.Rows[index].Cells[2].Value.ToString();
                try
                {
                    dateNS.Value = DateTime.Parse(dtGridQLKH.Rows[index].Cells[3].Value.ToString());
                }
                catch
                {
                    dateNS.Value = DateTime.Now;
                }
                if(dtGridQLKH.Rows[index].Cells[4].Value.ToString() == "Nam")
                {
                    rdGT_Nam.Checked = true;
                } else
                {
                    rdGT_Nu.Checked = true;
                }
                txtDiaChi.Text = dtGridQLKH.Rows[index].Cells[5].Value.ToString();
                txtSDT.Text = dtGridQLKH.Rows[index].Cells[6].Value.ToString();
            }
        }
        // Hàm load dữ liệu bảng khách hàng lên data grid view
        private void Load_DataGrid(DataTable data)
        {
            dtGridQLKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridQLKH.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dtGridQLKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtGridQLKH.RowsDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            dtGridQLKH.DataSource = null;
            dtGridQLKH.Refresh();
            dtGridQLKH.DataSource = data;

            dtGridQLKH.Columns[0].HeaderText = "Mã KH";
            dtGridQLKH.Columns[1].HeaderText = "Tên KH";
            dtGridQLKH.Columns[2].HeaderText = "Số CMND";
            dtGridQLKH.Columns[3].HeaderText = "Ngày sinh";
            dtGridQLKH.Columns[4].HeaderText = "Giới tính";
            dtGridQLKH.Columns[5].HeaderText = "Địa chỉ";
            dtGridQLKH.Columns[6].HeaderText = "SDT";
        }
        // Hàm kiểm tra text box
        private bool Check_TextBox()
        {
            if(string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKH.Focus();
                return false;
            } else if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKH.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtCMND.Text))
            {
                MessageBox.Show("Vui lòng nhập số cmnd", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCMND.Focus();
                return false;
            } else if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            } else
            {
                return true;
            }
        }
        // Hàm clear text box
        private void Clear_TextBox()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtCMND.Clear();
            dateNS.Value = DateTime.Now;
            rdGT_Nam.Checked = true;
            txtDiaChi.Clear();
            txtSDT.Clear();
        }
        // Hàm tạo đối tượng khách hàng
        private KHACH_HANG Create_kH()
        {
            // Lấy ngày sinh
            string day = dateNS.Value.Day.ToString().Length == 1 ? $"0{dateNS.Value.Day}" : dateNS.Value.Day.ToString();
            string month = dateNS.Value.Month.ToString().Length == 1 ? $"0{dateNS.Value.Month}" : dateNS.Value.Month.ToString();
            string year = dateNS.Value.Year.ToString();
            string NgaySinh = $"{day}/{month}/{year}";
            // Lấy giới tính
            string GioiTinh;
            if(rdGT_Nam.Checked)
            {
                GioiTinh = rdGT_Nam.Text;
            } else
            {
                GioiTinh = rdGT_Nu.Text;
            }
            KHACH_HANG KH = new KHACH_HANG(txtMaKH.Text, txtTenKH.Text, txtCMND.Text, NgaySinh, GioiTinh, txtDiaChi.Text, txtSDT.Text);
            return KH;
        }
        // Tạo đối tượng quản lý khách hàng
        private QUAN_LY_KHACH_HANG Create_QLKH()
        {
            QUAN_LY_KHACH_HANG QLKH = new QUAN_LY_KHACH_HANG(txtMaKH.Text, "QL001");
            return QLKH;
        }

        // Sự kiện thêm khách hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            QUAN_LY_KHACH_HANG QLKH = Create_QLKH();
            KHACH_HANG KH = Create_kH();
            if(Check_TextBox())
            {
                if (BUS_QLKH.ThemKhachHang(KH, QLKH))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load_DataGrid(BUS_QLKH.getData());
                    Clear_TextBox();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Sự kiện sửa khách hàng
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
            KHACH_HANG KH = Create_kH();
            DialogResult result = MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (Check_TextBox())
                {
                    if (BUS_QLKH.SuaKhachHang(KH))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DataGrid(BUS_QLKH.getData());
                        Clear_TextBox();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Sự kiện xóa khách hàng
        private void btnXoa_Click(object sender, EventArgs e)
        {
            QUAN_LY_KHACH_HANG QLKH = Create_QLKH();
            KHACH_HANG KH = Create_kH();
            DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                if (Check_TextBox())
                {
                    if (BUS_QLKH.XoaKhachHang(KH, QLKH))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_DataGrid(BUS_QLKH.getData());
                        Clear_TextBox();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // Sự kiện tìm kiếm
        int count = 0;      // Biến lưu số lần click btnTimKiem
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            panel_TimKiem.Show();
            if (count > 0)
            {
                if (rdMaKH.Checked)
                {
                    DataTable data = BUS_QLKH.TimKiem_MaKH(txtTK_MaKH.Text);
                    Load_DataGrid(data);
                    lbKetQua_TK.Text = data.Rows.Count.ToString();
                }
                else
                {
                    DataTable data = BUS_QLKH.TimKiem_TenKH(txtTK_TenKH.Text);
                    Load_DataGrid(data);
                    lbKetQua_TK.Text = data.Rows.Count.ToString();
                }
            }
            ++count;
        }
        // Sự kiện đóng panel tìm kiếm
        private void btnClose_Click(object sender, EventArgs e)
        {
            panel_TimKiem.Hide();
            Load_DataGrid(BUS_QLKH.getData());
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.Cursor = Cursors.Hand;
            btnClose.BackColor = Color.Red;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void dtGridQLKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel_TimKiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbKetQua_TK_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTK_TenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdTenKH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTK_MaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdMaKH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rdGT_Nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdGT_Nam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateNS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
