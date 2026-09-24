namespace Math.Engine.Core
{
    public static class PowerEngine
    {
        public static double CalculatePower(double baseNum, int exponent)
        {
            if (baseNum == 0 && exponent < 0)
            {
                throw  new DivideByZeroException("Zero cannot be raised to a negative power.");
            }

            if (baseNum == 0 && exponent == 0)
            {
                throw new ArgumentException("Indeterminate form: 0^0 is undefined.");
            }

            int absExponent = exponent < 0 ? -exponent : exponent;
            
            double result = 1;
            for (int i = 0; i < absExponent; i++)
            {
                result *= baseNum;
            }

            if (exponent < 0)
            {
                return 1.0 / result;
            }
            return result;
        }
    }
}