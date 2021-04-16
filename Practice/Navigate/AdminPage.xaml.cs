using Practice.DataFiles;
using Practice.Resources;
using Practice.Resources.Usebtn;
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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        Hire_videotapeEntities db1 = new Hire_videotapeEntities();

        void Update1()
        {
            DG1.ItemsSource = db1.VideoTapes.ToList();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DG1.ItemsSource = Connectdb.dbobj.VideoTapes.ToList();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            Add s = new Add();
            s.Show();
            Update1();
        }

        private void Deletedbt_Click(object sender, RoutedEventArgs e)
        {

            var currentTapes = DG1.SelectedItem as VideoTapes;
            if (currentTapes != null)
            {
                db1.VideoTapes.Remove(currentTapes);
                db1.SaveChanges();
                Update1();
            }

        }

        private void changebtn_Click(object sender, RoutedEventArgs e)
        {
            Connectdb.dbobj.SaveChanges();
           
        }
    }
}
