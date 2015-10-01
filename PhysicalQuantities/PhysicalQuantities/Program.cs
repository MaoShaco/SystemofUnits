using System;
using PhysicalQuantities.BaseUnits.Exceptions;

namespace PhysicalQuantities
{
    class Program
    {
        private static void Main()
        {
            try
            {

            }
            catch (PhysicalBaseUnitOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
