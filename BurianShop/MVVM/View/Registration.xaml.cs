using BurianShop.MVVM.ViewModel;
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
using BurianShopService;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BurianShopService.WPFServices;

namespace BurianShop.MVVM.View
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        MainViewModel mainViewModel = null;
        MainWindow mw = null;
        public Registration(MainViewModel mainViewModel, MainWindow mw)
        {
            InitializeComponent();
            this.mainViewModel = mainViewModel;
            this.mw = mw;
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            mw.Close();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            mw.Show();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }
       
        private void registerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(loginTxtBox.Text) || String.IsNullOrWhiteSpace(emailTxtBox.Text) || String.IsNullOrWhiteSpace(passwordPswBox.Password) || String.IsNullOrWhiteSpace(confirmPassPswdBox.Password) )
            {
                MessageBox.Show("Please, enter all fields!");
                return;
            }
            if (!BurianShopService.WPFServices.Validation.IsCorrectEmail(emailTxtBox.Text))
            {
                MessageBox.Show("Please, enter correct email!");
                return;
            }
            if (!BurianShopService.WPFServices.Validation.IsCorrectPassword(passwordPswBox.Password))
            {
                MessageBox.Show("Please, enter correct password!");
                return;
            }
            if (passwordPswBox.Password != confirmPassPswdBox.Password)
            {
                MessageBox.Show("Password does not match with re-enetered password!");
                return;
            }
            if (mainViewModel.Users.Any((el)=> el.Login == loginTxtBox.Text))
            {
                MessageBox.Show("User with same name already exists!");
                return;
            }
            try {
                mainViewModel.Context.Users.Add(new User { Login = loginTxtBox.Text, Password = passwordPswBox.Password, Email = emailTxtBox.Text });
                mainViewModel.Context.SaveChanges();
                MessageBox.Show($"Hi from BurianShop, {loginTxtBox.Text}!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
