using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal
{
    internal class Arquero : Unidades
    {


        public Arquero(float precio, float salud, float turnos, float ataque)
        {
            this.precio = precio;
            this.salud = salud;
            this.turnos = turnos;
            this.ataque = ataque;
        }
    }
}
