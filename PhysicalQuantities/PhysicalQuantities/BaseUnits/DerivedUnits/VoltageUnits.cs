using PhysicalQuantities.BaseUnits.PhysicalUnits;

namespace PhysicalQuantities.BaseUnits.DerivedUnits
{
    class VoltageUnits : DerivedUnit
    {
        public VoltageUnits(double digitField, string nameField) : base(digitField, nameField)
        {
            NamePatternField = "W/A";
            NameField = nameField.Equals(NamePatternField) ? "V" : nameField;
        }
        public static PowerUnits operator *(VoltageUnits baseUnit2, ElectricUnits baseUnit1)
        {
            return new PowerUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField}*{baseUnit2.NameField}");
        }
    }
}
