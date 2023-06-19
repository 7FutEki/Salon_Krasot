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
            Katalog_lb.ItemsSource = Products;
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
