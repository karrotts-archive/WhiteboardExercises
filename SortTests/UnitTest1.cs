using NUnit.Framework;

namespace SortTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BasicSortTest1()
        {
            Assert.AreEqual(new int[]{ -1, 0, 2, 3, 4, 5}, Sorting.Sorter.BubbleSort(new int[] { 2, 5, 3, -1, 4, 0 }));
        }
        [Test]
        public void BasicSortTest2()
        {
            Assert.AreEqual(new int[] { -1, 0, 2, 3, 4, 5 }, Sorting.Sorter.BubbleSort(new int[] { -1, 0, 2, 3, 4, 5 }));
        }
        [Test]
        public void BasicSortTest3()
        {
            Assert.AreEqual(new int[] { -1, 0, 2, 3, 4, 5 }, Sorting.Sorter.BubbleSort(new int[] { 2, 4, 3, 0, 5, -1 }));
        }

        [Test]
        public void ArrayDoesNotChange()
        {
            int[] arr = { 2, 5, 3, -1, 4, 0 };
            Sorting.Sorter.BubbleSort(arr);

            Assert.AreEqual(new int[] { 2, 5, 3, -1, 4, 0 }, arr);
        }
    }
}