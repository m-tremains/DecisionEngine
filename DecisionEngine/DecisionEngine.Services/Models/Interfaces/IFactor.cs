using System;
using System.Collections.Generic;
using System.Text;
using DecisionEngine.Services.Calculator.Models.Enums;

namespace DecisionEngine.Services.Calculator.Models.Interfaces
{
    public interface IFactor
    {
        FactorTypeEnum FactorType { get; }
        decimal Value { get; }
    }
}
