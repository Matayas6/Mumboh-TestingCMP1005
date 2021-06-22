using System;

namespace Calculator
{
    public class Calculator
    {

        public double add(double labelOneInput, double labelTwoInput)
        {
            return labelOneInput + labelTwoInput;
        }

        static public double divide(double labelOneInput, double labelTwoInput)
        {
            if (labelTwoInput > 0)
                return labelOneInput / labelTwoInput;

            throw new DivideByZeroException(@"Dividing by 0 is not expected, change your input");
        }
    }
}

