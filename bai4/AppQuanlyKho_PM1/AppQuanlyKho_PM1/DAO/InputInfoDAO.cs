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
    public class InputInfoDAO
    {
        private static InputInfoDAO instance;

        public static InputInfoDAO Instance { 
            get {if (instance == null) instance = new InputInfoDAO(); return InputInfoDAO.instance;}
            private set { InputInfoDAO.instance = value;  }
        }
        private InputInfoDAO() { }

        public List<Input> GetListInput()
        {
            List<Input> pList = new List<Input>();

            string query = "select * from Input";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Input input = new Input(item);
                pList.Add(input);
            }
            return pList;
        }

        public bool InsertInputInfo(string id, string supplyname, string idinput, int quantity, float inputprice, string status)
        {
            string query = string.Format("exec AddInputInfoByN '{0}',N'{1}','{2}',{3},{4},'{5}'", id, supplyname, idinput, quantity, inputprice, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateInputInfo(string id, string supplyname, string idinput, int quantity, float inputprice, string status, string idold)
        {

            string query = string.Format("exec UpdateInputInfoByN '{0}',N'{1}','{2}',{3},{4},'{5}','{6}'", id, supplyname, idinput, quantity, inputprice, status,idold);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteInputInfo(string ID)
        {

            string query = string.Format("delete InputInfo where ID='{0}'", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
