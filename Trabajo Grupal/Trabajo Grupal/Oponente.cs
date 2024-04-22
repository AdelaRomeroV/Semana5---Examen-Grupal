using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Grupal
{
    internal class Oponente
    {
        List<Unidades> unidades = new List<Unidades>();
        List<Estructura> estructuras = new List<Estructura>();

        int turnos;

        //numero primos
        int numeroActual = 2;
        int Primo = 2;

        //fibonacci
        int fibAnterior = 0;
        int fibActual = 1;

        public Oponente(int turnos)
        {
            this.turnos = turnos;
        }

        public void Turnos() //Ejecutar cada pase de turno cuando inicie la batalla
        {
            turnos++;

            if(turnos >= 10)
            {
                numeroActual++;

                if(Primo == numeroActual)
                {
                    CrearUnidades();
                    HallarPrimo();
                }
            }

        }

        int HallarPrimo() //Obtiene el siguiente numero primo
        {
            bool esPrimo;

            do
            {
                esPrimo = true;
                Primo++;

                // Verificar si el número actual es primo
                for (int i = 2; i <= Math.Sqrt(Primo); i++)
                {
                    if (Primo % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            } while (!esPrimo);

            return Primo;
        }


        public void CrearUnidades()
        {
            for(int i = 0; i < Fibonacci(); i++)
            {
                //Unidades u = new Soldado();

                //unidades.Add(u);
            }

        }

        int Fibonacci() //Obtiene el siguiente digito de fibonacci
        {
            int temp = fibActual;
            fibActual = fibAnterior + fibActual;
            fibAnterior = temp;

            return fibActual;
        }

    }
}
