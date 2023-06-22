﻿using Salon_Krasot.Models;
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
            Products = new ObservableCollection<Product_Card>(dbContext.Products_Cards.ToList());

            foreach (var photo in Products)
            {
                photo.Photo = $"pack://application:,,,/{photo.Photo}";
                //Фотографии не выводятся(
            }
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




        
    }
}
