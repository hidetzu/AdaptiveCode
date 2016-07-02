using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DecoratorComponet : IComponent
    {
        private readonly IComponent decoratedComponet;

        public DecoratorComponet(IComponent decoratedComponet)
        {
            this.decoratedComponet = decoratedComponet;
        }

        public void Something()
        {
            SomethingElse();
            this.decoratedComponet.Something();
        }

        private void SomethingElse()
        {
        }
    }
}
