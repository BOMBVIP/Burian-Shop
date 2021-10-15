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
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }

    public class User
    { 
        [Key]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
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
        public virtual Category Category { get; set; }
    }
}