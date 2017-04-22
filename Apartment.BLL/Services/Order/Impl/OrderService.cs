using System;
using System.Collections.Generic;
using Apartment.Model;
using Apartment.Dal.Base;
using Apartment.Dal.IRepository;

namespace Apartment.BLL.Services.Order.Impl
{
    public class OrderService : Repository<ap_order>, IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepostory)
        {
            _orderRepository = orderRepostory;
        }

        public bool IsOrderExist(long intUserId, long intHouseId)
        {
            return _orderRepository.Any(f => f.Id == intHouseId);
        }

        public List<ap_leaseoffer> MyHouseLeaseOffer(long houseId)
        {
            return Db.MySqlContext_Apartment.FromSql("SELECT * from ap_leaseoffer where HouseId=" + houseId + " AND IsDel=0").ToList<ap_leaseoffer>();
        }
    }
}
  