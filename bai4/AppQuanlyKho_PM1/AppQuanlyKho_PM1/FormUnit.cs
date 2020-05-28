using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanlyKho_PM1.DAO;

namespace AppQuanlyKho_PM1
{
    public partial class FormUnit : Form
    {
        BindingSource UnitList = new BindingSource();
        public FormUnit()
        {
            InitializeComponent();

            LoadKho();
        }

        void LoadKho()
        {
            string query = "select ID, DisplayName as [Đơnvị] from Unit";

            dtgvUnit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvUnit.DataSource = UnitList;

            UnitList.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
