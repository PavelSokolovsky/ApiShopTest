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
    public class ProductsInOrdersController : ApiController
    {
        private ShopTestDBEntities db = new ShopTestDBEntities();
        public class Data5
        {
            public int id { get; set; }
            

        }

        [HttpPost]
        [Route("productsInOrders")]
        [ResponseType(typeof(Responce.ResponceProductsInOrder))]
        public IHttpActionResult ProductsInOrders([FromBody] Data5 data5)
        {
            List<PriductsInOrders> products = db.PriductsInOrders.Where(i => i.idOrder == data5.id).ToList();

            if (products == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(products.ConvertAll<Responce.ResponceProductsInOrder>(i => new Responce.ResponceProductsInOrder(i)));
            }
        }
    }
}
