using BurianShop.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using System.Windows;

namespace BurianShop.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public ShopModel Context;
        public User LoginedUser { get; set; } = null;
        //public ObservableCollection<ProductViewModel> Products { get; set; }
        public ObservableCollection<UserViewModel> Users { get; set; }
        private ObservableCollection<ProductViewModel> products;
        public ObservableCollection<ProductViewModel> Products { get => products; set { products = value; OnPropertyChanged(); } }

        public ObservableCollection<BasketViewModel> Baskets { get; set; }
        public RellayCommand LoadCommand { get; set; }
        //private ProductViewModel _product;
        //public ProductViewModel Products
        //{
        //    get => _product;
        //    set { _product = value; OnPropertyChanged(); }
        //}
        ShopModel _context;
        Mapper _mapper;
        public void UpdateProducts() {
           
            Products = new ObservableCollection<ProductViewModel>(_mapper.Map<IEnumerable<ProductViewModel>>(Context.Products.ToList()));
            
        }
        public void UpdateBaskets() {
            Baskets = new ObservableCollection<BasketViewModel>(_mapper.Map<IEnumerable<BasketViewModel>>(Context.Baskets.ToList()));
        }
        public void UpdateUsers() {
            Users = new ObservableCollection<UserViewModel>(_mapper.Map<IEnumerable<UserViewModel>>(Context.Users.ToList()));
        }
        public MainViewModel()
        {
            Context = new ShopModel();
            var config = new MapperConfiguration(c =>
            {      
                c.CreateMap<Role, RoleViewModel>().ReverseMap();
                c.CreateMap<Product, ProductViewModel>().ReverseMap();
                c.CreateMap<User, UserViewModel>().ReverseMap();
                c.CreateMap<Basket, BasketViewModel>().ReverseMap();
            });
            _mapper = new Mapper(config);
            _context = Context;
            // Products = new ObservableCollection<ProductViewModel>(_mapper.Map<IEnumerable<ProductViewModel>>(Context.Products.ToList()));

            //ShoppingCards = new ObservableCollection<ShoppingCardViewModel>(_mapper.Map<IEnumerable<ShoppingCardViewModel>>(Context.ShoppingCarts.ToList()));
           


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
