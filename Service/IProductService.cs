using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Service
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(Int64 id);
        void Insert(Product model);
        void Update(Product model);
        void Delete(Product model);
    }
}
