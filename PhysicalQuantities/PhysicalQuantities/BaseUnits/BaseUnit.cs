using System;
using PhysicalQuantities.BaseUnits.Exceptions;

namespace PhysicalQuantities.BaseUnits
{
    abstract class BaseUnit
    {
        protected BaseUnit(double digitField, string nameField)
        {
            DigitField = digitField;
            NameField = nameField;
        }

        public double DigitField { get; }

        public string NameField { get; protected set; }

        public static BaseUnit operator +(BaseUnit baseUnit1, BaseUnit baseUnit2)
        {
            if (baseUnit1.GetType() != baseUnit2.GetType())
                throw new PhysicalBaseUnitOperationTypeCastException(Operations.Addition, baseUnit1, baseUnit2);
            if (baseUnit1.NameField != baseUnit2.NameField)
                throw new PhysicalBaseUnitOperationOtherUnitsException(Operations.Addition, baseUnit1, baseUnit2);

            return (BaseUnit) Activator.
                CreateInstance(baseUnit1.GetType(), baseUnit1.DigitField + baseUnit2.DigitField, baseUnit1.NameField);
        }

        public static BaseUnit operator -(BaseUnit baseUnit1, BaseUnit baseUnit2)
        {
            if (baseUnit1.GetType() != baseUnit2.GetType())
                throw new PhysicalBaseUnitOperationTypeCastException(Operations.Subtraction, baseUnit1, baseUnit2);
            if (baseUnit1.NameField != baseUnit2.NameField)
                throw new PhysicalBaseUnitOperationOtherUnitsException(Operations.Subtraction, baseUnit1, baseUnit2);

            return (BaseUnit)Activator.
                CreateInstance(baseUnit1.GetType(), baseUnit1.DigitField - baseUnit2.DigitField, baseUnit1.NameField);
        }

        public static BaseUnit operator *(BaseUnit baseUnit1, BaseUnit baseUnit2)
        {
            throw new PhysicalBaseUnitOperationTypeCastException(Operations.Multiplication, baseUnit1, baseUnit2);

        }
        public static BaseUnit operator /(BaseUnit baseUnit1, BaseUnit baseUnit2)
        {
            throw new PhysicalBaseUnitOperationTypeCastException(Operations.Division, baseUnit1, baseUnit2);
        }

        public override string ToString()
        {
            return $"{DigitField} {NameField}";
        }
    }
}
