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

namespace Salon_Krasot.Windows_Application_Menu
{
    /// <summary>
    /// Логика взаимодействия для SalesHistory_Window.xaml
    /// </summary>
    public partial class SalesHistory_Window : Window
    {
        private ApplicationContext DBcontext;
        public ObservableCollection<Product_Sale_History> SalesProducts { get; set; }
        public SalesHistory_Window()
        {
            InitializeComponent();
            DataContext = this;
            DBcontext= new ApplicationContext();
            LoadSalesHistory();
        }

        private void LoadSalesHistory()
        {
            SalesProducts = new ObservableCollection<Product_Sale_History>(DBcontext.Product_Sale_History.ToList());
        }


        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Admin_Main_Part_Window admin_Main_Part_Window = new Admin_Main_Part_Window();
            Close();
            admin_Main_Part_Window.ShowDialog();
        }
    }
}
