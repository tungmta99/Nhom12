using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanlyKho_PM1.DTO;

namespace AppQuanlyKho_PM1.DAO
{
    public class SupplyDAO
    {
        private static SupplyDAO instance;

        public static SupplyDAO Instance
        {
            get { if (instance == null) instance = new SupplyDAO(); return SupplyDAO.instance; }
            private set { SupplyDAO.instance = value; }
        }

        private SupplyDAO() { }

        public List<Supply> GetListSupply()
        {
            List<Supply> pList = new List<Supply>();

            string query = "select * from Supply";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Supply supply = new Supply(item);
                pList.Add(supply);
            }

            return pList;
        }

        public bool InsertSupply(string id, string displayname, string unitname, string supplyname, string qrcode, string barcode)
        {
            string query = string.Format("exec AddSupplyByN '{0}',N'{1}',N'{2}',N'{3}','{4}','{5}'", id, displayname, unitname, supplyname, qrcode, barcode);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateSupply(string id, string displayname, string unitname, string supplyname, string qrcode, string barcode, string idold)
        {

            string query = string.Format("exec UpdateSupplyByN '{0}',N'{1}',N'{2}',N'{3}','{4}','{5}',{6}", id, displayname, unitname, supplyname, qrcode, barcode, idold);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteSupply(string ID)
        {

            string query = string.Format("delete Supply where ID='{0}'", ID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
