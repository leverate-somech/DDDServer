using System;

namespace Core
{
    public interface IUnitOfWork : IDisposable
    {
        void RegisterNew(BaseAggregate aggregate);
        void RegisterDirty(BaseAggregate aggregate);
        void RegisterDeleted(BaseAggregate aggregate);        

        void Commit();
        void Rollback();
    }
}