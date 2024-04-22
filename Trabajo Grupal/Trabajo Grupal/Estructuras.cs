using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal
{
    internal class Estructura
    {
        public float precio;
        public float salud;
        public float turnos;

        public virtual void Beneficio(float a) { }
        public virtual float Precio() { return precio; }
        public virtual float Salud() { return salud; }
        public virtual float Turnos() { return turnos; }
    }
}
