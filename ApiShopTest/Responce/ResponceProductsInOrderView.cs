using ApiShopTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiShopTest.Responce
{
    public partial class ResponceProductsInOrderView
    {
        public ResponceProductsInOrderView(ProductsInOrderView productsInOrderView)
        {
            idUsers = productsInOrderView.idUsers;
            id = productsInOrderView.id;
            Name = productsInOrderView.name;
            AmountInOrder = productsInOrderView.amountInOrder;
            
        }
        public string Name;
        public int id;
        public int AmountInOrder;
        public int idUsers;
    }
}