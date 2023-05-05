using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_3
{
    class Moto : Vehiculo
    {
        // Atributos
        bool sidecar;

        // Constructor
        public Moto(int id, string marca, string model, int km, decimal precio, int annio, bool sidecar) : base(id, marca, model, km, precio, annio)
        {
            this.sidecar = sidecar;
        }

        // propiedades
        public bool Sidecar { get => sidecar; set => sidecar = value; }

        // Métodos
        public override string ToString()
        {
            if (sidecar)
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + (base.Precio + (decimal)50) + "\nAnnio: " + base.Annio;
            }
            else
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + base.Precio + "\nAnnio: " + base.Annio;
            }
        }
    }
}
