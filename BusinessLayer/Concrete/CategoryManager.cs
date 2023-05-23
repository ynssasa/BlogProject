using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository categoryRepository;

        public CategoryManager()
        {
            categoryRepository = new EfCategoryRepository();
        }
        public void Add(Category category)
        {
            categoryRepository.Add(category);
        }

        public List<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return categoryRepository.GetById(id);
        }

        public void Remove(Category category)
        {
            categoryRepository.Delete(category);
        }

        public void Update(Category category)
        {
            categoryRepository.Update(category);
        }
    }
}
