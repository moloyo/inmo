using Inmobiliaria.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Inmobiliaria.DataAccess
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly DataContext dataContext;

        public Repository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.dataContext.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return this.dataContext.Set<TEntity>().SingleOrDefault(e => e.Id == id);
        }
    }
}
