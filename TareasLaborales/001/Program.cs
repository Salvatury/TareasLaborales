using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] v2 = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            List<int> resultado = CompararVectores(v1, v2, false); //aca dependiendo que queramos comparar, le pasamos true o false

            foreach (int numero in resultado)
            {
                Console.WriteLine(numero);
            }

        }

        static List<int> CompararVectores(int[] v1, int[] v2, bool comp) //agregar for each y devolver listas para mejorar el codigo
        {
            List<int> resultado = new List<int>();

            foreach (int numeroV1 in v1)//recorro v1
            {
                bool existe = false;

                foreach (int numeroV2 in v2)//recorro v2
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
