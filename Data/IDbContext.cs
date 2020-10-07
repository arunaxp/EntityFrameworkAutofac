using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IDbContext
    {

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();
        void Dispose();
    }
}
