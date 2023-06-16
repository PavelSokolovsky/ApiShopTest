using ApiShopTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Razor.Tokenizer;
using static ApiShopTest.Controllers.ChangeAmountProductController;

namespace ApiShopTest.Controllers
{
    public class CheckOrderController : ApiController
    {
        private ShopTestDBEntities db = new ShopTestDBEntities();

        [HttpGet]
        [Route("getInfoCheckOrder")] 
        public IHttpActionResult getInfoCheckOrder(int Id)
        {
            var info = db.UsersProducts.FirstOrDefault(i => i.idUsers == Id && i.amountMin==i.amountCurrent);
            if (info != null)
            {
                return Ok();
            }   
            else
            {
                return NotFound();
            }
        }


        [HttpPost]
        [Route("checkOrder")]
        public IHttpActionResult CheckOrder(int Id)
        {
            var isActive = db.Orders.FirstOrDefault(i => i.isActive == true && i.idUsers == Id);
            var minValue = db.UsersProducts.FirstOrDefault(i => i.amountCurrent == i.amountMin && i.idUsers== Id);
            var anyToBuy = db.UsersProducts.Where(i => i.amountMAX > i.amountCurrent && i.idUsers == Id);
            if (minValue != null&&isActive!=null)
            { 
                if(anyToBuy != null)
                {
                    foreach (var item in anyToBuy)
                    {

                        if (item.amountCurrent < item.amountMAX)
                        {
                            int toAdd = item.amountMAX - item.amountCurrent;
                            PriductsInOrders priductsInOrders = new PriductsInOrders();
                            priductsInOrders.amountInOrder = toAdd;
                            priductsInOrders.idOrder = isActive.id;
                            priductsInOrders.idProducts = item.idProducts;
                            db.PriductsInOrders.Add(priductsInOrders);

                        }

                    }
                    isActive.isActive = false;

                    foreach (var item in anyToBuy)
                    {
                        item.amountCurrent = item.amountMAX;

                    }
                    db.SaveChanges();
                }

            }
            return Ok();
        }

    }
}
