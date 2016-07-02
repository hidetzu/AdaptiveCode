using CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    class Program
    {
        static IComponent component;
        static void Main(string[] args)
        {
            var composite = new CompositeComponent();
            composite.Add(new Leaf());
            composite.Add(new SecondTypeOfLeaf());
            composite.Add(new AThirdLeafType());

            component = composite;
            component.Something();
        }
    }
}
