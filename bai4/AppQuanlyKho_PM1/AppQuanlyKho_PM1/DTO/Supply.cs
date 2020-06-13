using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanlyKho_PM1.DTO
{
    public class Supply
    {
        public Supply(string displayname)
        {
            this.Displayname =displayname;
        }

        public Supply(DataRow row)
        {
            this.Displayname = row["Displayname"].ToString();
        }

        private string iD;
        private string displayname;
        private string idunit;
        private string idsupply;
        private string qrcode;
        private string barcode;
        private int stock;

        public string ID { get => iD; set => iD = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public string Idunit { get => idunit; set => idunit = value; }
        public string Idsupply { get => idsupply; set => idsupply = value; }
        public string Qrcode { get => qrcode; set => qrcode = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
