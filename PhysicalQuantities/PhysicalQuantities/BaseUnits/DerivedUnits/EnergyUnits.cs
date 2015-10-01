using PhysicalQuantities.BaseUnits.PhysicalUnits;

namespace PhysicalQuantities.BaseUnits.DerivedUnits
{
    class EnergyUnits : DerivedUnit
    {
        public EnergyUnits(double digitField, string nameField) : base(digitField, nameField)
        {
            NamePatternField = "N*kg";
            NameField = nameField.Equals(NamePatternField) ? "J" : nameField;
        }
        //public static PowerUnits operator /(EnergyUnits baseUnit1, TimeUnits baseUnit2)
        //{
        //    return new PowerUnits(baseUnit1.DigitField / baseUnit2.DigitField,
        //        $"{baseUnit1.NameField}/{baseUnit2.NameField}");
        //}
        public static PowerUnits operator /(EnergyUnits baseUnit1, PowerUnits baseUnit2)
        {
            return new PowerUnits(baseUnit1.DigitField / baseUnit2.DigitField,
                $"{baseUnit1.NameField}/{baseUnit2.NameField}");
        }

        public static ForceUnits operator /(EnergyUnits baseUnit1, WeightUnits baseUnit2)
        {
            return new ForceUnits(baseUnit1.DigitField / baseUnit2.DigitField,
                $"{baseUnit1.NameField}/{baseUnit2.NameField}");
        }
        public static WeightUnits operator /(EnergyUnits baseUnit1, ForceUnits baseUnit2)
        {
            return new WeightUnits(baseUnit1.DigitField / baseUnit2.DigitField,
                $"{baseUnit1.NameField}/{baseUnit2.NameField}");
        }

    }
}
