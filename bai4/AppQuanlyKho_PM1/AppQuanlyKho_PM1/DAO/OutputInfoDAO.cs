using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanlyKho_PM1.DTO;

namespace AppQuanlyKho_PM1.DAO
{
    public class OutputInfoDAO
    {
        private static OutputInfoDAO instance;

        public static OutputInfoDAO Instance
        {
            get { if (instance == null) instance = new OutputInfoDAO(); return OutputInfoDAO.instance; }
            private set { OutputInfoDAO.instance = value; }
        }
        private OutputInfoDAO() { }

        public List<Output> GetListOutput()
        {
            List<Output> pList = new List<Output>();

            string query = "select * from Outputs";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Output output = new Output(item);
                pList.Add(output);
            }
            return pList;
        }

        public bool InsertOutputInfo(string id,string idoutput,string supplyname,string customername,int quantity,float outputprice,string status)
        {
            string query = string.Format("exec AddOutputInfoByN '{0}','{1}',N'{2}',N'{3}',{4},{5},'{6}'", id,idoutput,supplyname, customername, quantity, outputprice, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateOutputInfo(string id, string idoutput, string supplyname, string customername, int quantity, float outputprice, string status,string idold)
        {

            string query = string.Format("exec UpdateOutputInfoByN '{0}','{1}',N'{2}',N'{3}',{4},{5},'{6}','{7}'", id, idoutput, supplyname, customername, quantity, outputprice, status,idold);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteOutputInfo(string ID)
        {

            string query = string.Format("delete OutputInfo where ID='{0}'", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
