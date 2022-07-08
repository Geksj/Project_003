using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_003
{
    public class Person
    {
        public string Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string NumberPhone { get; set; }
        public string PasportData { get; set; }

        public Person(string id, string surname, string firstName, string secondName, string numberPhone, string pasportData)
        {
            Id = id;
            Surname = surname;
            FirstName = firstName;
            SecondName = secondName;
            NumberPhone = numberPhone;
            PasportData = pasportData;
        }
    }
}
