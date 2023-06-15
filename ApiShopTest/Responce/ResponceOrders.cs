using ApiShopTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiShopTest.Responce
{
    public partial class ResponceOrders
    {
        public ResponceOrders(Orders orders)
        {
            id = orders.id;
            idUsers = orders.idUsers;
            OrderDate = orders.orderDate;
            IsActive = orders.isActive;
            
        }
        public int id;
        public int idUsers;
        public DateTime OrderDate;
        public bool IsActive;
        
    }
}