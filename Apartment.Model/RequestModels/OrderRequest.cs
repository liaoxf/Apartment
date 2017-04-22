using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.RequestModels
{
    public class CreateOrderRequest : BaseRequest
    {
        /// <summary>
        /// 用户ID号
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// 房屋ID号
        /// </summary>
        public int houseId { get; set; }
    }
   
    public class ReleaseOrderRequest : BaseRequest
    {
        /// <summary>
        /// 用户ID号
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string orderNo { get; set; }
    }
    public class GetOrderByOrderNoRequest : BaseRequest
    {
        /// <summary>
        /// 用户ID号
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string orderNo { get; set; }
    }
    public class ALLRequest : BaseRequest
    {
        /// <summary>
        /// 用户ID号
        /// </summary>
        public int userId { get; set; }
    }
    public class GetOrderTrackLogRequest : BaseRequest
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string orderNo { get; set; }
    }
    
}
