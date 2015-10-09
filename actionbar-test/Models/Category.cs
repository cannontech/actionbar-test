using SQLite;

namespace actionbartest
{
    [Table("categories")]
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set;}
        public string Name { get; set;}

        public Category()
        {
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

