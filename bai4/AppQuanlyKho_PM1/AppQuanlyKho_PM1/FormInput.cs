using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using AppQuanlyKho_PM1.DAO;
using AppQuanlyKho_PM1.DTO;

namespace AppQuanlyKho_PM1
{
    public partial class FormInput : Form
    {
        BindingSource pList = new BindingSource();
        public FormInput()
        {
            InitializeComponent();

            LoadInputInfo();

            LoadListSupply();

            AddBingdingInputInfo();

            //LoadInputList();
        }

        void LoadInputInfo()
        {
            string query = String.Format("select * from InputInfoView",comboBoxInputID.Text);

            dtgvInputInfor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvInputInfor.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);


        }

        void LoadListSupply()
        {
            List<Supply> SupplyList = SupplyDAO.Instance.GetListSupply();
            comboBoxSupplyName.DataSource = SupplyList;
            comboBoxSupplyName.DisplayMember = "Displayname";

        }

        void AddBingdingInputInfo()
        {
            textBoxInputInfoID.DataBindings.Add(new Binding("Text", dtgvInputInfor.DataSource, "ID", true, DataSourceUpdateMode.Never));
            textBoxQuantity.DataBindings.Add(new Binding("Text", dtgvInputInfor.DataSource, "Số lượng", true, DataSourceUpdateMode.Never));
            textBoxInputPrice.DataBindings.Add(new Binding("Text", dtgvInputInfor.DataSource, "Giá nhập", true, DataSourceUpdateMode.Never));
            textBoxStatus.DataBindings.Add(new Binding("Text", dtgvInputInfor.DataSource, "Trạng thái", true, DataSourceUpdateMode.Never));
            comboBoxSupplyName.DataBindings.Add(new Binding("Text", dtgvInputInfor.DataSource, "Vật tư", true, DataSourceUpdateMode.Never));
            dtpInput.DataBindings.Add(new Binding("Value", dtgvInputInfor.DataSource, "Ngày nhập", true, DataSourceUpdateMode.Never));
            labelIDold.DataBindings.Add(new Binding("Text", dtgvInputInfor.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }

        void LoadInputList()
        {
            List<Input> InputList = InputInfoDAO.Instance.GetListInput();

            comboBoxInputID.DataSource = InputList;
            comboBoxInputID.DisplayMember = "ID";
            
        }

        private void comboBoxInputID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = String.Format("select * from InputInfoView where IdInput =N'{0}'", comboBoxInputID.Text);

            dtgvInputInfor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvInputInfor.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        private void comboBoxInputID_MouseClick(object sender, MouseEventArgs e)
        {
            LoadInputList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxInputID.Text == "") MessageBox.Show("Bạn hãy chọn Mã IdInput cần thêm trước");
            else
            {
                string id = textBoxInputInfoID.Text;
                string supplyname = comboBoxSupplyName.Text;
                string idinput = comboBoxInputID.Text;
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                float inputprice = (float)Convert.ToDouble(textBoxInputPrice.Text);
                string status = textBoxStatus.Text;
                if (InputInfoDAO.Instance.InsertInputInfo(id,supplyname,idinput,quantity,inputprice,status))
                {
                    MessageBox.Show("Thêm thành công");

                    LoadInputInfo();
                }

                else
                {
                    MessageBox.Show("Có lỗi khi thêm");
                }
            }    
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxInputID.Text == "") MessageBox.Show("Bạn hãy chọn Mã IdInput cần thêm trước");
            else
            {
                string id = textBoxInputInfoID.Text;
                string supplyname = comboBoxSupplyName.Text;
                string idinput = comboBoxInputID.Text;
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                float inputprice = (float)Convert.ToDouble(textBoxInputPrice.Text);
                string status = textBoxStatus.Text;
                string idold = labelIDold.Text;
                if (InputInfoDAO.Instance.UpdateInputInfo(id, supplyname, idinput, quantity, inputprice, status,idold))
                {
                    MessageBox.Show("Sửa thành công");

                    LoadInputInfo();
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
                if (InputInfoDAO.Instance.DeleteInputInfo(id))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadInputInfo();

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

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {

        }
    }
}
