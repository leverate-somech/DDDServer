using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.WebApi
{
    public class AccountKey
    {
        public Guid AccountId { get; set; }
        public int Shard { get; set; }
    }
}
