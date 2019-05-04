using System;
using System.Collections.Generic;
using System.Text;
using ShopOnline.Data.EF.Infrastructure;
using ShopOnline.Data.Entities;
using ShopOnline.Data.IRepositories;

namespace ShopOnline.Data.EF.Repositories
{
    public class FunctionRepository : RepositoryBase<Function>, IFunctionRepository
    {
        public FunctionRepository(IDbFactory context) : base(context)
        {
        }
    }
}
