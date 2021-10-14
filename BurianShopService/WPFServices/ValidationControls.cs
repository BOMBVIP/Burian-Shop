using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace BurianShopService.WPFServices
{
    public static class Validation
    {
        //private static bool IsTextBoxEmptyOrWhiteSpace(TextBox textBox, string text)
        //{
        //    if (String.IsNullOrWhiteSpace(textBox.Text))
        //    {
        //        MessageBox.Show($"Please enter correct, {text}");
        //        return true;
        //    }
        //    return false;
        //}
        //private static bool IsPasswordBoxEmptyOrWhiteSpace(PasswordBox passwordBox, string text)
        //{
        //    if (String.IsNullOrWhiteSpace(passwordBox.Password))
        //    {
        //        MessageBox.Show($"Please enter correct, {text}");
        //        return true;
        //    }
        //    return false;
        //}
        public static bool IsCorrectEmail(string email) {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsCorrectPassword(string password)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(password) || password.Length < 8)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
