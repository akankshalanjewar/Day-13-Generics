using System;

namespace UC_5_GenericMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 912, 744, 832, 455, 478 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();

            double[] doubleArray = { 67.2, 96.4, 8.32, 55.5, 34.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();

            string[] stringArray = { "mango", "apple", "grapes", "peach", "kiwi" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadKey();
        }
    }
}
