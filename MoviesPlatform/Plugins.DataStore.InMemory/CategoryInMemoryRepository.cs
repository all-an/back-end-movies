using CoreActions;
using System;
using System.Collections.Generic;
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
                new Category { CategoryId = 1, Name = "Biographical", Description = "Biography"},
                new Category { CategoryId = 2, Name = "Sci-Fi", Description = "Science Fiction"},
            };
        }
        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }
    }
}
