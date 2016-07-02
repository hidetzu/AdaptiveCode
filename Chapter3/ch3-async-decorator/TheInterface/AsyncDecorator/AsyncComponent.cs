using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDecorator
{
    public class AsyncComponent : IComponent
    {
        private readonly IComponent decoratedComponent;

        public AsyncComponent(IComponent decoratedComponent)
        {
            this.decoratedComponent = decoratedComponent;
        }

        public void Process()
        {
            Task.Run((Action)decoratedComponent.Process);
        }
    }
}
