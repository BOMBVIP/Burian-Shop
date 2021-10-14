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
        ShopModel context ;
        public ObservableCollection<ProductViewModel> Products { get; set; }
        public ObservableCollection<UserViewModel> Users { get; set; }
        public ObservableCollection<ShoppingCardViewModel> ShoppingCards { get; set; }
        public RellayCommand LoadCommand { get; set; }
        private ProductViewModel _product;
        public ProductViewModel Product
        {
            get => _product;
            set { _product = value; OnPropertyChanged(); }
        }
        ShopModel _context;
        Mapper _mapper;

        public MainViewModel()
        {
            Console.WriteLine("uihi");
            context = new ShopModel();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Role, RoleViewModel>().ReverseMap();
                c.CreateMap<Product, ProductViewModel>().ReverseMap();
                c.CreateMap<ShoppingCard, ShoppingCardViewModel>().ReverseMap();
                c.CreateMap<User, UserViewModel>().ReverseMap();
            });
            _mapper = new Mapper(config);
            _context = context;
            Products = new ObservableCollection<ProductViewModel>(_mapper.Map<IEnumerable<ProductViewModel>>(context.Products.ToList()));
            MessageBox.Show($"Count users: {context.Users.Count()}");
            foreach (var item in context.Users)
            {
                Console.WriteLine(item.Login);
                Console.WriteLine(item.Password);
            }
            ShoppingCards = new ObservableCollection<ShoppingCardViewModel>(_mapper.Map<IEnumerable<ShoppingCardViewModel>>(context.ShoppingCarts.ToList()));
            Users = new ObservableCollection<UserViewModel>(_mapper.Map<IEnumerable<UserViewModel>>(context.Users.ToList()));
            

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
