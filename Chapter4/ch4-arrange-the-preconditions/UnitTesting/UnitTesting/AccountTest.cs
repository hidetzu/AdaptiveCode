using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerAccounts;

namespace UnitTesting
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void AddingTransactionChangeBalance()
        {
            var account = new Account();

            account.AddTransaction(200m);

            Assert.AreEqual(200m, account.Balance);
        }
    }
}
