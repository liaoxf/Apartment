using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Model.RequestModels
{
 public   class HouseAuditRequest
    {
        public int HouseId { get; set; }
        public string  HouseName { get; set; }
        public string  TypeLog { get; set; }
        public string LogRemark { get; set; }
        public int Status { get; set; }
        public string AuditBy { get; set; }
        public string AuditName { get; set; }
        public string MutilIds { get; set; }
    }
}
