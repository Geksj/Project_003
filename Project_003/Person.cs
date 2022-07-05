using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_003
{
    public class Person
    {
        public int Id { get; }

        public  string Surname { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string NumberPhone { get; set; }
        public string PasportData { get; set; }

        public Person(int Id, string Surname, string FirstName, string SecondName, string NumberPhone, string PasportData)
        {
            this.Id = Id;
            this.Surname = Surname;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.NumberPhone = NumberPhone;
            this.PasportData = PasportData;
        }

        public Person(string Surname, string FirstName, string SecondName, string NumberPhone, string PasportData)
        {
            this.Surname = Surname;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.NumberPhone = NumberPhone;
            this.PasportData = PasportData;
        }
    }
}
