using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Interfaces
    {
        public interface IVehicle
        {
            public int HowManyWheels { get; set; }
            public int HowManyDoors { get; set; }
            public bool HasEngine { get; set; }
            public bool IsCovertible { get; set; }


        }
        public interface ICompany
        {
            public string Logo { get; set; }

            public string CountryofOrigin { get; set; }
        }
    }
}
