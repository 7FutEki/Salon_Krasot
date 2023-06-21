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

namespace Salon_Krasot.Windows_Profiles
{
    /// <summary>
    /// Логика взаимодействия для Admin_Edit_Profile_Window.xaml
    /// </summary>
    public partial class Admin_Edit_Profile_Window : Window
    {
        public Admin admin;
        public Admin_Edit_Profile_Window(Admin currentAdmin)
        {
            InitializeComponent();
            admin = currentAdmin;
            DataContext = admin;
            
        }

        

        private void btn_exit_profile_Click(object sender, RoutedEventArgs e)
        {
            
            Admin_Profile_Window admin_Profile_Window = new Admin_Profile_Window();
            Close();
            admin_Profile_Window.ShowDialog();
        }

        private void btn_edit_image_Click(object sender, RoutedEventArgs e)
        {

        }

        private void save_edit_profile_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                var currentAdmin = db.Admins.FirstOrDefault(u => u.Login == admin.Login);
                if (currentAdmin != null)
                {
                    currentAdmin.Login = admin.Login;
                    currentAdmin.Password = admin.Password;
                    currentAdmin.Name = admin.Name;
                    currentAdmin.Surname = admin.Surname;
                    currentAdmin.Patronymic = admin.Patronymic;
                    currentAdmin.DateBirthday = admin.DateBirthday;
                    currentAdmin.Passport = admin.Passport;
                    currentAdmin.Sex = admin.Sex;
                    currentAdmin.CoefZp = admin.CoefZp;
                    currentAdmin.DivCode = admin.DivCode;
                    currentAdmin.Category = admin.Category;
                    db.SaveChanges();

                    MessageBox.Show("Профиль успешно обновлен.");
                    Admin_Profile_Window admin_Profile = new Admin_Profile_Window();
                    Close();
                    admin_Profile.Show();
                }

            }
        }
    }
}
