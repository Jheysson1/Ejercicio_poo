using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("De su nombre: ");
                string nombre = Console.ReadLine();

                if (i < 1)
                {
                    personas[i] = new Profesor(nombre);

                }
                else
                {
                    personas[i] = new Estudiante(nombre);

                }
            }

            foreach (Persona persona in personas)
            {
                if (persona is Profesor)
                {
                    ((Profesor)persona).Explicar();
                }
                else
                {
                    ((Estudiante)persona).Estudiar();
                }


            }


            Console.ReadLine();
        }
    }
}
