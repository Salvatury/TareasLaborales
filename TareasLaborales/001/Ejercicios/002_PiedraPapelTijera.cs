using System;
using System.Collections.Generic;

namespace _001.Ejercicios
{
    internal class PiedraPapelTijera
    {
        /*
         * Crea un programa que calcule quien gana más partidas al piedra,
         * papel, tijera.
         * - El resultado puede ser: "Player 1", "Player 2", "Tie" (empate)
         * - La función recibe un listado que contiene pares, representando cada jugada.
         * - El par puede contener combinaciones de "R" (piedra), "P" (papel)
         *   o "S" (tijera).
         * - Ejemplo. Entrada: [("R","S"), ("S","R"), ("P","S")]. Resultado: "Player 2".
         */
        public static void Ejecutar()
        {
            List<string> jugadasPlayer1 = new List<string>();
            List<string> jugadasPlayer2 = new List<string>();

            jugadasPlayer1.Add("R");
            jugadasPlayer2.Add("P");

            jugadasPlayer1.Add("S");
            jugadasPlayer2.Add("S");

            jugadasPlayer1.Add("P");
            jugadasPlayer2.Add("S");

            string ganador = ConteoPartidas(jugadasPlayer1, jugadasPlayer2);

            Console.WriteLine("Ganador: " + ganador);
        }

        public static string ConteoPartidas(List<string> jugadasPlayer1, List<string> jugadasPlayer2)
        {
            int puntajePlayer1 = 0;
            int puntajePlayer2 = 0;

            for (int i = 0; i < jugadasPlayer1.Count; i++)
            {
                string jugadaPlayer1 = jugadasPlayer1[i];
                string jugadaPlayer2 = jugadasPlayer2[i];

                if (jugadaPlayer1 == jugadaPlayer2)
                {
                    Console.WriteLine("Empate en la partida " + (i + 1));
                }
                else if (jugadaPlayer1 == "R" && jugadaPlayer2 == "S")
                {
                    Console.WriteLine("Player 1 gana la partida " + (i + 1));
                    puntajePlayer1++;
                }
                else if (jugadaPlayer1 == "S" && jugadaPlayer2 == "P")
                {
                    Console.WriteLine("Player 1 gana la partida " + (i + 1));
                    puntajePlayer1++;
                }
                else if (jugadaPlayer1 == "P" && jugadaPlayer2 == "R")
                {
                    Console.WriteLine("Player 1 gana la partida " + (i + 1));
                    puntajePlayer1++;
                }
                else
                {
                    Console.WriteLine("Player 2 gana la partida " + (i + 1));
                    puntajePlayer2++;
                }
            }

            Console.WriteLine("Puntaje Player 1: " + puntajePlayer1);
            Console.WriteLine("Puntaje Player 2: " + puntajePlayer2);

            if (puntajePlayer1 > puntajePlayer2)
            {
                return "Player 1";
            }
            else if (puntajePlayer2 > puntajePlayer1)
            {
                return "Player 2";
            }
            else
            {
                return "Tie";
            }
        }
    }
}

