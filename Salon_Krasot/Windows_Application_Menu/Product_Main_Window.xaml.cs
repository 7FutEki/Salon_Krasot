using Microsoft.EntityFrameworkCore;
using Salon_Krasot.Models;
using Salon_Krasot.Windows_Product_Mahinations;
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
        

        public Product_Main_Window(Product_Card product)
        {
            InitializeComponent();
            DataContext = product;
        }

       

        private void btn_edit_Click(object sender, RoutedEventArgs e)
        {
            Edit_Product_Window edit_Product_Window = new Edit_Product_Window((Product_Card)DataContext);
            Close();
            edit_Product_Window.ShowDialog();
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {   
            var deleteProduct = (Product_Card)DataContext;
            using (var context = new ApplicationContext())
            {
                var productDelete = context.Products_Cards.FirstOrDefault(p => p.Id == deleteProduct.Id);

                if (productDelete != null)
                {
                    context.Products_Cards.Remove(productDelete);
                    context.SaveChanges();

                    MessageBox.Show("Продукт успешно удален из базы данных.");
                }
                Admin_Main_Part_Window window = new Admin_Main_Part_Window();
                Close();
                window.Show();

            }
        }

        

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Admin_Main_Part_Window admin_Main_Part_Window = new Admin_Main_Part_Window();
            Close();
            admin_Main_Part_Window.ShowDialog();
        }
    }
}
