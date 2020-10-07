using System;
using System.Collections.Generic;
using Entity;

namespace Service
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Insert(Category model);
        void Update(Category model);
        void Delete(Category model);
    }
}
