using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BurianShop.MVVM.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private byte discount;
        private string description;
        private byte[] image;
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }


        public byte[] Image
        {
            get { return image; }
            set { image = value; OnPropertyChanged(); }
        }


        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(); }
        }


        public byte Discount
        {
            get { return discount; }
            set { discount = value; OnPropertyChanged(); }
        }

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
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
