using System;
using System.Collections.Generic;

namespace DesingPatternsCreacionalLabo5
{
    public interface IMathOperationStrategy
    {
        double DoOperation(List<double> listNumbers);
        void ShowResult(double result);
    }
}
