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
        User user;
        public User_Edit_Profile_Window()
        {
            InitializeComponent();
            user = new User();
            InitializeComponent();
            DataContext = user;
            user.Surname = "Мифтахов";
            user.Name = "Роман";
            user.Patronymic = "Марселевич";
            user.DateBirthday = new DateOnly(2005, 12, 2); //почему то нельзя в тектобоксе редактировать
            user.NumberPhone = "89873477702";
            user.Email = "nekromant@gmail.com";
            user.Sex = "M";
        }

        private void btn_exit_profile_Click(object sender, RoutedEventArgs e)
        {
            User_Profile_Window user_Profile_Window = new User_Profile_Window();
            Close();
            user_Profile_Window.ShowDialog();
        }

        private void save_edit_profile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_edit_image_Click(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
