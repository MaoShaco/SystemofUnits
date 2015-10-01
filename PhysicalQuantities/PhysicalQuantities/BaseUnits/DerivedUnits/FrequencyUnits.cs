namespace PhysicalQuantities.BaseUnits.DerivedUnits
{
    class FrequencyUnits : DerivedUnit
    {
        
        public FrequencyUnits(double digitField, string nameField = "1/s")
            : base(digitField, nameField)
        {
            NamePatternField = "1/s";
            NameField = nameField.Equals(NamePatternField) ? "1/s" : nameField;
        }
        public static AccelerationUnits operator *(FrequencyUnits baseUnit2, SpeedUnits baseUnit1)
        {
            return new AccelerationUnits(baseUnit1.DigitField * baseUnit2.DigitField,
                $"{baseUnit1.NameField}/{baseUnit2.NameField.Split('/')[1]}");
        }
    }
}
