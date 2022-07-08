using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_003
{
   internal class Manager : Consultant
    {
        public override ObservableCollection<Person> GetPersons()
        {
            var result = new ObservableCollection<Person>();
            using (StreamReader sr = new StreamReader("DataBase.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    result.Add(new Person(data[0], data[1], data[2], data[3], data[4], data[5]));
                }
            }
            return result;
        }
    }
}
