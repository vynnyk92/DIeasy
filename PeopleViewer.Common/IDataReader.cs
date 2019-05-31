using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleViewer.Common
{
    public interface IDataReader
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
    }
}
