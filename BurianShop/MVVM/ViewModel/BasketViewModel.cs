using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BurianShop.MVVM.ViewModel
{
    public class BasketViewModel : INotifyPropertyChanged
    {

        private int id;
        private int userId;
        private UserViewModel user;
        private ICollection<ProductViewModel> products;

        public ICollection<ProductViewModel> Products { get => products; set { products = value; OnPropertyChanged(); } }


        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        public int UserId
        {
            get { return userId; }
            set { userId = value; OnPropertyChanged(); }
        }
        public UserViewModel User
        {
            get { return user; }
            set { user = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
