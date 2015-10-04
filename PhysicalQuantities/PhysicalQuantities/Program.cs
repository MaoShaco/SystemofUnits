using System;
using PhysicalQuantities.Units.BaseUnits.Length;
using PhysicalQuantities.Units.BaseUnits.Weight;
using PhysicalQuantities.Units.DerivedUnits;
using PhysicalQuantities.Units.Exceptions;

namespace PhysicalQuantities
{
    class Program
    {
        private static void Main()
        {
            try
            {
                var a = new LengthUnits(5, LengthUnit.Mile);
                var b = new LengthUnits(6, LengthUnit.Centimeter);
                Console.WriteLine(a*a*a/(a*b));
            }
            catch (PhysicalBaseUnitOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
