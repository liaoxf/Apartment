using Apartment.Dal.Base;
using Apartment.Dal.IRepository;
using Apartment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Dal.Repostiory
{
    public class OrderRepository : Repository<ap_order>, IOrderRepository
    {
    }
}
