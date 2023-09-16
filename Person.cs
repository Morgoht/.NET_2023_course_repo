using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semaine_01
{
    internal class Person
    {
        private  string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        private string Firstname
        {
            get { return Firstname; }
            set { Firstname = value; }  
        }
        private  DateTime BirthDate
        {
            get { return BirthDate; }
            set { BirthDate = value; }
        }

        public Person(string name, string firstname, DateTime birthDate) {
            Name = name;
            Firstname = firstname;
            BirthDate  = birthDate;
        }
    }
}
