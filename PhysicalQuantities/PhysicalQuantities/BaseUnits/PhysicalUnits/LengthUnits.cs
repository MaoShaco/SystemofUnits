using PhysicalQuantities.BaseUnits.DerivedUnits;

namespace PhysicalQuantities.BaseUnits.PhysicalUnits
{
    internal class LengthUnits : BaseUnit
    {
        public LengthUnits(double digitField, string nameField = "m")
            : base(digitField, nameField)
        {
        }

        public static SpeedUnits operator /(LengthUnits baseUnit1, TimeUnits baseUnit2)
        {
            return new SpeedUnits(baseUnit1.DigitField/baseUnit2.DigitField,
                $"{baseUnit1.NameField}/{baseUnit2.NameField}");
        }

        public static TimeUnits operator /(LengthUnits baseUnit1, SpeedUnits baseUnit2)
        {
            return new TimeUnits(baseUnit1.DigitField/baseUnit2.DigitField,
                $"{baseUnit2.NameField.Split('/')[1]}");
        }
    }
}
