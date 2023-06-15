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
    public class DefaultController : ApiController
    {
        private ShopTestDBEntities db = new ShopTestDBEntities();
        public class Data
        {
            public string Login { get; set; }

            public string Password { get; set; }

        }

        [HttpPost]  
        [Route("auth")]
        [ResponseType(typeof(Responce.ResponceUsers))]
        
        public IHttpActionResult Authorizaton([FromBody] Data data)
        {
            var user = db.Users.FirstOrDefault(i => i.login == data.Login  && i.password == data.Password);

            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(new Responce.ResponceUsers(user));
            }
        }
    }
}
