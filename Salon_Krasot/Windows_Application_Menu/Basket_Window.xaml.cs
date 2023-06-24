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
    /// Логика взаимодействия для Basket_Window.xaml
    /// </summary>
    public partial class Basket_Window : Window
    {
        public ObservableCollection<Product_Card> Products { get; set; }
        public Basket_Window()
        {
            InitializeComponent();
            DataContext = this;
            LoadBasket();
        }
        private void LoadBasket()
        {
            using (var db = new ApplicationContext())
            {
                var logins = db.ForLogin.ToList();
                string login = logins.Last().Login;
                var basket_Product_Cards = db.Basket_Product_Cards.Where(x => x.Login == login).ToList();

                List<Product_Card> basket_product = new List<Product_Card>();

                foreach (var item in basket_Product_Cards)
                {
                    var s = db.Products_Cards.Where(y => y.Title == item.Title).ToList();
                    foreach (var card in s)
                    {
                        basket_product.Add(card);
                    }
                }

                Products = new ObservableCollection<Product_Card>(basket_product);

                foreach (var photo in Products)
                {
                    if (photo.Photo.Length == 58)
                    {
                        continue;
                    }
                    else
                        photo.Photo = $"pack://application:,,,/{photo.Photo}";
                }





                



            }
        }


        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            User_Main_Part_Window user_Main_Part_Window = new User_Main_Part_Window();
            Close();
            user_Main_Part_Window.ShowDialog();
        }

        private void buy_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Basket_lb.SelectedItem != null)
            {
                MessageBox.Show("К сожалению, на данный момент невозможно выполнить данную операцию. Рекомендуется обратиться в службу поддержки для получения дополнительной помощи. Мы приносим извинения за возможные неудобства.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning   );
            }
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Basket_lb.SelectedItem != null)
            {
                var selectedProduct = (Product_Card)Basket_lb.SelectedItem;
                using (var db = new ApplicationContext())
                {
                    var logins = db.ForLogin.ToList();
                    string login = logins.Last().Login;
                    var basketProduct = db.Basket_Product_Cards.FirstOrDefault(x => x.Title == selectedProduct.Title && x.Login == login);

                    if (basketProduct != null)
                    {
                        db.Basket_Product_Cards.Remove(basketProduct);
                        db.SaveChanges();
                        Products.Remove(selectedProduct);
                    }
                }
            }
        }
    }
}
