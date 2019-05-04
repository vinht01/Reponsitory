using System;
using System.Collections.Generic;
using System.Text;
using ShopOnline.Data.EF.Infrastructure;
using ShopOnline.Data.Entities;
using ShopOnline.Data.IRepositories;

namespace ShopOnline.Data.EF.Repositories
{
    public class BlogTagRepository : RepositoryBase<BlogTag>, IBlogTagRepository
    {
        public BlogTagRepository(IDbFactory context) : base(context)
        {
        }
    }
}
