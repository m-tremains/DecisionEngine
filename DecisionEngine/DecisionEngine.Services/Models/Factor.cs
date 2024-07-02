using DecisionEngine.Services.Calculator.Models.Enums;
using DecisionEngine.Services.Calculator.Models.Interfaces;

namespace DecisionEngine.Services.Calculator.Models
{
    public class Factor : IFactor
    {
        // TODO MDT 03-08-20, create a factory (double check how factory protects class)
        public Factor(
            OperationEnum operationEnum,
            FactorTypeEnum factorType, 
            decimal value)
        {
            OperationEnum = operationEnum;

            // TODO MDT 03-08-20, apply factortype rounding when constructed
            // TODO MDT 03-08-20, capture original/un-rounded value
            FactorType = factorType;
            Value = value;
        }

        public OperationEnum OperationEnum { get; }

        public FactorTypeEnum FactorType { get; }
        public decimal Value { get; }
    }
}
