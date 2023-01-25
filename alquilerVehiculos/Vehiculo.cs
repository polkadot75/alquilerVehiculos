using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal abstract class Vehiculo
    {
        private string matricula;
        private string marca;
        private string modelo;

        public string Matricula { get => matricula; set => matricula = value; } //para acceder a los datos privados
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
    }
}
