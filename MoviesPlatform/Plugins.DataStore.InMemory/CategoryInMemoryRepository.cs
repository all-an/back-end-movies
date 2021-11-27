using CoreActions;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

// Movie categories class and inmemory datastore

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public CategoryInMemoryRepository()
        {
            // default movie categories
            categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "Biographical"},
                new Category { CategoryId = 2, Name = "Sci-Fi" },
            };
        }

        public void AddCategory(Category category)
        {
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            try
            {
                return;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null reference");
            }
            var maxId = categories.Max(x => x.CategoryId);
            category.CategoryId = maxId + 1;

            categories.Add(category); 
        }

        public void UpdateCategory(Category category)
        {
            var categoryToUpdate = GetCategoryById(category.CategoryId);
            if (categoryToUpdate != null) categoryToUpdate = category;
        
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int CategoryId)
        {
            return categories?.FirstOrDefault(x => x.CategoryId == CategoryId);
        }
    }
}
