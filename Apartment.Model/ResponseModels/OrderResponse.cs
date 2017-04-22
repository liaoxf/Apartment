using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zfx365.Com.Model.ResponseModels
{
    public class OrderInfoResponse 
    {
        #region Field
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo { get; set; } = string.Empty;
        /// <summary>
        /// 订单状态：0代表创建意向单；1代表已经填写预约看房时间；2代表释放订单；3代表正式订单；4代表确认成交；5代表合同生成；6代表成功签约；
        /// </summary>
        public int OrderStatus { get; set; } = 0;
        /// <summary>
        /// 订单生成时间
        /// </summary>
        public DateTime? AddTime { get; set; }
        /// <summary>
        /// 订单更新时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }
        /// <summary>
        /// 订单金额
        /// </summary>
        public decimal OrderAmount { get; set; } = 0;
        /// <summary>
        /// 租赁客户ID号
        /// </summary>
        public int? LeaseCustomerId { get; set; } = 0;
        /// <summary>
        /// 租赁客户的姓名
        /// </summary>
        public string LeasingCustomerName { get; set; } = string.Empty;
        /// <summary>
        /// 房屋ID号
        /// </summary>
        public int? HouseID { get; set; } = 0;
        /// <summary>
        /// 房屋名称
        /// </summary>
        public string HouseName { get; set; } = string.Empty;
        /// <summary>
        /// 房东ID号
        /// </summary>
        public int? LandlordId { get; set; } = 0;
        /// <summary>
        /// 房东名称
        /// </summary>
        public string LandlordName { get; set; } = string.Empty;
        #endregion
    }
    public class GetALLResponse
    {
        #region Field
        /// <summary>
        /// 主键自增ID号
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo { get; set; } = string.Empty;
        /// <summary>
        /// 订单状态：0代表创建意向单；1代表已经填写预约看房时间；2代表释放订单；3代表正式订单；4代表确认成交；5代表合同生成；6代表成功签约；
        /// </summary>
        public int OrderStatus { get; set; } = 0;
        /// <summary>
        /// 订单生成时间
        /// </summary>
        public DateTime? AddTime { get; set; }
        /// <summary>
        /// 房屋名称
        /// </summary>
        public string HouseName { get; set; } = string.Empty;
        /// <summary>
        /// 房东名称
        /// </summary>
        public string LandlordName { get; set; } = string.Empty;
        #endregion
    }

    public class GetOrderTrackLogResponse
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
        /// 订单状态：0代表创建意向单；1代表释放订单；2代表正式订单；3代表确认成交；4代表合同生成；5代表成功签约；
        /// </summary>
        public int? OrderStatus { get; set; }
        /// <summary>
        /// 日志备注
        /// </summary>
        public string LogRemark { get; set; }
        /// <summary>
        /// 操作人ID号
        /// </summary>
        public int? OperatorId { get; set; }
        /// <summary>
        /// 操作人姓名
        /// </summary>
        public string OperatorName { get; set; }
        /// <summary>
        /// 订单日志生成时间
        /// </summary>
        public DateTime? AddTime { get; set; }
        #endregion
    }


}
