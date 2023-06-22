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
    /// Логика взаимодействия для Reg_Admin_Window.xaml
    /// </summary>
    public partial class Reg_Admin_Window : Window
    {
        private ApplicationContext dbContext;
        public Reg_Admin_Window()
        {
            InitializeComponent();
            dbContext = new ApplicationContext();
        }

        private void reg_btn_Click(object sender, RoutedEventArgs e)
        {
            string login = login_tb.Text;
            string password = password_pb.Password;
            string confirmPassword = repeat_password.Password;

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
                Admin admin = new Admin()
                {
                    Login = login,
                    Password = password
                };

                using (var db = new ApplicationContext())
                {
                    var checkadmin = db.Admins.FirstOrDefault(x => x.Login == login && x.Password == password);
                    var checkuser = db.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
                    if (checkadmin != null)
                    {
                        MessageBox.Show("Имя занято");
                    }
                    else if (checkuser != null)
                    {
                        MessageBox.Show("Имя занято");
                    }
                    else
                    {
                        dbContext.Admins.Add(admin);
                        dbContext.SaveChanges();

                        MessageBox.Show("Сотрудник зарегистрирован.");

                        MainWindow mainWindow = new MainWindow();
                        Close();
                        mainWindow.ShowDialog();
                    }
                }
                
            }

        }
        private void out_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }

    }
}
