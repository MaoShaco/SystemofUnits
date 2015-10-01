using PhysicalQuantities.BaseUnits.DerivedUnits;

namespace PhysicalQuantities.BaseUnits.PhysicalUnits
{
    internal class WeightUnits : BaseUnit
    {
        public WeightUnits(double digitField, string nameField = "kg")
            : base(digitField, nameField)
        {
        }

        public static ForceUnits operator *(WeightUnits baseUnit1, AccelerationUnits baseUnit2)
        {
            return new ForceUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField}*{baseUnit2.NameField}");
        }

        public static EnergyUnits operator *(WeightUnits baseUnit2, ForceUnits baseUnit1)
        {
            return new EnergyUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField}*{baseUnit2.NameField}");
        }
    }
}

