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


namespace WpfApp1.Доб_Админ.Сотрудники
{
    /// <summary>
    /// Логика взаимодействия для InsSotr.xaml
    /// </summary>
    public partial class InsSotr : Window
    {
        gr691_koyEntities1 db = new gr691_koyEntities1();
        Sotr ISotr = new Sotr();


        public InsSotr()
        {
            InitializeComponent();
        }

        private void Insert_Sotr(object sender, RoutedEventArgs e)
        {
            db = new gr691_koyEntities1();

            try
            {
              
                ISotr.InsSotr(txtIdSotr.Text, txtФамилия.Text, txtИмя.Text, txtОтчество.Text, txtПароль.Text);
                DobSotr.ItemsSource = db.Поварята.ToList();

            }
            catch
            { 
            
            }

        }



        private void Delete_Sotr(object sender, RoutedEventArgs e)
        {
            ISotr.Delete_Sotr(txtIdSotr.Text);
            DobSotr.ItemsSource = db.Поварята.ToList();
        }

        private void VhAdm_Sotr(object sender, RoutedEventArgs e)
        {
            Close();
            Hide();
            MainWindow meny = new MainWindow();
            meny.Show();
            Close();
        }

        private void Update_Sotr(object sender, RoutedEventArgs e)
        {
            db = new gr691_koyEntities1();
            ISotr.Update_Sotr(txtIdSotr.Text, txtФамилия.Text, txtИмя.Text, txtОтчество.Text, txtПароль.Text);
            DobSotr.ItemsSource = db.Поварята.ToList();
        }

        private void DobSotr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            db = new gr691_koyEntities1();
            DobSotr.ItemsSource = db.Поварята.ToList();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //gr691_koyEntities1 db = new gr691_koyEntities1();    ///////////////////////// необходимо открыть прни использовании
            //DobSotr.ItemsSource = db.Поварята.ToList();
        }

        private void txtIdSotr_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
