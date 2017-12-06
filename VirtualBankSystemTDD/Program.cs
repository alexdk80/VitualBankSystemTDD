using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualBank.Library;

namespace VirtualBankSystemTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1,10000);
            Console.WriteLine("Initial Balance: " + account.Balance);
            account.Deposit(1500);
            Console.WriteLine("After deposit 1500 Balace is: "+account.Balance);
            
            Console.ReadLine();
        }        
    }
}
