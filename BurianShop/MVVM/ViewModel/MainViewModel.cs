using BurianShop.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurianShop.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<Product> Products { get; set; }
        public MainViewModel()
        {

        }
    }
}
