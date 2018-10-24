using System;
using System.Data;

namespace ActiveMidia.Infra.Context.Interfaces
{
    public interface IUnitOfWork 
    {
        IDapperContext Context { get; }
        IDbTransaction Transaction { get; }
        IDbTransaction BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.RepeatableRead);
        void Commit();
        void Rollback();
    }
}
