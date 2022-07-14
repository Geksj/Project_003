using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_003
{
    internal class LastRole : INotifyPropertyChanged
    {
        private string timeLast;
        private string roleLast;
        public string TimeLast 
        {
            get => timeLast;
            set
            {
                timeLast = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof))
            } 
        }
        public string RoleLast 
        {
            get => roleLast;
            set
            {
                roleLast = value;
                OnPropertyChanged("RoleLast");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
