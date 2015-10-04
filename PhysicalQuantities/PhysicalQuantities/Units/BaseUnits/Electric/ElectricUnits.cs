using PhysicalQuantities.Units.DerivedUnits;

namespace PhysicalQuantities.Units.BaseUnits.Electric
{
    class ElectricUnits : BaseUnit
    {
        public ElectricUnits(double digitField, ElectricUnit unit = ElectricUnit.Ampere)
            : base(digitField)
        {
            DigitField = ElectricConvertor.ReturnAmpere(unit, digitField);
            NameField = "Ampere";
        }
        public static PowerUnits operator *(ElectricUnits baseUnit1, VoltageUnits baseUnit2)
        {
            return new PowerUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }
    }
}
