using PhysicalQuantities.Units.BaseUnits;
using PhysicalQuantities.Units.BaseUnits.Electric;

namespace PhysicalQuantities.Units.DerivedUnits
{
    class VoltageUnits : BaseUnit
    {
        public VoltageUnits(double digitField)
            : base(digitField)
        {
            NameField = "Volt";
        }
        public static PowerUnits operator *(VoltageUnits baseUnit2, ElectricUnits baseUnit1)
        {
            return new PowerUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }
    }
}
