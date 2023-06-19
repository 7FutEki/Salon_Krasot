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
using Salon_Krasot.Models;

namespace Salon_Krasot.Windows_Application_Menu
{
    /// <summary>
    /// Логика взаимодействия для Gost_Main_Part_Window.xaml
    /// </summary>
    public partial class Gost_Main_Part_Window : Window
    {
        public ObservableCollection<Product_Card> Products { get; set; }
        public Gost_Main_Part_Window()
        {
            InitializeComponent();
            Products = new ObservableCollection<Product_Card>();
            Katalog_lb.ItemsSource = Products;

            Products.Add(new Product_Card { Title = "ТЕСТ", Price = 999 });
            Products.Add(new Product_Card { Title = "Тест", Price = 849 });
            Products.Add(new Product_Card { Title = "ТеСт", Price = 1312 });
            Products.Add(new Product_Card { Title = "Туз", Price = 5435 });
            Products.Add(new Product_Card { Title = "Тестирование", Price = 4234 });
            Products.Add(new Product_Card { Title = "Снова тестирование", Price = 3132 });
            Products.Add(new Product_Card { Title = "Черт побери, откуда тут взялся туз¿", Price = 3132, Manufacturer="adawgaa" });
        }
        

        private void btn_choose_Click(object sender, RoutedEventArgs e)
        {
            Product_Main_Part_GUEST_Window product_Main_Part_GUEST_Window = new Product_Main_Part_GUEST_Window();
            Close();
            product_Main_Part_GUEST_Window.ShowDialog();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }
    }
}
