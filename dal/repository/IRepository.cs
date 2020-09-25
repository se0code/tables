using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dal.repository
{
    interface IRepository<TEntity,TKey>
        where TEntity : class
        where TKey : struct

    {
        IQueryable<TEntity> GetAll();

        TEntity GetById(TKey key);


    }
}
