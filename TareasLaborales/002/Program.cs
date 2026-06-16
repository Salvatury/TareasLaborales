using System;
using System.Collections.Generic;

namespace PiedraPapelTijera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> jugadasPlayer1 = new List<string>();
            List<string> jugadasPlayer2 = new List<string>();

            jugadasPlayer1.Add("R");
            jugadasPlayer2.Add("S");

            jugadasPlayer1.Add("S");
            jugadasPlayer2.Add("S");

            jugadasPlayer1.Add("P");
            jugadasPlayer2.Add("S");

            string ganador = ConteoPartidas(jugadasPlayer1, jugadasPlayer2);

            Console.WriteLine("Ganador final: " + ganador);

            Console.ReadKey();
        }

        public static string ConteoPartidas(List<string> jugadasPlayer1, List<string> jugadasPlayer2)
        {
            int puntajePlayer1 = 0;
            int puntajePlayer2 = 0;

            int posicion = 0;

            foreach (string jugadaPlayer1 in jugadasPlayer1)
            {
                string jugadaPlayer2 = jugadasPlayer2[posicion];

                if (jugadaPlayer1 == jugadaPlayer2)
                {
                    Console.WriteLine("Empate en la partida " + (posicion + 1));
                }
                else if (jugadaPlayer1 == "R" && jugadaPlayer2 == "S")
                {
                    Console.WriteLine("Player 1 gana la partida " + (posicion + 1));
                    puntajePlayer1++;
                }
                else if (jugadaPlayer1 == "S" && jugadaPlayer2 == "P")
                {
                    Console.WriteLine("Player 1 gana la partida " + (posicion + 1));    
                    puntajePlayer1++;
                }
                else if (jugadaPlayer1 == "P" && jugadaPlayer2 == "R")
                {
                    Console.WriteLine("Player 1 gana la partida " + (posicion + 1));
                    puntajePlayer1++;
                }
                else
                {
                    Console.WriteLine("Player 2 gana la partida " + (posicion + 1));
                    puntajePlayer2++;
                }

                posicion++;
            }

            return "";
        }
    }
}