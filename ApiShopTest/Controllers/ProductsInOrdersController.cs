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
            public int idOrder { get; set; }
            

        }

        [HttpPost]
        [Route("productsInOrders")]
        [ResponseType(typeof(Responce.ResponceProductsInOrderView))]
        public IHttpActionResult ProductsInOrders([FromBody] Data5 data5)
        {
            List<ProductsInOrderView> productsInOrderView = db.ProductsInOrderView.Where(i => i.id == data5.idOrder && i.idUsers == data5.id).ToList();

            if (productsInOrderView == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(productsInOrderView.ConvertAll<Responce.ResponceProductsInOrderView>(i => new Responce.ResponceProductsInOrderView(i)));
            }
        }
    }
}
