using Microsoft.Win32;
using Salon_Krasot.Models;
using Salon_Krasot.Windows_Application_Menu;
using Salon_Krasot.Windows_Profiles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Salon_Krasot.Windows_Product_Maxinations
{
    /// <summary>
    /// Логика взаимодействия для Add_Product_Window.xaml
    /// </summary>
    public partial class Add_Product_Window : Window
    {
        Product_Card pp { get; set; }
        public Add_Product_Window()
        {
            InitializeComponent();
            pp = new Product_Card();
        }

        private void btn_add_product_Click(object sender, RoutedEventArgs e)
        {
            Product_Card product_Card2 = new Product_Card();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg)|*.jpg;*.png;*.jpeg";
            if (title_tb.Text == "" || manufacturer_tb.Text == "" || price_tb.Text == "")
            {
                MessageBox.Show("Пожалуйста, сначала заполните поля");
            }
            else
            {


                if (openFileDialog.ShowDialog() == true)
                {
                    string imagePath = openFileDialog.FileName;
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    product_Card2.PhotoByte = imageData;

                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = new MemoryStream(imageData);
                    bitmapImage.EndInit();
                    photo_im.Source = bitmapImage;

                    Product_Card product_Card = new Product_Card
                    {
                        Title = title_tb.Text,
                        Manufacturer = manufacturer_tb.Text,
                        Active = Convert.ToBoolean(active_cb.IsChecked),
                        Price = Convert.ToDouble(price_tb.Text),
                        Description = descrip_tb.Text,
                        PhotoByte = imageData

                    };
                    using (var db = new ApplicationContext())
                    {
                        db.Products_Cards.Add(product_Card);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Товар добавлен");
                    Admin_Main_Part_Window admin_Main_Part_Window = new Admin_Main_Part_Window();
                    Close();
                    admin_Main_Part_Window.ShowDialog();
                }
            }

            
            
            
        }
        
        
        private void btn_image_Click(object sender, RoutedEventArgs e)
        {
            Product_Card product_Card = new Product_Card();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg)|*.jpg;*.png;*.jpeg";
            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                byte[] imageData = File.ReadAllBytes(imagePath);
                product_Card.PhotoByte = imageData;

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = new MemoryStream(imageData);
                bitmapImage.EndInit();
                photo_im.Source = bitmapImage;
                
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Admin_Main_Part_Window admin_Main_Part_Window = new Admin_Main_Part_Window();
            Close();
            admin_Main_Part_Window.ShowDialog();
        }

        
    }
}
