using System;

namespace UC_2_MaximumNumberCheck
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            int output = MaximumNumber.MaximumIntegerNumber(89,22, 76);
            Console.WriteLine(output);
            double doubleoutput = MaximumNumber.MaximumFloatNumber(100.2, 44.45, 88.56);
            Console.WriteLine(doubleoutput);
        }
    }
}
