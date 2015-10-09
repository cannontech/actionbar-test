using SQLite;

namespace actionbartest
{    
    [Table("drinks")]    
    public class Drink
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set;}
        public Category Category { get; set;}
        public string Name { get; set;}

        public Drink()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

