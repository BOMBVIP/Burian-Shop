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
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        ShopModel context;
        public UserPage()
        {
            InitializeComponent();
        }

        private void btnNewAccount_Click(object sender, RoutedEventArgs e)
        {
            CreateNewAccount(tbLogin.Text, tbPassword.Text, tbEmail.Text);
        }
        private void CreateNewAccount(string login,string password,string email)
        {
            try
            {
                context.Users.Add(new User()
                {
                    Login = login,
                    Password = password,
                    Email = email
                });
                context.SaveChanges();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
