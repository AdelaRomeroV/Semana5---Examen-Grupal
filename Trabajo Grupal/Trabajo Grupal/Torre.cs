using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal
{
    internal class Torre : Estructura
    {
        public Torre(float precio, float salud, float turnos)
        {
            this.precio = precio;
            this.salud = salud;
            this.turnos = turnos;
        }

        public override void Beneficio(float a)
        {
            a = 5;
        }
    }
}
