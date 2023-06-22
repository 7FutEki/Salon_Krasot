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
            Products = new ObservableCollection<Product_Card>();
            DataContext = this;
            LoadBasket();
        }
        private void LoadBasket()
        {
            //using (var db = new ApplicationContext())
            //{
            //    var logins = db.ForLogin.ToList();
            //    string login = logins.Last().Login;
                
                
            //        var basket_Product_Cards = db.Basket_Product_Cards.Where(x => x.Login == login).ToList();
            //        foreach (var item in basket_Product_Cards)
            //        {
            //            List<Product_Card> ba = new List<Product_Card>();
            //            var s = db.Products_Cards.Where(y => y.Title == item.Title);
            //            foreach (var card in s)
            //            {
            //                ba.Add(card);
            //            }
            //        //var s = db.Products_Cards.Where(y => y.Title == item.Title).ToList();

            //        //Basket_lb.Items.Add(ba);
            //            Basket_lb.Items.Add(ba);
            //    }
            //        foreach (var photo in Products)
            //        {
            //            photo.Photo = $"pack://application:,,,/{photo.Photo}";
            //            //Фотографии не выводятся(
            //        }
                    
                
            //}
        }
       

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            User_Main_Part_Window user_Main_Part_Window = new User_Main_Part_Window();
            Close();
            user_Main_Part_Window.ShowDialog();
        }
    }
}
