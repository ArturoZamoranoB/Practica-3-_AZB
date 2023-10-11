using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3__AZB
{
    internal class Problema1
    {
        public void practica()
        {
            int[,] jose = new int[3, 3] { { 2, 6, 7 }, { 8, 9, 1 }, { 3, 4, 5 } };

            for (int fila = 0; fila < jose.GetLength(0); fila++)
            
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"elementos de la fila {fila}");
                Console.WriteLine("--------------------------------");
                for (int columna = 0; columna < jose.GetLength(1); columna++)
                {
                    Console.WriteLine($"Posicion = {columna}  Numero = " + jose[fila, columna]);



                }



            }


        }
    }
}
