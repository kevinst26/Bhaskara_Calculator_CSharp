﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bhaskara_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


        double a, b, c, d, raiz, x1, x2;
            

        Console.Write("Valor de a: ");
        a = Convert.ToDouble(Console.ReadLine());


        Console.Write("Valor de b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor de c: ");
        c = Convert.ToDouble(Console.ReadLine());

        d = (b * b) - 4 * a * c;
        Console.WriteLine("Valor de Delta: " + d);

        raiz = Math.Sqrt(d);
        x1 = ((-b) + (raiz)) / (2 * a);
        x2 = ((-b) - (raiz)) / (2 * a);

        Console.WriteLine("Valor de x1: " + x1);
        Console.WriteLine("Valor de x2: " + x2);


        Console.ReadKey();


        }
    }
}
