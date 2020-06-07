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
    public partial class FormUser : Form
    {
        BindingSource pList = new BindingSource();
        public FormUser()
        {
            InitializeComponent();

            LoadUser();

            LoadRoleList();

            AddBindingUser();

        }

        void LoadUser()
        {
            string query = "select Users.ID as [ID],Users.DisplayName as[Tên hiển thị],UserName as[Tên],Password as[Mật khẩu],UserRole.DisplayName as [Quyền] from Users,UserRole where Users.IdRole=UserRole.ID";

            dtgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtgvUser.DataSource = pList;

            pList.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        void LoadRoleList()
        {
            List<Role> listRole = RoleDAO.Instance.GetListRole();
            comboBoxRole.DataSource = listRole;
            comboBoxRole.DisplayMember = "RoleName";
        }

        void AddBindingUser()
        {
            textBoxUserDisplayName.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
            textBoxUserName.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Tên", true, DataSourceUpdateMode.Never));
            textBoxPassWord.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Mật khẩu", true, DataSourceUpdateMode.Never));
            comboBoxRole.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "Quyền", true, DataSourceUpdateMode.Never));
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
