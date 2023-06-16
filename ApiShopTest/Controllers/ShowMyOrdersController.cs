using ApiShopTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ApiShopTest.Controllers
{
    public class ShowMyOrdersController : ApiController
    {
        private ShopTestDBEntities db = new ShopTestDBEntities();

        [HttpGet]
        [Route("myOrders")]
        
        public IHttpActionResult ShowMyOrders(int Id)
        {
            List<Orders> orders = db.Orders.Where(i => i.idUsers == Id).ToList();

            if (orders == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(orders.ConvertAll<Responce.ResponceOrders>(i => new Responce.ResponceOrders(i)));
            }
        }
    }
}
