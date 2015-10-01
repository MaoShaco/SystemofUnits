namespace PhysicalQuantities.BaseUnits.Exceptions
{
    class PhysicalBaseUnitOperationTypeCastException : PhysicalBaseUnitOperationException
    {
        public override string Message { get; }
        public PhysicalBaseUnitOperationTypeCastException()
        {
            Message = "Для используемой операции данные типы не подходят";
        }
        public PhysicalBaseUnitOperationTypeCastException(Operations operation, BaseUnit baseUnit1, BaseUnit baseUnit2)
        {
            Message =
                $"Для операции {operation} значения <{baseUnit1}> и <{baseUnit2}> не подходят по типам" +
                $"\nObj1 <{baseUnit1.GetType().Name}>  Obj2 <{baseUnit2.GetType().Name}>";
        }
    }
}
