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
        public MainWindow(bool flag)
        {
            p = new Presenter(flag);
            InitializeComponent();
            ListViewDB.ItemsSource = p.Load();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddWindow aw = new AddWindow();
            aw.ShowDialog();
        }
    }
}
