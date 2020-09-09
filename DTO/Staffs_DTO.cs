using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staffs_DTO
    {
        public string St_id { get; set; }
        public string St_password { get; set; }
        public string St_firstName { get; set; }
        public string St_lastName { get; set; }
        public string St_phone { get; set; }
        public string St_email { get; set; }
        public bool St_gender { get; set; }
        public int St_workdays { get; set; }
        public DateTime St_birthday { get; set; }
        public decimal St_salary { get; set; }
        public int St_role { get; set; }
        public string Ag_id { get; set; }
    }
}
