using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factories
{
    public class AccountFactory
    {
        public AccountBase CreateAccount(AccountType accountType)
        {
            AccountBase account = null;
            switch (accountType)
            {
                case AccountType.Gold:
                    account = new GoldAccount();
                    break;
                case AccountType.Silver:
                    account = new SilverAccount();
                    break;
                case AccountType.Platinum:
                    account = new PlatinumAccount();
                    break;
                case AccountType.Bronze:
                    account = new BronzeAccount();
                    break;
            }
            return account;
        }
    }
}
