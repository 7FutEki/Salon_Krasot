using Salon_Krasot.Models;
using Salon_Krasot.Windows_Application_Menu;
using System;
using System.Collections.Generic;
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
        public Edit_Product_Window(Product_Card editProduct)
        {
            InitializeComponent();
            DataContext = editProduct;
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Product_Main_Window product_Main = new Product_Main_Window((Product_Card)DataContext);
            Close();
            product_Main.Show();
            ///переделать, работает криво
        }

        private void btn_add_product_Click(object sender, RoutedEventArgs e)
        {
            var editedProduct = (Product_Card)DataContext;
            using (var dbContext = new ApplicationContext())
            {
                Product_Card editProduct = dbContext.Products_Cards.FirstOrDefault(p => p.Id == editedProduct.Id);
                if (editProduct!=null)
                {
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

        }
    }
}
