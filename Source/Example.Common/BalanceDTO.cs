using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Example.Common
{
    public class BalanceDTO : IDTO
    {
        public BalanceDTO(decimal balance)
        {
            Balance = balance;
        }

        public decimal Balance { get; private set; }
    }
}
