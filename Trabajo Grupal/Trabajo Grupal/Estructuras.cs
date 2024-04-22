using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal
{
    internal class Estructura
    {
        public virtual void Beneficio(float a) { }
        public virtual float Precio() { return 0; }
        public virtual float Salud() { return 0; }
        public virtual float Turnos() { return 0; }
    }
}
