using System;
using System.Linq;

namespace TeduShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteMulti(Exception<Func<T, bool>> where);

        T GetSingleById(int id);
        T GetSingleByCondition(Exception<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);
        IQueryable<T> GetMulti(Exception<Func<T, bool>> predicate, string[] includes = null);
        IQueryable<T> GetMultiPaging(Exception<Func<T, bool>> filter, out int total, int index = 0,int size=50,string[] includes=null);

        int Count(Exception<Func<T, bool>> where);

        bool CheckContains(Exception<Func<T, bool>> predicate);
    }
}