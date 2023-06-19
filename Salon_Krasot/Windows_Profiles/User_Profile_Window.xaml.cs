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
            user.Surname = "Мифтахов";
            user.Name = "Роман";
            user.Patronymic = "Марселевич";
            user.DateBirthday = new DateOnly(2005, 12, 2);
            user.NumberPhone = "89873477702";
            user.Email = "nekromant@gmail.com";
            user.Sex = "M";
        }

        private void btn_edit_profile_Click(object sender, RoutedEventArgs e)
        {
            User_Edit_Profile_Window user_Edit_Profile_Window = new User_Edit_Profile_Window();
            Close();
            user_Edit_Profile_Window.ShowDialog();
        }

        

        public class User
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Patronymic { get; set; }
            public DateOnly DateBirthday { get; set; }
            public string NumberPhone { get; set; }
            public string Email { get; set; }
            public string Sex { get; set; }
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
