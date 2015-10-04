using PhysicalQuantities.Units.BaseUnits;
using PhysicalQuantities.Units.BaseUnits.Length;

namespace PhysicalQuantities.Units.DerivedUnits
{
    class VolumeUnits : BaseUnit
    {
        public VolumeUnits(double digitField)
            : base(digitField)
        {
            NameField = "CubicMeter";
        }
        public static LengthUnits operator /(VolumeUnits baseUnit1, AreaUnits baseUnit2)
        {
            return new LengthUnits(baseUnit1.DigitField / baseUnit2.DigitField);
        }

        public static AreaUnits operator /(VolumeUnits baseUnit1, LengthUnits baseUnit2)
        {
            return new AreaUnits(baseUnit1.DigitField / baseUnit2.DigitField);
        }
    }
}
