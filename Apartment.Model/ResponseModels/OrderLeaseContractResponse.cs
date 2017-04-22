using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.ResponseModels
{
    public class GetResponse
    {
        #region Field
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int Id { get; set; }
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
        /// <summary>
        /// 合同生成时间
        /// </summary>
        public DateTime? AddTime { get; set; }
        /// <summary>
        /// 合同更新时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }
        #endregion
    }
}
