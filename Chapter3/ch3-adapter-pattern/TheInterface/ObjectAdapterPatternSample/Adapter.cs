using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAdapterPatternSample
{
    public class Adapter : IExpectedInterface
    {
        private TargetClass target;

        public Adapter(TargetClass traget)
        {
            this.target = traget;
        }

        public void MethodA()
        {
            target.MethodB();
        }
    }
}
