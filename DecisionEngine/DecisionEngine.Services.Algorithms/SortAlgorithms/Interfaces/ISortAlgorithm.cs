using System;
using System.Collections.Generic;
using System.Text;
using DecisionEngine.Services.Algorithms.Enums;

namespace DecisionEngine.Services.Algorithms.Interfaces
{
    public interface ISortAlgorithm
    {
        int[] Sort(int[] input, SortOrderEnum sortOrder = SortOrderEnum.Ascending);
    }
}
