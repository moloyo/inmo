using System;

namespace Inmobiliaria.Dominio.Entidades
{
    public class Propietario : Entity
    {
        public String Nombre { get; private set; }

        public String Apellido { get; private set; }

        public String Telefono { get; private set; }
    }
}
