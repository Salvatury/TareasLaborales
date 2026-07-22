using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.Ejercicios
{
    internal class CifradoCesar
    {
        /*
         * Crea un programa que realize el cifrado César de un texto y lo imprima.
         * También debe ser capaz de descifrarlo cuando así se lo indiquemos.
         *
         * Te recomiendo que busques información para conocer en profundidad cómo
         * realizar el cifrado. Esto también forma parte del reto.
         */

        public static void Ejecutar()
        {
            Console.Write("Ingrese un texto: ");
            string texto = Console.ReadLine();

            Console.Write("Ingrese el desplazamiento: ");
            int desplazamiento = int.Parse(Console.ReadLine());

            string textoCifrado = CifrarTexto(texto, desplazamiento);

            Console.WriteLine("Texto original: " + texto);
            Console.WriteLine("Texto cifrado: " + textoCifrado);
        }

        public static string CifrarTexto(string texto, int cifrado)
        {
            string resultado = "";

            cifrado = cifrado % 26;

            for (int i = 0; i < texto.Length; i++)
            {
                char caracter = texto[i];

                if (caracter >= 'a' && caracter <= 'z')
                {
                    char nuevaLetra = (char)(caracter + cifrado);

                    if (nuevaLetra > 'z')
                    {
                        nuevaLetra = (char)(nuevaLetra - 26);
                    }

                    resultado += nuevaLetra;
                }
                else if (caracter >= 'A' && caracter <= 'Z')
                {
                    char nuevaLetra = (char)(caracter + cifrado);

                    if (nuevaLetra > 'Z')
                    {
                        nuevaLetra = (char)(nuevaLetra - 26);
                    }

                    resultado += nuevaLetra;
                }
                else
                {
                    resultado += caracter;
                }
            }

            return resultado;
        }


    }
}
