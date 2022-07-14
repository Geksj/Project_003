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
    internal class Presenter
    {
        Model model;
       
        bool flag;

        public Presenter(bool flag)
        {
            model = new Model();
            this.flag = flag;
        }

        public string ViewRole()
        {
            string role = "Роль: Консультант";
            if (flag == true) { role = "Роль: Менеджер"; } 
            return role;
        }

        public ObservableCollection<Person> Load()
        {
            return model.DataStorage(flag);
        }

        public void AddPerson(string SName, string FName, string SecName, string NPhone, string PData)
        {
            model.AddPerson(SName, FName, SecName, NPhone, PData);
        }

        public void ChangePerson(int index, string SName, string FName, string SecName, string NPhone, string PData, bool flag)
        {
            model.ChangePerson(index, SName, FName, SecName, NPhone, PData, flag);
        }
        public void RemovePerson(int index)
        {
            model.RemovePerson(index);
        }



    }

}
