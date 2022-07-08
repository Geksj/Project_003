using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_003
{
    internal class Presenter
    {
        private Model model;
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
        public string LoadLastChange()
        {

            string [] text = File.ReadAllText("logLastChange.txt").Split('#');

                return text[0] +" " + text[1];
            
        }

        public ObservableCollection<Person> Load()
        {
                return model.Load(flag);
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
