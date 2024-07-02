using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DecisionEngine.Services.Calculator.Models.Enums;

namespace DecisionEngine.Services.Calculator.Models
{
    public class CompositeFactor
    {
        private readonly IReadOnlyCollection<Factor> _factors;

        public CompositeFactor(IReadOnlyCollection<Factor> factors)
        {
            if (factors == null)
            {
                // TODO MDT 03-08-20, create wrapper for throwing exceptions? (resharper proabably wont like it)
                throw new ArgumentNullException();
            }

            if (factors.Count < 2)
            {
                throw new ArgumentException();
            }

            _factors = factors;

        }


        public IReadOnlyCollection<FactorTypeEnum> FactorTypes => _factors.Select(s => s.FactorType).Distinct().ToArray();
        public bool IsMultiFactorType => FactorTypes.Count > 1;
    }
}
