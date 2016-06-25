using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    public class Context
    {
        public Context()
        {
            currentStrategy = strategyA;
        }

        public void DoSomething()
        {
            currentStrategy.Execute();

            currentStrategy = (currentStrategy == strategyA) ? strategyB : strategyA;
        }

        private readonly IStrategy strategyA = new ConcreteStrategyA();
        private readonly IStrategy strategyB = new ConcreteStrategyB();

        private IStrategy currentStrategy;
    }
}
