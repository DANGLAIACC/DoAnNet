﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Orders_BLL
    {
        public static List<Orders_DTO> LoadOrders()
        {
            return Orders_DAL.LoadOrders();
        }
    }
}