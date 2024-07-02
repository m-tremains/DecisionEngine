using System;
using System.Collections.Generic;
using System.Text;
using DecisionEngine.Services.Algorithms.Enums;
using DecisionEngine.Services.Algorithms.Interfaces;
using DecisionEngine.Services.Algorithms.Strategies.SortOrder.Interfaces;

namespace DecisionEngine.Services.Algorithms.SortAlgorithms.Abstracts
{
    public abstract class SortAlgorithmBase : ISortAlgorithm
    {
        public abstract int[] Sort(
            int[] input,
            SortOrderEnum sortOrder);

        protected abstract ISortOrderStrategy GetSortOrderStrategy(SortOrderEnum sortOrder);
    }
}
