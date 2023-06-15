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

namespace Salon_Krasot.Windows_To_Register
{
    /// <summary>
    /// Логика взаимодействия для Reg_Admin_Window.xaml
    /// </summary>
    public partial class Reg_Admin_Window : Window
    {
        public Reg_Admin_Window()
        {
            InitializeComponent();
        }

        private void out_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
