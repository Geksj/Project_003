using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Project_003
{
    public class Model
    {
        private int id;
        private Consultant consultant;
        private Manager manager;
        private ObservableCollection<Person> personGroup;

        public Model()
        {
            consultant = new Consultant();
            manager = new Manager();
            personGroup = new ObservableCollection<Person>();
        }

        public ObservableCollection<Person> DataStorage(bool flag)
        {
            foreach (var item in DataLoad.DataUploud(flag))
            {
                personGroup.Add(item);
            }
            return personGroup;    
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
            if (flag != false)
            {
                manager.DataEditing(index, SName, FName, SecName, NPhone, PData);
            }
           else
            {
                consultant.DataEditing(index, SName, FName, SecName, NPhone, DataStorage(true)[index].PasportData);
            }
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

        private int NextId()
        {
            id = 10;
            id++;
            return id;
        }
    }
}
