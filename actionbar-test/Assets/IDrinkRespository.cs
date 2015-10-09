using System.Collections.Generic;

namespace actionbartest
{
    public interface IDrinkRespository
    {
        Drink GetDrink(int id);
        List<Drink> GetAll();
        int SaveDrink(Drink drink);
    }
}

