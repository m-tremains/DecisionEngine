using System;
using System.Collections.Generic;
using System.Text;

namespace DecisionEngine.Tools.Extensions
{
    public static class NullableBoolExtensions
    {
        public static bool ToBool(this bool? value)
        {
            var toBool = value.HasValue 
                         && value.Value;

            return toBool;
        }
    }
}
