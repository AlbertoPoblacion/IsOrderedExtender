namespace UnitTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ExtenderLibrary;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyList()
        {
            int[] test = new int[0];
            bool isOrdered = test.IsOrdered();
            Assert.IsTrue(isOrdered);
        }

        [TestMethod]
        public void OneItemList()
        {
            int[] test = new int[] { 999 };
            bool isOrdered = test.IsOrdered();
            Assert.IsTrue(isOrdered);
        }

        [TestMethod]
        public void SortedList()
        {
            int[] test = new int[] { 1, 2, 3, 4, 5 };
            bool isOrdered = test.IsOrdered();
            Assert.IsTrue(isOrdered);
        }

        [TestMethod]
        public void UnsortedList()
        {
            int[] test = new int[] { 5, 4, 3, 2, 1 };
            bool isOrdered = test.IsOrdered();
            Assert.IsFalse(isOrdered);
        }

        [TestMethod]
        public void SortedString()
        {
            string[] test = new string[] { "alfa", "bravo", "charlie" };
            bool isOrdered = test.IsOrdered();
            Assert.IsTrue(isOrdered);
        }

        [TestMethod]
        public void UnsortedString()
        {
            string[] test = new string[] { "alfa", "delta", "charlie" };
            bool isOrdered = test.IsOrdered();
            Assert.IsFalse(isOrdered);
        }

        [TestMethod]
        public void SortedLongList()
        {
            IEnumerable<int> test = Enumerable.Range(100, 10000);
            bool isOrdered = test.IsOrdered(); // takes 5 ms for 10k elements.
            Assert.IsTrue(isOrdered);
        }

        [TestMethod]
        public void UnsortedLongList()
        {
            IEnumerable<int> test = Enumerable.Range(100, 10000).Concat(new int[] { 0 });
            bool isOrdered = test.IsOrdered();
            Assert.IsFalse(isOrdered);
        }

        [TestMethod]
        public void SortedReferenceType()
        {
            List<MyClass> test = new List<MyClass> { new MyClass { Name = "a" }, new MyClass { Name = "b" } };
            bool isOrdered = test.IsOrdered();
            Assert.IsTrue(isOrdered);
        }

        [TestMethod]
        public void UnsortedReferenceType()
        {
            List<MyClass> test = new List<MyClass> { new MyClass { Name = "c" }, new MyClass { Name = "b" } };
            bool isOrdered = test.IsOrdered();
            Assert.IsFalse(isOrdered);
        }

        [TestMethod]
        public void OneItemReferenceType()
        {
            List<MyClass> test = new List<MyClass> { new MyClass { Name = "single" } };
            bool isOrdered = test.IsOrdered();
            Assert.IsTrue(isOrdered);
        }

        private class MyClass : IComparable<MyClass>
        {
            public string Name { get; set; }

            public int CompareTo(MyClass other)
            {
                return Name.CompareTo(other.Name);
            }
        }
    }
}
