using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Model.RequestModels
{
   public class DepositRequest
    {
          public string TransactionNo { get; set; }
          public int       RefundUserId { get; set; }
        public decimal       RefundAmount { get; set; }
        public string       RefundName { get; set; }
        public string       PayPlatform { get; set; }
        public int       DepositID  { get; set; }
}
}
