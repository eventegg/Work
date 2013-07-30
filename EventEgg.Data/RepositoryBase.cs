using System;
using System.Linq;
using System.Linq.Expressions;
using EventEgg.Data.Infrastructure;
using NHibernate;
using NHibernate.Linq;

namespace EventEgg.Data
{
    public abstract class RepositoryBase<T> : IRepository<T>, IDisposable
        where T : class
    {
        private readonly ISessionFactory _sessionFactory;
        private readonly ISession _session;
        readonly UnitOfWork _unitOfWork = null;

        protected RepositoryBase()
        {
            _sessionFactory = SessionFactory.CreateFactory<T>();
            _unitOfWork = new UnitOfWork(_sessionFactory);
            _session = _unitOfWork.Session;
        }

        #region Implementation of IRepository<T>

        /// <summary>
        /// Yeni kayit ekle
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            try
            {
                _session.Save(item);
                _unitOfWork.Commit();
            }
            catch
            {
                _unitOfWork.Rollback();
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }

        public void Update(T item)
        {

            try
            {
                _session.Update(item);
                _unitOfWork.Commit();
            }
            catch
            {
                _unitOfWork.Rollback();
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }

        public void Delete(T item)
        {
            try
            {
                _session.Delete(item);
                _unitOfWork.Commit();
            }
            catch
            {
                _unitOfWork.Rollback();
            }
            finally
            {
                _unitOfWork.Dispose();
            }
        }

        public T SingleBy(Expression<Func<T, bool>> query)
        {
            return _session.Query<T>().SingleOrDefault(query);
        }

        public IQueryable<T> Query()
        {
            return _session.Query<T>().AsQueryable();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> query)
        {
            return _session.Query<T>().Where(query).AsQueryable();
        }

        public long Count(Expression<Func<T, bool>> query)
        {
            return _session.Query<T>().LongCount(query);
        }

        public void Dispose()
        {
            _session.Dispose();
            _sessionFactory.Dispose();
        }

        #endregion
    }
}
