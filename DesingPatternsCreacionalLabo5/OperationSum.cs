using System;
using System.Collections.Generic;

namespace DesingPatternsCreacionalLabo5
{
    public class OperationSum:IMathOperationStrategy
    {
        
        public double DoOperation(List<double> listNumbers)
        {
            double result=0;
            for(int i=0;i<listNumbers.Count;i++)
            {
                result += listNumbers[i];
            }
            ShowResult(result);
            return result;
        }
        public void ShowResult(double result)
        {
            Console.WriteLine("El resultado de la suma es: " + result);
        }
    }
}
