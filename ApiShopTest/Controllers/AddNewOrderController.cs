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
    public class AddNewOrderController : ApiController
    {
        private ShopTestDBEntities db = new ShopTestDBEntities();

        [HttpGet]
        [Route("getInfoIsActiveOrder")]
        
        public IHttpActionResult getInfoIsActiveOrder(int Id)
        {
            var info = db.Orders.FirstOrDefault(i=>i.idUsers ==  Id && i.isActive==true);
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
        [Route("postNewOrder")]
        public IHttpActionResult PostNewOrder(int Id)
        {
            var add = db.Orders.FirstOrDefault(i => i.idUsers == Id&& i.isActive==true);
            var user =  Id;
            if (add==null)
            {
                Orders newOrder = new Orders();
                newOrder.orderDate = DateTime.Now;
                newOrder.idUsers = Id;
                newOrder.isActive = true;
                db.Orders.Add(newOrder);
                db.SaveChanges();
                
            }
           return Ok();
        }

    }
}
