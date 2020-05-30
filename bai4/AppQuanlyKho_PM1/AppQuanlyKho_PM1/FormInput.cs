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
    public partial class FormInput : Form
    {
        BindingSource pList = new BindingSource();
        public FormInput()
        {
            InitializeComponent();

            LoadInputInfo();
        }

        void LoadInputInfo()
        {
            string query = String.Format("select * from InputInfo",comboBoxInputID.Text);

            dtgvInputInfor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvInputInfor.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);


        }
    }
}
