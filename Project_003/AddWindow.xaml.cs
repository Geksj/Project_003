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
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            Presenter p = new Presenter(true);
            p.AddPerson(SurnameTB.Text, FirstNameTB.Text, SecondNameTB.Text, NumberPhoneTB.Text, PasportDataTB.Text);
        }


    }
}
