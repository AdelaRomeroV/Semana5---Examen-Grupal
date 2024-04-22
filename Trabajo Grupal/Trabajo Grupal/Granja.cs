using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal
{
    internal class Granja : Estructura
    {
        public Granja(float precio, float salud, float turnos)
        {
            this.precio = precio;
            this.salud = salud;
            this.turnos = turnos;
        }

        public override void Beneficio(float a)
        {
            a += 5;
        }

        public override float Precio() { return precio; }
        public override float Salud() { return salud; }
        public override float Turnos() { return turnos; }
    }
}
