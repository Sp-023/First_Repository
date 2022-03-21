using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebcoreApi.Models;
using WebcoreApi.Models.Services;

namespace WebApicore.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct con;
        public ProductController(IProduct cc)
        {
            con = cc;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Product")]
        public IEnumerable<ProductDt> GetAll()
        {
            return con.GetAll();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Product")]
        public ProductDt AddProduct(ProductDt pp)
        {
            return con.AddProduct(pp);
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/Product")]
        public ProductDt UpdateProduct(ProductDt up)
        {
            return con.UpdateProduct(up);
        }
        [HttpDelete]
        
        public ProductDt DeleteProduct(int id)
        {
            return con.DeleteProduct(id);
        }
    }
}
