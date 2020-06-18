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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            frmHocSinh hs = new frmHocSinh();
            hs.ShowDialog();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            frmGiaoVien gv = new frmGiaoVien();
            gv.ShowDialog();
        }

        private void btnTKB_Click(object sender, EventArgs e)
        {
            frmTKB tkb = new frmTKB();
            tkb.ShowDialog();
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming soon !!!");
        }
    }
}
