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
            string[,] jose = new string[2, 4] { { "A", "B", "C", "D" }, { "E", "F", "G", "H" } };

            for (int fila = 0; fila < jose.GetLength(0); fila++)
            {
                
                for (int columna = 0; columna < jose.GetLength(1); columna++)
                {
                    Console.WriteLine(jose[fila,columna]);


                }



            }


        }
    } 
}
    
