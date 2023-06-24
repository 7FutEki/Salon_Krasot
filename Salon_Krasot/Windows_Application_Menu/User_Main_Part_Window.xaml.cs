using Salon_Krasot.Models;
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


namespace Salon_Krasot.Windows_Application_Menu
{
    /// <summary>
    /// Логика взаимодействия для User_Main_Part_Window.xaml
    /// </summary>
    public partial class User_Main_Part_Window : Window
    {
        private ApplicationContext dbContext;
        public ObservableCollection<Product_Card> Products { get; set; }
        public User_Main_Part_Window()
        {
            InitializeComponent();
            DataContext = this;
            dbContext = new ApplicationContext();
            LoadProducts();
        }

        private void LoadProducts()
        {
            var allProducts = dbContext.Products_Cards.ToList();
            var activeProducts = allProducts.Where(p => p.Active).ToList();
            foreach (var photo in activeProducts)
            {
                photo.Photo = $"pack://application:,,,/{photo.Photo}";
            }
            Products = new ObservableCollection<Product_Card>(activeProducts);

        }

        private void btn_profile_Click(object sender, RoutedEventArgs e)
        {
            User_Profile_Window user_Profile_Window = new User_Profile_Window();
            Close();
            user_Profile_Window.ShowDialog();
        }

        private void btn_basket_Click(object sender, RoutedEventArgs e)
        {
            
            Basket_Window basket_Window = new Basket_Window();
            Close();
            basket_Window.ShowDialog();
        }

        private void btn_choose_Click(object sender, RoutedEventArgs e)
        {
            if (Katalog_lb.SelectedItem is Product_Card SelectedProduct)
            {
                Product_Main_Part_USER_Window product_Main_Part_USER_Window = new Product_Main_Part_USER_Window(SelectedProduct);
                Close();
                product_Main_Part_USER_Window.ShowDialog();
            }
           
        }

        private void search_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = search_tb.Text.ToLower();
            var searchProducts = dbContext.Products_Cards.Where(p => p.Active && p.Title.ToLower().Contains(searchText)).ToList();
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
