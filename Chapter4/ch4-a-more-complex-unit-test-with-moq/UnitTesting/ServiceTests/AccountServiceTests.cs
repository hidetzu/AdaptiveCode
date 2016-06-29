using System;

using Services;
using RepositoryInterfaces;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;
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
            var mockAccountRepository = new Mock<IAccountRepository>();
            mockAccountRepository.Setup(r => r.GetByName("Trading Account")).Returns(account);
                
            var sut = new AccountService(mockAccountRepository.Object);

            sut.AddTransactionToAccount("Trading Account", 200m);

            Assert.AreEqual(200m, account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CannotCreateAccountServiceWithNullAccountRepository()
        {
            // Arrange

            // Act
            new AccountService(null);

            // Assert
        }

        [TestMethod]
        public void DoNotThrowWhenAccountIsNotFound()
        {
            // Arrange
            var mockRepository = new Mock<IAccountRepository>();
            var sut = new AccountService(mockRepository.Object);

            // Act
            sut.AddTransactionToAccount("Trading Account", 100m);

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ServiceException))]
        public void AccountExceptionsAreWrappedInThrowServiceException()
        {
            // Arrange
            var account = new Mock<Account>();
            account.Setup(a => a.AddTransaction(100m)).Throws<DomainException>();
            var mockRepository = new Mock<IAccountRepository>();
            mockRepository.Setup(r => r.GetByName("Trading Account")).Returns(account.Object);
            var sut = new AccountService(mockRepository.Object);

            // Act
            sut.AddTransactionToAccount("Trading Account", 100m);

            // Assert
        }
    }
}
