using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
     class Barco
    {

        public string Nombres { get; set; }
        public int CapacidadPasajeros { get; set; }
        public int CapacidadCarga { get; set; }


        public Barco(string Nombres, int CapacidadPasajeros, int CapacidadCarga)
        {
            this.Nombres = Nombres;
            this.CapacidadPasajeros = CapacidadPasajeros;
            this. CapacidadCarga = CapacidadCarga;
        }
        public void MostrarBarcos()
        {
           
            Console.WriteLine("   Datos del Barco   ");
            Console.WriteLine("---------------");
            Console.WriteLine("Nombre " + Nombres);
            Console.WriteLine("tipo: Pesquero ");
            Console.WriteLine("Capasidad de pasajeros: "+ CapacidadPasajeros);
            Console.WriteLine("Capasidad almacen: " + CapacidadCarga+ "Kg");
            Console.WriteLine("---------------");

        }

    }
}
