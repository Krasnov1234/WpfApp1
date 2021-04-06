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
namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
           
        }


        private void Admin(object sender, RoutedEventArgs e)
        {
            Hide();
            Вход_Администратора.Вход_админа вход = new Вход_Администратора.Вход_админа();
            вход.Show();
           
        }


        private void Sotr(object sender, RoutedEventArgs e)
        {
            //Hide();
            //Вход_сотрудника.ВходСотрудника ВхСтр = new Вход_сотрудника.ВходСотрудника();
            //ВхСтр.Show();
           
        }

        private void Пользователь(object sender, RoutedEventArgs e)
        {
            //Hide();
            //Пользователь.Пользователь Польз = new Пользователь.Пользователь();
            //Польз.Show();
           
        }
    }
}
