using PhysicalQuantities.Units.BaseUnits;
using PhysicalQuantities.Units.BaseUnits.Length;
using PhysicalQuantities.Units.BaseUnits.Time;

namespace PhysicalQuantities.Units.DerivedUnits
{
    class SpeedUnits : BaseUnit
    {
        public SpeedUnits(double digitField)
            : base(digitField)
        {
            NameField = "MeterInSecond";
        }

        public static LengthUnits operator *(SpeedUnits baseUnit1, TimeUnits baseUnit2)
        {
            return new LengthUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }

        public static FrequencyUnits operator /(SpeedUnits baseUnit1, LengthUnits baseUnit2)
        {
            return new FrequencyUnits(baseUnit1.DigitField/baseUnit2.DigitField);
        }

        public static AccelerationUnits operator *(SpeedUnits baseUnit1, FrequencyUnits baseUnit2)
        {
            return new AccelerationUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }

    }
}
