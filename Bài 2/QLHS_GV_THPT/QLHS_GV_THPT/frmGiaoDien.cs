using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS_GV_THPT
{
    public partial class frmGiaoDien : Form
    {
        public frmGiaoDien()
        {
            InitializeComponent();
        }

        private void buttonDN_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.ShowDialog();
            this.Hide();
        }

        private void buttonDK_Click(object sender, EventArgs e)
        {
            frmDangKy dk = new frmDangKy();
            dk.ShowDialog();
        }
        private void frmGiaoDien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
