using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_003
{
    internal class Consultant : IClientDataMonitor
    {
        public ObservableCollection<Person> ViewClientData(string[] personTemp)
        {
            ObservableCollection<Person> personGroup = new ObservableCollection<Person>();
            personGroup.Add(new Person(personTemp[0], personTemp[1], personTemp[2], personTemp[3], personTemp[4], "**** *******"));
            return personGroup;
        }

        public void DataEditing(int index, string SName, string FName, string SecName, string NPhone, string PData)
        {
            string[] line = File.ReadAllLines("dataBase.txt");
            line[index] = $"{index + 1}#{SName}#{FName}#{SecName}#{NPhone}#{PData}";
            File.WriteAllLines("dataBase.txt", line);
        }
    }
}
