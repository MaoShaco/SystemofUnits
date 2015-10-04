using System;

namespace PhysicalQuantities.Units.BaseUnits.Weight
{
    internal class WeightConvertor
    {
        private const double KiloPerTon = 1000;
        private const double KiloPerGram = 0.001;
        private const double KiloPerPound = 0.45359;

        public static double ReturnKilograms(WeightUnit unit, double number)
        {
            switch (unit)
            {
                case WeightUnit.Ton:
                    return number*KiloPerTon;
                case WeightUnit.Kilogram:
                    return number;
                case WeightUnit.Gram:
                    return number*KiloPerGram;
                case WeightUnit.Pound:
                    return number*KiloPerPound;
                default:
                    throw new ArgumentOutOfRangeException(nameof(unit), unit, null);
            }
        }
    }
}
