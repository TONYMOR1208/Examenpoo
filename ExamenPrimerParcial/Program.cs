using System;

namespace ExamenPrimerParcial
{
     class Program
    {
        static void Main(string[] args)
        {

            Barco barco = new Barco("Tercero 'A' ", 10, 30000);
            barco.MostrarBarcos();
          


            GPS gps = new GPS("8'24'54", "9'23'21", "18/11/2022", "09:00", 30);
            gps.datos();


            Capitan capi = new Capitan("Marcos", 098432123, 23296542, 20, "20 años", "Masculino", "Tercero A", 254, 4500, 4900, 900);
            capi.imprimiratributos();
            capi.calculoBono();



































        }
    }
}
