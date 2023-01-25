using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class VehiculosRent
    {
        private String nif;
        private String nombre;
        private ArrayList listaClientes;
        private ArrayList flotas;
        private ArrayList agencias;

        public VehiculosRent()
        {
            listaClientes = new ArrayList();
            flotas = new ArrayList();
            agencias = new ArrayList();
        }

        public string Nif { get => nif; set => nif = value; } //lectura y escritura Para el implementador de una clase, una propiedad es uno o dos bloques de código que representa un descriptor de acceso get o un descriptor de acceso set.
                                                              //El bloque de código del get descriptor de acceso se ejecuta cuando se lee la propiedad; el bloque de código del set descriptor de acceso se ejecuta cuando se asigna un valor a la propiedad .
        public ArrayList ListaClientes { get => listaClientes; set => listaClientes = value; }
        public ArrayList Flotas { get => flotas; set => flotas = value; }
        public string Nombre { get => nombre; set => nombre = value; }




        // Se tiene que crear este objeto junto con el new

    }
}
