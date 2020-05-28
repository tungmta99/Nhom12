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
    public partial class FormSupplier : Form
    {
        BindingSource SupplierList = new BindingSource();
        public FormSupplier()
        {
            
            InitializeComponent();

            LoadSupplier();
        }

        void LoadSupplier()
        {
            string query = "select * from Supplier";

            dtgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvSupplier.DataSource = SupplierList;

            SupplierList.DataSource = DataProvider.Instance.ExecuteQuery(query);


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
