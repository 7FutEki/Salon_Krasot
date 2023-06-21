using Salon_Krasot.Windows_Application_Menu;
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
using Salon_Krasot.Models;
namespace Salon_Krasot.Windows_Profiles
{
    /// <summary>
    /// Логика взаимодействия для User_Profile_Window.xaml
    /// </summary>
    public partial class User_Profile_Window : Window 
    {
        public User user;
        public User_Profile_Window()
        {
            user = new User();
            InitializeComponent();
            DataContext = user;
            LoadProfile();
            
        }

        private void LoadProfile()
        {
            using (var db = new ApplicationContext())
            {
                
                var logins = db.ForLogin.ToList();
                string login = logins.Last().Login;
                var userprofile = db.Users.Where(x => x.Login == login);
                foreach (var item in userprofile)
                {
                    user.Name = item.Name;
                    user.Surname = item.Surname;
                    user.Patronymic = item.Patronymic;
                    user.DateBirthday = item.DateBirthday;
                    user.NumberPhone = item.NumberPhone;
                    user.Sex = item.Sex;
                    user.Email = item.Email;
                }
            }
        }

        private void btn_edit_profile_Click(object sender, RoutedEventArgs e)
        {
            User_Edit_Profile_Window user_Edit_Profile_Window = new User_Edit_Profile_Window();
            Close();
            user_Edit_Profile_Window.ShowDialog();
            
        }
       
        
        private void btn_exit_profile_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            User_Main_Part_Window user_Main_Part_Window = new User_Main_Part_Window();
            Close();
            user_Main_Part_Window.ShowDialog();
        }
    }
}
