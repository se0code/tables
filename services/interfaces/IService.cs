using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace services.interfaces
{
    public interface IService<TEntity,TKey>
        where TEntity: class
        where TKey:struct
    {
        Task<List<TEntity>> GetAll();

        Task<TEntity> GetById(TKey id);

        Task<bool> Exist(TEntity model);
    }
}
