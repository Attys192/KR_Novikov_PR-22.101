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
using WPFTESTKR.Models;
using WPFTESTKR.Services;

namespace WPFTESTKR
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

        private void tbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
       
            LoginBaseEntities2 db = Helper.GetContext();
            string login = tbLogin.Text;
           string password = tbPassword.Text;
           
            var user = db.Users.Where(x => x.login == login && x.password == password).FirstOrDefault();
            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("логин не может быть пустой");
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("пароль не может быть пустой");
            }
            if (user != null)
            {
             
                MessageBox.Show($"Добро пожаловать! Ваша роль:{user.Position.PositionName}", "Успешный вход!", MessageBoxButton.OK, MessageBoxImage.Information);
                Client clientWindow = new Client(user);
                clientWindow.Show();
                this.Close();
            
            }
            else
            {
           
                MessageBox.Show("Неверный логин или пароль", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}
