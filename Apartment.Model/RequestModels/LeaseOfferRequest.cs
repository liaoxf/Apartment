using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.RequestModels
{
    public class IsLeaseOfferRequest
    {
        public int userId { get; set; }
        public int houseId { get; set; }
    }
    public class UserLeaseOfferRequest
    {
        public int userId { get; set; }
        public int houseId { get; set; }
        public decimal price { get; set; }
    }
    public class GetListRequest
    {
        public int houseId { get; set; }
    }
    public class ChooseRequest
    {
        public int userId { get; set; }
        public int leaseOfferId { get; set; }
        /// <summary>
        /// 0表示不同意；1表示同意
        /// </summary>
        public int isAgree { get; set; }
    }
    
}
