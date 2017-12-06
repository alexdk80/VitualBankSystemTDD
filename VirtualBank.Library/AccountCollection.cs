using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBank.Library
{
    public class AccountCollection
    {
        private ISerializer serializer;

        public AccountCollection(ISerializer @object)
        {
            this.serializer = @object;
        }

        public Account SelectById(int v)
        {
            ICollection<Account> accounts = serializer.Read();
            return accounts.FirstOrDefault(a=>a.Id==v);
        }
    }
}
