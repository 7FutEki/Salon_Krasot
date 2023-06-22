using Salon_Krasot.Models;
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
    /// Логика взаимодействия для Product_Story_Window.xaml
    /// </summary>
    public partial class Product_Story_Window : Window
    {
        private ApplicationContext dbContext;
        Product_Card product = new Product_Card();
        public ObservableCollection<Product_Sale_History> Products { get; set; }
        public Product_Story_Window()
        {
            InitializeComponent();
        }

      

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Product_Main_Window product_Main_Window = new Product_Main_Window(product);
            Close();
            product_Main_Window.ShowDialog();
        }
    }
}
