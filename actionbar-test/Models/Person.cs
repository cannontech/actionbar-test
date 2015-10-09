using SQLite;

namespace actionbartest
{
    [Table("people")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}

        public Person()
        {            
        } 

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}

