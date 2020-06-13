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

            AddBingdingCustomer();
        }

        void LoadCustomer()
        {
            string query = "select ID,Displayname as[Tên],Adress as[Địa chỉ],Phone as[SDT],Email,MoreInfo as[Khác],ContractDate as[Ngày hợp tác] from Customer";

            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvCustomer.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);


        }   

        void AddBingdingCustomer()
        {
            textBoxCustomerName.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            textBoxCustomerAdress.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            textBoxCustomerEmail.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Email", true, DataSourceUpdateMode.Never));
            textBoxCustomerPhone.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            
            textBoxCustomerMoreInfo.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "Khác", true, DataSourceUpdateMode.Never));
            dtpCustomerContractDate.DataBindings.Add(new Binding("Value", dtgvCustomer.DataSource, "Ngày hợp tác", true, DataSourceUpdateMode.Never));
            labelCustomerID.DataBindings.Add(new Binding("Text", dtgvCustomer.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string customerName = textBoxCustomerName.Text;
            string customerAdress = textBoxCustomerAdress.Text;
            string customerPhone = textBoxCustomerPhone.Text;
            string supplerEmail = textBoxCustomerEmail.Text;
            string customerMoreInfo = textBoxCustomerMoreInfo.Text;
            DateTime contractDate = dtpCustomerContractDate.Value;

            if (CustomerDAO.Instance.InsertCustomer(customerName, customerAdress, customerPhone, supplerEmail, customerMoreInfo, contractDate))
            {
                MessageBox.Show("Thêm thành công");
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(labelCustomerID.Text);
            string customerName = textBoxCustomerName.Text;
            string customerAdress = textBoxCustomerAdress.Text;
            string customerPhone = textBoxCustomerPhone.Text;
            string supplerEmail = textBoxCustomerEmail.Text;
            string customerMoreInfo = textBoxCustomerMoreInfo.Text;
            DateTime contractDate = dtpCustomerContractDate.Value;
            
            if (CustomerDAO.Instance.UpdateCustomer(customerName, customerAdress, customerPhone, supplerEmail, customerMoreInfo, contractDate,customerID))
            {
                MessageBox.Show("Sửa thành công");
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(labelCustomerID.Text);

            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                if (CustomerDAO.Instance.DeleteCustomer(customerID))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadCustomer();
                }
                else
                {
                    MessageBox.Show("Có lỗi");
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
