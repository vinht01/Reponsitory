using ShopOnline.Data.EF.Infrastructure;
using ShopOnline.Data.Entities;
using ShopOnline.Data.IRepositories;

namespace ShopOnline.Data.EF.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory context) : base(context)
        {
        }
    }
}