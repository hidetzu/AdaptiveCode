using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceContract
{
    [ServiceContract]
    public interface CalculatorService
    {
        [OperationContract]
        int Add(int a, int b);
    }
}
