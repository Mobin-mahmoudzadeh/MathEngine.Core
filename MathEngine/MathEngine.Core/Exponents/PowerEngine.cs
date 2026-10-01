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
        
        public static double CalculatePower(double baseNum, double exponent)
        {
            if (exponent % 1 == 0)
            {
                int intExponent = (int)exponent;
                return CalculatePower(baseNum, intExponent);
            }

            if (baseNum < 0)
            {
                throw new ArgumentException("Negative base with a fractional exponent is not defined in real numbers.");
            }
    
            
            if (baseNum == 0 && exponent < 0)
            {
                throw new DivideByZeroException("Zero cannot be raised to a negative power.");
            }
    
            if (baseNum == 0 && exponent > 0)
            {
                return 0;
            }
    
           
            long intpart = (long)exponent;
            double fracpart = exponent - intpart;
    
           
            double intPower = CalculatePower(baseNum, (int)intpart);

           
            if (fracpart == 0.5)
            {
                double fractionalPowerResult = System.Math.Sqrt(baseNum);
                return intPower * fractionalPowerResult;
            }

           
            throw new NotSupportedException("Exponents other than 0.5 fractions are not supported in version V0.1.0.");
        }
    }
}