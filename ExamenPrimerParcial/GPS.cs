using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
     class GPS
    {
        public string  CooredenadasX { get; set; }
        public string CooredenadasY { get; set; }
        public string  Fecha { get; set; }
        public string Hora { get; set; }

        public  int DiasTripulado { get; set; }

    public GPS (string CooredenadasX, string  CooredenadasY, string Fecha, string Hora, int DiasTripulado)
        {
            this.CooredenadasX = CooredenadasX;
            this. CooredenadasY = CooredenadasY;
            this. Fecha = Fecha;
            this.Hora = Hora;
            this.DiasTripulado = DiasTripulado;
        }
        public void datos()
        {

            Console.WriteLine("   Datos ubicacion  ");
            Console.WriteLine("---------------");
            Console.WriteLine("Coordenada X: " + CooredenadasX);
            Console.WriteLine("Coordenada Y: " + CooredenadasY);
            Console.WriteLine("Dias tripulados: "+ DiasTripulado);
            Console.WriteLine("Fecha de registro: "+ Fecha);
            Console.WriteLine("Hora de registo: " + Hora);
            Console.WriteLine("---------------");
        }

    }
}
