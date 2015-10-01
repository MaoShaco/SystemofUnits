using System;

namespace PhysicalQuantities.BaseUnits.Exceptions
{
    class PhysicalBaseUnitOperationException : Exception
    {
        public override string Message { get; } = "Что-то пошло не так...";
    }
}
