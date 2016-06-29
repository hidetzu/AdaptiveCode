using Domains;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void AddingTransactionChangesBalanceOfZero()
        {
            var account = new Account();

            Assert.AreEqual(0m, account.Balance);
        }

        [TestMethod]
        public void Adding100TransactionChangeBalance()
        {
            var account = new Account();

            account.AddTransaction(100m);

            Assert.AreEqual(100m, account.Balance);
        }

        [TestMethod]
        public void AddingTwoTransactionsCreatesSummationBalance()
        {
            var account = new Account();
            account.AddTransaction(50m);

            account.AddTransaction(75m);

            Assert.AreEqual(125m, account.Balance);
        }
    }
}
