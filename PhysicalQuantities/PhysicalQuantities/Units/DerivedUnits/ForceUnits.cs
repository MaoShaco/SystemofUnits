using PhysicalQuantities.Units.BaseUnits;
using PhysicalQuantities.Units.BaseUnits.Weight;

namespace PhysicalQuantities.Units.DerivedUnits
{
    class ForceUnits : BaseUnit
    {
        public ForceUnits(double digitField)
            : base(digitField)
        {
            NameField = "Newton";
        }
        public static EnergyUnits operator *(ForceUnits baseUnit1, WeightUnits baseUnit2)
        {
            return new EnergyUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }
        public static AccelerationUnits operator /(ForceUnits baseUnit1, WeightUnits baseUnit2)
        {
            return new AccelerationUnits(baseUnit1.DigitField/baseUnit2.DigitField);
        }
        public static WeightUnits operator /(ForceUnits baseUnit1, AccelerationUnits baseUnit2)
        {
            return new WeightUnits(baseUnit1.DigitField / baseUnit2.DigitField);
        }
    }
}
