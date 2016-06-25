using AdapterPatternSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    class Program
    {
        static Adapter dependency = new Adapter();
        static ObjectAdapterPatternSample.Adapter dependency2 = new ObjectAdapterPatternSample.Adapter(
            new ObjectAdapterPatternSample.TargetClass());

        static void Main(string[] args)
        {
            dependency.MethodA();
            dependency2.MethodA();
        }
    }
}
