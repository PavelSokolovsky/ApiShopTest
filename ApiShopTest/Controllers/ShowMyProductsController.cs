﻿using ApiShopTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ApiShopTest.Controllers
{
    public class ShowMyProductsController : ApiController
    {
        private ShopTestDBEntities db = new ShopTestDBEntities();

        [HttpGet]
        [Route("myProducts")]
        [ResponseType(typeof(Responce.ResponceUsersProducts))]
        public IHttpActionResult ShowMyProducts(int idUser)
        {
            List<ProductsView> products = db.ProductsView.Where(i => i.idUsers == idUser).ToList();

            if (products == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(products.ConvertAll<Responce.ResponceProductsView>(i => new Responce.ResponceProductsView(i)));
            }
        }
    }
}
