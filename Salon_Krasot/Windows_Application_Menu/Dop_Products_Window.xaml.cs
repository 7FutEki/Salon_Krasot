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
using Microsoft.EntityFrameworkCore;
using Salon_Krasot.Models;

namespace Salon_Krasot.Windows_Application_Menu
{
    /// <summary>
    /// Логика взаимодействия для Dop_Products_Window.xaml
    /// </summary>
    public partial class Dop_Products_Window : Window
    {
        public ObservableCollection<Product_Card> Products { get; set; }
        ApplicationContext dbContext;
        Product_Card product2;
        public Dop_Products_Window(Product_Card product)
        {
            InitializeComponent();
            dbContext = new ApplicationContext();
            DataContext = this;
            product2 = product;
            LoadWindow(product);
        }
        private void LoadWindow(Product_Card product)
        {
            using (var db = new ApplicationContext())
            {
                var s = db.Products_Cards.Where(x => x.Manufacturer == product.Manufacturer).ToList();
                var activeProducts = s.Where(p => p.Active).ToList();
                foreach (var photo in activeProducts)
                {
                    photo.Photo = $"pack://application:,,,/{photo.Photo}";
                }
                Products = new ObservableCollection<Product_Card>(activeProducts);
            }
        }

        private void btn_add_basket_Click(object sender, RoutedEventArgs e)
        {
            var logins = dbContext.ForLogin.ToList();
            string login = logins.Last().Login;

            var s = Katalog_lb.SelectedItem as Product_Card;
            
            
            
            
            Basket_Product_Cards basket_Product_Cards = new Basket_Product_Cards()
            {
                Login = login,
                Title = s.Title
            };

            dbContext.Basket_Product_Cards.Add(basket_Product_Cards);
            dbContext.SaveChanges();
            Close();
        }
    }
}
