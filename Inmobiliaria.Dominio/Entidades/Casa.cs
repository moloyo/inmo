using System;

namespace Inmobiliaria.Dominio.Entidades
{
    public class Casa : Propiedad
    {
        public Boolean TienePatio { get; private set; }

        public override Int32 Precio { get => TienePatio ? PrecioBase + 10000 : PrecioBase; }
    }
}
