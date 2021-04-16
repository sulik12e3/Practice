using Practice.DataFiles;
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
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Data;

namespace Practice.Resources.Usebtn
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
     
        public Add()
        {
            InitializeComponent();
            cmbtermVD.SelectedValuePath = "ID";
            cmbtermVD.DisplayMemberPath = "termvideotapes";
            cmbtermVD.ItemsSource = Connectdb.dbobj.DateVideoTapes.ToList();
            txbGenre.SelectedValuePath = "ID";
            txbGenre.DisplayMemberPath = "Genre";
            txbGenre.ItemsSource = Connectdb.dbobj.InformationTapes.ToList();


        }
        
        public Add(VideoTapes p)
        {
            InitializeComponent();
            this.VideoTapes = p;
            txbnametape.Text = p.NameVideotapes;
            txbGenre.ItemsSource = db.InformationTapes.ToList();
            txbGenre.Text = p.InformationTapes.Genre;
            cmbtermVD.ItemsSource = db.InformationTapes.ToList();
            cmbtermVD.Text = p.InformationTapes.Genre;
           
        }

        Hire_videotapeEntities db = new Hire_videotapeEntities();
        VideoTapes VideoTapes;


        /// <summary>
        /// Логика работы с  БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VideoTapes p = new VideoTapes();
                p.NameVideotapes = txbnametape.Text;
                p.DateVideoTapes.termvideotapes = cmbtermVD.Text;
                p.InformationTapes.Genre = txbGenre.Text;
                db.VideoTapes.Add(p);
                db.SaveChanges();
                this.Close();



            }
            catch (Exception ex)
            {
              MessageBox.Show("Критическая ошибка", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
