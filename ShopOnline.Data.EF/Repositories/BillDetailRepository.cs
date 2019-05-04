using ShopOnline.Data.EF.Infrastructure;
using ShopOnline.Data.Entities;
using ShopOnline.Data.IRepositories;

namespace ShopOnline.Data.EF.Repositories
{
    public class BillDetailRepository : RepositoryBase<BillDetail>, IBillDetailRepository
    {
        public BillDetailRepository(DbFactory context) : base(context)
        {
        }
    }
}