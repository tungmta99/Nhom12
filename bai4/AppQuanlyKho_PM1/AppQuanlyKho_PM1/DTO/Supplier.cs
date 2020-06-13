using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanlyKho_PM1.DTO
{
    public class Supplier
    {
        public Supplier(string displayname)
        {
            this.Displayname = displayname;
        }

        public Supplier(DataRow row)
        {
            this.Displayname = row["Displayname"].ToString();
        }
        private int iD;
        private string displayname;
        private string adress;
        private string phone;
        private string email;
        private string moreinfo;
        private DateTime contractdate;

        public int ID { get => iD; set => iD = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Moreinfo { get => moreinfo; set => moreinfo = value; }
        public DateTime Contractdate { get => contractdate; set => contractdate = value; }
    }
}
