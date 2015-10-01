using PhysicalQuantities.BaseUnits.PhysicalUnits;

namespace PhysicalQuantities.BaseUnits.DerivedUnits
{
    class PowerUnits : DerivedUnit
    {
        public PowerUnits(double digitField, string nameField)
            : base(digitField, nameField)
        {
            NamePatternField = "J/s";
            NameField = nameField.Equals(NamePatternField) ? "W" : nameField;

        }
        public static VoltageUnits operator /(PowerUnits baseUnit1, ElectricUnits baseUnit2)
        {
            return new VoltageUnits(baseUnit1.DigitField / baseUnit2.DigitField,
                $"{baseUnit1.NameField}/{baseUnit2.NameField}");
        }
        public static ElectricUnits operator /(PowerUnits baseUnit1, VoltageUnits baseUnit2)
        {
            return new ElectricUnits(baseUnit1.DigitField / baseUnit2.DigitField,
                $"{baseUnit1.NameField}/{baseUnit2.NameField}");
        }
        public static ForceUnits operator *(PowerUnits baseUnit1, TimeUnits baseUnit2)
        {
            return new ForceUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField}*{baseUnit2.NameField}");
        }
    }
}
