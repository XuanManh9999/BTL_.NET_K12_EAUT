namespace GUI
{
    partial class Form_Giao_Dich
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTenTaiKhoanNhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTenNN = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbTKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChuyenKhoan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtNoiDungChuyen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbNDChuyen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoTienChuyen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSTChuyen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTaiKhoanNhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTKNhan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoTaiKhoanGui = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSTK = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboHinhThucChuyenKhoan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbHTC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelMain.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Chocolate;
            this.panelMain.Controls.Add(this.guna2Button1);
            this.panelMain.Controls.Add(this.guna2GroupBox1);
            this.panelMain.Controls.Add(this.guna2ControlBox1);
            this.panelMain.Controls.Add(this.guna2ControlBox2);
            this.panelMain.Controls.Add(this.guna2ControlBox3);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.panelMain.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(254)))), ((int)(((byte)(157)))));
            this.panelMain.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1067, 562);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.guna2Button1.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(833, 522);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(197, 37);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Về Trang Chủ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.txtTenTaiKhoanNhan);
            this.guna2GroupBox1.Controls.Add(this.lbTenNN);
            this.guna2GroupBox1.Controls.Add(this.lbTKH);
            this.guna2GroupBox1.Controls.Add(this.txtTenTK);
            this.guna2GroupBox1.Controls.Add(this.btnChuyenKhoan);
            this.guna2GroupBox1.Controls.Add(this.txtNoiDungChuyen);
            this.guna2GroupBox1.Controls.Add(this.lbNDChuyen);
            this.guna2GroupBox1.Controls.Add(this.txtSoTienChuyen);
            this.guna2GroupBox1.Controls.Add(this.lbSTChuyen);
            this.guna2GroupBox1.Controls.Add(this.txtTaiKhoanNhan);
            this.guna2GroupBox1.Controls.Add(this.lbTKNhan);
            this.guna2GroupBox1.Controls.Add(this.txtSoTaiKhoanGui);
            this.guna2GroupBox1.Controls.Add(this.lbSD);
            this.guna2GroupBox1.Controls.Add(this.txtSoTien);
            this.guna2GroupBox1.Controls.Add(this.lbSTK);
            this.guna2GroupBox1.Controls.Add(this.cboHinhThucChuyenKhoan);
            this.guna2GroupBox1.Controls.Add(this.lbHTC);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(46, 43);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(984, 473);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Thông Tin Chuyển Tiền";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 2);
            // 
            // txtTenTaiKhoanNhan
            // 
            this.txtTenTaiKhoanNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoanNhan.DefaultText = "";
            this.txtTenTaiKhoanNhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTaiKhoanNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTaiKhoanNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiKhoanNhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTaiKhoanNhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoanNhan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoanNhan.ForeColor = System.Drawing.Color.Black;
            this.txtTenTaiKhoanNhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTaiKhoanNhan.Location = new System.Drawing.Point(338, 283);
            this.txtTenTaiKhoanNhan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTenTaiKhoanNhan.Name = "txtTenTaiKhoanNhan";
            this.txtTenTaiKhoanNhan.PasswordChar = '\0';
            this.txtTenTaiKhoanNhan.PlaceholderText = "";
            this.txtTenTaiKhoanNhan.ReadOnly = true;
            this.txtTenTaiKhoanNhan.SelectedText = "";
            this.txtTenTaiKhoanNhan.Size = new System.Drawing.Size(506, 35);
            this.txtTenTaiKhoanNhan.TabIndex = 18;
            // 
            // lbTenNN
            // 
            this.lbTenNN.BackColor = System.Drawing.Color.Transparent;
            this.lbTenNN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNN.ForeColor = System.Drawing.Color.Black;
            this.lbTenNN.Location = new System.Drawing.Point(44, 287);
            this.lbTenNN.Name = "lbTenNN";
            this.lbTenNN.Size = new System.Drawing.Size(244, 31);
            this.lbTenNN.TabIndex = 17;
            this.lbTenNN.Text = "Tên Tài Khoản Nhận:";
            // 
            // lbTKH
            // 
            this.lbTKH.BackColor = System.Drawing.Color.Transparent;
            this.lbTKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKH.ForeColor = System.Drawing.Color.Black;
            this.lbTKH.Location = new System.Drawing.Point(45, 147);
            this.lbTKH.Name = "lbTKH";
            this.lbTKH.Size = new System.Drawing.Size(150, 31);
            this.lbTKH.TabIndex = 16;
            this.lbTKH.Text = "Khách Hàng:";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTK.DefaultText = "";
            this.txtTenTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTK.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.ForeColor = System.Drawing.Color.Black;
            this.txtTenTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTK.Location = new System.Drawing.Point(336, 147);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.PasswordChar = '\0';
            this.txtTenTK.PlaceholderText = "";
            this.txtTenTK.ReadOnly = true;
            this.txtTenTK.SelectedText = "";
            this.txtTenTK.Size = new System.Drawing.Size(506, 35);
            this.txtTenTK.TabIndex = 15;
            this.txtTenTK.TabStop = false;
            // 
            // btnChuyenKhoan
            // 
            this.btnChuyenKhoan.BorderRadius = 10;
            this.btnChuyenKhoan.BorderThickness = 1;
            this.btnChuyenKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyenKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyenKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyenKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuyenKhoan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuyenKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuyenKhoan.FillColor = System.Drawing.Color.White;
            this.btnChuyenKhoan.FillColor2 = System.Drawing.Color.White;
            this.btnChuyenKhoan.FocusedColor = System.Drawing.Color.White;
            this.btnChuyenKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenKhoan.ForeColor = System.Drawing.Color.Black;
            this.btnChuyenKhoan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(254)))), ((int)(((byte)(157)))));
            this.btnChuyenKhoan.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.btnChuyenKhoan.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnChuyenKhoan.Location = new System.Drawing.Point(115, 422);
            this.btnChuyenKhoan.Name = "btnChuyenKhoan";
            this.btnChuyenKhoan.Size = new System.Drawing.Size(747, 43);
            this.btnChuyenKhoan.TabIndex = 13;
            this.btnChuyenKhoan.Text = "Chuyển Tiền";
            this.btnChuyenKhoan.Click += new System.EventHandler(this.btnChuyenKhoan_Click_1);
            // 
            // txtNoiDungChuyen
            // 
            this.txtNoiDungChuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoiDungChuyen.DefaultText = "";
            this.txtNoiDungChuyen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoiDungChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoiDungChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDungChuyen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoiDungChuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDungChuyen.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungChuyen.ForeColor = System.Drawing.Color.Black;
            this.txtNoiDungChuyen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoiDungChuyen.Location = new System.Drawing.Point(338, 381);
            this.txtNoiDungChuyen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNoiDungChuyen.Name = "txtNoiDungChuyen";
            this.txtNoiDungChuyen.PasswordChar = '\0';
            this.txtNoiDungChuyen.PlaceholderText = "";
            this.txtNoiDungChuyen.SelectedText = "";
            this.txtNoiDungChuyen.Size = new System.Drawing.Size(505, 35);
            this.txtNoiDungChuyen.TabIndex = 11;
            // 
            // lbNDChuyen
            // 
            this.lbNDChuyen.BackColor = System.Drawing.Color.Transparent;
            this.lbNDChuyen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNDChuyen.ForeColor = System.Drawing.Color.Black;
            this.lbNDChuyen.Location = new System.Drawing.Point(45, 385);
            this.lbNDChuyen.Name = "lbNDChuyen";
            this.lbNDChuyen.Size = new System.Drawing.Size(285, 31);
            this.lbNDChuyen.TabIndex = 10;
            this.lbNDChuyen.Text = "Nội dung chuyển khoản:";
            // 
            // txtSoTienChuyen
            // 
            this.txtSoTienChuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTienChuyen.DefaultText = "";
            this.txtSoTienChuyen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoTienChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoTienChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTienChuyen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTienChuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTienChuyen.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienChuyen.ForeColor = System.Drawing.Color.Black;
            this.txtSoTienChuyen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTienChuyen.Location = new System.Drawing.Point(337, 336);
            this.txtSoTienChuyen.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSoTienChuyen.Name = "txtSoTienChuyen";
            this.txtSoTienChuyen.PasswordChar = '\0';
            this.txtSoTienChuyen.PlaceholderText = "";
            this.txtSoTienChuyen.SelectedText = "";
            this.txtSoTienChuyen.Size = new System.Drawing.Size(506, 35);
            this.txtSoTienChuyen.TabIndex = 9;
            // 
            // lbSTChuyen
            // 
            this.lbSTChuyen.BackColor = System.Drawing.Color.Transparent;
            this.lbSTChuyen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTChuyen.ForeColor = System.Drawing.Color.Black;
            this.lbSTChuyen.Location = new System.Drawing.Point(45, 340);
            this.lbSTChuyen.Name = "lbSTChuyen";
            this.lbSTChuyen.Size = new System.Drawing.Size(193, 31);
            this.lbSTChuyen.TabIndex = 8;
            this.lbSTChuyen.Text = "Số Tiền Chuyển:";
            // 
            // txtTaiKhoanNhan
            // 
            this.txtTaiKhoanNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaiKhoanNhan.DefaultText = "";
            this.txtTaiKhoanNhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaiKhoanNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaiKhoanNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoanNhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaiKhoanNhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoanNhan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoanNhan.ForeColor = System.Drawing.Color.Black;
            this.txtTaiKhoanNhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaiKhoanNhan.Location = new System.Drawing.Point(336, 238);
            this.txtTaiKhoanNhan.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTaiKhoanNhan.Name = "txtTaiKhoanNhan";
            this.txtTaiKhoanNhan.PasswordChar = '\0';
            this.txtTaiKhoanNhan.PlaceholderText = "";
            this.txtTaiKhoanNhan.SelectedText = "";
            this.txtTaiKhoanNhan.Size = new System.Drawing.Size(506, 35);
            this.txtTaiKhoanNhan.TabIndex = 7;
            this.txtTaiKhoanNhan.TextChanged += new System.EventHandler(this.txtTaiKhoanNhan_TextChanged_1);
            // 
            // lbTKNhan
            // 
            this.lbTKNhan.BackColor = System.Drawing.Color.Transparent;
            this.lbTKNhan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTKNhan.ForeColor = System.Drawing.Color.Black;
            this.lbTKNhan.Location = new System.Drawing.Point(44, 245);
            this.lbTKNhan.Name = "lbTKNhan";
            this.lbTKNhan.Size = new System.Drawing.Size(232, 31);
            this.lbTKNhan.TabIndex = 6;
            this.lbTKNhan.Text = "Số Tài Khoản Nhận:";
            // 
            // txtSoTaiKhoanGui
            // 
            this.txtSoTaiKhoanGui.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTaiKhoanGui.DefaultText = "";
            this.txtSoTaiKhoanGui.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoTaiKhoanGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoTaiKhoanGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTaiKhoanGui.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTaiKhoanGui.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTaiKhoanGui.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTaiKhoanGui.ForeColor = System.Drawing.Color.Black;
            this.txtSoTaiKhoanGui.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTaiKhoanGui.Location = new System.Drawing.Point(336, 102);
            this.txtSoTaiKhoanGui.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSoTaiKhoanGui.Name = "txtSoTaiKhoanGui";
            this.txtSoTaiKhoanGui.PasswordChar = '\0';
            this.txtSoTaiKhoanGui.PlaceholderText = "";
            this.txtSoTaiKhoanGui.ReadOnly = true;
            this.txtSoTaiKhoanGui.SelectedText = "";
            this.txtSoTaiKhoanGui.Size = new System.Drawing.Size(506, 35);
            this.txtSoTaiKhoanGui.TabIndex = 5;
            this.txtSoTaiKhoanGui.TabStop = false;
            // 
            // lbSD
            // 
            this.lbSD.BackColor = System.Drawing.Color.Transparent;
            this.lbSD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSD.ForeColor = System.Drawing.Color.Black;
            this.lbSD.Location = new System.Drawing.Point(45, 193);
            this.lbSD.Name = "lbSD";
            this.lbSD.Size = new System.Drawing.Size(98, 31);
            this.lbSD.TabIndex = 4;
            this.lbSD.Text = "Số Tiền:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTien.DefaultText = "";
            this.txtSoTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.ForeColor = System.Drawing.Color.Black;
            this.txtSoTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTien.Location = new System.Drawing.Point(338, 193);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.PasswordChar = '\0';
            this.txtSoTien.PlaceholderText = "";
            this.txtSoTien.ReadOnly = true;
            this.txtSoTien.SelectedText = "";
            this.txtSoTien.Size = new System.Drawing.Size(506, 35);
            this.txtSoTien.TabIndex = 3;
            this.txtSoTien.TabStop = false;
            // 
            // lbSTK
            // 
            this.lbSTK.BackColor = System.Drawing.Color.Transparent;
            this.lbSTK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTK.ForeColor = System.Drawing.Color.Black;
            this.lbSTK.Location = new System.Drawing.Point(44, 102);
            this.lbSTK.Name = "lbSTK";
            this.lbSTK.Size = new System.Drawing.Size(260, 31);
            this.lbSTK.TabIndex = 2;
            this.lbSTK.Text = "Số Tài Khoản Chuyển:";
            // 
            // cboHinhThucChuyenKhoan
            // 
            this.cboHinhThucChuyenKhoan.BackColor = System.Drawing.Color.Transparent;
            this.cboHinhThucChuyenKhoan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHinhThucChuyenKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThucChuyenKhoan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHinhThucChuyenKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHinhThucChuyenKhoan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHinhThucChuyenKhoan.ForeColor = System.Drawing.Color.Black;
            this.cboHinhThucChuyenKhoan.ItemHeight = 30;
            this.cboHinhThucChuyenKhoan.Location = new System.Drawing.Point(336, 56);
            this.cboHinhThucChuyenKhoan.Name = "cboHinhThucChuyenKhoan";
            this.cboHinhThucChuyenKhoan.Size = new System.Drawing.Size(506, 36);
            this.cboHinhThucChuyenKhoan.TabIndex = 1;
            // 
            // lbHTC
            // 
            this.lbHTC.BackColor = System.Drawing.Color.Transparent;
            this.lbHTC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHTC.ForeColor = System.Drawing.Color.Black;
            this.lbHTC.Location = new System.Drawing.Point(45, 56);
            this.lbHTC.Name = "lbHTC";
            this.lbHTC.Size = new System.Drawing.Size(226, 31);
            this.lbHTC.TabIndex = 0;
            this.lbHTC.Text = "Hình Thức Chuyển:";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1003, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(62, 36);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(932, 0);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(63, 36);
            this.guna2ControlBox2.TabIndex = 7;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox3.HoverState.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(858, 0);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(63, 36);
            this.guna2ControlBox3.TabIndex = 8;
            // 
            // Form_Giao_Dich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Giao_Dich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Giao_Dich";
            this.Load += new System.EventHandler(this.Form_Giao_Dich_Load);
            this.panelMain.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelMain;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTaiKhoanNhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTenNN;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTK;
        private Guna.UI2.WinForms.Guna2GradientButton btnChuyenKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtNoiDungChuyen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbNDChuyen;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTienChuyen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSTChuyen;
        private Guna.UI2.WinForms.Guna2TextBox txtTaiKhoanNhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTKNhan;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTaiKhoanGui;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSD;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSTK;
        private Guna.UI2.WinForms.Guna2ComboBox cboHinhThucChuyenKhoan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHTC;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}