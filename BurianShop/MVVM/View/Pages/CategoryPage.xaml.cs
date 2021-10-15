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

namespace BurianShop.MVVM.View.Pages
{
    /// <summary>
    /// Interaction logic for CategoryPage.xaml
    /// </summary>
    public partial class CategoryPage : Page
    {
        ShopModel context;
        public CategoryPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        public void CreateNewCategory(string name)
        {
            try
            {
                context = new ShopModel();
                context.Categories.Add(new Category() { Name = name });
                context.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
