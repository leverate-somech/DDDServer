using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.WebApi
{
    public class DepositMoneyModel
    {
        public Guid AccountId { get; set; }
        public int Version { get; set; }
        public decimal Amount { get; set; }
    }
}
