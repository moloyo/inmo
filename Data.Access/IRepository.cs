using Inmobiliaria.Dominio.Entidades;
using System.Collections.Generic;

namespace Inmobiliaria.DataAccess
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}
