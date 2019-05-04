using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ShopOnline.Data.EF;

namespace ShopOnline.App_Start
{
    internal class DatabaseSetup
    {
        public static void Initialize()
        {
            Database.SetInitializer(new DbInitializer());

            using (var db = new AppDbContext())
            {
                db.Database.Initialize(true);
            }
        }
    }
}