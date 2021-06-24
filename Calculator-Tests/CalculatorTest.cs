using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TwoDoubleNumberMupliedShouldResouldInDouble()
        {
            double NumberOne = 3;
            double NumberTwo = 3;
            object outcome = Calculator.Calculate.multiply(NumberOne, NumberTwo);
            Assert.IsInstanceOfType(outcome, typeof(double));
        }

        [TestMethod]
        public void MultiplyingTwoDoubleShouldNotDependOnTheOrder()
        {
            double NumberOne = 10;
            double NumberTwo = 4;
            double outcome = Calculator.Calculate.multiply(NumberOne, NumberTwo);
            double secondOutcome = Calculator.Calculate.multiply(NumberOne, NumberTwo);
            Assert.IsTrue(outcome == secondOutcome);
        }


        [TestMethod]
        public void AddTwoPositiveNumbersAndGetPositiveNumber()
        {
            double NumberOne = 4;
            double NumberTwo = 2;
            double outcome = Calculator.Calculate.add(NumberOne, NumberTwo);
            Assert.IsTrue(outcome > 0);
        }

        [TestMethod]
        public void SubtractingTwoWholeNumberShouldResultInWholeNumber()
        {
            double NumberOne = 10;
            double NumberTwo = 4;
            double outcome = Calculator.Calculate.subtract(NumberOne, NumberTwo);
            Assert.AreEqual(6d, outcome);
        }

        [TestMethod]
        public void TheOutcomeIsDeterminedByTheOrderOfTheDivision()
        {
            double NumberOne = 8;
            double NumberTwo = 4;
            double outcome = Calculator.Calculate.divide(NumberOne, NumberTwo);
            double secondOutcome = Calculator.Calculate.divide(NumberTwo, NumberOne);
            Assert.IsTrue(outcome != secondOutcome);
        }


        [TestMethod]
        public void MultiplyingTwoNegativeNumberShouldResultInPositiveNumber()
        {
            double NumberOne = -5;
            double NumberTwo = -5;
            double outcome = Calculator.Calculate.multiply(NumberOne, NumberTwo);
            Assert.AreEqual(25d, outcome);
        }

        [TestMethod]
        public void AddingTwoDoubleShouldGetADoubleInResult()
        {
            double NumberOne = 5;
            double NumberTwo = 1;
            object outcome = Calculator.Calculate.add(NumberOne, NumberTwo);
            Assert.IsInstanceOfType(outcome, typeof(double));
        }

        [TestMethod]
        public void DivideByZeroShouldThroWAnException()
        {
            double NumberOne = 6;
            double NumberTwo = 0;
            Assert.ThrowsException<DivideByZeroException>(() => Calculator.Calculate.divide(NumberOne, NumberTwo));
        }

        [TestMethod]
        public void DividingByNegativeNumberShouldWorkExceptZero()
        {
            double NumberOne = 16;
            double NumberTwo = -8;
            double outcome = Calculator.Calculate.divide(NumberOne, NumberTwo);
            Assert.AreEqual(-2, outcome);
        }

        [TestMethod]
        public void NegativeNumberDividedByAPositiveShouldResultInNegativeNumber()
        {
            double NumberOne = -10;
            double NumberTwo = 2;
            double outcome = Calculator.Calculate.divide(NumberOne, NumberTwo);
            Assert.AreEqual(-5, outcome);
        }
    }
}
