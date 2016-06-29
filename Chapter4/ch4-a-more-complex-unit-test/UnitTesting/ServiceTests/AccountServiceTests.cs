using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using Domains;

namespace ServiceTests
{
    [TestClass]
    public class AccountServiceTests
    {
        [TestMethod]
        public void AddingTransactionToAccountDelegatesToAccountInstance()
        {
            var account = new Account();
            var fakeAccountRepository = new FakeAccountRepository(account);
            var sut = new AccountService(fakeAccountRepository);

            sut.AddTransactionToAccount("Trading Account", 200m);

            Assert.AreEqual(200m, account.Balance);
        }
    }
}
