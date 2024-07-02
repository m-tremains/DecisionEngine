using System;
using DecisionEngine.Services.Algorithms.Strategies.SortOrder.Interfaces;

namespace DecisionEngine.Services.Algorithms.Strategies.SortOrder
{
    public class DescendingSortOrderStrategy : ISortOrderStrategy
    {
        public bool Execute(
            int left,
            int right)
        {
            var sorted = left >= right;

            return sorted;
        }
    }
}
