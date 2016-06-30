using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class AccountBase
    {
        public static AccountBase CreateAccount(AccountType type)
        {
            AccountBase account = null;
            switch(type)
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
            }
            return account;
        }


        public decimal Balance
        {
            get;
            private set;
        }

        public int RewardsPoints
        {
            get;
            private set;
        }

        public void AddTransaction(decimal amount)
        {
            RewardsPoints += CalculateRewardPoints(amount);
            Balance += amount;
        }

        public abstract int CalculateRewardPoints(decimal amount);

        private const int SilverTransactionCostPerPoint = 10;
        private const int GoldTransactionCostPerPoint = 5;
        private const int PlatinumTransactionCostPerPoint = 2;

        private const int GoldBalanceCostPrePoint = 2000;
        private const int PlatinumBalanceCostPerPoint = 1000;
    }
}
