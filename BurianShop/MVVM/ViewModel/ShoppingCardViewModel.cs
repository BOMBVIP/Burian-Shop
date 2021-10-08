using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BurianShop.MVVM.ViewModel
{
    public class ShoppingCardViewModel : INotifyPropertyChanged
    {

        private int id;
        private List<string> products;

        public List<string>  Products
        {
            get { return products; }
            set { products = value; OnPropertyChanged(); }
        }


        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
