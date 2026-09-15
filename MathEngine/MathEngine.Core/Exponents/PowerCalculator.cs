namespace Math.Engine.Core
{
    public static class PowerEngine
    {
        public static double CalculatePositivePower(double baseNum, int exponent)
        {
            double result = 1;
            for(int i = 0; i < exponent ; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}