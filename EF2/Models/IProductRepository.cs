using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF2.Models
{
    public interface IProductRepository
    {
        Product GetById(int productid);
        IQueryable<Product> Products { get; }
        void CreateProduct(Product product);
        void UptadeProduct(Product product);
        void DeleteProduct(int productid);
       
    }
}
