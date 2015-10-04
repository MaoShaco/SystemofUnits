using PhysicalQuantities.Units.BaseUnits.Length;
using PhysicalQuantities.Units.DerivedUnits;

namespace PhysicalQuantities.Units.BaseUnits.Time
{
    class TimeUnits : BaseUnit
    {
        public TimeUnits(double digitField, TimeUnit unit = TimeUnit.Seconds)
            : base(digitField)
        {
            DigitField = TimeConvertor.ReturnSeconds(unit, digitField);
            NameField = "Seconds";
        }
        public static ForceUnits operator *(TimeUnits baseUnit2, PowerUnits baseUnit1)
        {
            return new ForceUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }
        public static LengthUnits operator *(TimeUnits baseUnit2, SpeedUnits baseUnit1)
        {
            return new LengthUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }
    }
}
