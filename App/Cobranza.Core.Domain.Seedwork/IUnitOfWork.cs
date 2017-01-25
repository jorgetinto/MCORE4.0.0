using System;

namespace Cobranza.Core.Domain.Seedwork
{
    public interface IUnitOfWork
        : IDisposable
    {
        void Commit();

        void CommitAndRefreshChanges();

        void RollbackChanges();
    }
}
