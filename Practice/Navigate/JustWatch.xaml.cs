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
            DG.ItemsSource = DB.VideoTapes.ToList();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }
    }
}
