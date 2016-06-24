using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    public interface ISimpleInterface
    {
        void ThisMethodRequiresImplement();

        string ThisStringPropertyNeedsImplementingToo
        {
            set;
            get;
        }

        int ThisIntPropertyOnlyNeedsAGetter
        {
            get;
        }

        event EventHandler<EventArgs> InterfaceCanContainEventsToo;
    }
}
