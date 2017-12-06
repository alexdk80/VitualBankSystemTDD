using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBank.Library
{
    public class Account
    {
        public Account(int id, double balance)
        {
            Id = id;
            Balance = balance;
        }
        public int Id { get; set; }
        public double Balance { get; set; }

        public double GetBalance()
        {
            return Balance;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public void Withdraw(int amount)
        {
            Balance-=amount;
        }
    }
}
