using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBank.Library
{
    public interface ISerializer
    {
        ICollection<Account> Read();        
    }
}
