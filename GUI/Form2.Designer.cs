namespace GUI
{
    partial class Form2
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
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.btnDangKy = new Guna.UI.WinForms.GunaGradientButton();
            this.btnDangNhap = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaTransfarantPictureBox1.Image = global::GUI.Properties.Resources.photo1640593039583_16405930396597044394681;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(1057, 647);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 0;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // btnDangKy
            // 
            this.btnDangKy.AnimationHoverSpeed = 0.07F;
            this.btnDangKy.AnimationSpeed = 0.03F;
            this.btnDangKy.BackColor = System.Drawing.Color.Black;
            this.btnDangKy.BaseColor1 = System.Drawing.Color.DarkGray;
            this.btnDangKy.BaseColor2 = System.Drawing.Color.LightGray;
            this.btnDangKy.BorderColor = System.Drawing.Color.Black;
            this.btnDangKy.BorderSize = 3;
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDangKy.FocusedColor = System.Drawing.Color.Empty;
            this.btnDangKy.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.Black;
            this.btnDangKy.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnDangKy.Image = null;
            this.btnDangKy.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDangKy.Location = new System.Drawing.Point(867, 571);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.OnHoverBaseColor1 = System.Drawing.Color.Yellow;
            this.btnDangKy.OnHoverBaseColor2 = System.Drawing.Color.OrangeRed;
            this.btnDangKy.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnDangKy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDangKy.OnHoverImage = null;
            this.btnDangKy.OnPressedColor = System.Drawing.Color.Black;
            this.btnDangKy.Radius = 5;
            this.btnDangKy.Size = new System.Drawing.Size(178, 64);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AnimationHoverSpeed = 0.07F;
            this.btnDangNhap.AnimationSpeed = 0.03F;
            this.btnDangNhap.BackColor = System.Drawing.Color.Black;
            this.btnDangNhap.BaseColor1 = System.Drawing.Color.DarkGray;
            this.btnDangNhap.BaseColor2 = System.Drawing.Color.LightGray;
            this.btnDangNhap.BorderColor = System.Drawing.Color.Black;
            this.btnDangNhap.BorderSize = 3;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDangNhap.FocusedColor = System.Drawing.Color.Empty;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnDangNhap.Image = null;
            this.btnDangNhap.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDangNhap.Location = new System.Drawing.Point(683, 571);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.OnHoverBaseColor1 = System.Drawing.Color.Yellow;
            this.btnDangNhap.OnHoverBaseColor2 = System.Drawing.Color.OrangeRed;
            this.btnDangNhap.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnDangNhap.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDangNhap.OnHoverImage = null;
            this.btnDangNhap.OnPressedColor = System.Drawing.Color.Black;
            this.btnDangNhap.Radius = 5;
            this.btnDangNhap.Size = new System.Drawing.Size(178, 64);
            this.btnDangNhap.TabIndex = 8;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 647);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.gunaTransfarantPictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaGradientButton btnDangKy;
        private Guna.UI.WinForms.GunaGradientButton btnDangNhap;
    }
}