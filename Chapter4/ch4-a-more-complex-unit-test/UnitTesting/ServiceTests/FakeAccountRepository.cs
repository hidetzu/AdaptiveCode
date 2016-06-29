using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RepositoryInterfaces;
using Domains;


namespace ServiceTests
{
    public class FakeAccountRepository : IAccountRepository
    {
        public FakeAccountRepository(Account account)
        {
            this.account = account;
        }
        
        public Account GetByName(string name)
        {
            return account;
        }

        private Account account;
    }
}
