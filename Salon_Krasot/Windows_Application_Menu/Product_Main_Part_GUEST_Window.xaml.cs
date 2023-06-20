using Microsoft.EntityFrameworkCore;
using Salon_Krasot.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        //Верстка, наименование товара, как увидишь, поймешь в чем дело
        public Product_Main_Part_GUEST_Window(Product_Card product)
        {
            InitializeComponent();
            DataContext = product;
        }


        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Gost_Main_Part_Window gost_Main_Part_Window = new Gost_Main_Part_Window();
            Close();
            gost_Main_Part_Window.ShowDialog();
        }
    }
}
