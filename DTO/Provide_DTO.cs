using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Provide_DTO
    {
        public string Pr_id { get; set; }
        public string Sp_id { get; set; }
        public string Ag_id { get; set; }
        public DateTime? Pr_date { get; set; }
        public decimal? Pr_deliveryCost { get; set; }
    }
}
