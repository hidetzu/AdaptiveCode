using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDecorate
{
    public class PredicatedComponent : IComponent
    {
        private readonly IComponent component;
        private readonly IPredicate predicate;

        public PredicatedComponent(IComponent component, IPredicate predicate)
        {
            this.component = component;
            this.predicate = predicate;
        }


        public void Something()
        {
            if (predicate.Test())
            {
                component.Something();

            }
        }
    }
}
