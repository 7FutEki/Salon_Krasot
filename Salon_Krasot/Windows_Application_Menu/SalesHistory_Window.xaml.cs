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
    /// Логика взаимодействия для SalesHistory_Window.xaml
    /// </summary>
    public partial class SalesHistory_Window : Window
    {

        public ObservableCollection<Product> Products { get; set; }
        public SalesHistory_Window()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product>();
            Katalog_lb.ItemsSource = Products;

            Products.Add(new Product { Title = "ТЕСТ", Price = 999,  Manufacturer="adawdad" });
            Products.Add(new Product { Title = "Тест", Price = 849 });
            Products.Add(new Product { Title = "ТеСт", Price = 1312 });
            Products.Add(new Product { Title = "Туз", Price = 5435 });
            Products.Add(new Product { Title = "Тестирование", Price = 4234 });
            Products.Add(new Product { Title = "Снова тестирование", Price = 3132 });
            Products.Add(new Product { Title = "Черт побери, откуда тут взялся туз¿", Price = 3132, Manufacturer="adawdad" });
        }
        public class Product
        {
            public string Title { get; set; }
            public double Price { get; set; }
            public string Manufacturer { get; set; }
            public string Image { get; set; }

        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Admin_Main_Part_Window admin_Main_Part_Window = new Admin_Main_Part_Window();
            Close();
            admin_Main_Part_Window.ShowDialog();
        }
    }
}
