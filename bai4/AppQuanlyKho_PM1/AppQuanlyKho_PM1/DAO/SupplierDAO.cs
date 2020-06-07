using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanlyKho_PM1.DTO;

namespace AppQuanlyKho_PM1.DAO
{
    public class SupplierDAO
    {
        private static SupplierDAO instance;

        public static SupplierDAO Instance


        {
            get { if (instance == null) instance = new SupplierDAO(); return SupplierDAO.instance; }
            private set { SupplierDAO.instance = value; }
        }

        private SupplierDAO() { }

        public List<Supplier> GetListSupplier()
        {
            List<Supplier> pList = new List<Supplier>();

            string query = "select * from Supplier";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Supplier supplier = new Supplier(item);
                pList.Add(supplier);
            }

            return pList;
        }

        public bool InsertSupplier(string supplierName,string adress,string phone, string email, string moreInfo, DateTime contractDate)
        {
            string query = String.Format("insert into Supplier values(N'{0}',N'{1}','{2}','{3}','{4}','{5}-{6}-{7}')", supplierName,adress,phone,email,moreInfo,contractDate.Month,contractDate.Day,contractDate.Year);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateSupplier(string supplierName, string adress, string phone, string email, string moreInfo, DateTime contractDate,int id)
        {
            string query = String.Format("update Supplier set Displayname=N'{0}',Adress=N'{1}',Phone='{2}',Email='{3}',MoreInfo=N'{4}',Contractdate='{5}-{6}-{7}' where ID={8}", supplierName, adress, phone, email, moreInfo, contractDate.Month, contractDate.Day, contractDate.Year,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteSupplier(int id)
        {
            string query = String.Format("delete Supplier where ID='{0}'",id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
