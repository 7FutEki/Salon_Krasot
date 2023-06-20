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
using Salon_Krasot.Windows_Application_Menu;
using Salon_Krasot.Windows_Profiles;
using Salon_Krasot.Windows_To_Register;
using Salon_Krasot.Models;
using Microsoft.EntityFrameworkCore;

namespace Salon_Krasot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            db.Database.Migrate();
        }

        private void reg_admin_btn_Click(object sender, RoutedEventArgs e)
        {
            Key_Reg_Window key_Reg_Window = new Key_Reg_Window();
            Close();
            key_Reg_Window.Show();
            
        }
        private void reg_user_btn_Click(object sender, RoutedEventArgs e)
        {
            
            Reg_User_Window reg_User_Window = new Reg_User_Window();
            Close();
            reg_User_Window.ShowDialog();

        }

        private void continue_btn_Click(object sender, RoutedEventArgs e)
        {
            Gost_Main_Part_Window  gost_main_Part_Window = new Gost_Main_Part_Window();
            Close();
            gost_main_Part_Window.Show();

        }

        private void authorization_btn_Click(object sender, RoutedEventArgs e)
        {
            string login = login_tb.Text;
            string password = password_pb.Password;
            using (var context = new ApplicationContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
                var admin = context.Admins.FirstOrDefault(x => x.Login== login && x.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Авторизация пользователя успешна!");
                    User_Main_Part_Window user_Main_Part = new User_Main_Part_Window();
                    user_Main_Part.Show();
                    Close();
                }
                else if (admin != null)
                {
                    MessageBox.Show("Авторизация сотрудника успешна!");
                    Admin_Main_Part_Window admin_Main_Part = new Admin_Main_Part_Window();
                    admin_Main_Part.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }

            }
        }
    }
}
