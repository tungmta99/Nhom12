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
    public partial class Form1 : Form
    {
        BindingSource KhoList = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            LoadKho();
        }

        void LoadKho()
        {
            string query = "select * from KhoView";

            dtgvStorage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvStorage.DataSource = KhoList;

            KhoList.DataSource = DataProvider.Instance.ExecuteQuery(query);

            string query2 = "select sum(Quantity) from InputInfo";
            labelSumInput.Text= DataProvider.Instance.ExecuteScalar(query2).ToString();

            string query3 = "select sum(Quantity) from OutputInfo";
            labelSumOutput.Text = DataProvider.Instance.ExecuteScalar(query3).ToString();

            int sumstock = Convert.ToInt32(labelSumInput.Text) - Convert.ToInt32(labelSumOutput.Text);
            labelSumStock.Text = sumstock.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text; 

            string query = string.Format("select * from KhoView where [ID] like N'%{0}%' or [Vật tư] like N'%{1}%' or [Đơn vị] like N'%{2}%'", keyword, keyword, keyword);

            dtgvStorage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvStorage.DataSource = KhoList;

            KhoList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
