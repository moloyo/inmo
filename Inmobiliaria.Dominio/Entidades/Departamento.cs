using System;

namespace Inmobiliaria.Dominio.Entidades
{
    public class Departamento : Propiedad
    {
        public Int32 Piso { get; private set; }

        public Char Letra { get; set; }

        public override Int32 Precio { get => PrecioBase + 1000 * Piso; }
    }
}
