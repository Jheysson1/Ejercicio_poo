using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Computadora comp = new Computadora(100, 100, true);
            Console.WriteLine("desea encender las computadora S/N");
            string resp1 = Console.ReadLine();
            if (resp1 == "S" || resp1 == "s")
            {
                comp.encender();
            }
            else
            {
                comp.apagar();

            }

            Console.WriteLine("Cuantos GB desea añadir");
            int datos = int.Parse(Console.ReadLine());
            comp.aniadirDatos(datos);

            Console.WriteLine("Cuantos GB desea eliminar");
            int datos1 = int.Parse(Console.ReadLine());
            comp.eliminarDatos(datos1);

            Console.ReadKey();
        }
    }
}
