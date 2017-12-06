using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using VirtualBank.Library;
using Moq;

namespace VirtualBank.Library.Tests
{
    [TestFixture]
    public class AccountTest
    {
        private Account account;
        [SetUp]
        public void Setup()
        {
            account = new Account(1, 10000);
        }
        
       
        [Test]
        public void Account_Constructor_Should_Set_Properties()
        {                 
            //Arrange            
            //Act
            Account account = new Account(1, 10000);
            //Assert
            Assert.AreEqual(1, account.Id);
            Assert.AreEqual(10000, account.Balance);
        }
        [Test]
        public void GetBalance_TestMethod_Return_10000()
        {
            //Arrange                    
            double expected = 10000;
            //Act
            double actual = account.GetBalance();
            //Assert            
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Deposit_TestMetod_Adds_500_ToBalance()
        {            
            account.Deposit(500);            
                      
            Assert.That(account.Balance, Is.EqualTo(10500));
        }
        [Test]
        public void Withdraw_TestMethid_Substruct_500_FromBalance()
        {
            //Arrange        
            Account account = new Account(1, 10000);
            double expected = 10000 - 500;
            //Act
            account.Withdraw(500);
            double actual = account.GetBalance();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
