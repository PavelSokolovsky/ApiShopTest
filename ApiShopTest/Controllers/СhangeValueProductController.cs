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
    public class СhangeValueProductController : ApiController
    {
        public class Data1
        {
            public int id { get; set; }

        }
        private ShopTestDBEntities db = new ShopTestDBEntities();
        [HttpPut]
        [Route("changeValue")]
        [ResponseType(typeof(Responce.ResponceUsersProducts))]
        public IHttpActionResult ChangeMyProducts([FromBody] Data1 data1 , string barcode)
        {

            var client = db.UsersProducts.FirstOrDefault(i => i.idUsers == data1.id  && i.Products.barCode == barcode);
            client.amountCurrent = client.amountCurrent - 1;
            db.SaveChanges();   
            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}
