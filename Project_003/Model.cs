using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_003
{
    public class Model
    {
        private Consultant personC;
        private Manager personM;
        public Model()
        {
            personC = new Consultant();
            personM = new Manager();
        }

        public ObservableCollection<Person> Load(bool flag)
        {
            if ( flag != false)
            {
                return personM.GetPersons();
            }
            return personC.GetPersons();
        }

        public void  AddPerson(string SName, string FName, string SecName, string NPhone, string PData)
        {
            PersonDataEntities entities = new PersonDataEntities();
            entities.PersonData.Add(new PersonData
            {
                Surname = SName,
                First_Name = FName,
                Second_Name = SecName,
                Number_Phone = NPhone,
                Pasport_Data = PData
            });
            entities.SaveChanges();
        }
    }
}
