using System;

namespace Calculator
{
    public class Calculate
    {
        //Addition
        static public double add(double NumberOne, double NumberTwo)
        {
            return NumberOne + NumberTwo;
        }

        //Subtraction
        static public double subtract(double NumberOne, double NumberTwo)
        {
            return NumberOne - NumberTwo;
        }

        //Multiplication
        static public double multiply(double NumberOne, double NumberTwo)
        {
            return NumberOne * NumberTwo;
        }

        //Divission
        static public double divide(double NumberOne, double NumberTwo)
        {
            //The Input for label two cannot be egual or less than 0
            if (NumberTwo != 0)
                return NumberOne / NumberTwo;

            throw new DivideByZeroException("Dividing by 0 is not expected, change your input");
        }
    }
}

