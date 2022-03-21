using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebcoreApi.Models.Services
{
   public  interface IProduct
    {
        public IEnumerable<ProductDt> GetAll();
        ProductDt AddProduct(ProductDt prod);
        ProductDt UpdateProduct(ProductDt prod);
        ProductDt DeleteProduct(int id);
       
    }
}
