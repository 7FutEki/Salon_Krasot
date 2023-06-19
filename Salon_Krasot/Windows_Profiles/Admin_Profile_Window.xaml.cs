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

namespace Salon_Krasot.Windows_Profiles
{
    /// <summary>
    /// Логика взаимодействия для Admin_Profile_Window.xaml
    /// </summary>
    public partial class Admin_Profile_Window : Window
    {
        Admin profiles { get; set; }
        public Admin_Profile_Window()
        {
            profiles = new Admin();
            InitializeComponent();
            DataContext = profiles;
            profiles.Surname = "Коркодинов";
            profiles.Name = "Арсений";
            profiles.Patronymic = "Леонидович";
            profiles.Category = "Сотрудник";
            profiles.Passport = "3619 655973";
            profiles.DivCode = 653;
            profiles.CoefZp = 15;
            profiles.DateBirthday = new DateOnly(2005, 05, 05);
        }

        

        

        private void btn_edit_image_Click(object sender, RoutedEventArgs e)
        {

        }
        public class Admin
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Patronymic { get; set; }
            public string Passport { get; set; }
            public int DivCode { get; set; }
            public DateOnly DateBirthday { get; set; }
            public string Category { get; set; }
            public int CoefZp { get; set; }
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

        }
    }
}
