using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Project_003
{
    public class Consultant
    {
        public virtual ObservableCollection<Person> GetPersons()
        {
            var result = new ObservableCollection<Person>();
            PersonDataEntities dataEntities = new PersonDataEntities();
            dataEntities.PersonData.Load();
            var res = dataEntities.PersonData;
            foreach (var item in res)
            {
                result.Add(new Person(item.Id, item.Surname, item.First_Name, item.Second_Name, item.Number_Phone, "**** ******"));
            }
            return result;
        }
    }
}
