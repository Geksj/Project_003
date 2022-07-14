using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project_003
{
    internal class DataLoad
    {
        public static ObservableCollection<Person> DataUploud(bool flag)
        {
            Manager manager = new Manager();
            Consultant consultant = new Consultant();
            ObservableCollection<Person> personTemp = new ObservableCollection<Person>();
            using (StreamReader sr = new StreamReader("DataBase.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    if (flag != false)
                    {
                        foreach (var item in manager.ViewClientData(data))
                        {
                            personTemp.Add(item);
                        }
                    }
                    else
                    {
                        foreach (var item in consultant.ViewClientData(data))
                        {
                            personTemp.Add(item);
                        }
                    }
                }
            }
            return personTemp;
        }

        //private void LoadLastChange()
        //{
        //    string[] text = File.ReadAllText("logLastChange.txt").Split('#');
        //    lastChange.LastTime = text[1];
        //    lastChange.RoleLast = text[0];
        //}

    }
}
