namespace DecisionEngine.Services.Calculator.Models.Enums
{
    // TODO MDT 03-08-20, may not be necessary if infering type; but may be good to have 
    // TODO MDT 03-08-20, operate exclusively on decimal (remove T), leverage FactorTypeEnum to set precision and identify mix types
    public enum FactorTypeEnum
    {
        Integer,
        Decimal,
        Money,

        Percent,
        Exponent
    }
}
