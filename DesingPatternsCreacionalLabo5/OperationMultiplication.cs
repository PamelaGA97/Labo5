using System;
using System.Collections.Generic;

namespace DesingPatternsCreacionalLabo5
{
    public class OperationMultiplication:IMathOperationStrategy
    {
        public double DoOperation(List<double> listNumbers)
        {
            double result = 1;
            foreach(var number in listNumbers)
            {
                result *= number;
            }
            ShowResult(result);
            return result;
        }
        public void ShowResult(double result)
        {
            Console.WriteLine("El resultado de la multiplicacion es: " + result);
        }
    }
}
