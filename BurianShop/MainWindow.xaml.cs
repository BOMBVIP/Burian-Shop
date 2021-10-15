using BurianShop.MVVM.View;
using BurianShop.MVVM.ViewModel;
using BurianShopService;
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

namespace BurianShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel = new MainViewModel();
        public MainWindow()
        {
            this.DataContext = mainViewModel;
            InitializeComponent();
        }


        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
        private void signInBtn_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"{loginTxtBox.Text}, {passwordTxtBox.Password}");
            //foreach (var item in FindVisualChildren<TextBox>(this))
            //{
            //    Console.WriteLine(item);
            //}
            
            if (String.IsNullOrWhiteSpace(loginTxtBox.Text))
            {
                MessageBox.Show("Please, enter a login");
                return;
            }
            if (String.IsNullOrWhiteSpace(passwordTxtBox.Password))
            {
                MessageBox.Show("Please, enter a password");
                return;
            }
            //foreach (var item in mainViewModel.Users)
            //{
            //    Console.WriteLine(item.Login);
            //    Console.WriteLine(item.Password);
            //}
            if (!mainViewModel.Context.Users.Any((el)=> el.Login == loginTxtBox.Text))
            {
                MessageBox.Show("Incorrect user name!");
                return;
            }
            var user = mainViewModel.Context.Users.Where((el) => el.Login == loginTxtBox.Text).First();
            if (user != null && user.Password == passwordTxtBox.Password)
            {
                MessageBox.Show($"Logined as {user.Login}");
                mainViewModel.LoginedUser = user;
                mainViewModel.UpdateProducts();
                ProductListView productListView = new ProductListView(mainViewModel, this);
                productListView.Show();
                this.Hide();
                return;
            }
            //if ()
            //{

            //}
                
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void signOutBtn_Click(object sender, RoutedEventArgs e)
        {

            Registration registration = new Registration(mainViewModel, this);
            registration.Show();
            this.Hide();
        }
    }
}
