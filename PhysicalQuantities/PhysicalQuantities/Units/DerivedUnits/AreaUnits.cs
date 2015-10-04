using PhysicalQuantities.Units.BaseUnits;
using PhysicalQuantities.Units.BaseUnits.Length;

namespace PhysicalQuantities.Units.DerivedUnits
{
    class AreaUnits : BaseUnit
    {
        public AreaUnits(double digitField)
            : base(digitField)
        {
            NameField = "SquareMeter";
        }
        public static LengthUnits operator /(AreaUnits baseUnit1, LengthUnits baseUnit2)
        {
            return new LengthUnits(baseUnit1.DigitField / baseUnit2.DigitField);
        }

        public static VolumeUnits operator *(AreaUnits baseUnit1, LengthUnits baseUnit2)
        {
            return new VolumeUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }
    }
}
