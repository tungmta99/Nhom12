using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QLKhachSanVui
{
    public partial class FormBaoCao : Form
    {
        public FormMain frmMain;
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            //reportViewer1.Reset();
            //SqlCommand cmd = new SqlCommand("DSHoaDon", DataBase.GetConnection());
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable tb = new DataTable();
            //adapter.Fill(tb);

            //this.reportViewer1.RefreshReport();

            //reportViewer1.LocalReport.ReportPath = "BaoCao.rdlc";
            //reportViewer1.LocalReport.DataSources.Clear();
            //ReportDataSource newDataSource = new ReportDataSource("BaoCao", tb);
            //reportViewer1.LocalReport.DataSources.Add(newDataSource);
            //reportViewer1.RefreshReport();
        }
    }
}
