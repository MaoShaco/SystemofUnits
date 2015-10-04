using System;

namespace PhysicalQuantities.Units.BaseUnits.Length
{
    internal class LengthConvertor
    {
        private const double MeterPerMile = 1610;
        private const double MeterPerKilometer = 1000;
        private const double MeterPerCentimeter = 0.01;

        public static double ReturnMeters(LengthUnit unit, double number)
        {
            switch (unit)
            {
                case LengthUnit.Mile:
                    return number * MeterPerMile;
                case LengthUnit.Kilometer:
                    return number * MeterPerKilometer;
                case LengthUnit.Meter:
                    return number ;
                case LengthUnit.Centimeter:
                    return number*MeterPerCentimeter;
                default:
                    throw new ArgumentOutOfRangeException(nameof(unit), unit, null);
            }
        }
    }
}
