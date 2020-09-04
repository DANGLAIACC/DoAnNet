using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhaSX
    {
        /// <summary>
        /// Load thông tin chi tiết tất cả nhà sản xuất
        /// </summary>
        /// <returns></returns>
        public static List<DTO_NhaSX> LoadNhaSX()
        {
            string query = @"select * from nhasx";
            DataTable table = new DataTable();
            table = DataProvider.Execute(query);
            int count = table.Rows.Count;
            if (table != null && count > 0)
            {
                List<DTO_NhaSX> lstNhaSX = new List<DTO_NhaSX>();
                DTO_NhaSX nhaSX;
                for (int i = 0; i < count; i++)
                {
                    nhaSX = new DTO_NhaSX();
                    nhaSX.Ma_nsx = Int32.Parse(table.Rows[i]["Ma_nsx"].ToString());
                    nhaSX.Ten_nsx = table.Rows[i]["Ten_nsx"].ToString();
                    nhaSX.Nuoc_sx = table.Rows[i]["Nuoc_sx"].ToString();
                    lstNhaSX.Add(nhaSX);
                }
                return lstNhaSX;
            }
            return null;
        }
    }
}
