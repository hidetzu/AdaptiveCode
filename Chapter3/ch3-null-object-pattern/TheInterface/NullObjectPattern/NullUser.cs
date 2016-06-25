using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    public class NullUser : IUser
    {
        public bool IsNull
        {
            get
            {
                return true;
            }
        }

        public string Name
        {
            get
            {
                return null;
            }
        }
                
        public void IncrementSessionTicket()
        {
            // do nothing
        }
    }
}
