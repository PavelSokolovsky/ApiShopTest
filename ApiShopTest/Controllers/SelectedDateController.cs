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
    public class SelectedDateController : ApiController
    {
        private ShopTestDBEntities db = new ShopTestDBEntities();
        public class Data6
        {
            public int id { get; set; }
            public DateTime orderDate { get; set; }
            public int isActive { get; set; }

        }

        [HttpPost]
        [Route("selectedDate")]
        [ResponseType(typeof(Responce.ResponceOrders))]
        public IHttpActionResult ShowMyOrders([FromBody] Data6 data6)
        {
            List<Orders> orders = db.Orders.Where(i => i.idUsers == data6.id && i.orderDate == data6.orderDate).ToList();

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
