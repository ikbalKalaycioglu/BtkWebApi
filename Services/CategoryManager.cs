using Entites.Exceptions;
using Entites.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;

        public CategoryManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public async Task CreateAsync(Category category)
        {
            _manager.Category.CreateOneCategory(category);
            await _manager.SaveAsync();
        }

        public async Task DeleteAsync(Category category)
        {
            _manager.Category.DeleteOneCategory(category);
            await _manager.SaveAsync();
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges)
        {
            return await _manager.Category.GetAllCategoriesAsync(trackChanges);
        }

        public async Task<Category> GetOneCategoriesAsync(int id, bool trackChanges)
        {
            var category = await _manager.Category.GetOneCategoryByIdAsync(id, trackChanges);
            if(category is null)
                throw new CategoryNotFoundException(id);
            return category;
        }

        public async Task UpdateAsync(Category category)
        {
            _manager.Category.UpdateOneCategory(category);
            await _manager.SaveAsync();
        }
    }
}
