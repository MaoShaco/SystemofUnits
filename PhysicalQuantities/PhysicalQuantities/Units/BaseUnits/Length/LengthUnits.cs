using PhysicalQuantities.Units.BaseUnits.Time;
using PhysicalQuantities.Units.DerivedUnits;

namespace PhysicalQuantities.Units.BaseUnits.Length
{
    internal class LengthUnits : BaseUnit
    {
        public LengthUnits(double digitField, LengthUnit unit = LengthUnit.Meter)
            : base(digitField)
        {
            DigitField = LengthConvertor.ReturnMeters(unit, digitField);
            NameField = "Meter";
        }

        public static SpeedUnits operator /(LengthUnits baseUnit1, TimeUnits baseUnit2)
        {
            return new SpeedUnits(baseUnit1.DigitField/baseUnit2.DigitField);
        }

        public static TimeUnits operator /(LengthUnits baseUnit1, SpeedUnits baseUnit2)
        {
            return new TimeUnits(baseUnit1.DigitField/baseUnit2.DigitField);
        }
        public static VolumeUnits operator *(LengthUnits baseUnit2, AreaUnits baseUnit1)
        {
            return new VolumeUnits(baseUnit1.DigitField * baseUnit2.DigitField);
        }
        public static AreaUnits operator *(LengthUnits baseUnit2, LengthUnits baseUnit1)
        {
            return new AreaUnits(baseUnit1.DigitField * baseUnit2.DigitField);
        }

    }
}
