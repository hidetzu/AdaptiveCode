using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDecorate
{
    public class BranchedComponent : IComponent
    {
        private readonly IComponent falseComponent;
        private readonly IComponent trueComponent;
        private readonly IPredicate predicate;

        public BranchedComponent(IComponent trueComponent, IComponent falseComponent, IPredicate predicate )
        {
            this.trueComponent = trueComponent;
            this.falseComponent = falseComponent;
            this.predicate = predicate;
        }


        public void Something()
        {
            if (predicate.Test())
                trueComponent.Something();
            else
                falseComponent.Something();
        }
    }
}
