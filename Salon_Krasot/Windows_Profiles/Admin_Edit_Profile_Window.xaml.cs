﻿using System;
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

namespace Salon_Krasot.Windows_Profiles
{
    /// <summary>
    /// Логика взаимодействия для Admin_Edit_Profile_Window.xaml
    /// </summary>
    public partial class Admin_Edit_Profile_Window : Window
    {
        public Admin_Edit_Profile_Window()
        {
            InitializeComponent();
            
        }
        
        private void btn_exit_profile_Click(object sender, RoutedEventArgs e)
        {
            
            Admin_Profile_Window admin_Profile_Window = new Admin_Profile_Window();
            Close();
            admin_Profile_Window.ShowDialog();
        }

        private void btn_edit_image_Click(object sender, RoutedEventArgs e)
        {

        }

        private void save_edit_profile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
