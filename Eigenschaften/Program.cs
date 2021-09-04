using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigenschaften
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto car = new Auto();

            car.Farbe = "Grün";
            Console.WriteLine(car.Farbe);

            Console.ReadKey();
        }
    }
    
    class Auto
    {
        //Variablen
        private bool motorAn;
        private bool scheibenwischerAn;

        //Eigenschaften
        public string Farbe { get; set; }
        public int PS { get; set; }
        public int AnzahlTüren { get; set; }
    }
}
