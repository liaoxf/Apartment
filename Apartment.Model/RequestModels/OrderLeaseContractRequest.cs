using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.RequestModels
{
    public class CreateRequest : BaseRequest
    {
        #region Field
        /// <summary>
        /// 用户Id号
        /// </summary>
        public int userId { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo { get; set; }
        /// <summary>
        /// 签约人ID号
        /// </summary>
        public int? SignatoryId { get; set; }
        /// <summary>
        /// 签约人姓名
        /// </summary>
        public string SignatoryName { get; set; }
        /// <summary>
        /// 合同签约时间
        /// </summary>
        public DateTime? ContractSignTime { get; set; }
        /// <summary>
        /// 合同金额
        /// </summary>
        public decimal ContractAmount { get; set; }
        /// <summary>
        /// 合同到期时间
        /// </summary>
        public DateTime? ContractDueTime { get; set; }
        /// <summary>
        /// 合同备注
        /// </summary>
        public string ContractRemark { get; set; }
        #endregion
    }
    public class GetRequest : BaseRequest
    {
        #region Field
        /// <summary>
        /// 用户Id号
        /// </summary>
        public int orderLeaseContractId { get; set; }
        #endregion
    }
    
}
