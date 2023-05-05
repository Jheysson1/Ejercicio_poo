using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre de la pelicula: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el año de la pelicula: ");
            int anio = int.Parse(Console.ReadLine());
            Pelicula pe = new Pelicula(nombre, anio, new List<Actor>());

            Console.WriteLine("-------------");
            Console.WriteLine("Ingrese el nombre del actor: ");
            string nombre_actor = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del actor");
            string apellido_actor = Console.ReadLine();
            Actor ac = new Actor(nombre_actor, apellido_actor);
            pe.AgregarActor(new Actor(nombre_actor, apellido_actor));

            Console.WriteLine("---------------");

            Console.WriteLine("Ingrsee el nombre del estudio");
            string nombre_estudio = Console.ReadLine();
            Console.WriteLine("Ingrese la descricion del estudio");
            string descripcion_estudio = Console.ReadLine();
            Estudio es = new Estudio(nombre_estudio, descripcion_estudio, new List<Pelicula>());
            es.AgregarPelicula(pe);

            Console.WriteLine("--------------------------");
            Console.WriteLine("Sus datos son: ");
            Console.WriteLine("El nombre de la pelicula es " + nombre + " con su año " + anio);
            Console.WriteLine("El nombre del actor que ha ingresado es " + nombre_actor + " con su apellido " + apellido_actor);
            Console.WriteLine("El estudio que ingreso se llama " + nombre_estudio + " Con su descripcion" + descripcion_estudio);

            Console.ReadKey();
        }
    }
}
/* Console.WriteLine("Desea mostrar todo? S/N");
             string resp1 = Console.ReadLine();
             if (resp1 == "S" || resp1 == "s")
             {
                 Console.WriteLine("Estos son los datos");
                 pe.mostarPelicula();
                 pe.mostrarEstudio();
                 pe.mostrarActor();
             }*/
