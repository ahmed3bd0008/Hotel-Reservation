using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IGenericRepository<T>
    {
        Task AddEntityAsync(T message);
        void AddEntity(T entity);
        void updateEntity(T entity);
        List<T> getEntity (bool track);
        Task< List<T>> getEntityAsync (bool track);
         IQueryable<T> getEntity (Expression<Func<T,bool>> expression,bool track);
        T getEntityById(int id);
        Task< T> getEntityAsyncById(int id);
        void Remove(T Entity);
        int saveRepos();
    }
}