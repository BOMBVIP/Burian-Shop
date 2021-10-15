using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurianShop.MVVM
{
    public class ShopModelInitializer : CreateDatabaseIfNotExists<ShopModel>
    {
        protected override void Seed(ShopModel context)
        {
            User adminUser = context.Users.Add(new User { Login = "admin", Password = "admin2281337" });
            User simpleUser = context.Users.Add(new User { Login = "s1mple", Password = "sosikapapirimskogo2009"});
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
