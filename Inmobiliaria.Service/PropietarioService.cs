using Inmobiliaria.DataAccess;
using Inmobiliaria.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria.Service
{
    public class PropietarioService
    {
        private readonly IRepository<Propietario> repository;

        private IDataContext dataContext;

        public PropietarioService(IDataContext dataContext, IRepository<Propietario> repository)
        {
            this.dataContext = dataContext;

            this.repository = repository;
        }

        public IEnumerable<Propietario> GetAll()
        {
            using (this.dataContext.CreateReadOnly())
            {

            }
        }
    }
}
