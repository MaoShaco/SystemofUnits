using PhysicalQuantities.Units.BaseUnits;
using PhysicalQuantities.Units.BaseUnits.Electric;
using PhysicalQuantities.Units.BaseUnits.Time;

namespace PhysicalQuantities.Units.DerivedUnits
{
    class PowerUnits : BaseUnit
    {
        public PowerUnits(double digitField)
            : base(digitField)
        {
            NameField = "Watt";
        }
        public static VoltageUnits operator /(PowerUnits baseUnit1, ElectricUnits baseUnit2)
        {
            return new VoltageUnits(baseUnit1.DigitField/baseUnit2.DigitField);
        }
        public static ElectricUnits operator /(PowerUnits baseUnit1, VoltageUnits baseUnit2)
        {
            return new ElectricUnits(baseUnit1.DigitField/baseUnit2.DigitField);
        }
        public static ForceUnits operator *(PowerUnits baseUnit1, TimeUnits baseUnit2)
        {
            return new ForceUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }
    }
}
