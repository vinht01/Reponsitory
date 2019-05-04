using System;
using System.Collections.Generic;
using System.Text;
using ShopOnline.Data.EF.Infrastructure;
using ShopOnline.Data.Entities;
using ShopOnline.Data.IRepositories;

namespace ShopOnline.Data.EF.Repositories
{
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbContext) : base(dbContext)
        {
        }
    }
}
