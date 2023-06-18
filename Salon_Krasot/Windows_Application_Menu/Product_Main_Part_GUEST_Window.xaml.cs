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
    /// Логика взаимодействия для Product_Main_Part_GUEST_Window.xaml
    /// </summary>
    public partial class Product_Main_Part_GUEST_Window : Window
    {
        public Product_Main_Part_GUEST_Window()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Gost_Main_Part_Window gost_Main_Part_Window = new Gost_Main_Part_Window();
            Close();
            gost_Main_Part_Window.ShowDialog();
        }
    }
}
