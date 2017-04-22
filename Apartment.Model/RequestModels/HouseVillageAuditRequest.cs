using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Model.RequestModels
{
   public class HouseVillageAuditRequest
    {
        public int HouseVillageId { get; set; }
        public string VillagName { get; set; }
        public string TypeLog { get; set; }
        public string LogRemark { get; set; }
        public int Status { get; set; }
    }
}
