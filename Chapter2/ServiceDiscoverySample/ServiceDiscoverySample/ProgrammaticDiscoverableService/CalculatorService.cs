using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammaticDiscoverableService
{
    class CalculatorService : ServiceContract.CalculatorService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
