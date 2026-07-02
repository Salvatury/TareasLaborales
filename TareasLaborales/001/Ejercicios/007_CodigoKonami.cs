using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001.Ejercicios
{
    internal class CodigoKonami
    {
        /*
         * Crea un programa que detecte cuando el famoso "Código Konami" se ha
         * introducido correctamente desde el teclado.
         * Si sucede esto, debe notificarse mostrando un mensaje en la terminal.
         * El Código Konami es una famosa secuencia de comandos que activa trucos y EasterEggs:
         * \(\uparrow, \uparrow, \downarrow, \downarrow, \leftarrow, \rightarrow, \leftarrow, \rightarrow, B, A\)
         */

        public static void Ejecutar()
        {
            Console.WriteLine("Ingrese la secuencia de teclas (W=Arriba, S=Abajo, A=Izquierda, D=Derecha, B=B, V=A):");
            
            string secuencia = Console.ReadLine().ToUpper();    

        }
    }
}
