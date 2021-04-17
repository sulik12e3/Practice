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
    /// Логика взаимодействия для addpage.xaml
    /// </summary>
    public partial class addpage : Page
    {
        public addpage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Заказ s = new Заказ();
                s.FIO = txbCodeT.Text;
                s.PhoneNumber = txbPhonenumber.Text;
                s.Codetapes = Convert.ToInt32(txbCodeT.Text);
                Connectdb.dbobj.Заказ.Add(s);
                Connectdb.dbobj.SaveChanges();
                MessageBox.Show("Добавление прошло успешно", "уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка ", "уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
