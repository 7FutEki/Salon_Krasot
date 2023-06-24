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
using Microsoft.EntityFrameworkCore;
using Salon_Krasot.Models;
using Salon_Krasot.Windows_Application_Menu;

namespace Salon_Krasot.Windows_Application_Menu
{
    /// <summary>
    /// Логика взаимодействия для Product_Main_Part_USER_Window.xaml
    /// </summary>
    public partial class Product_Main_Part_USER_Window : Window
    {
        ApplicationContext dbContext;
        Product_Card product2;
        public Product_Main_Part_USER_Window(Product_Card product)
        {
            InitializeComponent();
            dbContext = new ApplicationContext();
            DataContext = product;
            product2 = product;
        }

        private void btn_add_to_basket_Click(object sender, RoutedEventArgs e)
        {
            Dop_Products_Window dop_Products_Window = new Dop_Products_Window(product2);
            dop_Products_Window.ShowDialog();
            
                var logins = dbContext.ForLogin.ToList();
                string login = logins.Last().Login;


                Basket_Product_Cards basket_Product_Cards = new Basket_Product_Cards()
                {
                    Login = login,
                    Title = product2.Title
                };

                dbContext.Basket_Product_Cards.Add(basket_Product_Cards);
                dbContext.SaveChanges();

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
