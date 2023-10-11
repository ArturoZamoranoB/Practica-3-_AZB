using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3__AZB
{
    internal class Problema2
    {
        public void practica2()
        {
            string[,] jose = new string[2, 2] { { "Rojo", "Verde" }, { "Azul", "Amarillo"} };

            for (int fila = 0; fila < jose.GetLength(0); fila++)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"elementos de la fila  {fila}");
                Console.WriteLine("--------------------------------");
                for (int columna = 0; columna < jose.GetLength(1); columna++)
                {
                    Console.WriteLine($"Posicion = {columna} palabra = " + jose[fila  , columna] );


                }



            }


        }
    }
}
