using System.Collections.Generic;

namespace actionbartest
{
    public class DrinkRespository : IDrinkRespository
    {
        public DrinkRespository()
        {
        }

        public Drink GetDrink(int id)
        {
            return new Drink();
        }

        public List<Drink> GetAll()
        {
            return new List<Drink>();
        }

        public int SaveDrink(Drink drink)
        {
            return 1;
        }
    }
}

