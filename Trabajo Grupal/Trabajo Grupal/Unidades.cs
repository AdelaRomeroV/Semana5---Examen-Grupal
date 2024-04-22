using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal
{
    internal class Unidades
    {
        public float precio;
        public float salud;
        public float turnos;
        public float ataque;

        public virtual float Precio()
        {
            return precio;
        }
        public virtual float Salud()
        {
            return salud;
        }
        public virtual float Ataque()
        {
            return ataque;
        }
        public virtual float Turnos()
        {
            return turnos;
        }
    }
}
