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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Salon_Krasot.Windows_Application_Menu;
using Salon_Krasot.Windows_Profiles;
using Salon_Krasot.Windows_To_Register;
using Salon_Krasot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.IO;

namespace Salon_Krasot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Database.Migrate();
            this.KeyDown += authorization_btn_KeyDown;

        }
       
        private void reg_admin_btn_Click(object sender, RoutedEventArgs e)
        {
            Key_Reg_Window key_Reg_Window = new Key_Reg_Window();
            Close();
            key_Reg_Window.Show();
            
        }
        private void reg_user_btn_Click(object sender, RoutedEventArgs e)
        {
            
            Reg_User_Window reg_User_Window = new Reg_User_Window();
            Close();
            reg_User_Window.ShowDialog();

        }

        private void continue_btn_Click(object sender, RoutedEventArgs e)
        {
            Gost_Main_Part_Window  gost_main_Part_Window = new Gost_Main_Part_Window();
            Close();
            gost_main_Part_Window.Show();

        }

        private void authorization_btn_Click(object sender, RoutedEventArgs e)
        {
            ApplicationContext db = new ApplicationContext();
            string login = login_tb.Text;
            string password = password_pb.Password;
            using (var context = new ApplicationContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
                var admin = context.Admins.FirstOrDefault(x => x.Login== login && x.Password == password);

                if (user != null)
                {
                    string loginforprofile = "";
                    var loguser = context.Users.Where(y => y.Login == login);
                    foreach (var item in loguser)
                    {
                        loginforprofile = item.Login;
                    }
                    ForLogin forLogin = new ForLogin()
                    {
                        Login = loginforprofile
                    };
                    db.ForLogin.Add(forLogin);
                    db.SaveChanges();
                    

                    User_Main_Part_Window user_Main_Part_Window = new User_Main_Part_Window();
                    user_Main_Part_Window.Show();
                    Close();
                }
                else if (admin != null)
                {
                    string loginprofile2 = "";
                    var logadmin = context.Admins.Where(b => b.Login == login);
                    foreach (var item in logadmin)
                    {
                        loginprofile2= item.Login;
                    }
                    ForLogin forLogin = new ForLogin()
                    {
                        Login = loginprofile2
                    };
                    db.ForLogin.Add(forLogin);
                    db.SaveChanges();

                    Admin_Main_Part_Window admin_Main_Part_Window = new Admin_Main_Part_Window();
                    admin_Main_Part_Window.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }

            }
        }

        private void authorization_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                authorization_btn_Click(sender, e);
            }
        }
    }
}
