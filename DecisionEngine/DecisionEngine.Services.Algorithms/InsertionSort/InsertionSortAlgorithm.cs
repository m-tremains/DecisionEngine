using DecisionEngine.Services.Algorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DecisionEngine.Services.Algorithms.Enums;
using DecisionEngine.Services.Algorithms.SortAlgorithms.Abstracts;
using DecisionEngine.Services.Algorithms.Strategies.SortOrder;
using DecisionEngine.Services.Algorithms.Strategies.SortOrder.Interfaces;

namespace DecisionEngine.Services.Algorithms.InsertionSort
{
    public class InsertionSortAlgorithm : SortAlgorithmBase
    {
        public override int[] Sort(int[] input, SortOrderEnum sortOrder)
        {
            for (var j = 1; j < input.Length; j++)
            {
                var key = input[j];
                var i = j - 1;

                var strategy = GetSortOrderStrategy(sortOrder);

                while (i >= 0
                    && strategy.Execute(input[i], key) == false)
                {
                    input[i + 1] = input[i];
                    i--;
                }

                input[i + 1] = key;
            }

            return input;
        }

        protected override ISortOrderStrategy GetSortOrderStrategy(SortOrderEnum sortOrder)
        {
            switch (sortOrder)
            {
                case SortOrderEnum.Ascending:
                    return new AscendingSortOrderStrategy();

                case SortOrderEnum.Descending:
                    return new DescendingSortOrderStrategy();

                default:
                    throw new InvalidOperationException($"{nameof(InsertionSortAlgorithm)} does not have {nameof(GetSortOrderStrategy)} defined for {nameof(SortOrderEnum)}: {sortOrder.ToString()}");
            }
        }
    }
}
