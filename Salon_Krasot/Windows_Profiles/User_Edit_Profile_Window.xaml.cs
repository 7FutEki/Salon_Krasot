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
    /// Логика взаимодействия для User_Edit_Profile_Window.xaml
    /// </summary>
    public partial class User_Edit_Profile_Window : Window
    {
        private User user;
        public User_Edit_Profile_Window(User currentUser)
        {
            InitializeComponent();
            user = currentUser ;
            DataContext = user;
            
        }
        

        private void btn_exit_profile_Click(object sender, RoutedEventArgs e)
        {
            User_Profile_Window user_Profile_Window = new User_Profile_Window();
            Close();
            user_Profile_Window.ShowDialog();
        }

        private void save_edit_profile_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                var currentUser = db.Users.FirstOrDefault(u => u.Login == user.Login);
                if (currentUser != null)
                {

                    currentUser.Name = user.Name;
                    currentUser.Surname = user.Surname;
                    currentUser.Patronymic = user.Patronymic;
                    currentUser.DateBirthday = user.DateBirthday;
                    currentUser.NumberPhone = user.NumberPhone;
                    currentUser.Sex = user.Sex;
                    currentUser.Email = user.Email;
                    db.SaveChanges();

                    MessageBox.Show("Профиль успешно обновлен.");
                    User_Profile_Window user_Profile = new User_Profile_Window();
                    Close();
                    user_Profile.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден в базе данных.");
                }
            }


        }

       

        private void btn_edit_image_Click(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
