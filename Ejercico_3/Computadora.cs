using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_3
{
    class Computadora
    {
        decimal capacidad_disco;
        decimal espacio_disponible;
        bool encendido = true;

        public Computadora(decimal capacidad_disco, decimal espacio_disponible, bool encendido)
        {
            this.capacidad_disco = capacidad_disco;
            this.espacio_disponible = espacio_disponible;
            this.encendido = encendido;
        }

        public decimal Capacidad_disco { get => capacidad_disco; set => capacidad_disco = value; }
        public decimal Espacio_disponible { get => espacio_disponible; set => espacio_disponible = value; }
        public bool Encendido { get => encendido; set => encendido = value; }

        /*aniadirDatos(int datos): añade información al disco duro, si supera el espacio disponible del disco, 
         * el tamaño del disco será el máximo posible. Solo si esta encendida la Computadora.*/
        public void aniadirDatos(int datos)
        {
            if (encendido)
            {
                // espacio_disponible -= datos;
                if (espacio_disponible > capacidad_disco)
                {
                    espacio_disponible = 0;
                    Console.WriteLine("No hay espacio disponible en el disco");
                }
                else
                {
                    espacio_disponible += datos;
                    Console.WriteLine("Se ha añadido " + datos + " GB al disco, espacio disponible " + espacio_disponible + " GB");
                }
            }
            else
            {
                Console.WriteLine("La computadora esta apagada");
            }
        }
        /* eliminarDatos(int datos): elimina información al disco duro, si el tamaño del disco es menor que 0,
     * el tamaño del disco se quedara a 0. Solo si esta encendida la Computadora.*/
        public void eliminarDatos(int datos)
        {
            if (encendido)
            {
                espacio_disponible -= datos;
                if (espacio_disponible > capacidad_disco)
                {
                    espacio_disponible = capacidad_disco;
                }
                Console.WriteLine("Se ha eliminado " + datos + "Gb del disco duro, quedan " + espacio_disponible + " GB");
            }
        }
        public void encender()
        {
            encendido = true;
            Console.WriteLine("Bienvenido");
        }
        public void apagar()
        {
            encendido = false;
            Console.WriteLine("Pantalla apagada");
        }
    }
}
