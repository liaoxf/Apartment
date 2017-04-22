	
using System;
using Dos.ORM;

namespace Zfx365.Com.UtilsModel
{


    [Serializable]
	public  class orderleasecontract
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
        /// 出租方ID号
        /// </summary>
		 public int? SignatoryId { get; set; }
	    /// <summary>
        /// 出租方姓名
        /// </summary>
		 public string SignatoryName { get; set; }
	    /// <summary>
        /// 出租方联系电话
        /// </summary>
		 public string SignatoryPhone { get; set; }
	    /// <summary>
        /// 出租方身份证号
        /// </summary>
		 public string SignatoryIDCard { get; set; }
	    /// <summary>
        /// 承租方ID号
        /// </summary>
		 public int? LessorId { get; set; }
	    /// <summary>
        /// 承租方姓名
        /// </summary>
		 public string LessorName { get; set; }
	    /// <summary>
        /// 承租方联系电话
        /// </summary>
		 public string LessorPhone { get; set; }
	    /// <summary>
        /// 承租方身份证号
        /// </summary>
		 public string LessorIDCard { get; set; }
	    /// <summary>
        /// 开始时间
        /// </summary>
		 public DateTime? ContractSignTime { get; set; }
	    /// <summary>
        /// 结束时间
        /// </summary>
		 public DateTime? ContractDueTime { get; set; }
	    /// <summary>
        /// 房子租金
        /// </summary>
		 public decimal ContractAmount { get; set; }
	    /// <summary>
        /// 房子租金（大写）
        /// </summary>
		 public string BContractAmount { get; set; }
	    /// <summary>
        /// 首次付款
        /// </summary>
		 public decimal FirstPayment { get; set; }
	    /// <summary>
        /// 房屋押金
        /// </summary>
		 public decimal HouseDeposit { get; set; }
	    /// <summary>
        /// 房租总月数
        /// </summary>
		 public string TotalMonth { get; set; }
	    /// <summary>
        /// 房租总月数（首次）
        /// </summary>
		 public int? FTotalMonth { get; set; }
	    /// <summary>
        /// 房租总金额（首次）
        /// </summary>
		 public decimal FTotalMoney { get; set; }
	    /// <summary>
        /// 审核状态：0表示待审核；1表示审核成功；2表示审核失败；
        /// </summary>
		 public int? AuditStatus { get; set; }
	    /// <summary>
        /// 房屋的ID号
        /// </summary>
		 public int? HouseId { get; set; }
	    /// <summary>
        /// 合同html
        /// </summary>
		 public string ContractHtml { get; set; }
	    /// <summary>
        /// 合同备注
        /// </summary>
		 public string ContractRemark { get; set; }
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
		 public int? IsDel { get; set; }
	    /// <summary>
        /// 合同生成时间
        /// </summary>
		 public DateTime? AddTime { get; set; }
	    /// <summary>
        /// 合同更新时间
        /// </summary>
		 public DateTime? LastUpdateTime { get; set; }
	    /// <summary>
        /// 合同生成方式：0表示线上；1表示线下；
        /// </summary>
		 public int? GenerateWay { get; set; }
	    /// <summary>
        /// 市
        /// </summary>
		 public string City { get; set; }
	    /// <summary>
        /// 区
        /// </summary>
		 public string District { get; set; }
	    /// <summary>
        /// 房源具体地址
        /// </summary>
		 public string DetailAddress { get; set; }
	    /// <summary>
        /// 小区名称
        /// </summary>
		 public string AreasName { get; set; }
	    /// <summary>
        /// （栋号）弄
        /// </summary>
		 public string BuildingNO { get; set; }
	    /// <summary>
        /// 室号
        /// </summary>
		 public string RoomNO { get; set; }
	    /// <summary>
        /// 房型规格
        /// </summary>
		 public string HSpec { get; set; }
	    /// <summary>
        /// 出租面积
        /// </summary>
		 public decimal RentalArea { get; set; }
	    /// <summary>
        /// 租金方式
        /// </summary>
		 public string RentMoneyWay { get; set; }
	    /// <summary>
        /// 签约日期
        /// </summary>
		 public DateTime? SignTime { get; set; }
	    /// <summary>
        /// 是否完善信息：0表示未完善；1表示已完善；
        /// </summary>
		 public int? IsComplete { get; set; }
		#endregion
    }

}
