using Apartment.Dal.Base;
using Apartment.Model;
using System.Collections.Generic;

namespace Apartment.BLL.Services.Order
{
    public interface IOrderService: IRepository<ap_order>
    {
        /// <summary>
        /// 根据用户ID和房屋ID和订单状态来判断订单是否已经存在
        /// </summary>
        /// <param name="intUserId"></param>
        /// <param name="intHouseId"></param>
        /// <returns></returns>
        bool IsOrderExist(long intUserId, long intHouseId);

        /// <summary>
        /// 获取房源的出价信息
        /// </summary>
        /// <param name="houseId"></param>
        /// <returns></returns>
        List<ap_leaseoffer> MyHouseLeaseOffer(long houseId);

    }
}
