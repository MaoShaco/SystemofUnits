using PhysicalQuantities.BaseUnits.PhysicalUnits;

namespace PhysicalQuantities.BaseUnits.DerivedUnits
{
    class ForceUnits : DerivedUnit
    {
        public ForceUnits(double digitField, string nameField)
            : base(digitField, nameField)
        {
            NamePatternField = "kg*m/s/s";
            NameField = nameField.Equals(NamePatternField) ? "N" : nameField;
        }
        public static EnergyUnits operator *(ForceUnits baseUnit1, WeightUnits baseUnit2)
        {
            return new EnergyUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField}*{baseUnit2.NameField}");
        }
    }
}
