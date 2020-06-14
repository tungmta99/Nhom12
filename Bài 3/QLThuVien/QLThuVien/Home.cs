using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonInforUser_Click(object sender, EventArgs e)
        {
            InforUser IU = new InforUser();
            IU.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            Book Bk = new Book();
            Bk.ShowDialog();
        }

        private void buttonLibraryCard_Click(object sender, EventArgs e)
        {
            LibraryCard LC = new LibraryCard();
            LC.ShowDialog();
        }

        private void buttonBAGB_Click(object sender, EventArgs e)
        {
            BorrowAndGiveBack BAGB = new BorrowAndGiveBack();
            BAGB.ShowDialog();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
