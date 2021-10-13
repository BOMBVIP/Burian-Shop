using BurianShop.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BurianShop.MVVM
{
    public class ShopModel : DbContext
    {
        public ShopModel()
            : base("name=ShopModel")
        {
            Database.SetInitializer(new ShopModelInitializer());
        }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingCard> ShoppingCarts { get; set; }
    }

    public class User
    { 
        [Key]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int RoleId { get; set; }
        public decimal Money { get; set; }
        // Navigation property
        public virtual Role Role { get; set; }
    }
    public class ShoppingCard
    {
        [Required]
        public int UserId { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }

    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }

    public class Product
    {
        [Required] 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public byte Discount { get; set; }
        public string Description { get; set; }
        public byte[] ProductImage { get; set; }
        public int? CategoryId { get; set; }
        public Category category { get; set; }
    }


    public class Role
    {
        [Key]
        public string Name { get; set; }
        // Navigation properties
        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}