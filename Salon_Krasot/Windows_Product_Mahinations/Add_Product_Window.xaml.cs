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

namespace Salon_Krasot.Windows_Product_Maxinations
{
    /// <summary>
    /// Логика взаимодействия для Add_Product_Window.xaml
    /// </summary>
    public partial class Add_Product_Window : Window
    {
        public Add_Product_Window()
        {
            InitializeComponent();
        }

        private void btn_add_product_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_image_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Admin_Main_Part_Window admin_Main_Part_Window = new Admin_Main_Part_Window();
            Close();
            admin_Main_Part_Window.ShowDialog();
        }
    }
}
