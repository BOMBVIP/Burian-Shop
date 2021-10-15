using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace BurianShop.MVVM.View.Pages
{
    /// <summary>
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        ShopModel context;
        public ProductPage()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CreateNewProduct(tbName.Text, (byte)Int32.Parse(tbDiscrount.Text), tbDescribe.Text, File.ReadAllBytes(tbPathToImage.Text)) ;
        }
        private void CreateNewProduct(string name,byte discount,string describe,byte[] image)
        {
            try
            {
                context = new ShopModel();
                context.Products.Add(new Product()
                {
                    Name = name,
                    Description = describe,
                    Discount = discount,
                    ProductImage = image,
                });
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void LoadComboBox()
        {
            cbCategory.Items.Add(new Category() { Name = "Fruits" });
            cbCategory.Items.Add(new Category() { Name = "Vegetables" });
            cbCategory.Items.Add(new Category() { Name = "Sweets" });
            cbCategory.Items.Add(new Category() { Name = "Bread products" });
            cbCategory.Items.Add(new Category() { Name = "Alcohol" });
        }
    }
}
