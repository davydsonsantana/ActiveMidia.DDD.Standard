using System;
using System.Data;

namespace ActiveMidia.Infra.Context.Interfaces
{
    public interface IDapperContext : IDisposable
    {
        IDbConnection Connection { get; }
    }
}
