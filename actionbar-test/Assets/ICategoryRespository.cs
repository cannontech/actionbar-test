using System.Collections.Generic;

namespace actionbartest
{
    public interface ICategoryRespository
    {
        Category GetDrink(int id);
        List<Category> GetAll();
        int SaveCategory(Category category);
    }
}

