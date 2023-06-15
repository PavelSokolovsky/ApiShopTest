using ApiShopTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiShopTest.Responce
{
    public partial class ResponceUsersProducts
    {
        public ResponceUsersProducts(UsersProducts usersProducts)
        {
           idUsers = usersProducts.idUsers;
           idroducts = usersProducts.idProducts;
           AmountMax = usersProducts.amountMAX;
           AmountMin = usersProducts.amountMin;
           AmountCurrent = usersProducts.amountCurrent;
        }
        public int idUsers;
        public int idroducts;
        public int AmountMax;
        public int AmountMin;
        public int AmountCurrent;
        
    }
}