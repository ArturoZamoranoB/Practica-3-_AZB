﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3__AZB
{
    internal class Problema3
    {
        public void practica3()
        {
            double[,] matriz_bi = new double[4, 3] { {1.4, 4, 5.5 }, { 8, 21 ,4}, { 15.2, 3, 5.5 }, { 17.3, 15 , 5.2} };
             double sumacolumna = 0;
            double resultado = 0;

            for (int fila = 0; fila < matriz_bi.GetLength(0); fila++)
            {
                

                for (int columna = 0; columna < matriz_bi.GetLength(1); columna++)
                {
                    sumacolumna = matriz_bi[fila,columna] + sumacolumna;
                  




                }

                
                


            }
            Console.WriteLine(resultado =  sumacolumna);


        }
    }
}
