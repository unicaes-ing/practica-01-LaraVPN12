using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_1_1
    {
        static void Main(string[] args)
        {
            string nombre, cargo, correo, fecha;
            int edad;
            double sueldo;

            System.Console.Write("Ingrese el nombre del empleado: ");
            nombre = System.Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Ingrese el cargo de {0}: ",nombre);
            cargo = System.Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Ingrese la edad de {0}: ", nombre);
            edad = System.Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Ingrese el correo de {0}: ", nombre);
            correo = System.Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Ingrese la fecha de contratación de {0}: ", nombre);
            fecha = System.Convert.ToString(System.Console.ReadLine());
            System.Console.Write("Ingrese el sueldo de {0}: ", nombre);
            sueldo = System.Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine();
            System.Console.WriteLine(" Nombe del Empleado: {0}\n Cargo de {0}: {1}\n Edad de {0}: {2}\n Correo de {0}: {3}\n" +
                "Fecha de cotratación de {0}: {4}\n Sueldo de {0}: ${5}",nombre, cargo, edad, correo, fecha, sueldo);
            System.Console.ReadKey();


        }
    }
}
