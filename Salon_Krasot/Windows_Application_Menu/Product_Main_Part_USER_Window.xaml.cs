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

namespace Salon_Krasot.Windows_Application_Menu
{
    /// <summary>
    /// Логика взаимодействия для Product_Main_Part_USER_Window.xaml
    /// </summary>
    public partial class Product_Main_Part_USER_Window : Window
    {
        public Product_Main_Part_USER_Window()
        {
            InitializeComponent();
        }

        private void btn_add_to_basket_Click(object sender, RoutedEventArgs e)
        {
            //какой то код
            User_Main_Part_Window user_Main_Part_Window = new User_Main_Part_Window();
            Close();
            user_Main_Part_Window.ShowDialog();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            User_Main_Part_Window user_Main_Part_Window = new User_Main_Part_Window();
            Close();
            user_Main_Part_Window.ShowDialog();
        }

        
    }
}
