namespace ConsoleTest
{
    using System;
    using System.Collections.Generic;

    using ExtenderLibrary;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> vector1 = new List<int> { -10, 9, 18, 170 };
            Console.WriteLine(vector1.IsOrdered()); // Should be True

            int[] vector2 = { -10, 90, 18, 170 };
            Console.WriteLine(vector2.IsOrdered()); // Should be False

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("Press ENTER to exit");
                Console.ReadLine();
            }
        }
    }
}
