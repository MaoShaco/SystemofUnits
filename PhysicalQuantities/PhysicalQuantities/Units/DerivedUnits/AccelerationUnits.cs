using PhysicalQuantities.Units.BaseUnits;
using PhysicalQuantities.Units.BaseUnits.Weight;

namespace PhysicalQuantities.Units.DerivedUnits
{
    class AccelerationUnits : BaseUnit
    {
        public AccelerationUnits(double digitField) 
            : base(digitField)
        {
            NameField = "Meter/SquareSecond";
        }
        public static ForceUnits operator *(AccelerationUnits baseUnit2, WeightUnits baseUnit1)
        {
            return new ForceUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }
    }
}
