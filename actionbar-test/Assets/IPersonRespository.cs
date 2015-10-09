using System;
using System.Collections.Generic;

namespace actionbartest
{
    public interface IPersonRespository
    {
        Person GetPerson(int id);
        List<Person> GetAll();
        int SavePerson(Person person);
    }
}

