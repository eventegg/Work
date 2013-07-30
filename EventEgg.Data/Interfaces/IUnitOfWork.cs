using System;

namespace EventEgg.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
