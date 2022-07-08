using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_003
{
    internal class Model
    {
        private int id;
        private Consultant personC;
        private Manager personM;
        private bool flag;
        public Model()
        {
            personC = new Consultant();
            personM = new Manager();
        }

        public ObservableCollection<Person>Load(bool flag)
        {
            this.flag = flag;
            if ( flag != false)
            {
                return personM.GetPersons();
            }
            return personC.GetPersons();
        }
        private int NextId()
        {
            id = 10;
            id++;
            return id;
        }


        public void AddPerson(string SName, string FName, string SecName, string NPhone, string PData)
        {
            int id = NextId();
            using(StreamWriter sw = new StreamWriter("dataBase.txt", true))
            {
                string text;
                text = $"{id}#{SName}#{FName}#{SecName}#{NPhone}#{PData}";
                sw.WriteLine(text);
            }
        }
        public void ChangePerson(int index, string SName, string FName, string SecName, string NPhone, string PData, bool flag)
        {
            personC.ChangePerson(index, SName, FName, SecName, NPhone);
            SaveLastChange(flag);
        }
        public void RemovePerson(int index)
        {
            string[] line = File.ReadAllLines("dataBase.txt");
            for (int i = index; i < line.Length - 1; i++)
            {
                line[i] = line[i + 1];
            }
            Array.Resize(ref line, line.Length - 1);
            File.WriteAllLines("dataBase.txt", line);
        }

        private void SaveLastChange(bool flag)
        {
            DateTime time = DateTime.Now;
            string role = $"Консультант";
            if (flag != false)
            {
                role = $"Менеджер";
            }
            using (StreamWriter sw = new StreamWriter("logLastChange.txt", false))
            {
                string line = $"{time}#{role}";
                sw.WriteLine(line);
            }
        }
    }
}
