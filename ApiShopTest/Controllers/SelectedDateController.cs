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
    
        [HttpGet]
        [Route("selectedDate")]

        public IHttpActionResult ShowMyOrders(int Id, DateTime orderDate)
        {
            List<Orders> orderss = db.Orders.Where(i => i.idUsers == Id && i.orderDate == orderDate).ToList();

            if (orderss == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(orderss.ConvertAll<Responce.ResponceOrders>(i => new Responce.ResponceOrders(i)));
            }
        }
    }
}
