using ApiShopTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiShopTest.Responce
{
    public class ResponceProductsInOrder
    {
        public ResponceProductsInOrder(PriductsInOrders productsInOrders)
        {
            IdOrder = productsInOrders.idOrder;
            Product = productsInOrders.Products;
            AmountCurrent = productsInOrders.amountInOrder;
            

        }
        public int IdOrder;
        public Products Product;
        public int AmountCurrent;
    }
}