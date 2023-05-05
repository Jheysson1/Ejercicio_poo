using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Estudio
    {
        string nombre_estudio;
        string descripcion_estudio;
        List<Pelicula> peliculas;

        public Estudio(string nombre_estudio, string descripcion_estudio, List<Pelicula> peliculas)
        {
            this.nombre_estudio = nombre_estudio;
            this.descripcion_estudio = descripcion_estudio;
            this.peliculas = peliculas;
        }

        public string Nombre_estudio { get => nombre_estudio; set => nombre_estudio = value; }
        public string Descripcion_estudio { get => descripcion_estudio; set => descripcion_estudio = value; }
        internal List<Pelicula> Peliculas { get => peliculas; set => peliculas = value; }

        public void AgregarPelicula(Pelicula pelicula)
        {
            Peliculas.Add(pelicula);
        }
        /* public void mostrarPelicula()
         {
             foreach (Pelicula x in this.peliculas)
             {
                 Console.WriteLine("----------");
                 Console.WriteLine(peliculas);
             }
         }*/
    }
}
