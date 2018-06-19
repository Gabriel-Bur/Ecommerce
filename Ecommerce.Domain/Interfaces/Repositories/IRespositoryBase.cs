using System.Collections.Generic;


namespace Ecommerce.Domain.Interfaces.Repositories
{
    public interface IRespositoryBase<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Add(TEntity obj);

        void Remove(TEntity obj);

        void Update(TEntity obj);

        void Dispose();
    }
}
