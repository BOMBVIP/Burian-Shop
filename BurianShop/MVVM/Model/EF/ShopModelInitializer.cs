using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurianShop.MVVM
{
    public class ShopModelInitializer : DropCreateDatabaseAlways<ShopModel>
    {
        protected override void Seed(ShopModel context)
        {
            Category fruits = context.Categories.Add(new Category { Name = "Fruits" });
            Category bakery = context.Categories.Add(new Category { Name = "Bakery" });
            Category for_cooking = context.Categories.Add(new Category { Name = "For cooking" });
            context.SaveChanges();
            Role user = context.Roles.Add(new Role { Name = "User" });
            Role admin = context.Roles.Add(new Role { Name = "Admin" });
            context.SaveChanges();
            User adminUser = context.Users.Add(new User { Login = "admin", Password = "admin2281337" });
            User simpleUser = context.Users.Add(new User { Login = "s1mple", Password = "sosikapapirimskogo2009"});
            context.SaveChanges();
            context.Products.Add(new Product { Name = "Banana", Category = fruits, Price = 20});
            context.Products.Add(new Product { Name = "Oil", Category = for_cooking, Price = 33});
            context.Products.Add(new Product { Name = "Bread", Category = bakery, Price = 17});
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
