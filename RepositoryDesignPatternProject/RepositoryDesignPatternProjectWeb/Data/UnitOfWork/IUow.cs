using RepositoryDesignPatternProjectWeb.Data.Interfaces;

namespace RepositoryDesignPatternProjectWeb.Data.UnitOfWork
{
    public interface IUow
    {
        public IRepository<T> GetRepository<T>() where T : class, new();
        public void SaveChanges();
    }
}