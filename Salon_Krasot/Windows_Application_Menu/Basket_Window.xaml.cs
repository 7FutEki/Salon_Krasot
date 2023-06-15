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
    /// Логика взаимодействия для Basket_Window.xaml
    /// </summary>
    public partial class Basket_Window : Window
    {
        public ObservableCollection<Product> Products { get; set; }
        public Basket_Window()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>();
            Basket_lb.ItemsSource = Products;

            Products.Add(new Product { Name = "ТЕСТ", Price = 999 });
            Products.Add(new Product { Name = "Тест", Price = 849 });
            Products.Add(new Product { Name = "ТеСт", Price = 1312 });
            Products.Add(new Product { Name = "Туз", Price = 5435 });
            Products.Add(new Product { Name = "Тестирование", Price = 4234 });
            Products.Add(new Product { Name = "Снова тестирование", Price = 3132 });
            Products.Add(new Product { Name = "Черт побери, откуда тут взялся туз¿", Price = 3132 });
        }

        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Image { get; set; }

        }
    }
}
