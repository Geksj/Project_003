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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_003
{

    public partial class MainWindow : Window
    {
        Presenter p;
        bool flag;
        public MainWindow(bool flag)
        {
            this.flag = flag;
            p = new Presenter(flag);
            InitializeComponent();
            ListViewDB.ItemsSource = p.Load();
            NameRoleTB.Text = p.ViewRole();
            if (flag != true)
            {
                RemoveBnt.IsEnabled = false;
                AddBtn.IsEnabled = false;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddWindow aw = new AddWindow();
            aw.ShowDialog();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            var row = (Person)ListViewDB.SelectedItem;
            var index = ListViewDB.SelectedIndex;
            ChangeWindow cw = new ChangeWindow(index, flag);
            if (flag == true)
            {
                if (row != null)
                {
                    cw.SurnameTB.Text = row.Surname;
                    cw.FirstNameTB.Text = row.FirstName;
                    cw.SecondNameTB.Text = row.SecondName;
                    cw.NumberPhoneTB.Text = row.NumberPhone;
                    cw.PasportDataTB.Text = row.PasportData;
                    cw.ShowDialog();
                }
            }
            else
            {
                if (row != null)
                {
                    cw.SurnameTB.Text = row.Surname;
                    cw.FirstNameTB.Text = row.FirstName;
                    cw.SecondNameTB.Text = row.SecondName;
                    cw.NumberPhoneTB.Text = row.NumberPhone;
                    cw.PasportDataTB.Text = row.PasportData;
                    cw.SurnameTB.IsEnabled = false;
                    cw.FirstNameTB.IsEnabled = false;
                    cw.SecondNameTB.IsEnabled = false;
                    cw.PasportDataTB.IsEnabled = false;
                    cw.ShowDialog();
                }

            }

        }
        private void RemoveBnt_Click(object sender, RoutedEventArgs e)
        {
            var index = ListViewDB.SelectedIndex;
            p.RemovePerson(index);
        }
    }
}
