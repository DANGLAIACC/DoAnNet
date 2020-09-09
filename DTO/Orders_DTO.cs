using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Orders_DTO
    {
        public string Od_id { get; set; }
        public DateTime? Od_dateOrder { get; set; }
        public DateTime? Od_dateDelivery { get; set; }
        public int? Od_status { get; set; }
        public string Od_address { get; set; }
        public string Od_payment { get; set; }
        public string St_id { get; set; }
        public string Ct_id { get; set; }
        public string Ag_id { get; set; }
    }
}
