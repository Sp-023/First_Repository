using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebcoreApi.Models.Services
{
    public class ProductService : IProduct
    {
       public  ProductDetailsContext context;
        public ProductService( ProductDetailsContext cc)
        {
            context = cc;
        }

        public ProductDt AddProduct(ProductDt prod)
        {
            context.ProductDt.Add(prod);
            context.SaveChanges();
            return prod;
        }

        public ProductDt DeleteProduct(int id)
        {
            var ded = context.ProductDt.Find(id);
            context.ProductDt.Remove(ded);
            context.SaveChanges();
            return ded;
        }

        public IEnumerable<ProductDt> GetAll()
        {
            return context.ProductDt.ToList();
            
        }

        public ProductDt UpdateProduct(ProductDt prod)
        {
            context.Entry(prod).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return prod;
        }
    }
}
