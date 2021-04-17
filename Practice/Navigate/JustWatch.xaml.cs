using Practice.DataFiles;
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
    /// Логика взаимодействия для JustWatch.xaml
    /// </summary>
    public partial class JustWatch : Page
    {
        public JustWatch()
        {
            InitializeComponent();
            
        }
        Hire_videotapeEntities DB = new Hire_videotapeEntities();
        void Update()
        {
            DG2.ItemsSource = DB.Заказ.ToList();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DG2.ItemsSource = Connectdb.dbobj.Заказ.ToList();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            Frames.Frmobj.Navigate(new addpage());
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var currentOrder = DG2.SelectedItem as Заказ;
            if (currentOrder != null)
            {
                DB.Заказ.Remove(currentOrder);
                DB.SaveChanges();
                Update();
            }
        }

        private void Changebtn_Click(object sender, RoutedEventArgs e)
        {
            Connectdb.dbobj.SaveChanges();
        }
    }
}
