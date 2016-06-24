using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheInterface;

namespace TheInterface
{
    public class SimpleInterfaceImplementation : ISimpleInterface
    {
        private int encapsulatedInteger;
        public int ThisIntPropertyOnlyNeedsAGetter
        {
            get
            {
                return this.encapsulatedInteger;
            }

            set
            {
                this.encapsulatedInteger = value;
            }
        }

        public string ThisStringPropertyNeedsImplementingToo
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler<EventArgs> InterfaceCanContainEventsToo = delegate { };

        public void ThisMethodRequiresImplement()
        {
        }
    }
}
