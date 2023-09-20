using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaine_01
{
    internal class PersonList
    {
        private static PersonList _instance;
        private IDictionary<String, Person> _personMap;


        private PersonList() 
        { 
            _personMap = new Dictionary<String, Person>();
        }
        public static PersonList getInstance()
        {
            if(_instance == null) _instance = new PersonList();
            return _instance;
        }

            public void AddPerson(Person person)
        {
            if (person == null) throw new ArgumentNullException();
            _personMap.Add(person.Name, person);
        }

        public IEnumerator<Person> personList()
        {
            return _personMap.Values.GetEnumerator();
        }
    }
}
