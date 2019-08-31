using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_1_2
    {
        static void Main(string[] args)
        {
            double numero1, numero2,suma,resta,multiplicacion,division;

            System.Console.Write("Ingrese un numero decimal: ");
            numero1 = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Ingrese otro número decimal: ");
            numero2 = System.Convert.ToDouble(System.Console.ReadLine());
            suma = numero1 + numero2;
            resta = numero1 - numero2;
            multiplicacion = numero1 * numero2;
            division = numero1 / numero2;
            System.Console.WriteLine();
            System.Console.WriteLine(" {0} más {1} es igual a {2}\n {0} menos {1} es igual a {3}\n {0} por {1} es igual a {4}\n"+
            " {0} entre {1} es igual a {5}",numero1, numero2, suma, resta, multiplicacion, division);
            System.Console.ReadKey();
            
        }
    }
}
