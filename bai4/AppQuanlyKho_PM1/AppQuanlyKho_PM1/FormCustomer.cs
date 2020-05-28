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
    public partial class FormCustomer : Form
    {
        BindingSource pList = new BindingSource();
        public FormCustomer()
        {

            InitializeComponent();

            LoadCustomer();
        }

        void LoadCustomer()
        {
            string query = "select * from Customer";

            dtgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvSupplier.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);


        }   
    }
}
