using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        // 2. Solicite el ingreso de un texto cualquiera y lo presente nuevamente al usuario.
            string ingreso = "";
            Console.WriteLine("Por favor, ingrese un texto cualquiera.");
            ingreso = Console.ReadLine();
            Console.WriteLine("El texto ingresado es:" + ingreso);
        }
    }
}
