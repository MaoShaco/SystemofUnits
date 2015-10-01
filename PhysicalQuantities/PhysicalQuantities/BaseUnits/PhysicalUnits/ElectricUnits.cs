using PhysicalQuantities.BaseUnits.DerivedUnits;

namespace PhysicalQuantities.BaseUnits.PhysicalUnits
{
    class ElectricUnits : BaseUnit
    {
        public ElectricUnits(double digitField, string nameField = "A")
            : base(digitField, nameField)
        {
        }
        public static PowerUnits operator *(ElectricUnits baseUnit1, VoltageUnits baseUnit2)
        {
            return new PowerUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField}*{baseUnit2.NameField}");
        }
    }
}
