using System;

namespace ShopOnline.Data.EF.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        AppDbContext Init();
    }
}