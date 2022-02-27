using Domain.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork
{
    public class UnitOfWorkBase : IDisposable, IUnitOfWork
    {
       

        public UnitOfWorkBase(APIOMSContext Context
             )
        {
            _dbContext = Context;
        }

        public APIOMSContext _dbContext { get; }

        public int SaveChanges()
        {
            var iResult = _dbContext.SaveChanges();
            return iResult;
        }

        public async Task<int> SaveChangesAsync()
        {
            var iResult = await _dbContext.SaveChangesAsync();
            return iResult;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
