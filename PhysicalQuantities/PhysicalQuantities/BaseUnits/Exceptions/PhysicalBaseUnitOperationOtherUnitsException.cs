namespace PhysicalQuantities.BaseUnits.Exceptions
{
    class PhysicalBaseUnitOperationOtherUnitsException : PhysicalBaseUnitOperationException
    {
        public override string Message { get; }
        public PhysicalBaseUnitOperationOtherUnitsException()
        {
            Message = "Для используемой операции различные единицы измерения не подходят";
        }
        public PhysicalBaseUnitOperationOtherUnitsException(Operations operation, BaseUnit baseUnit1, BaseUnit baseUnit2)
        {
            Message =
                $"Для операции {operation} значения <{baseUnit1}> и <{baseUnit2}> \nимеют неверные единицы измерения" +
                $"\nObj1 <{baseUnit1.NameField}>  Obj2 <{baseUnit2.NameField}>";
        }
    }
}
