using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace _001.Ejercicios
{
    internal class Escalera
    {
        /*
         * Crea una función que dibuje una escalera según su número de escalones.
         * - Si el número es positivo, será ascendente de izquiera a derecha.
         * - Si el número es negativo, será descendente de izquiera a derecha.
         * - Si el número es cero, se dibujarán dos guiones bajos (__).

         *         _
         *       _|         
         *     _|
         *   _|
         * _|
         *
         */

        public static void Ejecutar()
        {
            Console.WriteLine("Cantidad de escalones:");
            int escalones = int.Parse(Console.ReadLine());

            DibujarEscalera(escalones);
        }

        public static void DibujarEscalera(int escalones)
        {
            if (escalones == 0)
            {
                Console.WriteLine("__");
                return;
            }

            if (escalones > 0)
            {
                string espaciosInicio = CrearEspacios(escalones * 2);
                Console.WriteLine(espaciosInicio + "_");

                int cantidadEspacios = (escalones - 1) * 2;

                for (int fila = 0; fila < escalones; fila++)
                {
                    string espacios = CrearEspacios(cantidadEspacios);

                    Console.WriteLine(espacios + "_|");

                    cantidadEspacios = cantidadEspacios - 2;
                }
            }

            if (escalones < 0)
            {
                int cantidadEscalones = escalones * -1;
                int cantidadEspacios = 1; //correccion estetica por que queda superpuesto con la linea de abajo

                Console.WriteLine("_");

                for (int fila = 0; fila < cantidadEscalones; fila++)
                {
                    string espacios = CrearEspacios(cantidadEspacios);

                    Console.WriteLine(espacios + "|_");

                    cantidadEspacios = cantidadEspacios + 2;
                }
            }
        }

        public static string CrearEspacios(int cantidad)
        {
            string espacios = "";

            for (int i = 0; i < cantidad; i++)
            {
                espacios = espacios + " ";
            }

            return espacios;
        }



    }
}
