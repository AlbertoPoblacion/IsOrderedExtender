# IsOrderedExtender
An extension method written in C# to verify whether an IEnumerable is ordered

The important part is the method "IsOrdered" located in class "Extenders" in the project "ExtenderLibrary".
The rest is just demonstration and testing code.

Use IsOrdered in your code by applying it as an extension method to any IEnumerable that contains IComparable members.

            List<int> vector1 = new List<int> { -10, 9, 18, 170 };
            Console.WriteLine(vector1.IsOrdered()); // Writes "True"

            int[] myArray = { -10, 90, 18, 170 };
            Console.WriteLine(myArray.IsOrdered()); // Writes "False"

An overload is available that takes an IComparer as an argument. When using this overload, it is not necessary for the items to implement IComparable.

            List<MyClass> test = new List<MyClass> { new MyClass { Name = "single" } };
            bool isOrdered = test.IsOrdered(new MyComparer());

You will find an example for MyClass and MyComparer inside the unit tests.
