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
            string[,] matriz_bi = new string[2, 2] { { "Rojo", "Verde" }, { "Azul", "Amarillo"} };

            for (int fila = 0; fila < matriz_bi.GetLength(0); fila++)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"elementos de la fila  {fila}");
                Console.WriteLine("--------------------------------");
                for (int columna = 0; columna < matriz_bi.GetLength(1); columna++)
                {
                    Console.WriteLine($"Posicion = {columna} palabra = " + matriz_bi[fila  , columna] );


                }



            }


        }
    }
}
