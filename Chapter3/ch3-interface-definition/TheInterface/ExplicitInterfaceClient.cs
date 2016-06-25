using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    public class ExplicitInterfaceClient
    {
        public ExplicitInterfaceClient(ExplicitInterfaceImplementation implementationReference, ISimpleInterface interfaceReference)
        {
            var instancePropertyValue = interfaceReference.ThisIntPropertyOnlyNeedsAGetter;
            interfaceReference.ThisMethodRequiresImplement();
            interfaceReference.ThisStringPropertyNeedsImplementingToo = "hello";
            interfaceReference.InterfaceCanContainEventsToo += EventHandler;
        }

        void EventHandler(object sender, EventArgs e)
        {
        }
    }
}
