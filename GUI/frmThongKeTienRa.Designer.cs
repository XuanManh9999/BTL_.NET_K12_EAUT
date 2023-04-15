namespace GUI
{
    partial class frmThongKeTienRa
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
            this.crysTal_ThongKeGD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crysTal_ThongKeGD
            // 
            this.crysTal_ThongKeGD.ActiveViewIndex = -1;
            this.crysTal_ThongKeGD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysTal_ThongKeGD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysTal_ThongKeGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysTal_ThongKeGD.Location = new System.Drawing.Point(0, 0);
            this.crysTal_ThongKeGD.Name = "crysTal_ThongKeGD";
            this.crysTal_ThongKeGD.Size = new System.Drawing.Size(800, 450);
            this.crysTal_ThongKeGD.TabIndex = 0;
            // 
            // frmThongKeTienRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crysTal_ThongKeGD);
            this.Name = "frmThongKeTienRa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKeTienRa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongKeTienRa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crysTal_ThongKeGD;
    }
}