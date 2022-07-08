using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project_003
{
    /// <summary>
    /// Логика взаимодействия для ChangeWindow.xaml
    /// </summary>
    public partial class ChangeWindow : Window
    {
        int index;
        bool flag;
        public ChangeWindow(int index, bool flag)
        {
            InitializeComponent();
            this.index = index;
            this.flag = flag;
            
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            Presenter p = new Presenter(flag);
            p.ChangePerson(index, SurnameTB.Text, FirstNameTB.Text, SecondNameTB.Text, NumberPhoneTB.Text, PasportDataTB.Text, flag);
            this.DialogResult = true;
        }
    }
}
