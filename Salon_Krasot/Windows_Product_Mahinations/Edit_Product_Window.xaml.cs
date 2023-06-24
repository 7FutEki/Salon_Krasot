using Microsoft.Win32;
using Salon_Krasot.Models;
using Salon_Krasot.Windows_Application_Menu;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Salon_Krasot.Windows_Product_Mahinations
{
    /// <summary>
    /// Логика взаимодействия для Edit_Product_Window.xaml
    /// </summary>
    public partial class Edit_Product_Window : Window
    {
        private Product_Card product;
        public Edit_Product_Window(Product_Card editProduct)
        {
            InitializeComponent();
            DataContext = editProduct;
            LoadPhoto(editProduct);
        }
        private void LoadPhoto(Product_Card product_Card)
        {
            using (var db = new ApplicationContext())
            {
                var s = db.Products_Cards.Where(x=>x.Title == product_Card.Title).ToList();
                foreach (var item in s)
                {
                    if (product_Card.Photo != null)
                    {

                        if (item.PhotoByte == null)
                        {
                            continue;
                        }
                        else
                        {
                            BitmapImage bitmapImage = new BitmapImage();
                            bitmapImage.BeginInit();
                            bitmapImage.StreamSource = new MemoryStream(item.PhotoByte);
                            bitmapImage.EndInit();
                            product_image.Source = bitmapImage;
                        }
                    }
                    else
                    {
                        product_Card.Photo = $"pack://application:,,,/{item.Photo}";
                    }
                }
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Product_Main_Window product_Main = new Product_Main_Window((Product_Card)DataContext);
            Close();
            product_Main.Show();
        }

        private void btn_add_product_Click(object sender, RoutedEventArgs e)
        {
            var editedProduct = (Product_Card)DataContext;
            using (var dbContext = new ApplicationContext())
            {
                Product_Card editProduct = dbContext.Products_Cards.FirstOrDefault(p => p.Id == editedProduct.Id);
                if (editProduct!=null)
                {
                    editProduct.PhotoByte = editedProduct.PhotoByte;
                    editProduct.Title = editedProduct.Title;
                    editProduct.Manufacturer = editedProduct.Manufacturer;
                    editProduct.Active = editedProduct.Active;
                    editProduct.Price = editedProduct.Price;
                    editProduct.Description = editedProduct.Description;

                    dbContext.SaveChanges();

                }
                Product_Main_Window product_Main = new Product_Main_Window(editedProduct);
                Close();
                product_Main.Show();


            }
        }

        private void btn_image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png, *.jpg, *.jpeg, *.gif, *.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                byte[] photoBytes = File.ReadAllBytes(filePath);

                var editedProduct = (Product_Card)DataContext;
                editedProduct.PhotoByte = photoBytes;

                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = new MemoryStream(photoBytes);
                bitmapImage.EndInit();
                product_image.Source = bitmapImage;
            }
        }
    }
}
