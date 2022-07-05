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
    /// Логика взаимодействия для SelectRole.xaml
    /// </summary>
    public partial class SelectRole : Window
    {
        Presenter p; 
        MainWindow mw;
        public SelectRole()
        {
            InitializeComponent();
            ConsultantBtn.Click += (s, e) => Select(false);
            ManagerBtn.Click += (s, e) => Select(true);
        }

        private void Select(bool flag)
        {
            mw = new MainWindow(flag);
            mw.Show();
            this.Close();
        }
    }
}
