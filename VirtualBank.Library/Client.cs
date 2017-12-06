using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBank.Library
{   
    public class Client
    {
        
       public Client(int v1, string v2, int v3, Account p)
        {
            this.Id = v1;
            this.Name = v2;
            this.Password = v3;            
            this.ClientAccount = p;            
        }       

        public int Id { get; set; }
        public string Name { get; set; }
        public int Password { get; set; }
        public Account ClientAccount { get; set; }

    }
}
