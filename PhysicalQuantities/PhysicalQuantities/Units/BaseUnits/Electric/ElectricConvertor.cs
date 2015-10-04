using System;

namespace PhysicalQuantities.Units.BaseUnits.Electric
{
    internal class ElectricConvertor
    {
        private const double AmperePerKiloAmpere = 1000;
        private const double AmperePerMiliAmpere = 0.001;

        public static double ReturnAmpere(ElectricUnit unit, double number)
        {
            switch (unit)
            {
                case ElectricUnit.KiloAmpere:
                    return number * AmperePerKiloAmpere;
                case ElectricUnit.Ampere:
                    return number;
                case ElectricUnit.MiliAmpere:
                    return number * AmperePerMiliAmpere;
                default:
                    throw new ArgumentOutOfRangeException(nameof(unit), unit, null);
            }
        }
    }
}
