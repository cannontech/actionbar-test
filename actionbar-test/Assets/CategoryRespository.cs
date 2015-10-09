using System.Collections.Generic;

namespace actionbartest
{
    public class CategoryRespository : ICategoryRespository
    {
        public CategoryRespository()
        {
        }
    
        public Category GetDrink(int id)
        {
            return new Category();
        }

        public List<Category> GetAll()
        {
            return new List<Category>();
        }

        public int SaveCategory(Category category)
        {
            return 1;
        }
    }
}

