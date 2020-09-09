using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order_detail_DTO
    {
        public string Od_id { get; set; }
        public string Pd_id { get; set; }
        public int? Od_quantity { get; set; }
        public decimal? Od_price { get; set; }
    }

}
