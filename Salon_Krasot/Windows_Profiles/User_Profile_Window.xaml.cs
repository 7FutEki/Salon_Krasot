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

        private void btn_edit_data_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_edit_image_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
