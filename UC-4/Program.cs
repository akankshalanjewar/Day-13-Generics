using System;

namespace UC_4
{
   class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 191, 100, 932, 495, 488 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 77.2, 87.4, 2.32, 44.5, 94.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "mango", "apple", "grapes", "peach", "kiwi" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadKey();

        }
    }
}
