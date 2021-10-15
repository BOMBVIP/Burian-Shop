using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurianShop.MVVM
{
    public class ShopModelInitializer : DropCreateDatabaseIfModelChanges<ShopModel>
    {
        protected override void Seed(ShopModel context)
        {
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
