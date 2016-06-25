using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class User : IUser
    {
        private DateTime sessionExpiry;

        public User(Guid id)
        {
            ID = id;
            sessionExpiry = DateTime.Now;
            IncrementSessionTicket();
        }

        public Guid ID { set; get; }
        public string Name { set; get; }

        public bool IsNull
        {
            get
            {
                return false;
            }
        }

        public void IncrementSessionTicket()
        {
            sessionExpiry.AddMinutes(30);
        }
    }
}
