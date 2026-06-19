using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _001.Ejercicios
{
    internal class OctalToHexadecimal
    {
        /*
        * Crea una función que reciba un número decimal y lo transforme a Octal
        * y Hexadecimal.
        * - No está permitido usar funciones propias del lenguaje de programación que
        * realicen esas operaciones directamente.
        */
        public static void Ejecutar()
        {
            int numeroDecimal = 147;

            string numeroOctal = ConvertirAOctal(numeroDecimal);
            string numeroHexadecimal = ConvertirAHexadecimal(numeroDecimal);

            Console.WriteLine("Número decimal: " + numeroDecimal);
            Console.WriteLine("Número octal: " + numeroOctal);
            Console.WriteLine("Número hexadecimal: " + numeroHexadecimal);
        }

        public static string ConvertirAOctal(int numeroDecimal)
        {
            List<int> restos = new List<int>();
            string resultado = "";

            while (numeroDecimal > 0)
            {
                int resto = numeroDecimal % 8;

                restos.Add(resto);

                numeroDecimal = numeroDecimal / 8;
            }

            for (int i = restos.Count - 1; i >= 0; i--)
            {
                resultado = resultado + restos[i].ToString();
            }

            return resultado;
        }

        public static string ConvertirAHexadecimal(int numeroDecimal)
        {
            List<int> restos = new List<int>();
            string resultado = "";

            while (numeroDecimal > 0)
            {
                int residuo = numeroDecimal % 16;

                restos.Add(residuo);

                numeroDecimal = numeroDecimal / 16;
            }

            for (int i = restos.Count - 1; i >= 0; i--)
            {
                string caracterHexadecimal = ConvertirResiduoAHexadecimal(restos[i]);

                resultado = resultado + caracterHexadecimal;
            }

            return resultado;
        }

        public static string ConvertirResiduoAHexadecimal(int resto)
        {
            switch (resto)
            {
                case 10:
                    return "A";
                case 11:
                    return "B";
                case 12:
                    return "C";
                case 13:
                    return "D";
                case 14:
                    return "E";
                case 15:
                    return "F";
                default:
                    return resto.ToString();
            }
        }
    }
}



/*
 * public static void Ejecutar()
        {
            int numeroDecimal = 147;

            string numeroOctal = ConvertirAOctal(numeroDecimal);
            string numeroHexadecimal = ConvertirAHexadecimal(numeroDecimal);

            Console.WriteLine("Número decimal: " + numeroDecimal);
            Console.WriteLine("Número octal: " + numeroOctal);
            Console.WriteLine("Número hexadecimal: " + numeroHexadecimal);
        }
        
        public static string ConvertirAOctal(int numeroDecimal)
        {
            string resultado = "";

            while (numeroDecimal > 0)
            {
                int resto = numeroDecimal % 8;

                resultado = resto.ToString() + resultado;

                numeroDecimal = numeroDecimal / 8;
            }

            return resultado;
        }

        public static string ConvertirAHexadecimal(int numeroDecimal)
        {
            string resultado = "";

            while (numeroDecimal > 0)
            {
                int resto = numeroDecimal % 16;

                string caracterHexadecimal = ConvertirRestoAHexadecimal(resto);

                resultado = caracterHexadecimal + resultado;

                numeroDecimal = numeroDecimal / 16;
            }

            return resultado;
        }
        public static string ConvertirRestoAHexadecimal(int resto)
        {
            switch (resto)
            {
                case 10:
                    return "A";

                case 11:
                    return "B";

                case 12:
                    return "C";

                case 13:
                    return "D";

                case 14:
                    return "E";

                case 15:
                    return "F";

                default:
                    return resto.ToString();
            }
        }
*/