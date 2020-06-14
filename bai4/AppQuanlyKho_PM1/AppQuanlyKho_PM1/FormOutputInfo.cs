using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanlyKho_PM1.DAO;
using AppQuanlyKho_PM1.DTO;

namespace AppQuanlyKho_PM1
{
    public partial class FormOutputInfo : Form
    {
        BindingSource pList = new BindingSource();
        public FormOutputInfo()
        {
            InitializeComponent();

            LoadOutputInfo();

            LoadListSupply();

            LoadListCustomer();

            //LoadOutputList();

            AddBindingOuputInfo();
        }

        void LoadOutputInfo()
        {
            string query = "select * from OutputInfoView";

            dtgvOutputInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvOutputInfo.DataSource = pList;

            pList.DataSource=DataProvider.Instance.ExecuteQuery(query);

            string query2 = "select sum(Quantity) from OutputInfo";
            labelSumOuput.Text = DataProvider.Instance.ExecuteScalar(query2).ToString();
        }

        void AddBindingOuputInfo()
        {
            textBoxOutputInfoID.DataBindings.Add(new Binding("Text", dtgvOutputInfo.DataSource, "ID", true, DataSourceUpdateMode.Never));
            textBoxQuantity.DataBindings.Add(new Binding("Text", dtgvOutputInfo.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
            textBoxOutputPrice.DataBindings.Add(new Binding("Text", dtgvOutputInfo.DataSource, "Giá xuất", true, DataSourceUpdateMode.Never));
            textBoxStatus.DataBindings.Add(new Binding("Text", dtgvOutputInfo.DataSource, "Trạng Thái", true, DataSourceUpdateMode.Never));
            dtpOutputDate.DataBindings.Add(new Binding("Value", dtgvOutputInfo.DataSource, "Ngày xuất", true, DataSourceUpdateMode.Never));
            comboBoxSupplyName.DataBindings.Add(new Binding("Text", dtgvOutputInfo.DataSource, "Vật tư", true, DataSourceUpdateMode.Never));
            comboBoxCustomer.DataBindings.Add(new Binding("Text", dtgvOutputInfo.DataSource, "Khách hàng", true, DataSourceUpdateMode.Never));
            labelIDold.DataBindings.Add(new Binding("Text", dtgvOutputInfo.DataSource, "ID", true, DataSourceUpdateMode.Never));

        }

        void LoadListSupply()
        {
            List<Supply> SupplyList = SupplyDAO.Instance.GetListSupply();
            comboBoxSupplyName.DataSource = SupplyList;
            comboBoxSupplyName.DisplayMember = "Displayname";

        }

        void LoadListCustomer()
        {
            List<Customer> CustomerList = CustomerDAO.Instance.GetListCustomer();
            comboBoxCustomer.DataSource = CustomerList;
            comboBoxCustomer.DisplayMember = "Displayname";

        }

        void LoadOutputList()
        {
            List<Output> OuputList = OutputInfoDAO.Instance.GetListOutput();

            comboBoxOutputID.DataSource = OuputList;
            comboBoxOutputID.DisplayMember = "ID";

        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxOutputID.Text == "") MessageBox.Show("Bạn hãy chọn Mã IdOutput cần thêm trước");
            else
            {
                string id = textBoxOutputInfoID.Text;
                string idoutput = comboBoxOutputID.Text;
                string supplyname = comboBoxSupplyName.Text;
                string customername = comboBoxCustomer.Text;
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                float outputprice = (float)Convert.ToDouble(textBoxOutputPrice.Text);
                string status = textBoxStatus.Text;
                if (OutputInfoDAO.Instance.InsertOutputInfo(id, idoutput, supplyname, customername, quantity, outputprice, status))
                {
                    MessageBox.Show("Thêm thành công");

                    LoadOutputInfo();
                }

                else
                {
                    MessageBox.Show("Có lỗi khi thêm");
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxOutputID.Text == "") MessageBox.Show("Bạn hãy chọn Mã IdOutput cần thêm trước");
            else
            {
                string id = textBoxOutputInfoID.Text;
                string idoutput = comboBoxOutputID.Text;
                string supplyname = comboBoxSupplyName.Text;
                string customername = comboBoxCustomer.Text;
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                float outputprice = (float)Convert.ToDouble(textBoxOutputPrice.Text);
                string status = textBoxStatus.Text;
                string idold = labelIDold.Text;
                if (OutputInfoDAO.Instance.UpdateOutputInfo(id, idoutput, supplyname, customername, quantity, outputprice, status,idold))
                {
                    MessageBox.Show("Sửa thành công");

                    LoadOutputInfo();
                }

                else
                {
                    MessageBox.Show("Có lỗi khi sửa");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = labelIDold.Text;
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                if (OutputInfoDAO.Instance.DeleteOutputInfo(id))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadOutputInfo();

                }

                else
                {
                    MessageBox.Show("Có lỗi khi xóa");
                }
            }
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            FormOutput1 f = new FormOutput1();
            f.Show();
        }

        private void comboBoxOutputID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = String.Format("select * from OutputInfoView where IdOutput=N'{0}'", comboBoxOutputID.Text);

            dtgvOutputInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvOutputInfo.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void comboBoxOutputID_MouseClick(object sender, MouseEventArgs e)
        {
            LoadOutputList();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            FormOutput1 f = new FormOutput1();
            f.Show();
        }
    }
}
