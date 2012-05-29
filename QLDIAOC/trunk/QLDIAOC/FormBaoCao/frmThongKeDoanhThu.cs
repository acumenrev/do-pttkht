using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLDIAOC.FormBaoCao
{
    public partial class frmThongKeDoanhThu : DevComponents.DotNetBar.Office2007Form
    {

        #region Fields

        private const int WM_NCLBUTTONDBLCLK = 0xA3;

        #endregion

        #region Constructor

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        // Ngan khong cho phong to cua so khi bam doi chuot vao title bar
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCLBUTTONDBLCLK:
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    return;
            }

            base.WndProc(ref m);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        
    }
}