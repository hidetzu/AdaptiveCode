using Domains;
using RepositoryInterfaces;
using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            if (accountRepository == null)
                throw new ArgumentNullException("repository", "A valid account repository must be supplied.");
            this.accountRepository = accountRepository;
        }

        public void AddTransactionToAccount(string uniqueAccountName, decimal transactionAmount)
        {
            var account = accountRepository.GetByName(uniqueAccountName);
            if (account != null)
            {
                try
                {
                    account.AddTransaction(transactionAmount);
                }
                catch (DomainException domainException)
                {
                    throw new ServiceException("An exception was thrown by a domain object", domainException);
                }
            }
        }
    }
}
