﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar um algoritmo que imprima a média aritmética entre os números 8, 9 e 7.
namespace Exerccicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int y = 9;
            int z = 7;
            double resultado = 0;
            resultado = (x + y + z) / 3;
            Console.WriteLine("A média de {0}, {1} e {2} é: {3}", x, y, z, resultado);
            Console.ReadLine();
        }
    }
}
