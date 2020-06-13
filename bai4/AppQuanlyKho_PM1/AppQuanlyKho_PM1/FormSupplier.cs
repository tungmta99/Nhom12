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

            AddBingdingSupplier();
        }

        void LoadSupplier()
        {
            string query = "select ID,Displayname as[Tên],Adress as[Địa chỉ],Phone as[SDT],Email,MoreInfo as[Khác],ContractDate as[Ngày hợp tác] from Supplier";

            dtgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvSupplier.DataSource = SupplierList;

            SupplierList.DataSource = DataProvider.Instance.ExecuteQuery(query);


        }

        void AddBingdingSupplier()
        {   
            textBoxSupplierName.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            textBoxSupplierAdress.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            textBoxSupplierEmail.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "Email", true, DataSourceUpdateMode.Never));
            Binding bindingsupplierphone = textBoxSupplierPhone.DataBindings.Add("Text", dtgvSupplier.DataSource, "SDT", true, DataSourceUpdateMode.Never); bindingsupplierphone.NullValue = "No one";
            //Binding bindingsuppliermoreinfo = textBoxSupplierMoreInfo.DataBindings.Add("Text", dtgvSupplier.DataSource, "Khác", true); bindingsuppliermoreinfo.NullValue = "Không có";
            // textBoxSupplierMoreInfo.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "Thêm", false, DataSourceUpdateMode.Never));
            textBoxSupplierMoreInfo.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "Khác", true, DataSourceUpdateMode.Never));
            dtpSupplierContract.DataBindings.Add(new Binding("Value", dtgvSupplier.DataSource, "Ngày hợp tác", true, DataSourceUpdateMode.Never));
            labeIdSupplier.DataBindings.Add(new Binding("Text", dtgvSupplier.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            string supplierName = textBoxSupplierName.Text;
            string supplierAdress = textBoxSupplierAdress.Text;
            string suplierPhone = textBoxSupplierPhone.Text;
            string supplerEmail = textBoxSupplierEmail.Text;
            string supplierMoreInfo = textBoxSupplierMoreInfo.Text;
            DateTime contractDate = dtpSupplierContract.Value;

            if (SupplierDAO.Instance.InsertSupplier(supplierName,supplierAdress,suplierPhone,supplerEmail,supplierMoreInfo,contractDate))
            {
                MessageBox.Show("Thêm thành công");
                LoadSupplier();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int idSupplier = Convert.ToInt32(labeIdSupplier.Text);
            string supplierName = textBoxSupplierName.Text;
            string supplierAdress = textBoxSupplierAdress.Text;
            string suplierPhone = textBoxSupplierPhone.Text;
            string supplerEmail = textBoxSupplierEmail.Text;
            string supplierMoreInfo = textBoxSupplierMoreInfo.Text;
            DateTime contractDate = dtpSupplierContract.Value;

            if (SupplierDAO.Instance.UpdateSupplier(supplierName, supplierAdress, suplierPhone, supplerEmail, supplierMoreInfo, contractDate,idSupplier))
            {
                MessageBox.Show("Sửa thành công");
                LoadSupplier();
            }
            else
            {
                MessageBox.Show("Có lỗi");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                int idSupplier = Convert.ToInt32(labeIdSupplier.Text);

                if (SupplierDAO.Instance.DeleteSupplier(idSupplier))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadSupplier();
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
