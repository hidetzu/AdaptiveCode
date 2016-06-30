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
        private Mock<Account> mockAccount;
        private Mock<IAccountRepository> mockRepository;
        private AccountService sut;


        [TestInitialize]
        public void Setup()
        {
            mockAccount = new Mock<Account>();
            mockRepository = new Mock<IAccountRepository>();
            sut = new AccountService(mockRepository.Object);
        }

        [TestMethod]
        public void AddingTransactionToAccountDelegatesToAccountInstance()
        {
            var account = new Account();
            mockRepository.Setup(r => r.GetByName("Trading Account")).Returns(account);

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

            // Act
            sut.AddTransactionToAccount("Trading Account", 100m);

            // Assert
        }

        [TestMethod]
        public void AccountExceptionsAreWrappedInThrowServiceException()
        {
            // Arrange
            mockAccount.Setup(a => a.AddTransaction(100m)).Throws<DomainException>();
            mockRepository.Setup(r => r.GetByName("Trading Account")).Returns(mockAccount.Object);
            sut = new AccountService(mockRepository.Object);

            try
            {
                // Act
                sut.AddTransactionToAccount("Trading Account", 100m);
            }
            catch (ServiceException serviceException)
            {
                // Assert
                Assert.IsInstanceOfType(serviceException.InnerException, typeof(DomainException));
            }

        }
    }
}
