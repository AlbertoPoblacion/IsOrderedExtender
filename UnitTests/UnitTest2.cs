namespace UnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using ExtenderLibrary;

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void SortedWithComparer()
        {
            List<MyClass> test = new List<MyClass> { new MyClass { Name = "a" }, new MyClass { Name = "b" } };
            bool isOrdered = test.IsOrdered(new MyComparer());
            Assert.IsTrue(isOrdered);
        }

        [TestMethod]
        public void UnsortedWithComparer()
        {
            List<MyClass> test = new List<MyClass> { new MyClass { Name = "c" }, new MyClass { Name = "b" } };
            bool isOrdered = test.IsOrdered(new MyComparer());
            Assert.IsFalse(isOrdered);
        }

        [TestMethod]
        public void OneItemWithComparer()
        {
            List<MyClass> test = new List<MyClass> { new MyClass { Name = "single" } };
            bool isOrdered = test.IsOrdered(new MyComparer());
            Assert.IsTrue(isOrdered);
        }

        private class MyClass
        {
            public string Name { get; set; }
        }

        private class MyComparer : IComparer<MyClass>
        {
            public int Compare(MyClass x, MyClass y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}
