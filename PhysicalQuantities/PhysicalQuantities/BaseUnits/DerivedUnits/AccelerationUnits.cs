using PhysicalQuantities.BaseUnits.PhysicalUnits;

namespace PhysicalQuantities.BaseUnits.DerivedUnits
{
    class AccelerationUnits : DerivedUnit
    {
        public AccelerationUnits(double digitField, string nameField) 
            : base(digitField, nameField)
        {
            NamePatternField = "m/s/s";
            NameField = nameField.Equals(NamePatternField) ? "m/s/s" : nameField;

        }
        public static ForceUnits operator *(AccelerationUnits baseUnit2, WeightUnits baseUnit1)
        {
            return new ForceUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField}*{baseUnit2.NameField}");
        }
    }
}
