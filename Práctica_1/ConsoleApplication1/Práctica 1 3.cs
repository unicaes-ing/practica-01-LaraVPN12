using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_1_3
    {
        static void Main(string[] args)
        {
            int numero;
            double raiz;

            System.Console.Write("Ingrese un número entero positivo: ");
            numero = System.Convert.ToInt32(System.Console.ReadLine());
            if (numero > 0)
            {
                raiz = Math.Sqrt(numero);
                System.Console.WriteLine();
                System.Console.WriteLine("La raíz cuadrada de {0 } es {1}", numero, raiz);
                System.Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine("El número es negativo");
                System.Console.ReadKey();
            }
            
           


        }
    }
}
