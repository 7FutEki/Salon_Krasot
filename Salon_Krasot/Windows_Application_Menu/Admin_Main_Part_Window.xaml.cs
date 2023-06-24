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
using Microsoft.EntityFrameworkCore;

namespace Salon_Krasot.Windows_Application_Menu
{
    /// <summary>
    /// Логика взаимодействия для Admin_Main_Part_Window.xaml
    /// </summary>
    public partial class Admin_Main_Part_Window : Window
    {
        Product_Card product { get; set; }
        ApplicationContext dbContext;
        Product_Card SelectedProduct { get; set; }
        public ObservableCollection<Product_Card> Products { get; set; }

        public Admin_Main_Part_Window()
        {
            product = new Product_Card();
            SelectedProduct = new Product_Card();
            InitializeComponent();
            Products = new ObservableCollection<Product_Card>();
            dbContext = new ApplicationContext();
            DataContext = this;
            LoadProducts();
         
        }

        private void LoadProducts()
        {
            Products = new ObservableCollection<Product_Card>(dbContext.Products_Cards.ToList());

            foreach (var photo in Products)
            {
                photo.Photo = $"pack://application:,,,/{photo.Photo}";
            }
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
            if (Katalog_lb.SelectedItem is Product_Card SelectedProduct)
            {
                Product_Main_Window product_Main_Window = new Product_Main_Window(SelectedProduct);
                Close();
                product_Main_Window.ShowDialog();
            }

           
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Add_Product_Window add_Product_Window= new Add_Product_Window();
            Close();
            add_Product_Window.ShowDialog();
        }

        private void search_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = search_tb.Text.ToLower();
            var searchProducts = dbContext.Products_Cards.Where(p => p.Title.ToLower().Contains(searchText)).ToList();
            Products = new ObservableCollection<Product_Card>(searchProducts);
            Katalog_lb.ItemsSource = Products;
        }
        private void Filter()
        {
            List<Product_Card> list = Products.ToList();


            switch (combobox.SelectedIndex)
            {
                case 0:
                    {
                        list = list;
                    }
                    break;
                case 1:
                    {
                        list.Sort((x, y) => x.Price.CompareTo(y.Price));
                    }
                    break;
                case 2:
                    {
                        list.Sort((x, y) => x.Price.CompareTo(y.Price));
                        list.Reverse();
                    }
                    break;
                case 3:
                    {
                        var s = list.Where(x => x.Manufacturer == tb_weleda.Text);
                        list = s.ToList();
                    }
                    break;
                case 4:
                    {
                        var s = list.Where(x => x.Manufacturer == tb_andalou.Text);
                        list = s.ToList();
                    }
                    break;
                case 5:
                    {
                        var s = list.Where(x => x.Manufacturer == tb_blue.Text);
                        list = s.ToList();
                    }
                    break;
                case 6:
                    {
                        var s = list.Where(x => x.Manufacturer == tb_amsarveda.Text);
                        list = s.ToList();
                    }
                    break;
                case 7:
                    {
                        var s = list.Where(x => x.Manufacturer == tb_matsesta.Text);
                        list = s.ToList();
                    }
                    break;
                case 8:
                    {
                        var s = list.Where(x => x.Manufacturer == tb_bio.Text);
                        list = s.ToList();
                    }
                    break;
                case 9:
                    {
                        var s = list.Where(x => x.Manufacturer == tb_diony.Text);
                        list = s.ToList();
                    }
                    break;
                case 10:
                    {
                        var s = list.Where(x => x.Manufacturer == tb_natura.Text);
                        list = s.ToList();
                    }
                    break;
            }
            Katalog_lb.ItemsSource = list;
        }
        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }
    }
}
