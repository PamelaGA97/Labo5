using System;
using System.Collections.Generic;

namespace DesingPatternsCreacionalLabo5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<double> list = new List<double>();
            list.Add(2);
            list.Add(2);
            list.Add(1);
            list.Add(-2);
            Client clientSum = new Client(new OperationSum());
            clientSum.DoOperation(list);
            Client clientSubtraction = new Client(new OperationSubtraction());
            clientSubtraction.DoOperation(list);
            Client clientMultiplication = new Client(new OperationMultiplication());
            clientMultiplication.DoOperation(list);
            Client clientDivision = new Client(new OperationDivision());
            clientDivision.DoOperation(list);
        }
    }
}
