using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Order_detail_DTO
    {
        public string Pd_name { get; set; }
        public string Od_id { get; set; }
        public string Pd_id { get; set; }
        public int Od_quantity { get; set; }
        public decimal Od_price { get; set; }

        public override string ToString()
        {
            return Pd_id+ " - " + Pd_name + " - " + Od_price.ToString("#,##0");
        }
        public Order_detail_DTO(string Pd_id, string Pd_name, decimal Od_price)
        {
            this.Pd_id = Pd_id;
            this.Pd_name = Pd_name;
            this.Od_price = Od_price;
            Od_quantity = 1;
        }
    }

}
