using System;

namespace Inmobiliaria.Dominio.Entidades
{
    public abstract class Propiedad : Entity
    {
        public String Direccion { get; private set; }

        public Propietario Propietario { get; private set; }

        public Int32 PrecioBase { get; protected set; }

        public Int32 Superficie { get; set; }

        public abstract Int32 Precio { get; }
    }
}
