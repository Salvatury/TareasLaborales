using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.Ejercicios
{
    internal class ComprimirPalabra
    {
        /*
         * Creá un método que reciba una palabra y la comprima contando cuántas veces aparece cada letra de forma consecutiva.
         * palabra = "aaabbccccdaa"
         * Resultado: a3b2c4d1a2
         */
        public static void Ejecutar()
        {
            string palabra = "Hooola eeeesto esss uuuuna prueba del programa";

            string resultado = ComprimirTexto(palabra);

            Console.WriteLine("Texto original: " + palabra);
            Console.WriteLine("Texto comprimido: " + resultado);
        }

        public static string ComprimirTexto(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "";
            }

            string resultado = "";
            int contador = 1;

            for (int i = 1; i < texto.Length; i++)
            {
                if (texto[i] == texto[i - 1])
                {
                    contador++;
                }
                else
                {
                    resultado += texto[i - 1].ToString() + contador;
                    contador = 1;
                }
            }

            resultado += texto[texto.Length - 1].ToString() + contador;

            return resultado;
        }

    }
}
