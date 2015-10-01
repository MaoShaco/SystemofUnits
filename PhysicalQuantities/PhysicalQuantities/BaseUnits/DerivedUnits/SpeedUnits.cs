using PhysicalQuantities.BaseUnits.PhysicalUnits;

namespace PhysicalQuantities.BaseUnits.DerivedUnits
{
    class SpeedUnits : DerivedUnit
    {
        public SpeedUnits(double digitField, string nameField = "m/s")
            : base(digitField, nameField)
        {
        }

        public static LengthUnits operator *(SpeedUnits baseUnit1, TimeUnits baseUnit2)
        {
            return new LengthUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField.Split('/')[0]}");
        }

        public static FrequencyUnits operator /(SpeedUnits baseUnit1, LengthUnits baseUnit2)
        {
            return new FrequencyUnits(baseUnit1.DigitField / baseUnit2.DigitField,
                $"1/{baseUnit1.NameField.Split('/')[1]}");
        }

        public static AccelerationUnits operator *(SpeedUnits baseUnit1, FrequencyUnits baseUnit2)
        {
            return new AccelerationUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField}/{baseUnit2.NameField.Split('/')[1]}");
        }

    }
}
