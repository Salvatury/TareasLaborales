using System;

namespace _001.Ejercicios
{
    internal class BatallaPokemon
    {
        /*
        * Crea un programa que calcule el daño de un ataque durante
        * una batalla Pokémon.
        * - La fórmula será la siguiente: daño = 50 * (ataque / defensa) * efectividad
        * - Efectividad: x2 (súper efectivo), x1 (neutral), x0.5 (no es muy efectivo)
        * - Sólo hay 4 tipos de Pokémon: Agua, Fuego, Planta y Eléctrico 
        * - El programa recibe:
        *  - Tipo del Pokémon atacante.
        *  - Tipo del Pokémon defensor.
        *  - Ataque: Entre 1 y 100.
        *  - Defensa: Entre 1 y 100.
        */

        public static void Ejecutar()
        {
            string tipoAtacante = "Fuego"; // Agua, Fuego, Planta, Electrico
            string tipoDefensor = "Planta";
            int ataque = 80;
            int defensa = 40;

            if (!EstadisticasValidas(ataque, defensa))
            {
                Console.WriteLine("El ataque/defensa deben estar entre 1 y 100");
                return;
            }

            double efectividad = ObtenerEfectividad(tipoAtacante, tipoDefensor);

            double danio = CalcularDanio(ataque, defensa, efectividad);

            MostrarResultado(tipoAtacante, tipoDefensor, ataque, defensa, efectividad, danio);
        }

        public static bool EstadisticasValidas(int ataque, int defensa)
        {
            if (ataque < 1 || ataque > 100)
            {
                return false;
            }

            if (defensa < 1 || defensa > 100)
            {
                return false;
            }

            return true;
        }

        public static double ObtenerEfectividad(string tipoAtacante, string tipoDefensor)
        {
            if (EsSuperEf(tipoAtacante, tipoDefensor))
            {
                return 2;
            }

            if (NoEsMuyEf(tipoAtacante, tipoDefensor))
            {
                return 0.5;
            }

            return 1;
        }

        public static bool EsSuperEf(string tipoAtacante, string tipoDefensor)
        {
            if (tipoAtacante == "Agua" && tipoDefensor == "Fuego")
            {
                return true;
            }

            if (tipoAtacante == "Fuego" && tipoDefensor == "Planta")
            {
                return true;
            }

            if (tipoAtacante == "Planta" && tipoDefensor == "Agua")
            {
                return true;
            }

            if (tipoAtacante == "Electrico" && tipoDefensor == "Agua")
            {
                return true;
            }

            return false;
        }

        public static bool NoEsMuyEf(string tipoAtacante, string tipoDefensor)
        {
            if (tipoAtacante == tipoDefensor)
            {
                return true;
            }

            if (tipoAtacante == "Agua" && tipoDefensor == "Planta")
            {
                return true;
            }

            if (tipoAtacante == "Fuego" && tipoDefensor == "Agua")
            {
                return true;
            }

            if (tipoAtacante == "Planta" && tipoDefensor == "Fuego")
            {
                return true;
            }

            if (tipoAtacante == "Electrico" && tipoDefensor == "Planta")
            {
                return true;
            }

            return false;
        }

        public static double CalcularDanio(int ataque, int defensa, double efectividad)
        {
            double danio = 50 * (ataque / (double)defensa) * efectividad;

            return danio;
        }

        public static void MostrarResultado(
            string tipoAtacante,
            string tipoDefensor,
            int ataque,
            int defensa,
            double efectividad,
            double danio)
        {
            Console.WriteLine($"Atacante: {tipoAtacante}");
            Console.WriteLine($"Defensor: {tipoDefensor}");
            Console.WriteLine($"Ataque: {ataque}");
            Console.WriteLine($"Defensa: {defensa}");
            Console.WriteLine($"Efectividad: x{efectividad}");
            Console.WriteLine($"Daño causado: {danio}");
        }
    }
}