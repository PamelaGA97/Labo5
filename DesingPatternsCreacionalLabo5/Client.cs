using System;
using System.Collections.Generic;

namespace DesingPatternsCreacionalLabo5
{
    public class Client
    {
        IMathOperationStrategy mathOperationStrategy;
        public Client(IMathOperationStrategy mathOperationStrategy)
        {
            this.mathOperationStrategy = mathOperationStrategy;
        }

        public void DoOperation(List<double>list)
        {
            mathOperationStrategy.DoOperation(list);
        }
    }
}
