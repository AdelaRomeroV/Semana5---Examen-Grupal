using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal
{
    internal class Juego
    {
        public float turno;
        public float EnemigosEliminados;
        public float EstructurasConstruidas;

        bool continueFlag = true;
        public void Stars()
        {
            Console.WriteLine("Bienvenido a juego de estrategia");

            Console.WriteLine("Inicia el juego");
            Console.WriteLine("Selecciona que accion quieres realizar: ");

            Console.WriteLine("1. Ver base");
            Console.WriteLine("2. Construir Estructura");
            Console.WriteLine("3. Construir Unidad");
            Console.WriteLine("4. ");
            Console.WriteLine("5. Iniciar Combate");

            int opt = int.Parse(Console.ReadLine());

            switch (opt) 
            {
                case 1:
                    
                    break;

                case 2:
                    
                    break;
            }


        }

        public void VerBase()
        {

        }

        public void ConstruirEstructura()
        {

        }

        public void ConstruirUnidad()
        {

        }

        public void PasarTurno()
        {

        }

        public void IniciarCombate()
        {

        }
    }
}
