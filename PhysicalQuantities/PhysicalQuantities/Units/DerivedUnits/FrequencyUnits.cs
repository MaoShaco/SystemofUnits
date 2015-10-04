using PhysicalQuantities.Units.BaseUnits;

namespace PhysicalQuantities.Units.DerivedUnits
{
    class FrequencyUnits : BaseUnit
    {
        
        public FrequencyUnits(double digitField)
            : base(digitField)
        {
            NameField = "Hertz";
        }
        public static AccelerationUnits operator *(FrequencyUnits baseUnit2, SpeedUnits baseUnit1)
        {
            return new AccelerationUnits(baseUnit1.DigitField*baseUnit2.DigitField);
        }
    }
}
