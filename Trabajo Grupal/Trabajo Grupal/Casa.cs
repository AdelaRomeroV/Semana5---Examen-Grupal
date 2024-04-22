using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal
{
    internal class Casa : Estructura
    {
        public float precio;
        public float salud;
        public float turnos;

        public Casa(float precio, float salud, float turnos) 
        {
            this.precio = precio;
            this.salud = salud;
            this.turnos = turnos;
        }

        public override void Beneficio(float a)
        {
            a += 1; 
        }

        public override float Precio() { return precio; }
        public override float Salud() { return salud; }
        public override float Turnos() { return turnos; }
    }
}
