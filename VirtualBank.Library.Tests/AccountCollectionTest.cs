using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using VirtualBank.Library;

namespace VirtualBank.Library.Tests
{
    [TestFixture]
    public class AccountCollectionTest
    {
        [Test]
        public void Account_SelectedById_Returns_Correct_AccountBalance()
        {
            Mock<ISerializer> serializer = new Mock<ISerializer>();

            Account account1 = new Account(1,1000);
            Account account2 = new Account(2,2000);

            List<Account> accounts = new List<Account>();
            accounts.Add(account1);
            accounts.Add(account2);            
            serializer.Setup(s => s.Read()).Returns(accounts);
            AccountCollection sut = new AccountCollection(serializer.Object);

            //Act
            Account getAccount = sut.SelectById(2);

            //Assert
            Assert.AreEqual(account2,getAccount);
        }


    }
}