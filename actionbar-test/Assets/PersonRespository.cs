using System;
using SQLite;
using System.Collections.Generic;

namespace actionbartest
{
    public class PersonRespository : IPersonRespository
    {
        public SQLiteConnection Connection { get; set; }

        public PersonRespository()
        {
            var path = FileAccessHelper.GetLocalFilePath("adsf.db");
            Connection = new SQLiteConnection(path);
            Connection.CreateTable<Person>();
        }

        public int SavePerson(Person person)
        {
            return Connection.Insert(person);
        }

        public List<Person> GetAll()
        {
            var list = new List<Person>();
            var query = Connection.Table<Person>().Where(p => p.Id != 0);

            foreach (var person in query)
            {
                list.Add(person);
            }

            return list;
        }

        public Person GetPerson(int id)
        {
            var query = Connection.Table<Person>().Where(p => p.Id == id);
            return query.First();
        }
    }
}

