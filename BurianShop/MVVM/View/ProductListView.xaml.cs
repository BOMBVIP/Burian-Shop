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

namespace BurianShop.MVVM.View
{
    /// <summary>
    /// Interaction logic for ProductListView.xaml
    /// </summary>
    public partial class ProductListView : Window
    {
        public ProductListView()
        {
            InitializeComponent();
        }

        private List<Products> GetProducts()
        {
            return new List<Products>()
            {
                new Products("Banana", 22, "./Icons/banana.jpg"),
                new Products("Banana1", 22, "./Icons/banana.jpg"),
                new Products("Banana2", 22, "./Icons/banana.jpg"),
                new Products("Banana3", 22, "./Icons/banana.jpg"),
                new Products("Banana4", 22, "./Icons/banana.jpg"),
                new Products("Banana5", 22, "./Icons/banana.jpg"),
            };
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
    }
}
