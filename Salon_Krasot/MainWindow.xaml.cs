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
using Salon_Krasot.Windows_Profiles;

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
        }

        private void reg_admin_btn_Click(object sender, RoutedEventArgs e)
        {
            Windows_To_Register.Key_Reg_Window key_Reg_Window = new Windows_To_Register.Key_Reg_Window();
            key_Reg_Window.Show();
            
        }
        private void reg_user_btn_Click(object sender, RoutedEventArgs e)
        {
            //Windows_To_Register.Reg_User_Window reg_User_Window = new Windows_To_Register.Reg_User_Window();
            //reg_User_Window.Show();
            Windows_Profiles.User_Profile_Window user_Profile_Window = new User_Profile_Window();
            user_Profile_Window.Show();
        }

        private void continue_btn_Click(object sender, RoutedEventArgs e)
        {
            Windows_Application_Menu.Main_Part_Window main_Part_Window = new Windows_Application_Menu.Main_Part_Window();
            main_Part_Window.Show();
            this.Close();

        }

    }
}
