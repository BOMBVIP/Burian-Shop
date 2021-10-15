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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BurianShop.MVVM.View
{
    /// <summary>
    /// Interaction logic for AdminPanelView.xaml
    /// </summary>
    public partial class AdminPanelView : Window
    {
        MainWindow mw = null;
        MainViewModel mainViewModel = null;
        public AdminPanelView(ViewModel.MainViewModel mainViewModel, MainWindow mw)
        {
            InitializeComponent();
            this.mainViewModel = mainViewModel;
            this.mw = mw;
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonTurn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void ButtonMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            else
                Application.Current.MainWindow.WindowState = WindowState.Normal;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            mw.Close();
        }

        private void btnShopingCard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRoles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
