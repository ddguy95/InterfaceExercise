using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public bool HasHeadLights { get; set; }
        public bool IsCovertible { get; set; }
        public int NumberOfWheels { get; set; } = 4;
        public bool HasTailLights { get ; set ; }
        public string FuelGrade { get ; set ; }
        public string Slogan { get ; set ; }
        public string Logo { get ; set ; }

        public void HonkNoise()
        {
            Console.WriteLine("Oooonnnnn.");
        }
    }
}
