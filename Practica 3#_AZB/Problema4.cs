using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3__AZB
{
    internal class Problema4
    {


        public void practica5()
        {
            string[,] matriz_bi = new string[2, 4] { { "A", "B", "C", "D" }, { "E", "F", "G", "H" } };

            for (int fila = 0; fila < matriz_bi.GetLength(0); fila++)
            {
                
                for (int columna = 0; columna < matriz_bi.GetLength(1); columna++)
                {
                    Console.Write("{0,-5}|" ,matriz_bi[fila,columna]);


                }
                Console.WriteLine();


            }


        }
    } 
}
    
