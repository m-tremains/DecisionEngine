using System;
using System.Collections.Generic;
using DecisionEngine.Services.Calculator.Models;

namespace DecisionEngine.Services.Calculator
{
    public class CalculatorService
    {
        public CompositeFactor ProcessFactors(
            IReadOnlyCollection<Factor> factors)
        {
            throw new NotImplementedException();
            return null;
        }

        // TODO MDT 03-08-20, capture actions/commands for logging and replay

        public decimal ProcessAdd(decimal addendLeft, decimal addendRight)
        {
            var sum = addendLeft
                      + addendRight;

            return sum;
        }

        public decimal ProcessMultiply(decimal factorLeft, decimal factorRight)
        {
            var product = factorLeft
                          * factorRight;

            return product;
        }

        public decimal ProcessPower(decimal baseValue, decimal exponent)
        {
            var power = (decimal)Math.Pow(
                (double)baseValue,
                (double)exponent);

            return power;
        }
    }
}
