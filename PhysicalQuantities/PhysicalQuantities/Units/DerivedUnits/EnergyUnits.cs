using PhysicalQuantities.Units.BaseUnits;
using PhysicalQuantities.Units.BaseUnits.Weight;

namespace PhysicalQuantities.Units.DerivedUnits
{
    class EnergyUnits : BaseUnit
    {
        public EnergyUnits(double digitField) 
            : base(digitField)
        {
            NameField = "Joule";
        }

        public static PowerUnits operator /(EnergyUnits baseUnit1, PowerUnits baseUnit2)
        {
            return new PowerUnits(baseUnit1.DigitField/baseUnit2.DigitField);
        }

        public static ForceUnits operator /(EnergyUnits baseUnit1, WeightUnits baseUnit2)
        {
            return new ForceUnits(baseUnit1.DigitField/baseUnit2.DigitField);
        }
        public static WeightUnits operator /(EnergyUnits baseUnit1, ForceUnits baseUnit2)
        {
            return new WeightUnits(baseUnit1.DigitField/baseUnit2.DigitField);
        }

    }
}
