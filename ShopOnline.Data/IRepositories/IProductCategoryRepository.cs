using ShopOnline.Data.Entities;
using System.Collections.Generic;

namespace ShopOnline.Data.IRepositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }
}