using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
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
    /// Логика взаимодействия для Gost_Main_Part_Window.xaml
    /// </summary>
    public partial class Gost_Main_Part_Window : Window
    {
        private ApplicationContext dbContext;
        public ObservableCollection<Product_Card> Products { get; set; }
        public Gost_Main_Part_Window()
        {
            InitializeComponent();
            DataContext = this;
            dbContext= new ApplicationContext();
            LoadProducts();
        }

        private void LoadProducts()
        {
            Products = new ObservableCollection<Product_Card>(dbContext.Products_Cards.ToList());
            foreach (var photo in Products)
            {
                photo.Photo = $"/Product_Image/{photo.Photo}";
                //Фотографии не выводятся(
            }
        }

        private void btn_choose_Click(object sender, RoutedEventArgs e)
        {
            if (Katalog_lb.SelectedItem is Product_Card SelectedProduct)
            {
            Product_Main_Part_GUEST_Window product_Main_Part_GUEST_Window = new Product_Main_Part_GUEST_Window(SelectedProduct);
            Close();
            product_Main_Part_GUEST_Window.ShowDialog();
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }

        private void Search_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = Search_tb.Text.ToLower();
            var searchProducts = dbContext.Products_Cards.Where(p => p.Title.ToLower().Contains(searchText)).ToList();
            Products = new ObservableCollection<Product_Card>(searchProducts);
            Katalog_lb.ItemsSource = Products;
        }
    }
}
