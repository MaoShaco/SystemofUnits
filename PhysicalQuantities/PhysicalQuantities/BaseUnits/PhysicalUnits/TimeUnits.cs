using PhysicalQuantities.BaseUnits.DerivedUnits;

namespace PhysicalQuantities.BaseUnits.PhysicalUnits
{
    class TimeUnits : BaseUnit
    {
        public TimeUnits(double digitField, string nameField = "s")
            : base(digitField, nameField)
        {
        }
        public static ForceUnits operator *(TimeUnits baseUnit2, PowerUnits baseUnit1)
        {
            return new ForceUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField}*{baseUnit2.NameField}");
        }
        public static LengthUnits operator *(TimeUnits baseUnit2, SpeedUnits baseUnit1)
        {
            return new LengthUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField.Split('/')[0]}");
        }
    }
}
