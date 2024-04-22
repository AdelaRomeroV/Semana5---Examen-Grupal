using System;
using System.Collections.Generic;

namespace Trabajo_Grupal
{
    internal class Pueblo
    {
        List<Unidades> unidadesPendientes = new List<Unidades>();
        List<Estructura> estructurasPendientes = new List<Estructura>();


        List<Unidades> unidades = new List<Unidades>();
        List<Estructura> estructuras = new List<Estructura>();

        float unidadesMax;
        float energia;

        public Pueblo()
        {
            unidadesMax = 0;
            energia = 100;
        }

        public void Pendientes() //EJECUTAR CADA PASE DE TURNO
        {

            for (int i = 0; i < estructurasPendientes.Count; i++) //Estructuras pendientes
            {
                estructurasPendientes[i].turnos--;

                if (estructurasPendientes[i].turnos <= 0)
                {
                    estructuras.Add(estructurasPendientes[i]);
                    estructurasPendientes.Remove(estructurasPendientes[i]);
                }
            }
            for (int i = 0; i < unidadesPendientes.Count; i++) //Se busca hacer algo parecido con las unidades
            {
                //unidadesPendientes[i].turnos--;

                //if (unidadesPendientes[i].turnos <= 0)
                //{
                //    unidades.Add(unidadesPendientes[i]);
                //    unidadesPendientes.Remove(unidadesPendientes[i]);
                //}
            }



            foreach(Estructura e in estructuras) //Energia extra por granjas
            {
                if(e is Granja)
                {
                    energia += 5;
                }
            }
        }

        public void ConstruirBase()  //Construir Unidad (lo pueden editar si lo necesitan)
        {
            if(unidades.Count < unidadesMax)
            {
                Console.WriteLine("Selecciona la unidad que quieres contruir:");
                Console.WriteLine("1. Soldado - Energia para construir: 0");
                Console.WriteLine("2. Arquero - Enegria para construir: 50");

                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1: //Añadir Soldados
                        {
                            //Unidades u = new Soldado();
                            //unidadesPendientes.add(u);
                            break;
                        }
                    case 2: //Añadir Arqueros
                        {
                            if (energia >= 50)
                            {
                                //Unidades u = new Arquero();
                                //unidadesPendientes.add(u);
                                energia -= 50;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("No tiene energia suficiente para construir esta unidad\n");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        }
                    default: //Opcion Incorrecta
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opcion Invalida\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("No tiene casas disponibles para otra unidad");
            }

            
        }

        public void ConstruirEstructura()
        {
            Console.WriteLine("Selecciona que estructura quieres construir:");
            Console.WriteLine("1. Granja: +5 energía");
            Console.WriteLine("2. Torre: +Daño");
            Console.WriteLine("3. Casa: +1 Unidad");

            int opt = int.Parse (Console.ReadLine());

            switch (opt)
            {
                case 1:  //GRANJA---------------------
                    {
                        if(energia >= 50)
                        {
                            Estructura e = new Granja(50, 10, 5);
                            estructurasPendientes.Add(e);
                            energia -= 50;
                        }
                        else
                        {
                            Console.WriteLine("Energia insuficiente\n");
                        }

                        break;
                    }
                case 2: //TORRE----------------------
                    {
                        if(energia >= 100)
                        {
                            Estructura e = new Torre(100, 50, 10);
                            estructurasPendientes.Add (e);
                            energia -= 100;
                        }
                        else
                        {
                            Console.WriteLine("Energia insuficiente\n");
                        }

                        break;
                    }
                case 3: //CASA-------------------------
                    {
                        if(energia >= 50)
                        {
                            Estructura e = new Casa(50, 10, 2);
                            estructurasPendientes.Add(e);
                            energia -= 50;
                        }
                        else
                        {
                            Console.WriteLine("Energia insuficiente\n");
                        }

                        break;
                    }
                default:
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Opcion invalida\n");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                    }
            }
        }

        public void VerBase() //Muestra las Variables, unidades y estructuras (tambien las que se estan construyendo)
        {
            int soldados = 0;
            int arqueros = 0;

            int granjas = 0;
            int torres = 0;
            int casas = 0;

            //VARIABLES
            Console.WriteLine($"Energia: {energia}");
            Console.WriteLine($"Unidades: {unidades.Count}/{unidadesMax}");

            //UNIDADES----------------------------------------------
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Unidades");

            Console.ForegroundColor= ConsoleColor.DarkGray;
            for (int i = 0; i < unidades.Count; i++)
            {
                //Conteo si son soldados
                if (unidades[i] is Soldado) soldados++;

                //Conteo si son arqueros
                else if (unidades[i] is Arquero) arqueros++;

            }

            Console.WriteLine($"Soldados: {soldados}");
            Console.WriteLine($"Arqueros: {arqueros}\n");


            //UNIDADES PENDIENTES-----------------------------------
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Unidades Pendientes");
            for(int i = 0; i < unidadesPendientes.Count; i++)
            {
                if (unidadesPendientes[i] is Soldado) Console.WriteLine("Soldado - Turnos restantes: {unidades[i].turno}");
                else Console.WriteLine("Arquero - Turnos restantes: {unidades[i].turno}");
            }

            //ESTRUCTURAS-------------------------------------------
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Estructuras");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            for(int i = 0;i < estructuras.Count; i++)
            {
                //Conteo de Granjas
                if (estructuras[i] is Granja) granjas++;

                //Conteo de torres
                else if (estructuras[i] is Torre) torres++;

                //Conteo de casas
                else casas++;
            }

            Console.ForegroundColor =ConsoleColor.White;
            Console.WriteLine($"Granjas: {granjas}");
            Console.WriteLine($"Torres: {torres}");
            Console.WriteLine($"Casas: {casas}");

            //ESTRUCTURAS PENDIENTES--------------------------------
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Estructuras Pendientes");
            for( int i = 0; i < estructurasPendientes.Count; i++ )
            {
                if (estructurasPendientes[i] is Granja) Console.WriteLine($"Granja - Turnos Restante: {estructurasPendientes[i].turnos}");
                else if (estructurasPendientes[i] is Torre) Console.WriteLine($"Torre - Turnos Restante: {estructurasPendientes[i].turnos}");
                else Console.WriteLine($"Casa - Turnos Restante: {estructurasPendientes[i].turnos}");
            }


        }

        public List<Unidades> Unidades //Lista para acceder desde JUEGO
        {
            get { return unidades; }
        }

        public List<Estructura> Estructuras //Lista para acceder desde JUEGO
        {
            get { return estructuras; }
        }

        public float Energia //Energia para acceder desde JUEGO
        {
            get { return energia; }
            set { energia = value; }
        }
    }
}
