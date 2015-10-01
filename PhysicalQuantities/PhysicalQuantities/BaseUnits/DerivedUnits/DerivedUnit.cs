namespace PhysicalQuantities.BaseUnits.DerivedUnits
{
    abstract class DerivedUnit : BaseUnit
    {
        protected string NamePatternField;

        protected DerivedUnit(double digitField, string nameField)
            : base(digitField, nameField)
        {

        }
    }
}
