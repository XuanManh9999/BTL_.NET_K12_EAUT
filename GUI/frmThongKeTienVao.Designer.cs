namespace GUI
{
    partial class frmThongKeTienVao
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
            this.crystalTKGDVao = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalTKGDVao
            // 
            this.crystalTKGDVao.ActiveViewIndex = -1;
            this.crystalTKGDVao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalTKGDVao.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalTKGDVao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalTKGDVao.Location = new System.Drawing.Point(0, 0);
            this.crystalTKGDVao.Name = "crystalTKGDVao";
            this.crystalTKGDVao.Size = new System.Drawing.Size(800, 450);
            this.crystalTKGDVao.TabIndex = 0;
            // 
            // frmThongKeTienVao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalTKGDVao);
            this.Name = "frmThongKeTienVao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKeTienVao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongKeTienVao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalTKGDVao;
    }
}