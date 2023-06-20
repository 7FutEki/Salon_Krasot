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
using Salon_Krasot.Windows_Application_Menu;
using Salon_Krasot.Models;
namespace Salon_Krasot.Windows_Profiles
{
    /// <summary>
    /// Логика взаимодействия для Admin_Profile_Window.xaml
    /// </summary>
    public partial class Admin_Profile_Window : Window
    {
        Admin admin { get; set; }
        public Admin_Profile_Window(string login)
        {
            admin = new Admin();
            InitializeComponent();
            DataContext = admin;
            LoadProfile(login);
        }

        private void LoadProfile(string login)
        {
            using (var db = new ApplicationContext())
            {
                var userprofile = db.Admins.Where(x => x.Login == login);
                foreach (var item in userprofile)
                {
                    admin.Name = item.Name;
                    admin.Surname = item.Surname;
                    admin.Patronymic = item.Patronymic;
                    admin.DateBirthday = item.DateBirthday;
                    admin.Passport = item.Passport;
                    admin.Sex = item.Sex;
                    admin.CoefZp = item.CoefZp;
                    admin.DivCode = item.DivCode;
                    admin.Category= item.Category;
                }
            }
        }





        private void btn_edit_image_Click(object sender, RoutedEventArgs e)
        {

        }
        

        private void btn_exit_profile_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }

        private void btn_edit_profile_Click(object sender, RoutedEventArgs e)
        {
            Admin_Edit_Profile_Window admin_Edit_Profile_Window = new Admin_Edit_Profile_Window();
            Close();
            admin_Edit_Profile_Window.ShowDialog();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Admin_Main_Part_Window admin_Main_Part_Window = new Admin_Main_Part_Window();
            Close();
            admin_Main_Part_Window.ShowDialog();

        }
    }
}
