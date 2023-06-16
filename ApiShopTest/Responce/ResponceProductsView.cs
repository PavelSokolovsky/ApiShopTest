using ApiShopTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiShopTest.Responce
{
    public partial class ResponceProductsView
    {
        public ResponceProductsView(ProductsView productsView)
        {
            idUsers = productsView.idUsers;
            id = productsView.id;
            Name = productsView.name;
            AmountMax = productsView.amountMAX;
            AmountMin = productsView.amountMin;
            AmountCurrent = productsView.amountCurrent;
        }
        public string Name;
        public int id;
        public int AmountMax;
        public int AmountCurrent;
        public int AmountMin;
        public int idUsers;
        
    }
}