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
using AppQuanlyKho_PM1.DTO;

namespace AppQuanlyKho_PM1
{
    public partial class FormSupply : Form
    {
        BindingSource pList = new BindingSource();
        public FormSupply()
        {

            InitializeComponent();

            LoadSupply();

            AddBindingSupply();

            LoadUnitList();

            LoadSupplierList();

            textBoxBarCode.Text = comboBoxUnitName.SelectedIndex.ToString();
        }

        void LoadSupply()
        {
            string query = "select * from SupplyView";

            dtgvSupply.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvSupply.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);

            
        }

        void LoadUnitList()
        {
            List<Unit> listUnit = UnitDAO.Instance.GetListUnit();
            comboBoxUnitName.DataSource = listUnit;
            comboBoxUnitName.DisplayMember = "UnitName";           
        }

        void LoadSupplierList()
        {
            List<Supplier> listSupplier = SupplierDAO.Instance.GetListSupplier();
            comboBoxSupplierName.DataSource = listSupplier;
            comboBoxSupplierName.DisplayMember = "Displayname";
        }


        void AddBindingSupply()
        {
            textBoxSupplyID.DataBindings.Add(new Binding("Text", dtgvSupply.DataSource, "ID", true, DataSourceUpdateMode.Never));
            textBoxSupplyName.DataBindings.Add(new Binding("Text", dtgvSupply.DataSource, "Vật tư", true, DataSourceUpdateMode.Never));
            comboBoxUnitName.DataBindings.Add(new Binding("Text", dtgvSupply.DataSource, "Đơn vị", true, DataSourceUpdateMode.Never));
            comboBoxSupplierName.DataBindings.Add(new Binding("Text", dtgvSupply.DataSource, "Nhà cung cấp", true, DataSourceUpdateMode.Never));
            textBoxQRCode.DataBindings.Add(new Binding("Text", dtgvSupply.DataSource, "QRcode", true, DataSourceUpdateMode.Never));
            textBoxBarCode.DataBindings.Add(new Binding("Text", dtgvSupply.DataSource, "Barcode", true, DataSourceUpdateMode.Never));
            labelIDold.DataBindings.Add(new Binding("Text", dtgvSupply.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id= textBoxSupplyID.Text;
            string supplyname = textBoxSupplyName.Text;
            string unitname = comboBoxUnitName.Text;
            string suppliername = comboBoxSupplierName.Text;
            string qrcode = textBoxQRCode.Text;
            string barcode = textBoxBarCode.Text;
            if (SupplyDAO.Instance.InsertSupply(id,supplyname,unitname,suppliername,qrcode,barcode))
            {
                MessageBox.Show("Thêm thành công");

                LoadSupply();
            }

            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string id = textBoxSupplyID.Text;
            string supplyname = textBoxSupplyName.Text;
            string unitname = comboBoxUnitName.Text;
            string suppliername = comboBoxSupplierName.Text;
            string qrcode = textBoxQRCode.Text;
            string barcode = textBoxBarCode.Text;
            string idold = labelIDold.Text;
            if (SupplyDAO.Instance.UpdateSupply(id, supplyname, unitname, suppliername, qrcode, barcode,idold))
            {
                MessageBox.Show("Sửa thành công");

                LoadSupply();
            }

            else
            {
                MessageBox.Show("Có lỗi khi sửa");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = labelIDold.Text;
            if (MessageBox.Show("Bạn có thật sự muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                if (SupplyDAO.Instance.DeleteSupply(id))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadSupply();

                }

                else
                {
                    MessageBox.Show("Có lỗi khi xóa");
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
