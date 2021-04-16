using Practice.Resources;
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

namespace Practice.Navigate
{
    /// <summary>
    /// Логика взаимодействия для MainNavigate.xaml
    /// </summary>
    public partial class MainNavigate : Page
    {
        public MainNavigate()
        {
        
            InitializeComponent();
        }

     
      

        private void Adminmode_Click(object sender, RoutedEventArgs e)
        {
            Frames.Frmobj.Navigate(new AdminPage());

        }

      

        private void ChooseTape_Click(object sender, RoutedEventArgs e)
        {
            Frames.Frmobj.Navigate(new  JustWatch());
        }
    }
}
