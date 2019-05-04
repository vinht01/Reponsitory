using ShopOnline.Data.EF.Infrastructure;
using ShopOnline.Data.Entities;
using ShopOnline.Data.IRepositories;

namespace ShopOnline.Data.EF.Repositories
{
    public class WholePriceRepository : RepositoryBase<WholePrice>, IWholePriceRepository
    {
        public WholePriceRepository(IDbFactory context) : base(context)
        {
        }
    }
}