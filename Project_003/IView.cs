using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_003
{
    public interface IView
    {
        string SurnameText { get; }
        string FirstNameText { get; }
        string SecondNameText { get; }
        string NumberPhoneText { get; }
        string PaspotDataText { get; }
    }
}
