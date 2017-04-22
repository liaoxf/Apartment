using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Model.Enum.Order
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// 已创建意向单
        /// </summary>
        已创建意向单 = 0,
        /// <summary>
        /// 预约看房中
        /// </summary>
        预约看房中 = 1,
        /// <summary>
        /// 已释放订单
        /// </summary>
        已释放订单 = 2,
        /// <summary>
        /// 已创建正式订单
        /// </summary>
        已创建正式订单 = 3,
        /// <summary>
        /// 已出价
        /// </summary>
        已出价 = 4,
        /// <summary>
        /// 已成交
        /// </summary>
        已成交 = 5,
        /// <summary>
        /// 已生成合同
        /// </summary>
        已生成合同 = 6,
        /// <summary>
        /// 已成功签约
        /// </summary>
        已成功签约 = 7
    }
}
