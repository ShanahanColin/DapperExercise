using System;
using System.Collections.Generic;

namespace DapperClass
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

    }
}
