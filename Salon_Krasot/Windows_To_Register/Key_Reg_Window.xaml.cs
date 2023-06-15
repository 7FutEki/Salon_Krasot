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
    /// Логика взаимодействия для Key_Reg_Window.xaml
    /// </summary>
    public partial class Key_Reg_Window : Window
    {
        public Key_Reg_Window()
        {
            InitializeComponent();
        }

        private void continue_key_btn_Click(object sender, RoutedEventArgs e)
        {
            if (key_TextBox.Text == "ключ")
            {
                Windows_To_Register.Reg_Admin_Window reg_Admin_Window = new Reg_Admin_Window();
                reg_Admin_Window.Show();
                this.Close();
            }
            else
                MessageBox.Show("Не верный ключ", "Внимание");
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
