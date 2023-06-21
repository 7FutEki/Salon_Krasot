using Salon_Krasot.Windows_Product_Maxinations;
using Salon_Krasot.Windows_Profiles;
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
    /// Логика взаимодействия для Admin_Main_Part_Window.xaml
    /// </summary>
    public partial class Admin_Main_Part_Window : Window
    {
        public ObservableCollection<Product_Card> Products { get; set; }

        public Admin_Main_Part_Window()
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
            Products.Add(new Product_Card { Title = "Черт побери, откуда тут взялся туз¿", Price = 3132 });
        }
        

        private void btn_profile_Click(object sender, RoutedEventArgs e)
        {
            Admin_Profile_Window admin_Profile_Window = new Admin_Profile_Window();
            Close();
            admin_Profile_Window.ShowDialog();
        }

        private void btn_story_Click(object sender, RoutedEventArgs e)
        {
            SalesHistory_Window salesHistory_Window = new SalesHistory_Window();
            Close();
            salesHistory_Window.ShowDialog();
        }

        private void btn_choose_Click(object sender, RoutedEventArgs e)
        {
            Product_Main_Window product_Main_Window = new Product_Main_Window();
            Close();
            product_Main_Window.ShowDialog();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Add_Product_Window add_Product_Window= new Add_Product_Window();
            Close();
            add_Product_Window.ShowDialog();
        }
    }
}
