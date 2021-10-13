using BurianShop.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BurianShop.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<ProductViewModel> Products { get; set; }
        public RellayCommand LoadCommand { get; set; }
        private ProductViewModel _product;
        public ProductViewModel Product
        {
            get => _product;
            set { _product = value; OnPropertyChanged(); }
        }
        ShopModel _context;
        Mapper _mapper;

        public MainViewModel(ShopModel context)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<Product, ProductViewModel>().ReverseMap();
            });
            _mapper = new Mapper(config);
            _context = context;
            Products = new ObservableCollection<ProductViewModel>(_mapper.Map<IEnumerable<ProductViewModel>>(context.Products.ToList()));
            

            //Products.Add(new ProductViewModel
            //{
            //    Id = 2312321,
            //    Name="Banana",
            //    Description = "Banana from Kavkaz",
            //    Category = "Fruits",
            //    Discount = 12,
            //    Image = new byte[] {1,2,3,4}
            //});
            //Products.Add(new ProductViewModel
            //{
            //    Id = 42342324,
            //    Name="Orange",
            //    Description = "Orange from Gruzin",
            //    Category = "Fruits",
            //    Discount = 50,
            //    Image = new byte[] {1,2,3,4}
            //});
            //Products.Add(new ProductViewModel
            //{
            //    Id = 46542321,
            //    Name="Redberry",
            //    Description = "Redberry from Ukraine",
            //    Category = "Fruits",
            //    Discount = 99,
            //    Image = new byte[] {1,2,3,4}
            //});
        }

    }
}
