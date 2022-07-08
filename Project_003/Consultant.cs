using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_003
{
    internal class Consultant
    {
        public virtual ObservableCollection<Person> GetPersons()
        {
            var result = new ObservableCollection<Person>();
            using (StreamReader sr = new StreamReader("DataBase.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    result.Add(new Person(data[0], data[1], data[2], data[3], data[4], "**** ******"));
                }
            }
                return result;
        }
        public void ChangePerson(int index, string SName, string FName, string SecName, string NPhone)
        {
            Manager m = new Manager();
            string[] line = File.ReadAllLines("dataBase.txt");
            line[index] = $"{index + 1}#{SName}#{FName}#{SecName}#{NPhone}#{m.GetPersons().Last().PasportData}";
            File.WriteAllLines("dataBase.txt", line);
        }
    }
}
