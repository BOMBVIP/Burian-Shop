using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BurianShop.MVVM.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {
        ShopModel context = null;
        private int id;
        private string login;
        private string password;
        private int roleId;
        private decimal money;
        public event PropertyChangedEventHandler PropertyChanged;


        public int Id { get => id; set { id = value; OnPropertyChanged(); } }
        public string Login { get => login; set { login = value; OnPropertyChanged(); } }
        public string Password { get => password; set { password = value; OnPropertyChanged(); } }
        public int RoleId { get => roleId; set { roleId = value; OnPropertyChanged(); } }
        public decimal Money { get => money; set { money = value; OnPropertyChanged(); } }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //public UserViewModel(ShopModel context)
        //{
        //    this.context = context;
        //}
    }
}
