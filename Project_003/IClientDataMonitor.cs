using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_003
{
    internal interface IClientDataMonitor
    {
        ObservableCollection<Person> ViewClientData(string[] personTemp);

        void DataEditing(int index, string SName, string FName, string SecName, string NPhone, string PData);
    }
}
