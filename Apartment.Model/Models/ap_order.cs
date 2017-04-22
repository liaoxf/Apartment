	
using System;
using System.IO;
using System.Data;
using Dos.ORM;
using Apartment.Model.Base;
namespace Apartment.Model
{
    [Serializable]
	public partial class ap_order : EntityExt
    {

		public ap_order() : base("ap_order") { }
	    #region Field

        private long _Id = int.MinValue;
			    /// <summary>
        /// 主键
        /// </summary>
        public new long Id
        {
            get { return _Id ==0 ? base.Id :_Id; }
            set
            {
                this.OnPropertyValueChange(_.Id, _Id, value);
                this._Id = value;
                
            }
        }
		      	
        private string _OrderNo = string.Empty;
		      	
	    /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo
        {
            get { return _OrderNo; }
            set
            {
                this.OnPropertyValueChange(_.OrderNo, _OrderNo, value);
                this._OrderNo = value;
                
            }
        }
		
        private int _OrderStatus = 0;
		      	
	    /// <summary>
        /// 订单状态：0代表创建意向单；1代表已经填写预约看房时间；2代表释放订单；3代表正式订单；4代表确认成交；5代表合同生成；6代表成功签约；
        /// </summary>
        public int OrderStatus
        {
            get { return _OrderStatus; }
            set
            {
                this.OnPropertyValueChange(_.OrderStatus, _OrderStatus, value);
                this._OrderStatus = value;
                
            }
        }
		
        private DateTime? _AddTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 订单生成时间
        /// </summary>
        public DateTime? AddTime
        {
            get { return _AddTime; }
            set
            {
                this.OnPropertyValueChange(_.AddTime, _AddTime, value);
                this._AddTime = value;
                
            }
        }
		
        private DateTime? _LastUpdateTime = DateTime.MinValue;
		      	
	    /// <summary>
        /// 订单更新时间
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return _LastUpdateTime; }
            set
            {
                this.OnPropertyValueChange(_.LastUpdateTime, _LastUpdateTime, value);
                this._LastUpdateTime = value;
                
            }
        }
		
        private decimal _OrderAmount = 0;
		      	
	    /// <summary>
        /// 订单金额
        /// </summary>
        public decimal OrderAmount
        {
            get { return _OrderAmount; }
            set
            {
                this.OnPropertyValueChange(_.OrderAmount, _OrderAmount, value);
                this._OrderAmount = value;
                
            }
        }
		
        private int? _LeaseCustomerId = int.MinValue;
		      	
	    /// <summary>
        /// 租赁客户ID号
        /// </summary>
        public int? LeaseCustomerId
        {
            get { return _LeaseCustomerId; }
            set
            {
                this.OnPropertyValueChange(_.LeaseCustomerId, _LeaseCustomerId, value);
                this._LeaseCustomerId = value;
                
            }
        }
		
        private string _LeasingCustomerName = string.Empty;
		      	
	    /// <summary>
        /// 租赁客户的姓名
        /// </summary>
        public string LeasingCustomerName
        {
            get { return _LeasingCustomerName; }
            set
            {
                this.OnPropertyValueChange(_.LeasingCustomerName, _LeasingCustomerName, value);
                this._LeasingCustomerName = value;
                
            }
        }
		
        private string _LeasingCustomerMobile = string.Empty;
		      	
	    /// <summary>
        /// 租赁客户手机号
        /// </summary>
        public string LeasingCustomerMobile
        {
            get { return _LeasingCustomerMobile; }
            set
            {
                this.OnPropertyValueChange(_.LeasingCustomerMobile, _LeasingCustomerMobile, value);
                this._LeasingCustomerMobile = value;
                
            }
        }
		
        private long? _HouseID = int.MinValue;
		      	
	    /// <summary>
        /// 房屋ID号
        /// </summary>
        public long? HouseID
        {
            get { return _HouseID; }
            set
            {
                this.OnPropertyValueChange(_.HouseID, _HouseID, value);
                this._HouseID = value;
                
            }
        }
		
        private long? _HouseVillageId = int.MinValue;
		      	
	    /// <summary>
        /// 房源小区ID
        /// </summary>
        public long? HouseVillageId
        {
            get { return _HouseVillageId; }
            set
            {
                this.OnPropertyValueChange(_.HouseVillageId, _HouseVillageId, value);
                this._HouseVillageId = value;
                
            }
        }
		
        private string _HouseName = string.Empty;
		      	
	    /// <summary>
        /// 房屋名称
        /// </summary>
        public string HouseName
        {
            get { return _HouseName; }
            set
            {
                this.OnPropertyValueChange(_.HouseName, _HouseName, value);
                this._HouseName = value;
                
            }
        }
		
        private string _HProvince = string.Empty;
		      	
	    /// <summary>
        /// 房屋所在省
        /// </summary>
        public string HProvince
        {
            get { return _HProvince; }
            set
            {
                this.OnPropertyValueChange(_.HProvince, _HProvince, value);
                this._HProvince = value;
                
            }
        }
		
        private string _HCity = string.Empty;
		      	
	    /// <summary>
        /// 房屋所在市
        /// </summary>
        public string HCity
        {
            get { return _HCity; }
            set
            {
                this.OnPropertyValueChange(_.HCity, _HCity, value);
                this._HCity = value;
                
            }
        }
		
        private string _HDistrict = string.Empty;
		      	
	    /// <summary>
        /// 房屋所在区
        /// </summary>
        public string HDistrict
        {
            get { return _HDistrict; }
            set
            {
                this.OnPropertyValueChange(_.HDistrict, _HDistrict, value);
                this._HDistrict = value;
                
            }
        }
		
        private long? _LandlordId = int.MinValue;
		      	
	    /// <summary>
        /// 房东ID号
        /// </summary>
        public long? LandlordId
        {
            get { return _LandlordId; }
            set
            {
                this.OnPropertyValueChange(_.LandlordId, _LandlordId, value);
                this._LandlordId = value;
                
            }
        }
		
        private string _LandlordName = string.Empty;
		      	
	    /// <summary>
        /// 房东名称
        /// </summary>
        public string LandlordName
        {
            get { return _LandlordName; }
            set
            {
                this.OnPropertyValueChange(_.LandlordName, _LandlordName, value);
                this._LandlordName = value;
                
            }
        }
		
        private string _LandlordMobileNo = string.Empty;
		      	
	    /// <summary>
        /// 房东手机号
        /// </summary>
        public string LandlordMobileNo
        {
            get { return _LandlordMobileNo; }
            set
            {
                this.OnPropertyValueChange(_.LandlordMobileNo, _LandlordMobileNo, value);
                this._LandlordMobileNo = value;
                
            }
        }
		
        private string _OrderRemark = string.Empty;
		      	
	    /// <summary>
        /// 订单备注
        /// </summary>
        public string OrderRemark
        {
            get { return _OrderRemark; }
            set
            {
                this.OnPropertyValueChange(_.OrderRemark, _OrderRemark, value);
                this._OrderRemark = value;
                
            }
        }
		
        private int? _IsDel = 0;
		      	
	    /// <summary>
        /// 软删除：0表示未删除；1表示已删除
        /// </summary>
        public int? IsDel
        {
            get { return _IsDel; }
            set
            {
                this.OnPropertyValueChange(_.IsDel, _IsDel, value);
                this._IsDel = value;
                
            }
        }
		
        private string _CreatorID = string.Empty;
		      	
	    /// <summary>
        /// 创建人ID
        /// </summary>
        public string CreatorID
        {
            get { return _CreatorID; }
            set
            {
                this.OnPropertyValueChange(_.CreatorID, _CreatorID, value);
                this._CreatorID = value;
                
            }
        }
		
        private string _CreatorName = string.Empty;
		      	
	    /// <summary>
        /// 操作人姓名
        /// </summary>
        public string CreatorName
        {
            get { return _CreatorName; }
            set
            {
                this.OnPropertyValueChange(_.CreatorName, _CreatorName, value);
                this._CreatorName = value;
                
            }
        }
		
        private string _OperatorID = string.Empty;
		      	
	    /// <summary>
        /// 操作人ID
        /// </summary>
        public string OperatorID
        {
            get { return _OperatorID; }
            set
            {
                this.OnPropertyValueChange(_.OperatorID, _OperatorID, value);
                this._OperatorID = value;
                
            }
        }
		
        private string _OperatorName = string.Empty;
		      	
	    /// <summary>
        /// 操作人姓名
        /// </summary>
        public string OperatorName
        {
            get { return _OperatorName; }
            set
            {
                this.OnPropertyValueChange(_.OperatorName, _OperatorName, value);
                this._OperatorName = value;
                
            }
        }
		
        private int? _IsPriced = int.MinValue;
		      	
	    /// <summary>
        /// 是否已经出价：0代表未出价；1代表已出价；
        /// </summary>
        public int? IsPriced
        {
            get { return _IsPriced; }
            set
            {
                this.OnPropertyValueChange(_.IsPriced, _IsPriced, value);
                this._IsPriced = value;
                
            }
        }
		
        private int? _IsGenerateContract = int.MinValue;
		      	
	    /// <summary>
        /// 是否已经生成合同：0代表未生成合同；1代表已生成合同；
        /// </summary>
        public int? IsGenerateContract
        {
            get { return _IsGenerateContract; }
            set
            {
                this.OnPropertyValueChange(_.IsGenerateContract, _IsGenerateContract, value);
                this._IsGenerateContract = value;
                
            }
        }
		
        private int? _IsBooking = int.MinValue;
		      	
	    /// <summary>
        /// 是否已经预约看房：0表示未预约；1表示已预约；
        /// </summary>
        public int? IsBooking
        {
            get { return _IsBooking; }
            set
            {
                this.OnPropertyValueChange(_.IsBooking, _IsBooking, value);
                this._IsBooking = value;
                
            }
        }
		
        private int? _Source = int.MinValue;
		      	
	    /// <summary>
        /// 来源
        /// </summary>
        public int? Source
        {
            get { return _Source; }
            set
            {
                this.OnPropertyValueChange(_.Source, _Source, value);
                this._Source = value;
                
            }
        }
		
        private string _HouseNo = string.Empty;
		      	
	    /// <summary>
        /// 房间号
        /// </summary>
        public string HouseNo
        {
            get { return _HouseNo; }
            set
            {
                this.OnPropertyValueChange(_.HouseNo, _HouseNo, value);
                this._HouseNo = value;
                
            }
        }
		
        private int? _IsSync = int.MinValue;
		      	
	    /// <summary>
        /// 是否同步
        /// </summary>
        public int? IsSync
        {
            get { return _IsSync; }
            set
            {
                this.OnPropertyValueChange(_.IsSync, _IsSync, value);
                this._IsSync = value;
                
            }
        }
				#endregion

		#region Method

		        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {_.Id };
        }
				 /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {_.Id,_.OrderNo,_.OrderStatus,_.AddTime,_.LastUpdateTime,_.OrderAmount,_.LeaseCustomerId,_.LeasingCustomerName,_.LeasingCustomerMobile,_.HouseID,_.HouseVillageId,_.HouseName,_.HProvince,_.HCity,_.HDistrict,_.LandlordId,_.LandlordName,_.LandlordMobileNo,_.OrderRemark,_.IsDel,_.CreatorID,_.CreatorName,_.OperatorID,_.OperatorName,_.IsPriced,_.IsGenerateContract,_.IsBooking,_.Source,_.HouseNo,_.IsSync};
        }

        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {this._Id,this._OrderNo,this._OrderStatus,this._AddTime,this._LastUpdateTime,this._OrderAmount,this._LeaseCustomerId,this._LeasingCustomerName,this._LeasingCustomerMobile,this._HouseID,this._HouseVillageId,this._HouseName,this._HProvince,this._HCity,this._HDistrict,this._LandlordId,this._LandlordName,this._LandlordMobileNo,this._OrderRemark,this._IsDel,this._CreatorID,this._CreatorName,this._OperatorID,this._OperatorName,this._IsPriced,this._IsGenerateContract,this._IsBooking,this._Source,this._HouseNo,this._IsSync };
        }

		/// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
							this._Id = DataUtils.ConvertValue<long>(reader["Id"]);
							this._OrderNo = DataUtils.ConvertValue<string>(reader["OrderNo"]);
							this._OrderStatus = DataUtils.ConvertValue<int>(reader["OrderStatus"]);
							this._AddTime = DataUtils.ConvertValue<DateTime?>(reader["AddTime"]);
							this._LastUpdateTime = DataUtils.ConvertValue<DateTime?>(reader["LastUpdateTime"]);
							this._OrderAmount = DataUtils.ConvertValue<decimal>(reader["OrderAmount"]);
							this._LeaseCustomerId = DataUtils.ConvertValue<int?>(reader["LeaseCustomerId"]);
							this._LeasingCustomerName = DataUtils.ConvertValue<string>(reader["LeasingCustomerName"]);
							this._LeasingCustomerMobile = DataUtils.ConvertValue<string>(reader["LeasingCustomerMobile"]);
							this._HouseID = DataUtils.ConvertValue<long?>(reader["HouseID"]);
							this._HouseVillageId = DataUtils.ConvertValue<long?>(reader["HouseVillageId"]);
							this._HouseName = DataUtils.ConvertValue<string>(reader["HouseName"]);
							this._HProvince = DataUtils.ConvertValue<string>(reader["HProvince"]);
							this._HCity = DataUtils.ConvertValue<string>(reader["HCity"]);
							this._HDistrict = DataUtils.ConvertValue<string>(reader["HDistrict"]);
							this._LandlordId = DataUtils.ConvertValue<long?>(reader["LandlordId"]);
							this._LandlordName = DataUtils.ConvertValue<string>(reader["LandlordName"]);
							this._LandlordMobileNo = DataUtils.ConvertValue<string>(reader["LandlordMobileNo"]);
							this._OrderRemark = DataUtils.ConvertValue<string>(reader["OrderRemark"]);
							this._IsDel = DataUtils.ConvertValue<int?>(reader["IsDel"]);
							this._CreatorID = DataUtils.ConvertValue<string>(reader["CreatorID"]);
							this._CreatorName = DataUtils.ConvertValue<string>(reader["CreatorName"]);
							this._OperatorID = DataUtils.ConvertValue<string>(reader["OperatorID"]);
							this._OperatorName = DataUtils.ConvertValue<string>(reader["OperatorName"]);
							this._IsPriced = DataUtils.ConvertValue<int?>(reader["IsPriced"]);
							this._IsGenerateContract = DataUtils.ConvertValue<int?>(reader["IsGenerateContract"]);
							this._IsBooking = DataUtils.ConvertValue<int?>(reader["IsBooking"]);
							this._Source = DataUtils.ConvertValue<int?>(reader["Source"]);
							this._HouseNo = DataUtils.ConvertValue<string>(reader["HouseNo"]);
							this._IsSync = DataUtils.ConvertValue<int?>(reader["IsSync"]);
				    }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
		    				this._Id =  DataUtils.ConvertValue<long>(row["Id"]);
							this._OrderNo =  DataUtils.ConvertValue<string>(row["OrderNo"]);
							this._OrderStatus =  DataUtils.ConvertValue<int>(row["OrderStatus"]);
							this._AddTime =  DataUtils.ConvertValue<DateTime?>(row["AddTime"]);
							this._LastUpdateTime =  DataUtils.ConvertValue<DateTime?>(row["LastUpdateTime"]);
							this._OrderAmount =  DataUtils.ConvertValue<decimal>(row["OrderAmount"]);
							this._LeaseCustomerId =  DataUtils.ConvertValue<int?>(row["LeaseCustomerId"]);
							this._LeasingCustomerName =  DataUtils.ConvertValue<string>(row["LeasingCustomerName"]);
							this._LeasingCustomerMobile =  DataUtils.ConvertValue<string>(row["LeasingCustomerMobile"]);
							this._HouseID =  DataUtils.ConvertValue<long?>(row["HouseID"]);
							this._HouseVillageId =  DataUtils.ConvertValue<long?>(row["HouseVillageId"]);
							this._HouseName =  DataUtils.ConvertValue<string>(row["HouseName"]);
							this._HProvince =  DataUtils.ConvertValue<string>(row["HProvince"]);
							this._HCity =  DataUtils.ConvertValue<string>(row["HCity"]);
							this._HDistrict =  DataUtils.ConvertValue<string>(row["HDistrict"]);
							this._LandlordId =  DataUtils.ConvertValue<long?>(row["LandlordId"]);
							this._LandlordName =  DataUtils.ConvertValue<string>(row["LandlordName"]);
							this._LandlordMobileNo =  DataUtils.ConvertValue<string>(row["LandlordMobileNo"]);
							this._OrderRemark =  DataUtils.ConvertValue<string>(row["OrderRemark"]);
							this._IsDel =  DataUtils.ConvertValue<int?>(row["IsDel"]);
							this._CreatorID =  DataUtils.ConvertValue<string>(row["CreatorID"]);
							this._CreatorName =  DataUtils.ConvertValue<string>(row["CreatorName"]);
							this._OperatorID =  DataUtils.ConvertValue<string>(row["OperatorID"]);
							this._OperatorName =  DataUtils.ConvertValue<string>(row["OperatorName"]);
							this._IsPriced =  DataUtils.ConvertValue<int?>(row["IsPriced"]);
							this._IsGenerateContract =  DataUtils.ConvertValue<int?>(row["IsGenerateContract"]);
							this._IsBooking =  DataUtils.ConvertValue<int?>(row["IsBooking"]);
							this._Source =  DataUtils.ConvertValue<int?>(row["Source"]);
							this._HouseNo =  DataUtils.ConvertValue<string>(row["HouseNo"]);
							this._IsSync =  DataUtils.ConvertValue<int?>(row["IsSync"]);
			        }
		#endregion
		
		#region _
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// *
            /// </summary>
            public readonly static Field All = new Field("*", "ap_order");
						/// <summary>
            /// 主键
            /// </summary>
            public readonly static Field Id = new Field("Id", "ap_order", "主键");
						/// <summary>
            /// 订单号
            /// </summary>
            public readonly static Field OrderNo = new Field("OrderNo", "ap_order", "订单号");
						/// <summary>
            /// 订单状态：0代表创建意向单；1代表已经填写预约看房时间；2代表释放订单；3代表正式订单；4代表确认成交；5代表合同生成；6代表成功签约；
            /// </summary>
            public readonly static Field OrderStatus = new Field("OrderStatus", "ap_order", "订单状态：0代表创建意向单；1代表已经填写预约看房时间；2代表释放订单；3代表正式订单；4代表确认成交；5代表合同生成；6代表成功签约；");
						/// <summary>
            /// 订单生成时间
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "ap_order", "订单生成时间");
						/// <summary>
            /// 订单更新时间
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "ap_order", "订单更新时间");
						/// <summary>
            /// 订单金额
            /// </summary>
            public readonly static Field OrderAmount = new Field("OrderAmount", "ap_order", "订单金额");
						/// <summary>
            /// 租赁客户ID号
            /// </summary>
            public readonly static Field LeaseCustomerId = new Field("LeaseCustomerId", "ap_order", "租赁客户ID号");
						/// <summary>
            /// 租赁客户的姓名
            /// </summary>
            public readonly static Field LeasingCustomerName = new Field("LeasingCustomerName", "ap_order", "租赁客户的姓名");
						/// <summary>
            /// 租赁客户手机号
            /// </summary>
            public readonly static Field LeasingCustomerMobile = new Field("LeasingCustomerMobile", "ap_order", "租赁客户手机号");
						/// <summary>
            /// 房屋ID号
            /// </summary>
            public readonly static Field HouseID = new Field("HouseID", "ap_order", "房屋ID号");
						/// <summary>
            /// 房源小区ID
            /// </summary>
            public readonly static Field HouseVillageId = new Field("HouseVillageId", "ap_order", "房源小区ID");
						/// <summary>
            /// 房屋名称
            /// </summary>
            public readonly static Field HouseName = new Field("HouseName", "ap_order", "房屋名称");
						/// <summary>
            /// 房屋所在省
            /// </summary>
            public readonly static Field HProvince = new Field("HProvince", "ap_order", "房屋所在省");
						/// <summary>
            /// 房屋所在市
            /// </summary>
            public readonly static Field HCity = new Field("HCity", "ap_order", "房屋所在市");
						/// <summary>
            /// 房屋所在区
            /// </summary>
            public readonly static Field HDistrict = new Field("HDistrict", "ap_order", "房屋所在区");
						/// <summary>
            /// 房东ID号
            /// </summary>
            public readonly static Field LandlordId = new Field("LandlordId", "ap_order", "房东ID号");
						/// <summary>
            /// 房东名称
            /// </summary>
            public readonly static Field LandlordName = new Field("LandlordName", "ap_order", "房东名称");
						/// <summary>
            /// 房东手机号
            /// </summary>
            public readonly static Field LandlordMobileNo = new Field("LandlordMobileNo", "ap_order", "房东手机号");
						/// <summary>
            /// 订单备注
            /// </summary>
            public readonly static Field OrderRemark = new Field("OrderRemark", "ap_order", "订单备注");
						/// <summary>
            /// 软删除：0表示未删除；1表示已删除
            /// </summary>
            public readonly static Field IsDel = new Field("IsDel", "ap_order", "软删除：0表示未删除；1表示已删除");
						/// <summary>
            /// 创建人ID
            /// </summary>
            public readonly static Field CreatorID = new Field("CreatorID", "ap_order", "创建人ID");
						/// <summary>
            /// 操作人姓名
            /// </summary>
            public readonly static Field CreatorName = new Field("CreatorName", "ap_order", "操作人姓名");
						/// <summary>
            /// 操作人ID
            /// </summary>
            public readonly static Field OperatorID = new Field("OperatorID", "ap_order", "操作人ID");
						/// <summary>
            /// 操作人姓名
            /// </summary>
            public readonly static Field OperatorName = new Field("OperatorName", "ap_order", "操作人姓名");
						/// <summary>
            /// 是否已经出价：0代表未出价；1代表已出价；
            /// </summary>
            public readonly static Field IsPriced = new Field("IsPriced", "ap_order", "是否已经出价：0代表未出价；1代表已出价；");
						/// <summary>
            /// 是否已经生成合同：0代表未生成合同；1代表已生成合同；
            /// </summary>
            public readonly static Field IsGenerateContract = new Field("IsGenerateContract", "ap_order", "是否已经生成合同：0代表未生成合同；1代表已生成合同；");
						/// <summary>
            /// 是否已经预约看房：0表示未预约；1表示已预约；
            /// </summary>
            public readonly static Field IsBooking = new Field("IsBooking", "ap_order", "是否已经预约看房：0表示未预约；1表示已预约；");
						/// <summary>
            /// 来源
            /// </summary>
            public readonly static Field Source = new Field("Source", "ap_order", "来源");
						/// <summary>
            /// 房间号
            /// </summary>
            public readonly static Field HouseNo = new Field("HouseNo", "ap_order", "房间号");
						/// <summary>
            /// 是否同步
            /// </summary>
            public readonly static Field IsSync = new Field("IsSync", "ap_order", "是否同步");
			
        }
		#endregion
        
    }

}
