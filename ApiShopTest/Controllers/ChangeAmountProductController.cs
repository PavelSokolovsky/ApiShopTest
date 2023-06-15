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
    public class ChangeAmountProductController : ApiController
    {
        public class Data2
        {
            public int Id { get; set; }
            public string barcode { get; set; }
            public int amountMax { get; set; }
            public int amountMin { get; set; }

        }
        private ShopTestDBEntities db = new ShopTestDBEntities();
        [HttpPut]
        [Route("changeAmount")]
        [ResponseType(typeof(Responce.ResponceUsersProducts))]
        public IHttpActionResult ChangeMyProducts([FromBody] Data2 data1)
        {

            var client = db.UsersProducts.FirstOrDefault(i => i.idUsers == data1.Id && i.Products.barCode == data1.barcode);
            if (client != null)
            {
                client.amountMin = data1.amountMin;
                client.amountMAX = data1.amountMax;
                db.SaveChanges();
                return StatusCode(HttpStatusCode.NoContent);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
