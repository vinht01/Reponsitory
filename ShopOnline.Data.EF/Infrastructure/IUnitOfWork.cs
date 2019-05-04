namespace ShopOnline.Data.EF.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}