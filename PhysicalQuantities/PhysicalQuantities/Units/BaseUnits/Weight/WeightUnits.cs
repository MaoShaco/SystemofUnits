using PhysicalQuantities.Units.DerivedUnits;

namespace PhysicalQuantities.Units.BaseUnits.Weight
{
    class WeightUnits : BaseUnit
    {
        public WeightUnits(double digitField, WeightUnit unit = WeightUnit.Kilogram)
            : base(digitField)
        {
            DigitField = WeightConvertor.ReturnKilograms(unit, digitField);
            NameField = "Kilogram";
        }

        public static ForceUnits operator *(WeightUnits baseUnit1, AccelerationUnits baseUnit2)
        {
            return new ForceUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }

        public static EnergyUnits operator *(WeightUnits baseUnit2, ForceUnits baseUnit1)
        {
            return new EnergyUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }
    }
}

