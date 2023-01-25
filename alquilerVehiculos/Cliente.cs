using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Cliente
    {
        private string nif; // En C# se usa el subguió para detectar que es un atribut privat
        private string nombre;

        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override String ToString() // Va al método que tiene ToString 
                                          // Un método override proporciona una nueva implementación de un método heredado de una clase base.
                                          // El método invalidado por una declaración override se conoce como método base invalidado.
                                          // Un método override debe tener la misma signatura que el método base invalidado.
        {
            return "Nif: "+ nif + " Nombre: "+ Nombre;
        }
    }
}
