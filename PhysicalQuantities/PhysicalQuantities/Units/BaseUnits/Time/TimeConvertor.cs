using System;

namespace PhysicalQuantities.Units.BaseUnits.Time
{
    internal class TimeConvertor
    {
        private const double SecondPerDay = 86400;
        private const double SecondPerHour = 3600;
        private const double SecondPerMinute = 60;

        public static double ReturnSeconds(TimeUnit unit, double number)
        {
            switch (unit)
            {
                case TimeUnit.Day:
                    return number * SecondPerDay;
                case TimeUnit.Hour:
                    return number*SecondPerHour;
                case TimeUnit.Minute:
                    return number * SecondPerMinute;
                case TimeUnit.Seconds:
                    return number;
                default:
                    throw new ArgumentOutOfRangeException(nameof(unit), unit, null);
            }
        }
    }
}
