using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceExercise.Interfaces;

namespace InterfaceExercise
{
    internal class SUV: IVehicle, ICompany
    {
        public bool Has3RowsofSeats { get; set; }
        public bool HasBadGasMileage { get; set; }

        public bool HasSmallTrunk { get; set; }
        public string Seats4 { get; set; }
        public int HowManyWheels { get; set; }
        public int HowManyDoors { get; set; }
        public bool HasEngine { get; set; }
        public bool IsCovertible { get; set; }

        public string Logo { get; set; }
        public string CountryofOrigin { get; set; }
    }
}
