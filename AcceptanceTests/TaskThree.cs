using System;

namespace AcceptanceTests
{
    class TaskThree
    {
        public static bool isInCircle(double radius, double x, double y)
        {
            return Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2);
        }
    }
}
