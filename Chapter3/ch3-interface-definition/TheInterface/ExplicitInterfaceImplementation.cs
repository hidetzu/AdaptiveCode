using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    public class ExplicitInterfaceImplementation : ISimpleInterface
    {
        private EventHandler<EventArgs> encapsulatedEvent;
        private int encapsulatedInteger;

        public ExplicitInterfaceImplementation()
        {
            this.encapsulatedInteger = 4;
        }

        public object ThisIntPropertyOnlyNeedsAGetter { get; internal set; }

        int ISimpleInterface.ThisIntPropertyOnlyNeedsAGetter
        {
            get
            {
                return this.encapsulatedInteger;
            }
        }

        string ISimpleInterface.ThisStringPropertyNeedsImplementingToo
        {
            get;
            set;
        }

        event EventHandler<EventArgs> ISimpleInterface.InterfaceCanContainEventsToo
        {
            add { encapsulatedEvent += value; } 
            remove { encapsulatedEvent -= value; }
        }

        void ISimpleInterface.ThisMethodRequiresImplement()
        {
        }
    }
}
