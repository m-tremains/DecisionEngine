using DecisionEngine.Services.Algorithms.Enums;
using DecisionEngine.Services.Algorithms.InsertionSort;
using DecisionEngine.Services.Algorithms.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecisionEngine.Services.Algorithms.Tests.InsertionSort
{
    [TestClass]
    public class InsertionSortTests
    {
        private readonly ISortAlgorithm _insertionSortAlgorithm;

        private readonly int[] _input;

        public InsertionSortTests()
        {
            _insertionSortAlgorithm = new InsertionSortAlgorithm();

            _input = new[] { 5, 2, 4, 6, 1, 3 };
        }

        [TestInitialize]
        public void Initialize()
        {
        }

        [TestMethod]
        public void Sort()
        {
            var array = _insertionSortAlgorithm.Sort(_input);

            var expectedSort = new[] { 1, 2, 3, 4, 5, 6 };

            for (var i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expectedSort[i], array[i]);
            }
        }

        [TestMethod]
        public void SortAscending()
        {
            var array = _insertionSortAlgorithm.Sort(_input, SortOrderEnum.Ascending);

            var expectedSort = new[] { 1, 2, 3, 4, 5, 6 };

            for (var i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expectedSort[i], array[i]);
            }
        }

        [TestMethod]
        public void SortDescending()
        {
            var array = _insertionSortAlgorithm.Sort(_input, SortOrderEnum.Descending);

            var expectedSort = new[] { 6, 5, 4, 3, 2, 1 };

            for (var i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expectedSort[i], array[i]);
            }
        }

        [TestMethod]
        public void SortExercise()
        {
            var exercise = new[] { 31, 41, 59, 26, 41, 58 };

            var array = _insertionSortAlgorithm.Sort(exercise);

            var expectedSort = new[] { 26, 31, 41, 41, 58, 59 };

            for (var i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expectedSort[i], array[i]);
            }
        }
    }
}
