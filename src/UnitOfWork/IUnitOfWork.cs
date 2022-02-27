using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void Dispose();
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
