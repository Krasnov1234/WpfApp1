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

namespace WpfApp1.Вход_Администратора
{
    /// <summary>
    /// Логика взаимодействия для Вход_админа.xaml
    /// </summary>
    public partial class Вход_админа : Window
    {
        public Вход_админа()
        {
            InitializeComponent();
        }
        private void Adminа(object sender, RoutedEventArgs e)
        {

            Close();
            MainWindow меню = new MainWindow();
            меню.Show();

        }

        private void VhAdm(object sender, RoutedEventArgs e)
        {

            if (txt_Login_Admin.Text == "1" && txt_password_Admin.Password == "1")
            {
                MessageBox.Show(" всё заполнено", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

                Close();
                
                Доб_Админ.Сотрудники.InsSotr insAdm = new Доб_Админ.Сотрудники.InsSotr();
                insAdm.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Введён не правильно логтн или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }




        }
    }
}
