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

            int[] resultado = CompararVectores(v1, v2, true); //aca dependiendo que queramos comparar, le pasamos true o false

            for (int i = 0; i <resultado.Length; i++)
            {
                Console.WriteLine(resultado[i]);
            }
            
        }

        static int[] CompararVectores(int[] v1, int[] v2, bool comp) //agregar for each y devolver listas para mejorar el codigo
        {
            int[] resultadoAux = new int[v1.Length + v2.Length];
            int indiceAux = 0;

            for (int i = 0; i < v1.Length; i++)
            {
                bool existe = false;

                for (int j = 0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        existe = true;
                    }
                }

                if (comp && existe)
                {
                    resultadoAux[indiceAux] = v1[i];
                    indiceAux++;
                }

                if (!comp && !existe)
                {
                    resultadoAux[indiceAux] = v1[i];
                    indiceAux++;
                }
            }

            if (!comp)
            {
                for (int i = 0; i < v2.Length; i++)
                {
                    bool existe = false;

                    for (int j = 0; j < v1.Length; j++)
                    {
                        if (v2[i] == v1[j])
                        {
                            existe = true;
                        }
                    }

                    if (!existe)
                    {
                        resultadoAux[indiceAux] = v2[i];
                        indiceAux++;
                    }
                }
            }

            int[] resultadoFinal = new int[indiceAux];

            for (int i = 0; i < indiceAux; i++)
            {
                resultadoFinal[i] = resultadoAux[i];
            }

            return resultadoFinal;
        }
    }
}
