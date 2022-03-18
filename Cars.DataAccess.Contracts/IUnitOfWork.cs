using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.DataAccess.Contracts
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();

    }
}
