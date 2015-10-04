using System;

namespace PhysicalQuantities.Units.Exceptions
{
    class PhysicalBaseUnitOperationException : Exception
    {
        public override string Message { get; } = "Что-то пошло не так...";
    }
}
