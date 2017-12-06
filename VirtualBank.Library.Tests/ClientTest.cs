using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBank.Library;

namespace VirtualBank.Library.Tests
{
    [TestFixture]
    class ClientTest
    {        
        [Test]
        public void Client_Constructor_Should_Set_Properties()
        {
            //Arrange   
            Account account = new Account(1,10000);
            //Act
            Client client = new Client(1, "Jens", 1234,account);
            //Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(1, client.Id);
                Assert.AreEqual("Jens", client.Name);
                Assert.AreEqual(1234, client.Password);
                Assert.AreEqual(account.Id, client.ClientAccount.Id);
                Assert.AreEqual(account.Balance, client.ClientAccount.Balance);
            });            
        }
    }
}
