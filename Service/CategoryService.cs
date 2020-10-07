using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        private IRepository<Category> categroyRepository;

        public CategoryService(IRepository<Category> categroyRepository)
        {
            this.categroyRepository = categroyRepository;
        }
        public List<Category> GetAll()
        {
            return categroyRepository.GetAll().ToList();
        }

        public Category GetById(int id)
        {
            if (id == 0)
                return null;
            return categroyRepository.GetById(id);
        }

        public void Insert(Category model)
        {
            if (model == null)
                throw new ArgumentNullException("category");
            categroyRepository.Insert(model);
        }

        public void Update(Category model)
        {
            if (model == null)
                throw new ArgumentNullException("category");
            categroyRepository.Update(model);

        }

        public void Delete(Category model)
        {
            if (model == null)
                throw new ArgumentNullException("category");
            categroyRepository.Delete(model);
        }
    }
}
