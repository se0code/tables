using services.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace services.implementations
{
    public class Service<TEntity, TKey> : IService<TEntity, TKey>
        where TEntity : class
        where TKey : struct
    {
        public async Task<List<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetById(TKey id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Exist(TEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
