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

namespace Salon_Krasot.Windows_Application_Menu
{
    /// <summary>
    /// Логика взаимодействия для Product_Main_Window.xaml
    /// </summary>
    public partial class Product_Main_Window : Window
    {
        public Product_Main_Window()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_story_Click(object sender, RoutedEventArgs e)
        {
            Product_Story_Window product_Story_Window = new Product_Story_Window();
            Close();
            product_Story_Window.ShowDialog();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Admin_Main_Part_Window admin_Main_Part_Window = new Admin_Main_Part_Window();
            Close();
            admin_Main_Part_Window.ShowDialog();
        }
    }
}
