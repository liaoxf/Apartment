using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.RequestModels
{
    public class BookingHouseRequest : BaseRequest
    {
        /// <summary>
        /// 用户ID号
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// 房屋ID号
        /// </summary>
        public int houseId { get; set; }

        /// <summary>
        /// 预约看房的时间
        /// </summary>
        public DateTime BookingTime { get; set; }

    }
    public class GetByOrderNoRequest : BaseRequest
    {
        /// <summary>
        /// 用户ID号
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// 看房状态：0表示待看；1表示满意；2不满意；
        /// </summary>
        public int lookStatus { get; set; }
    }
    public class OperateIsAgreeRequest : BaseRequest
    {
        /// <summary>
        /// 用户ID号
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// 预约看房记录ID号
        /// </summary>
        public int bookingHouseId { get; set; }
        /// <summary>
        /// 看房状态：0不满意；1表示满意；
        /// </summary>
        public int isPass { get; set; }
    }
    
}
