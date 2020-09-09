using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customers_DTO
    {
        public string Ct_id { get; set; }
        public string Ct_firstName { get; set; }
        public string Ct_lastName { get; set; }
        public string Ct_phone { get; set; }
        public string Ct_email { get; set; }
        public bool Ct_gender { get; set; }
        public string Ct_address { get; set; }
        public string Cp_tin { get; set; }
    }

}
