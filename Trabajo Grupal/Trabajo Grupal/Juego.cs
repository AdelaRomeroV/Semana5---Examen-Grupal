﻿using System;
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
        public float Energia;

        Pueblo pueblo;
        public void Stars()
        {
            pueblo = new Pueblo();
            Console.WriteLine("Bienvenido a juego de estrategia");

            Console.WriteLine("Inicia el juego");
            Console.WriteLine("Selecciona que accion quieres realizar: ");

            Console.WriteLine("1. Ver base");
            Console.WriteLine("2. Construir Estructura");
            Console.WriteLine("3. Construir Unidad");
            Console.WriteLine("4. Iniciar Combate");
            Console.WriteLine("5. Pasar turno");

            int opt = int.Parse(Console.ReadLine());

            switch (opt) 
            {
                case 1:
                    VerBase();
                    break;

                case 2:
                    ConstruirEstructura();
                    break;

                case 3:
                    ConstruirUnidad();
                    break;

                case 4:
                    PasarTurno();
                    break;
            }
        }

        public void VerBase()
        {
            pueblo.VerBase();
        }

        public void ConstruirEstructura()
        {
            pueblo.ConstruirEstructura();
        }

        public void ConstruirUnidad()
        {
            pueblo.ConstruirBase();
        }

        public void PasarTurno()
        {
            pueblo.Energia += 20;

        }

        public void IniciarCombate()
        {


        }
    }
}
