using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Provide_detail_DTO
    {
        public string Pr_id { get; set; }
        public string Pd_id { get; set; }
        public int? Prd_quantity { get; set; }
        public decimal? Prd_purchase { get; set; }
    }
}
