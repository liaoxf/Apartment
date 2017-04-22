using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Model.RequestModels
{
    public class HouseRefreshRequest
    {
        public int HouseId { get; set; }
        public string HouseTitle { get; set; }
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public int Status { get; set; }
        public string AuditBy { get; set; }
        public string AuditName { get; set; }
        public string MutilIds { get; set; }
    }
}
