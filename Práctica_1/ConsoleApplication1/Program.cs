using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, especie;
            int edad;

            System.Console.Write("Ingrese el nombre de su mascota: ");
            nombre = System.Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Ingrese la especie de su mascota: ");
            especie = System.Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Ingrese la edad de su {0}: ", especie);
            edad = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine("Nombre de la mascota: {0}\nEspecie de la mascota: {1}\nEdad del {1}: {2} años", nombre, especie, edad);
            System.Console.ReadKey();
        }
    }
}
