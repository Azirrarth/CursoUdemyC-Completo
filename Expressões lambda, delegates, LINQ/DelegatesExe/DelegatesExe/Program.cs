using System;
using DelegatesExe.Services;

namespace DelegatesExe
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op2 = CalculationService.Max;
           

            double result = op(a, b);
            double result2 = op2(a, b);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        
        }
    }
}
