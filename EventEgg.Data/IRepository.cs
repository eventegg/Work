using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NHibernate;

namespace EventEgg.Data
{
    public interface IRepository<T> where T : class
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);

        T SingleBy(Expression<Func<T, bool>> query);
        IQueryable<T> Query();
        IQueryable<T> Query(Expression<Func<T, bool>> query);
        long Count(Expression<Func<T, bool>> query);
    }
}
