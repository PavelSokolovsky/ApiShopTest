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
        public class Data3
        {
            public int id { get; set; }
            public DateTime orderDate { get; set; }
            public int isActive { get; set; }

        }

        [HttpPost]
        [Route("myOrders")]
        [ResponseType(typeof(Responce.ResponceOrders))]
        public IHttpActionResult ShowMyOrders([FromBody] Data3 data3)
        {
            List<Orders> orders = db.Orders.Where(i => i.idUsers == data3.id).ToList();

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
