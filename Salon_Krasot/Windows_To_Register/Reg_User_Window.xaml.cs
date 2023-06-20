using Salon_Krasot.Models;
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

namespace Salon_Krasot.Windows_To_Register
{
    /// <summary>
    /// Логика взаимодействия для Reg_User_Window.xaml
    /// </summary>
    public partial class Reg_User_Window : Window
    {
        private ApplicationContext dbContext;
        public Reg_User_Window()
        {
            InitializeComponent();
            dbContext = new ApplicationContext();
        }

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            string login = login_lb.Text;
            string password = password_pb.Password;
            string confirmPassword = repeat_pass.Password;

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Необходимо минимум 8 символов");
            }
            else
            {
                User user = new User()
                {
                    Login = login,
                    Password = password
                };

                dbContext.Users.Add(user); 
                dbContext.SaveChanges();

                MessageBox.Show("Пользователь зарегистрирован.");

                MainWindow mainWindow = new MainWindow();
                Close();
                mainWindow.ShowDialog();
            }

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }
    }
}
