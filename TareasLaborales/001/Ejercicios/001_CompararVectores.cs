using System;
using System.Collections.Generic;

namespace _001.Ejercicios
{
    internal class CompararVectores
    {
        public static void Ejecutar()
        {
            int[] v1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] v2 = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            List<int> resultado = CompararVectoresEnteros(v1, v2, false);

            foreach (int numero in resultado)
            {
                Console.WriteLine(numero);
            }
        }

        static List<int> CompararVectoresEnteros(int[] v1, int[] v2, bool comp)
        {
            List<int> resultado = new List<int>();

            foreach (int numeroV1 in v1)
            {
                bool existe = false;

                foreach (int numeroV2 in v2)
                {
                    if (numeroV1 == numeroV2)
                    {
                        existe = true;
                        break;
                    }
                }

                if (comp == true)
                {
                    if (existe)
                    {
                        resultado.Add(numeroV1);
                    }
                }
                else
                {
                    if (!existe)
                    {
                        resultado.Add(numeroV1);
                    }
                }
            }

            if (comp == false)
            {
                foreach (int numeroV2 in v2)
                {
                    bool existe = false;

                    foreach (int numeroV1 in v1)
                    {
                        if (numeroV2 == numeroV1)
                        {
                            existe = true;
                            break;
                        }
                    }

                    if (!existe)
                    {
                        resultado.Add(numeroV2);
                    }
                }
            }

            return resultado;
        }
    }
}