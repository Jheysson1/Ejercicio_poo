using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Actor
    {
        string nombre_actor;
        string apellido_actor;

        public Actor(string nombre_actor, string apellido_actor)
        {
            this.nombre_actor = nombre_actor;
            this.apellido_actor = apellido_actor;
        }

        public string Nombre_actor { get => nombre_actor; set => nombre_actor = value; }
        public string Apellido_actor { get => apellido_actor; set => apellido_actor = value; }
    }
}
