using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_003
{
    internal class Presenter
    {
        private Model model;
        bool flag = false;

        public Presenter(bool flag)
        {
            model = new Model();
            this.flag = flag;
        }
        public ObservableCollection<Person> Load()
        {
                return model.Load(flag);
        }

        public void AddPerson(string SName, string FName, string SecName, string NPhone, string PData)
        {
            model.AddPerson(SName, FName, SecName, NPhone,  PData);
        }
    }

}
