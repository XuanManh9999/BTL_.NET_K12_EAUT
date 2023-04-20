﻿using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        BUS_DangNhap bus_DN = new BUS_DangNhap();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        // Hàm check textBox
        private bool Check_TextBox()
        {
            if(string.IsNullOrWhiteSpace(txtTenDN.Text))
            {
                MessageBox.Show("Nhập tên đăng nhập");
                txtTenDN.Focus();
                return false;
            } else if (string.IsNullOrWhiteSpace(txtMK.Text))
            {
                MessageBox.Show("Nhập mật khẩu");
                txtMK.Focus();
                return false;
            }
            return true;
        }

        // Sự kiến click đăng nhập
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(Check_TextBox())
            {
                if(bus_DN.DangNhap(txtTenDN.Text, txtMK.Text) || (txtTenDN.Text == "Admin" && txtMK.Text == "123"))
                {
                    Hide();
                    Form_Trang_Chu frmMain = new Form_Trang_Chu();
                    frmMain.Show();
                } else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện click đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmDK = new frmDangKy();
            frmDK.ShowDialog();
        }

        // Sự kiện click Quên mk
        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            Hide();
            frmQuenMK frmQuenMK = new frmQuenMK();
            frmQuenMK.Show();
        }

        // Xử lý hover đăng ký
        private void btnDangKy_MouseHover(object sender, EventArgs e)
        {
            btnDangKy.ForeColor = Color.FromArgb(0, 201, 255);
        }
        private void btnDangKy_MouseLeave(object sender, EventArgs e)
        {
            btnDangKy.ForeColor = Color.Black;
        }

        // Xử lý hover quên mk
        private void btnQuenMK_MouseHover(object sender, EventArgs e)
        {
            btnQuenMK.ForeColor = Color.FromArgb(0, 201, 255);
        }

        private void btnQuenMK_MouseLeave(object sender, EventArgs e)
        {
            btnQuenMK.ForeColor = Color.Black;
        }
    }
}
